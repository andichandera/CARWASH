using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Security.Cryptography;

namespace CW.COMMON
{
    public class Encryptor
    {
        public static string EncryptStringRijndaelToHexString(string StringToEncrypt)
        {
            ASCIIEncoding textConverter = new ASCIIEncoding();
            RijndaelManaged oRijndael = new RijndaelManaged();
            string Key1 = "carwash";
            string Key2 = "andi";
            Byte[] encrypted;
            Byte[] toEncrypt;
            Byte[] key;
            Byte[] IV;

            //get the Key and IV
            key = GetRijndaelKey(Key1, textConverter);
            IV = GetRijndaelIV(Key2, textConverter);

            //get an encryptor
            ICryptoTransform encryptor = oRijndael.CreateEncryptor(key, IV);

            //encryp data
            MemoryStream msEncrypt = new MemoryStream();
            CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);

            toEncrypt = textConverter.GetBytes(StringToEncrypt);

            //Write all data to the crypto stream and flush it.
            csEncrypt.Write(toEncrypt, 0, toEncrypt.Length);
            csEncrypt.FlushFinalBlock();

            //Get encrypted array of bytes.
            encrypted = msEncrypt.ToArray();

            StringToEncrypt = HexStringHelper.ConvertBytesToHexString(encrypted);

            return StringToEncrypt;
        }

        public static string DecryptStringRijndaelFromHexString(string originalHexStringToDecrypt)
        {
            string DecryptedString;

            ASCIIEncoding textConverter = new ASCIIEncoding();
            RijndaelManaged oRijndael = new RijndaelManaged();
            string Key1 = "carwash";
            string Key2 = "andi";
            Byte[] toDecrypte;
            Byte[] key;
            Byte[] IV;

            key = GetRijndaelKey(Key1, textConverter);
            IV = GetRijndaelIV(Key2, textConverter);

            //get decryptor
            ICryptoTransform decryptor = oRijndael.CreateDecryptor(key, IV);
            try
            {
                //decrypt data
                Byte[] encryted = HexStringHelper.ConvertHexStringToBytes(originalHexStringToDecrypt);

                MemoryStream msDecrypt = new MemoryStream(encryted);
                CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);

                //covert data to a byte array.
                toDecrypte = new Byte[encryted.Length - 1];

                //write all data to the crypto stream and flush it.
                csDecrypt.Read(toDecrypte, 0, toDecrypte.Length);

                int nSigCharLength = -1;
                foreach (Byte nByte in toDecrypte)
                {
                    nSigCharLength += 1;
                    if (nByte == 0)
                        break;
                }

                //redim preserve
                toDecrypte = toDecrypte.Take(nSigCharLength).ToArray();

                DecryptedString = textConverter.GetString(toDecrypte);

            }
            catch (CryptographicException ex)
            {
                throw new ApplicationException(ex.Message, ex);
            }
            catch (ApplicationException ex)
            {
                throw new ApplicationException(ex.Message, ex);
            }

            return DecryptedString;
        }

        public static Byte[] GetRijndaelKey(string Key1, ASCIIEncoding txtConverter)
        {
            if (Key1.Length < 32)
                Key1 = Key1.PadRight(32);
            else
                Key1 = Key1.Substring(0, 32);

            return txtConverter.GetBytes(Key1);
        }

        public static Byte[] GetRijndaelIV(string Key2, ASCIIEncoding txtConverter)
        {
            if (Key2.Length < 16)
                Key2 = Key2.PadRight(16);
            else
                Key2 = Key2.Substring(0, 16);

            return txtConverter.GetBytes(Key2);
        }
    }
}
