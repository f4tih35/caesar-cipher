using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class EncodeDecode
    {
        string plaintext;
        string ciphertext;
        int shift;

        public string encode(string Fplaintext, int Fshift)
        {
            ciphertext = "";
            shift = Fshift;
            plaintext = Fplaintext;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(Fplaintext);
            char[] cipher = new char[plaintext.Length];
            for(int i = 0;i< plaintext.Length;i++)
            {
                cipher[i] = (char)(Convert.ToInt32(asciiBytes[i]));
                if (Convert.ToInt32(cipher[i])>=97 && Convert.ToInt32(cipher[i]) <=122)
                {
                    cipher[i] += (char)shift;
                    if (Convert.ToInt32(cipher[i]) > 122)
                    {
                        cipher[i] = (char)(cipher[i] - 26);
                    }
                    ciphertext += cipher[i].ToString();
                }
                else if(Convert.ToInt32(cipher[i]) >= 65 && Convert.ToInt32(cipher[i]) <= 90)
                {
                    cipher[i] += (char)(shift);
                    if (Convert.ToInt32(cipher[i]) > 90)
                    {
                        cipher[i] = (char)(cipher[i] - 26);
                    }
                    ciphertext += cipher[i].ToString();
                }
                else
                {
                    ciphertext += " ";
                }
            }
            return ciphertext;
        }

        public string decode(string Fciphertext, int Fshift)
        {
            plaintext = "";
            shift = Fshift;
            ciphertext = Fciphertext;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(Fciphertext);
            char[] plain = new char[ciphertext.Length];
            for (int i = 0; i < ciphertext.Length; i++)
            {
                plain[i] = (char)(Convert.ToInt32(asciiBytes[i]));
                if (Convert.ToInt32(plain[i])>=97 && Convert.ToInt32(plain[i]) <=122)
                {
                    plain[i] -= (char)shift;
                    if (Convert.ToInt32(plain[i]) < 97)
                    {
                        plain[i] = (char)(plain[i] + 26);
                    }
                    plaintext += plain[i].ToString();
                }
                else if (Convert.ToInt32(plain[i]) >= 65 && Convert.ToInt32(plain[i]) <= 90)
                {
                    plain[i] -= (char)(shift);
                    if (Convert.ToInt32(plain[i]) < 65)
                    {
                        plain[i] = (char)(plain[i] + 26);
                    }
                    plaintext += plain[i].ToString();
                }

            }
            return plaintext;
        }
    }
}
