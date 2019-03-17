using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Student
    {
        private string name;
        private string sname;
        private int age;
        private char sex;
        private float mark;
        private int hour;

        public string Name { get => name; set => name = value; }
        public string Sname { get => sname; set => sname = value; }
        public int Age { get => age; set => age = value; }
        public char Sex { get => sex; set => sex = value; }
        public float Mark { get => mark; set => mark = value; }
        public int Hour { get => hour; set => hour = value; }
        

        public string info()
        {
            return String.Format("Студент - {0} {1} {2} лет пол-{3}\nСредний балл {4} Кол-во пропущеных часов {5}", this.sname,this.Name,this.age,this.sex,this.mark,this.hour);
        }

        public Student(string name, string sname, int age, char sex)
        {
            this.name = name;
            this.sname = sname;
            this.age = age;
            this.sex = sex;
            this.mark = 0;
            this.hour = 0;
        }

        public void m_mark()
        {
            int n;
            Console.WriteLine("кол-во оценок");
            n = Convert.ToInt32(Console.ReadLine());
            int[] mark = new int[n]; 
            for (int i = 0 ; i < n; i++)
            {
                Console.Write("Введите оценку - ");
                Console.WriteLine(i+1);
                mark[i] = Convert.ToInt32(Console.ReadLine());
            }
            float m_mark = 0;
            for (int i = 0; i < n; i++)
            {
                m_mark += mark[i];
            }
            m_mark /= n;
            this.Mark = m_mark;
        }

        public void pass()
        {
            int n;
            Console.WriteLine("кол-во предметов в семестре");
            n = Convert.ToInt32(Console.ReadLine());
            int[] mark = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите кол-во пропущенных часов по предмету ");
                Console.WriteLine(i+1 +" - ");
                mark[i] = Convert.ToInt32(Console.ReadLine());
            }
            int pass = 0;
            for (int i = 0; i < n; i++)
            {
                pass += mark[i];
            }
            this.Hour = pass;
        }
    }
}
