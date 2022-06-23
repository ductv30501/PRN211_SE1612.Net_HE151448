using System;
using System.Collections;
using System.Collections.Generic;

namespace demoInherit_KeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            /*student s = new SEStudent(10, "duc", ".net");
            s.display();
            student s1 = new student(10,"duc" );
            s1.display();
            SEStudent s2 = new SEStudent();
            s2.input();
            s2.display();
            student sa = new student(1, "duc");
            student sd = new student(1, "duc");
            if (sa.Equals(sd)) Console.WriteLine("bang nhau");
            else Console.WriteLine("khong bang nhau");*/
            demoArrayList();
            DemoList();
        }
        public static void demoArrayList()
        {
            /*ArrayList array = new ArrayList();
            array.Add(2);
            array.Add(4);
            array.Add(6);
            int sum = (int)array[1] + (int)array[2];
            Console.WriteLine(sum);*/
            ArrayList a = new ArrayList();
            a.Add(new student(1, "duc"));
            a.Add(new student(9, "duc"));
            ((student)a[1]).display();
        }
        public static void DemoList()
        {
            List<int> l1 = new List<int>();
            l1.Add(4);
            l1.Add(6);
            int sum = l1[0] + l1[1];

            List<student> s = new List<student>();
            s.Add(new student(1, "duc"));
            s.Add(new SEStudent(1, "duc",".net"));
            s[1].display();
        }
    }
}
