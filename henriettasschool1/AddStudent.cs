using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace henriettasschool1
{
     public class AddStudent
    {
        eriettaDB2Entities db = new eriettaDB2Entities();
        public void Add()
        {
            Console.WriteLine("Give me the ID");
            string id_OfStudent = Console.ReadLine();
            int id1=Convert.ToInt32(id_OfStudent);
            var Student = db.Students.Find(id1);
            db.Entry(Student).State = EntityState.Added;
            db.SaveChanges();

        }
    }
}
