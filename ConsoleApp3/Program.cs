using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dekanat dekanat;
            Console.WriteLine("Добро пожаловать в универ(made by ДОБИ)");

            #region dekanat
            Console.WriteLine("Введите информацию о деканате:");
            Console.Write("Факульет - ");
            string name = Console.ReadLine();
            dekanat = new Dekanat(name);
            #endregion dekanat

            #region group
            Console.Write("Введите количество групп - ");
            int kol_group=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kol_group; i++)
            {
                Console.Write("Введите номер группы - ");
                String nomer = Console.ReadLine();
                Console.Write("Введите специальность - ");
                String spec = Console.ReadLine();
                Group new_group = new Group(nomer,spec);
                Console.WriteLine(String.Empty.PadLeft(40, '*'));
                Console.Write("Введите количество студентов - ");
                int kol_student = Convert.ToInt32(Console.ReadLine());
                for (int j=0;j<kol_student;j++)
                {
                    Console.WriteLine("Введите иноформацию о студенте");
                    Console.Write("Введите Имя - ");
                    String st_name = Console.ReadLine(); 
                    Console.Write("Введите Фамилию - ");
                    String st_sname = Console.ReadLine();
                    Console.Write("Введите Возраст - ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите Пол - ");
                    char sex = Console.ReadLine()[0];

                    Student new_student = new Student(st_name,st_sname,age,sex);
                    new_group.add(new_student);
                    Console.WriteLine(String.Empty.PadLeft(40, '-'));
                    
                }
            }
            #endregion group
        }
    }
}
