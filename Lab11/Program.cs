using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        public static string[] mounths =
        {
            "January",
            "Fedruary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };

        public static string printW_S(int n)
        {
            if (n == 0) return "Winter's";
            if (n == 1) return "Summer's";
            return null;
        }

        static void Main(string[] args)
        {
            //////////////////////-----------------------1111111---------------------
            int n = 0;
            //Console.WriteLine("Enter the lenght");
            //n = int.Parse(Console.ReadLine());
            //IEnumerable<string> sequence = mounths
            //.Where(x => x.Length == n)
            //.Select(x => x);
            //Console.WriteLine($"Only {n} letters lenght");
            //foreach (string mounth in sequence)
            //{
            //    Console.WriteLine("{0}", mounth);
            //}
            //////////////---------------------------------------------
            //Console.WriteLine("Winter(0) or Summer(1)");
            //string[] wintermount = { "January", "Fedruary", "December" };
            //string[] summermount = { "June", "July", "August" };
            //n = int.Parse(Console.ReadLine());
            //IEnumerable<string> sequenceTimeOfTheYear = null;
            //if (n == 0)
            //{
            //    sequenceTimeOfTheYear = from m in mounths
            //                            where wintermount.Contains(m)
            //                            select m;
            //}
            //if (n == 1)
            //{
            //    sequenceTimeOfTheYear = from m in mounths
            //                            where summermount.Contains(m)
            //                            select m;
            //}
            //Console.WriteLine($"{printW_S(n)} mounths are: ");
            //foreach (string mounth in sequenceTimeOfTheYear)
            //{
            //    Console.WriteLine("{0}", mounth);
            //}
            //////////////---------------------------------------------
            //Console.WriteLine("By alphabet ");
            //IEnumerable<string> sequenceByAlphabet = from m in mounths
            //                                         orderby m[0] descending
            //                                         select m;
            //foreach (string mounth in sequenceByAlphabet)
            //{
            //    Console.WriteLine("{0}", mounth);
            //}
            ////////////////---------------------------------------------
            //Console.WriteLine("Contain letter 'u' and length >4 ");
            //IEnumerable<string> sequenceWithU = from m in mounths
            //                                    where m.Contains('u')
            //                                    where m.Length > 4
            //                                    select m;
            //foreach (string mounth in sequenceWithU)
            //{
            //    Console.WriteLine("{0}", mounth);
            //}
            //---------------------------------------------
            List<Student> students = new List<Student>
            {
                new Student(),
                new Student("Danil",200,0),
                new Student("Andrey",350,2),
                new Student("Dmitriy",10,1),
                new Student("Maksim",249,3),
                new Student("Misha",1000,0),
                new Student("Katya",1000,1),
                new Student("Julia",143,0)
            };

            IEnumerable<Student> sequence;
            sequence = from s in students
                       where (s.GetName()).Contains('a') || (s.GetName()).Contains('A')
                       select s;
            Console.WriteLine("\nContain in the name letter a");
            foreach (Student student in sequence)
            {
                Console.WriteLine(student);
            }
            //-=-=-
            sequence = null;
            sequence = from s in students
                       where s.GetMoney()>250
                       select s;
            Console.WriteLine("\nS with money >250");
            foreach (Student student in sequence)
            {
                Console.WriteLine(student);
            }
            //-=-=-
            sequence = null;
            sequence = from s in students
                       where s.GetRetakes()>0
                       orderby s.GetRetakes() descending
                       select s;
            Console.WriteLine("\nS with retakes (sort descending)");
            foreach (Student student in sequence)
            {
                Console.WriteLine(student);
            }
            //-=-=-
            sequence = null;
            sequence = from s in students
                       orderby s.GetMoney() descending
                       orderby s.GetRetakes()
                       select s;
            Console.WriteLine("\nSorted money,retakes");
            foreach (Student student in sequence)
            {
                Console.WriteLine(student);
            }
            //-=-=-
            sequence = null;
            sequence = from s in students
                       orderby s.GetRetakes()
                       orderby s.GetMoney() descending
                       select s;
            Console.WriteLine("\nSorted retakes,money");
            foreach (Student student in sequence)
            {
                Console.WriteLine(student);
            }


            //---------------------------------------------
            //          example
            // Использование синтаксиса выражения запроса
            //IEnumerable<string> sequence = from n in names
            //                               where n.Length < 6
            //                               select n;
            //foreach (string name in sequence)
            //{
            //    Console.WriteLine("{0}", name);
            //}

            Console.ReadKey();
        }
    }
}
