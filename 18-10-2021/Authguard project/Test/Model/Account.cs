using System.ComponentModel.DataAnnotations;

namespace Test.Model
{
    public class Account
    {   [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}