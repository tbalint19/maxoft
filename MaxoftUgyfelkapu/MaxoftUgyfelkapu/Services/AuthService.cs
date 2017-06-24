using MaxoftUgyfelkapu.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaxoftUgyfelkapu.Services
{
    public class AuthService
    {
        private EncryptionHelper encrypter;
        private string key;
        private string separator;
        private string validator;

        public AuthService()
        {
            encrypter = new EncryptionHelper();
            separator = "<<<>>>";
            validator = "CONFIRMEDUSER";
        }

        public string generateToken(string username)
        {
            string token = encrypter.Encrypt(username + separator + validator);
            return token;
        }

        public string validateToken(string token)
        {
            if (token == null || token == "")
            {
                return null;
            }
            string decryptedToken = encrypter.Decrypt(token);
            if (!decryptedToken.Contains(validator) || !decryptedToken.Contains(separator))
            {
                return null;
            }
            string username = decryptedToken.Split(separator.ToCharArray())[0];
            return username;
        }
    }
}