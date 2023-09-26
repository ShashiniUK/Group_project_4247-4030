using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Models
{

    public class NormalUser
    {
        
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }



        public NormalUser(string regno, string name, string username, string password, string email)
        {
            ID = regno;
            Name = name;
            UserName = username;
            Password = password;
            Email = email;
        }

        public NormalUser()
        {
        }
    }
}
