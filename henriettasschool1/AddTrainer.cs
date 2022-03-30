using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace henriettasschool1
{
    public class AddTrainer
    {
        eriettaDB2Entities db = new eriettaDB2Entities();

        public void TrainersAdded()
        {
            Console.WriteLine("Give me the name of the trainer, you want to Add in the List");
            string Name_of_Trainer = Console.ReadLine();
            Console.WriteLine("The First Name of the trainer is"+ Name_of_Trainer);
            Console.WriteLine("Give me the Last_name of the trainer, you want to Add in the List");
            string Last_of_Trainer = Console.ReadLine();
            Console.WriteLine("The First Name of the trainer is" + Last_of_Trainer);
            Trainer t_1 = new Trainer()
            {
                FirstName = Name_of_Trainer,
                LastName = Last_of_Trainer
            };
            db.Trainers.Add(t_1);
            db.SaveChanges();
        }


    }
}
