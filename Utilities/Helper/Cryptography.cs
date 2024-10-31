using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Utilities.Helper
{
    public class RSACryptography
    {
        // Tạo khóa RSA mới
        public static (string publicKey, string privateKey) GenerateKeys()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                // Lấy khóa công khai và khóa riêng
                string publicKey = Convert.ToBase64String(rsa.ExportCspBlob(false));
                string privateKey = Convert.ToBase64String(rsa.ExportCspBlob(true));
                return (publicKey, privateKey);
            }
        }

        // Hàm mã hóa dữ liệu, trả về kết quả dưới dạng string
        public static string EncryptData(string plainText, string publicKey)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportCspBlob(Convert.FromBase64String(publicKey));
                byte[] dataToEncrypt = Encoding.UTF8.GetBytes(plainText);
                byte[] encryptedData = rsa.Encrypt(dataToEncrypt, true);
                return Convert.ToBase64String(encryptedData); // Trả về kết quả mã hóa dưới dạng string
            }
        }

        // Hàm giải mã dữ liệu, nhận vào string và trả về string
        public static string DecryptData(string cipherText, string privateKey)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportCspBlob(Convert.FromBase64String(privateKey));
                byte[] dataToDecrypt = Convert.FromBase64String(cipherText);
                byte[] decryptedData = rsa.Decrypt(dataToDecrypt, true);
                return Encoding.UTF8.GetString(decryptedData); // Trả về kết quả giải mã dưới dạng string
            }
        }
    }

    public class Cryptography
    {
        public enum SymmProvEnum
        {
            DES, RC2, Rijndael
        }

        private readonly SymmetricAlgorithm _mobjCryptoService;

        public Cryptography()
        {
            _mobjCryptoService = new DESCryptoServiceProvider();
        }

        public Cryptography(SymmProvEnum netSelected)
        {
            switch (netSelected)
            {
                case SymmProvEnum.DES:
                    _mobjCryptoService = new DESCryptoServiceProvider();
                    break;
                case SymmProvEnum.RC2:
                    _mobjCryptoService = new RC2CryptoServiceProvider();
                    break;
                case SymmProvEnum.Rijndael:
                    _mobjCryptoService = new RijndaelManaged();
                    break;
            }
        }

        public Cryptography(SymmetricAlgorithm mobjCryptoService)
        {
            _mobjCryptoService = mobjCryptoService;
        }

        private byte[] GetLagalKey(string key)
        {
            string sKey = null;

            if (_mobjCryptoService.LegalKeySizes.Length > 0)
            {
                var moreSize = _mobjCryptoService.LegalKeySizes[0].MinSize;

                while (key.Length * 8 > moreSize)
                {
                    moreSize += _mobjCryptoService.LegalKeySizes[0].SkipSize;
                }
                sKey = key.PadRight(moreSize / 8, ' ');
            }
            else
            {
                sKey = key;
            }

            return Encoding.ASCII.GetBytes(sKey);
        }

        public string Encrypting(string source, string key)
        {
            var bytKey = GetLagalKey(key);

            _mobjCryptoService.Key = bytKey;
            _mobjCryptoService.IV = bytKey;

            var ms = new MemoryStream();
            var encrypto = _mobjCryptoService.CreateEncryptor();
            var cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);

            var bytIn = Encoding.UTF8.GetBytes(source);
            cs.Write(bytIn, 0, bytIn.Length);
            cs.FlushFinalBlock();

            var bytOut = ms.ToArray();

            return Convert.ToBase64String(bytOut, 0, bytOut.Length);
        }

        public string Decrypting(string source, string key)
        {
            var bytIn = Encoding.UTF8.GetBytes(source);
            var ms = new MemoryStream(bytIn, 0, bytIn.Length);
            var bytKey = GetLagalKey(key);

            _mobjCryptoService.Key = bytKey;
            _mobjCryptoService.IV = bytKey;

            var encrypto = _mobjCryptoService.CreateEncryptor();
            var cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);

            return new StreamReader(cs).ReadToEnd();
        }
    }
}
