using FilmOpinions.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmOpinions.Domain.Entity
{
    public class User
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string SaltPassword { get; set; }
        public DateTime UserCreateDate { get; set; }
        public Role UserRole { get; set; }
        public bool UserDelete { get; set; }
        public bool UserBlocked { get; set; }
    }
}
