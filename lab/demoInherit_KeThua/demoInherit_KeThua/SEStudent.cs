using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoInherit_KeThua
{
    class SEStudent : student
    {
        public string Skill { get; set; }
        public SEStudent(int ID, string name, string skill) : base(ID,name)
        {
            Skill = skill;
        }

        public SEStudent()
        {
        }

        public SEStudent(int iD, string name) : base(iD, name)
        {
        }

        override public void display()
        {
            Console.WriteLine($"student: ID: {ID}, name: {name}, skill: {Skill}");
        }

        

        
        public void input()
        {
            base.input();
            Console.WriteLine("input student skill: ");
            Skill = Console.ReadLine();
        }
    }
}
