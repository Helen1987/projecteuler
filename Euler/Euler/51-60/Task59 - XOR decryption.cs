using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// Each character on a computer is assigned a unique code and the preferred standard is ASCII (American Standard Code for Information Interchange). 
    /// For example, uppercase A = 65, asterisk (*) = 42, and lowercase k = 107.
    /// 
    /// A modern encryption method is to take a text file, convert the bytes to ASCII, then XOR each byte with a given value, taken from a secret key.
    /// The advantage with the XOR function is that using the same encryption key on the cipher text, restores the plain text; for example, 65 XOR 42 = 107, then 107 XOR 42 = 65.
    /// 
    /// For unbreakable encryption, the key is the same length as the plain text message, and the key is made up of random bytes.The user would keep the 
    /// encrypted message and the encryption key in different locations, and without both "halves", it is impossible to decrypt the message.
    /// 
    /// Unfortunately, this method is impractical for most users, so the modified method is to use a password as a key. If the password is shorter than 
    /// the message, which is likely, the key is repeated cyclically throughout the message.The balance for this method is using a sufficiently long 
    /// password key for security, but short enough to be memorable.
    /// 
    /// Your task has been made easy, as the encryption key consists of three lower case characters.Using cipher.txt(right click and 'Save Link/Target As...'),
    /// a file containing the encrypted ASCII codes, and the knowledge that the plain text must contain common English words, decrypt the message and find 
    /// the sum of the ASCII values in the original text.
    /// </summary>
    public class Task59
    {
        private IEnumerable<int> Encrypt(int[] message, int[] key)
        {
            for (int i = 0; i < message.Length; i++)
            {
                yield return message[i] ^ key[i % key.Length];
            }
        }

        private int[] GetKey(int[] message, int keyLength)
        {
            int maxsize = 0;
            // find array size for counting sort
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] > maxsize) maxsize = message[i];
            }
            // init counting sort for keyLength chunks
            int[,] frequencies = new int[keyLength, maxsize + 1];
            int[] key = new int[keyLength];
            // find the most frequent character in every chunk (space)
            for (int i = 0; i < message.Length; i++)
            {
                int j = i % keyLength;
                frequencies[j, message[i]]++;
                if (frequencies[j, message[i]] > frequencies[j, key[j]])
                    key[j] = message[i];
            }

            int spaceAscii = 32;
            for (int i = 0; i < keyLength; i++)
            {
                key[i] = key[i] ^ spaceAscii;
            }

            return key;
        }

        public int Run(int keyLength)
        {
            using (StreamReader reader = new StreamReader("data/cipher.txt"))
            {
                string text = reader.ReadToEnd();
                int[] ascii = text.Split(',').Select(int.Parse).ToArray();

                int[] key = GetKey(ascii, keyLength);

                return Encrypt(ascii, key).ToArray().Sum();
            }
        }

    }
}
