using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kursova.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string Faculty { get; set; }
        //public bool isChangedPasword { get; set; }
        public DateTime DateOfRegister { get; set; }
    }
}