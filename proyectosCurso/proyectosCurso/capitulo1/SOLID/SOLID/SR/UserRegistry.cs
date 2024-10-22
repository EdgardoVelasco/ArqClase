using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SR
{
    public class User { 
       public string? Email { get; set; }
       public string? Password { get; set; }    
    }

    public class EncryptionService {
        public static string Encrypt(string data) {
            var encoding=Encoding.UTF8.GetBytes(data);
            var sha256 = SHA256.HashData(encoding);
            var dataEncrypted = Convert.ToHexString(sha256);
            return dataEncrypted;
        }
    }
    public class UserRegistry
    {
        private List<User> Users= new List<User>();

        public bool Registry(User user) {
            if (user.Email.Length>0 && user.Password.Length>=8) {
                /*Encriptar Password*/
              var passwordEncripted=EncryptionService.Encrypt(user.Password);
                /*End Encriptar Password*/
                Users.Add(new User() {
                    Email=user.Email, 
                    Password=passwordEncripted
                });
                return true;
            }
            return false;
        }

    }
}
