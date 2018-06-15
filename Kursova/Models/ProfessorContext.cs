using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kursova.Models
{
    public class ProfessorContext: DbContext
    {
        public ProfessorContext()
             : base("DefaultConnection")
        { }
        public DbSet<Professor> Professors { get; set; }
    }
}