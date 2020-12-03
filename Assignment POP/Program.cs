using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_POP_Nativel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the firstname of your student");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter the lastname of your student");
            string lastname =Console.ReadLine();
            Console.WriteLine("Enter the student's age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the student's number of your student");
            string studentnumber = Console.ReadLine();
            Console.WriteLine("How many marks does " + firstname + " " + lastname + " " + " have");
            int numberofmarks = Convert.ToInt32(Console.ReadLine());
            int[] scores = new int[numberofmarks];
            int count = 0;
            int mark = -1;
            int num = 0;
            while(count<numberofmarks)
            {
                num = count + 1;
                Console.WriteLine("Enter  mark "+num+" , number between 0 and 100 (one by one)");
                mark = Convert.ToInt32(Console.ReadLine());
                while (mark < 0 || mark > 100)
                {
                    Console.WriteLine("Enter mark "+num+" , number between 0 and 100 (one by one)");
                    mark = Convert.ToInt32(Console.ReadLine());                    
                }
                scores[count] = mark;
                count++;
            }
            Console.WriteLine("Enter the country of your student");
            string country = Console.ReadLine();
            Console.WriteLine("Enter the city of your student");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the street of your student");
            string street = Console.ReadLine();
            Console.WriteLine("Enter the street number of your student");
            int street_number = Convert.ToInt32(Console.ReadLine());
            Address address1 = new Address(street_number, street, city, country);
            Person person1 = new Person(firstname, lastname);
            Student student1 = new Student(studentnumber, age, address1, scores,firstname,lastname);
            Console.WriteLine("student " + student1.fullname + " score is " + student1.average_score);
            Console.WriteLine("student " + student1.fullname + " is living in " + student1.address.city);
            Console.WriteLine("student " + student1.fullname + " address is " + student1.full_address);
            student1.ToString();
            Console.ReadKey();
        }

    }
}
