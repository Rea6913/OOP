using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Group
    {
        private Student[] students;
        private int kol;
        private float sr_mark;
        private int leval;
        private string profel;
        private string number;

        public Group(string number, string profel)
        {
            this.students = new Student[0];
            this.kol = 0;
            this.sr_mark = 0;
            this.leval = 1;
            this.profel = profel;
            this.number = number;
        }

        public int Kol { get => kol; set => kol = value; }
        public float Sr_mark { get => sr_mark; set => sr_mark = value; }
        public int Leval { get => leval; set => leval = value; }
        public string Profel { get => profel; set => profel = value; }
        internal Student[] Students { get => students; set => students = value; }
        public string Number { get => number; set => number = value; }

        public Student nouck(string s_name)
        {
            for (int i = 0; i < this.kol; i++)
                if (this.students[i].Sname == s_name)
                    return (this.students[i]);
            Console.WriteLine("нет в данной группе");
            return (null);
        }
        public Student get (int nomer)
        {
            if (nomer > this.kol || this.kol < 0)
            {
                Console.WriteLine("такого студента нет ");
                return (null);
            }
            return (this.students[nomer-1]);
                         
        }
        public void  add (Student student)
        {
            Student[] mas_student = new Student[kol+ 1];
            for (int i = 0; i < this.kol; i++)
                mas_student[i] = this.students[i];
            mas_student[this.kol] = student;
            this.students = mas_student;
            this.kol = this.kol + 1;
        }
        public void del (int nomer)
        {
            if (nomer > this.kol || this.kol < 0)
            {
                Console.WriteLine("такого студента нет ");
            }
            else
            {
                Student[] mas_student = new Student[kol - 1];
                for (int i = 0; i < nomer; i++)
                    mas_student[i] = this.students[i];
                for (int i = nomer ; i < kol-1; i++)
                    mas_student[i] = this.students[i+1];
            }

        }
    }
}
