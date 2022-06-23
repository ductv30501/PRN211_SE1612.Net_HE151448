using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoInherit_KeThua
{
    class student
    {
        public student(int iD, string name)
        {
            ID = iD;
            this.name = name;
        }

        public student()
        {
        }

        public int ID { get; set; }

        public string name { get; set; }

        virtual public void display()
        {
            Console.WriteLine($"student: ID:{ID}, Name: {name}");
        }
         public void input()
        {
            Console.WriteLine("input student ID:");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input student name:");
            name = Console.ReadLine();
        }

        public override bool Equals(object obj)
        {
            return obj is student student &&
                   ID == student.ID &&
                   name == student.name;
        }
    }
}
