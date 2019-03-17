using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nody
{
    class DataFormattingClass
    {
        public static void SendRequest(string request, string username, string password)
        {
            string aesKeyZero = CryptoSecurityClass.GenerateKey(32);
            string aesKeyOne = CryptoSecurityClass.GenerateKey(32);

            string outgoingRequest = String.Format("{0}<!<Split Them Up>!>{1}<sub split>{2}<sub split>{3}",
                request,
                CryptoSecurityClass.RsaEncrypt(username),
                CryptoSecurityClass.RsaEncrypt(password),
                CryptoSecurityClass.AesEncrypt(ASCIIEncoding.ASCII.GetBytes(GlobalVariablesClass.clientPublicKey), ASCIIEncoding.ASCII.GetBytes(aesKeyOne)
                ));

            string outgoinSecureRequest = String.Format("{0}<key data>{1}<key data>{2}",
                CryptoSecurityClass.AesEncrypt(ASCIIEncoding.ASCII.GetBytes(outgoingRequest), ASCIIEncoding.ASCII.GetBytes(aesKeyOne)),
                CryptoSecurityClass.RsaEncrypt(aesKeyOne),
                CryptoSecurityClass.RsaEncrypt(aesKeyOne)
                 );

            HandleCommunicationClass.SendData(outgoinSecureRequest);

        }

        public static void SendNodeDataRequest(string request, string username, string password, string nodeName)
        {
            string aesKeyZero = CryptoSecurityClass.GenerateKey(32);
            string aesKeyOne = CryptoSecurityClass.GenerateKey(32);

            string outgoingRequest = String.Format("{0}<!<Split Them Up>!>{1}<sub split>{2}<sub split>{3}<sub split>{4}",
                request,
                CryptoSecurityClass.RsaEncrypt(username),
                CryptoSecurityClass.RsaEncrypt(password),
                CryptoSecurityClass.RsaEncrypt(nodeName),
                CryptoSecurityClass.AesEncrypt(ASCIIEncoding.ASCII.GetBytes(GlobalVariablesClass.clientPublicKey), ASCIIEncoding.ASCII.GetBytes(aesKeyOne)
                ));

            string outgoinSecureRequest = String.Format("{0}<key data>{1}<key data>{2}",
                CryptoSecurityClass.AesEncrypt(ASCIIEncoding.ASCII.GetBytes(outgoingRequest), ASCIIEncoding.ASCII.GetBytes(aesKeyOne)),
                CryptoSecurityClass.RsaEncrypt(aesKeyOne),
                CryptoSecurityClass.RsaEncrypt(aesKeyOne)
                 );

            HandleCommunicationClass.SendData(outgoinSecureRequest);
        }
        public static string[] ServerCollectionToArray(string securedCollection)
        {

            string[] keyKeywordChars = { "<key data>" };
            string[] splitingKeywordChars = { "<data>" };

   
            string[] securedCollectionArray = securedCollection.Split(keyKeywordChars, StringSplitOptions.RemoveEmptyEntries);
            
            string decryptionKey = CryptoSecurityClass.RsaDecrypt(securedCollectionArray[1]);
            string decryptedCollection = CryptoSecurityClass.AesDecrypt(securedCollectionArray[0], ASCIIEncoding.ASCII.GetBytes(decryptionKey));

            string[] decryptedCollectionArray = decryptedCollection.Split(splitingKeywordChars, StringSplitOptions.RemoveEmptyEntries);
            
            return decryptedCollectionArray;
        }
        public static string DesecureServerResponse(string securedServerResponse)
        {
            return CryptoSecurityClass.RsaDecrypt(securedServerResponse);
        }
    }
}
