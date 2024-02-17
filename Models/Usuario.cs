using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestion_Avalos.Models
{
    public class Usuario
    {
        private int Id;
        private string FirstName;
        private string LastName;
        private string UserName;
        private string Password;
        private string Email;

        public Usuario()
        {

        }
        public Usuario(int id, string firstName, string lastName, string userName, string password, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Email = email;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string UserName1 { get => UserName; set => UserName = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Email1 { get => Email; set => Email = value; }
    }
}
