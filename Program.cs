using System;

namespace Homework._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте,система Сивилла вас приветсвует, какого работника выбрать?");
            int[] arr1 = new int[12];
            Random rnd = new Random();
            for (int i = 0; i < 12; i++)
            {
                arr1[i] = rnd.Next(500, 1500);
            }
            int[] arr2 = new int[12];

            for (int i = 0; i < 12; i++)
            {
                arr2[i] = rnd.Next(500, 1500);
            }
            int[] arr3 = new int[12];

            for (int i = 0; i < 12; i++)
            {
                arr3[i] = rnd.Next(500, 1500);
            }
            Console.WriteLine("Игорь(a),Виктор(b),Павел(с)");
            string action;
            action = Console.ReadLine();
            int k = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                k = k + arr1[i];
                
            }
            k = k / arr1.Length;
            int a = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                a = a + arr1[i];

            }
            a = a / arr1.Length;
            int v = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                v = v + arr1[i];

            }
            v = v / arr1.Length;
            Еmployee[] employeeArray1 = new Еmployee[12];
            for (int i = 0; i < 12; i++)
            {
                Еmployee m = new Еmployee();

                m.name = "Игорь";
                m.salary = arr1[i];
                m.max_salary = arr1.Max();
                m.average_salary = k;
                employeeArray1[i] = m;
            }
            Еmployee[] employeeArray2 = new Еmployee[12];
            for (int i = 0; i < 12; i++)
            {
                Еmployee b = new Еmployee();

                b.name = "Виктор";
                b.salary = arr2[i];
                b.max_salary = arr2.Max();
                b.average_salary = a;
                employeeArray2[i] = b;
            }
            Еmployee[] employeeArray3 = new Еmployee[12];
            for (int i = 0; i < 12; i++)
            {
                Еmployee c = new Еmployee();

                c.name = "Павел";
                c.salary = arr3[i];
                c.max_salary = arr3.Max();
                c.average_salary = v;
                employeeArray3[i] = c;
            }

            switch (action)
            {
                case "a":
                    for (int i = 0; i <12; i++)
                    {
                        employeeArray1[i].DB(employeeArray1[i]);
                        
                    }
                    break;
                case "b":
                    for (int i = 0; i < 12; i++)
                    {
                        employeeArray2[i].DB(employeeArray2[i]);

                    }
                    break;
                case "c":
                    for (int i = 0; i < 12; i++)
                    {
                        employeeArray3[i].DB(employeeArray3[i]);

                    }
                    break;
            }           
        }
    }

    internal class Еmployee
    {
        
        public string name { get; set; }
        public int salary { get; set; }
        public int max_salary { get; set; }
        public double average_salary { get; set; }
        public void DB(Еmployee employeeArray1)
        {
            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Зарплата сотрудника {employeeArray1.name}: месяц {i} зарплата {employeeArray1.salary} ,средняя {employeeArray1.average_salary}   ");
                Console.WriteLine($"Максимальная зарплата {employeeArray1.max_salary}");
                break;
            }
        }
    }
}