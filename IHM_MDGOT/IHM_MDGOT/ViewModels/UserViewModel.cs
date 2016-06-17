using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace IHM_MDGOT.ViewModels
{
    class UserViewModel : NotifyPropertyChangedBase
    {


        public bool EmailValid(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private string CalculateHash(string clearTextPassword, string us)
        {
            // Converti le mdp en mode byte
            byte[] saltedHashBytes = Encoding.UTF8.GetBytes(clearTextPassword + us);
            // Use the hash algorithm to calculate the hash
            HashAlgorithm algorithme = new SHA256Managed();
            byte[] hash = algorithme.ComputeHash(saltedHashBytes);
            // Return the hash as a base64 encoded string to be compared to the stored password
            return Convert.ToBase64String(hash);
        }

    }

}
