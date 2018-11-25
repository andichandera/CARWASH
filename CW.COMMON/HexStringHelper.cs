using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CW.COMMON
{
    public class HexStringHelper
    {
        public static Byte[] ConvertHexStringToBytes(string HexString)
        {
            Byte[] buffers;

            buffers = new Byte[(Convert.ToInt32(HexString.Length / 2))];

            int nI = -1;
            for (nI = 0; nI <= buffers.Length - 1; nI++)
            {
                string sHex = HexString.Substring((nI * 2), 2);
                Byte b = ConvertHexPairToByte(sHex);
                buffers[nI] = b;
            }

            return buffers;
        }

        public static Byte ConvertHexPairToByte(string sHex)
        {
            if (sHex.Length != 2)
                throw new ApplicationException("Hex Pair Must Be 2 Char");

            Byte nValue = 0;

            Char[] arHexPart = sHex.ToCharArray();
            Char cHexPart1 = arHexPart[0];
            Char cHexPart2 = arHexPart[1];

            nValue += ConvertHexCharToByte(cHexPart2);
            nValue += Convert.ToByte(ConvertHexCharToByte(cHexPart1) * 16);

            return nValue;
        }

        public static Byte ConvertHexCharToByte(Char cHextPart)
        {
            Dictionary<Char, Byte> oHexCharMap = new Dictionary<char, byte>();

            oHexCharMap.Add((char)'0', 0);
            oHexCharMap.Add((char)'1', 1);
            oHexCharMap.Add((char)'2', 2);
            oHexCharMap.Add((char)'3', 3);
            oHexCharMap.Add((char)'4', 4);
            oHexCharMap.Add((char)'5', 5);
            oHexCharMap.Add((char)'6', 6);
            oHexCharMap.Add((char)'7', 7);
            oHexCharMap.Add((char)'8', 8);
            oHexCharMap.Add((char)'9', 9);
            oHexCharMap.Add((char)'a', 10);
            oHexCharMap.Add((char)'b', 11);
            oHexCharMap.Add((char)'c', 12);
            oHexCharMap.Add((char)'d', 13);
            oHexCharMap.Add((char)'e', 14);
            oHexCharMap.Add((char)'f', 15);

            Byte result;
            if (oHexCharMap.ContainsKey(cHextPart))
                oHexCharMap.TryGetValue(cHextPart, out result);
            else
                throw new ApplicationException("Invalid Hex Char");


            return result;
        }

        public static string ConvertBytesToHexString(Byte[] arBytes)
        {
            StringBuilder sbHexString = new StringBuilder();
            foreach (Byte oByte in arBytes)
            {
                sbHexString.AppendFormat("{0:x2}", oByte);
            }

            return sbHexString.ToString();
        }
    }
}
