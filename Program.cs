using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int id;
            String name;
            char gender;
            double salary;
            DateTime doj;
            Console.WriteLine("Enter id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter gender");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter doj");
            doj = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nID \t Employee Name \t Employee gender \t Employee Salary \t DOJ");
            
            Console.WriteLine("-----------------------------------------------------------------------------------------------");
          
            Console.WriteLine(id+"\t\t"+name+"\t\t"+gender+"\t\t\t"+salary+"\t\t"+doj);
            Console.WriteLine("\nYou need to pay______");
            if (salary > 90000)
            {
                Console.WriteLine("\nyou need to pay 30%");

            }
            else
            {
                Console.WriteLine("\nyou need to pay 15%");
            }

            Console.ReadKey();
        }
    }
}
