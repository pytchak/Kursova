using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Kursova.Models;
using System.Data.Entity;

namespace Kursova.Jobs
{
    public class CheckUsers : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            using (ProfessorContext db = new ProfessorContext())
            {
                var users = db.Professors;
                foreach (Professor u in users)
                {
                    DateTime temp = u.DateOfRegister.AddHours(48);
                    if (temp < DateTime.Now)
                    {
                        db.Professors.Remove(u);
                    }
                }
                db.SaveChanges();
            }
        }
    }
}