using System.Text.Json.Serialization;

namespace ReservacionesRestful.Bussiness.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        public User(int Id, string Name, string Email, string password) { 
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Password = password;
        }
    }
}
