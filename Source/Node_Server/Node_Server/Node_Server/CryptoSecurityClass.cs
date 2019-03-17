using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using Sodium;


namespace Node_Server
{
    public class CryptoSecurityClass
    {

        private static RSACryptoServiceProvider rSACryptoServiceProvider;

        public static string AesEncrypt(byte[] plainDataBytes, byte[] keyBytes)
        {
            CryptoSecurityClass cryptoSecurity = new CryptoSecurityClass();
            AesCryptoServiceProvider serviceProvider = cryptoSecurity.GetAesProvider(keyBytes);

            ICryptoTransform encryptor = serviceProvider.CreateEncryptor();

            byte[] encryptedBytes = encryptor.TransformFinalBlock(plainDataBytes, 0, plainDataBytes.Length);

            string encryptedString = Convert.ToBase64String(encryptedBytes);

            return encryptedString;
        }

        public static string AesDecrypt(string encryptedData, byte[] keyBytes)
        {
            byte[] encryptedDataBytes = Convert.FromBase64String(encryptedData);

            CryptoSecurityClass cryptoSecurity = new CryptoSecurityClass();
            AesCryptoServiceProvider serviceProvider = cryptoSecurity.GetAesProvider(keyBytes);

            ICryptoTransform decriptor = serviceProvider.CreateDecryptor();

            byte[] dectyptedBytes = decriptor.TransformFinalBlock(encryptedDataBytes, 0, encryptedDataBytes.Length);

            string decryptedString = Encoding.ASCII.GetString(dectyptedBytes);
            return decryptedString;
        }

        public static string RsaEncrypt(string data, string publicKey)
        {
            rSACryptoServiceProvider = new RSACryptoServiceProvider();
            rSACryptoServiceProvider.ImportParameters(GetRSAParameters(publicKey));

            byte[] stringBytes = Encoding.Unicode.GetBytes(data);
            byte[] encryptedBytes = rSACryptoServiceProvider.Encrypt(stringBytes, false);

            rSACryptoServiceProvider.Clear();
            rSACryptoServiceProvider.Dispose();

            return Convert.ToBase64String(encryptedBytes);
        }

        public static string RsaDecrypt(string encryptedData)
        {
            // Gets the bytes from the data which is presented as a Base64 string
            byte[] stringBytes = Convert.FromBase64String(encryptedData);
            // Initializes an instance of the RSACryptoServiceProvider
            rSACryptoServiceProvider = new RSACryptoServiceProvider();
            //Imports the key parameter from the GlobalVariablesClass.clientPrivateKet parameter
            rSACryptoServiceProvider.ImportParameters(GlobalVariablesClass.serverPrivateKey);
            // Decrypts the bytes without OAEP padding
            byte[] decryptedBytes = rSACryptoServiceProvider.Decrypt(stringBytes, false);
            // Clears the RSACryptoServiceProvider
            rSACryptoServiceProvider.Clear();
            // Releases all the resources used by RSACryptoServiceProvider
            rSACryptoServiceProvider.Dispose();
            // Returns the decrypted bytes
            return Encoding.Unicode.GetString(decryptedBytes);   
        }

        public static void GenerateCommunicationKeys()
        {
            StringWriter stringW = new StringWriter();
            RSACryptoServiceProvider keyCryptoProvider = new RSACryptoServiceProvider(4096);
            var publicKey = keyCryptoProvider.ExportParameters(false);
            var privateKey = keyCryptoProvider.ExportParameters(true);

            var publicSerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));

            publicSerializer.Serialize(stringW, publicKey);
            GlobalVariablesClass.serverPublicKey = stringW.ToString();
            stringW.Flush();

            GlobalVariablesClass.serverPrivateKey = privateKey;

            keyCryptoProvider.Clear();
        }

        public static string GenerateKey(int length)
        {
            // Imtitates StringBuilder object
            StringBuilder keyString = new StringBuilder(length);
            // Creates a hard coded char array that contains sequence of letters
            char[] leagalCharsArray = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ01234+{}]56789!@#$%^&*()_[;:/?".ToCharArray();

            // A valid data is 1 byte
            byte[] validData = new byte[1];

            using (RNGCryptoServiceProvider rngStrProvider = new RNGCryptoServiceProvider())
            {
                rngStrProvider.GetNonZeroBytes(validData);

                validData = new byte[length];

                rngStrProvider.GetNonZeroBytes(validData);

                foreach (byte currentByte in validData)
                {
                    keyString.Append(leagalCharsArray[currentByte % (leagalCharsArray.Length)]);
                }
            }
            return keyString.ToString();

        }

        public static RSAParameters GetRSAParameters(string xmlKeyString)
        {
            StringReader stringReader = new StringReader(xmlKeyString);
            var keySerializer = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));

            RSAParameters keyParamters = (RSAParameters)keySerializer.Deserialize(stringReader);

            return keyParamters;
        }

        private AesCryptoServiceProvider GetAesProvider(byte[] key)
        {
            return new AesCryptoServiceProvider()
            {
                Key = key,
                BlockSize = 128,
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.ECB
            };
        }
        public static string HashPassword(string password, string salt)
        {
            byte[] passwordHashBytes = PasswordHash.ArgonHashBinary(
                password,
                salt,
                PasswordHash.StrengthArgon.Interactive,
                128
                );

            return Convert.ToBase64String(passwordHashBytes);
        }
    }
}