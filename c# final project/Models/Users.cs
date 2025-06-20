using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__final_project.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }    
        public string Name { get; set; }        
        public string Password { get; set; }    
        public string Role { get; set; }       
        public string Gender { get; set; }
        public string Course { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }
        public string NICNumber { get; set; }         
        public DateTime DOB { get; set; }       
        public string Subject { get; set; }
         public string Phonenumber { get; set; }
    }
}
