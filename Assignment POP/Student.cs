using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_POP_Nativel
{
    class Student: Person
    {

        public string studentnumber;
        public int age;
        public Address address;
        public string fullname;
        public int[] scores;
        public int average_score;
        public string full_address;
        public Student(string studentnumber, int age, Address a, int[] scores, string firstname, string lastname) : base(firstname, lastname)
        {        
            fullname = firstname + " " + lastname;
            int average_score = 0;
            this.studentnumber = studentnumber;
            this.age = age;
            address = a;
            full_address = a.country +", "+ a.city+", "+a.street+", "+a.number;
            this.scores = scores;
            for(int i=0;i<scores.Length;i++)
            {
                average_score = average_score + scores[i];
            }
            this.average_score = average_score/scores.Length;
        }
        public void PrintScore()
        {
            for(int index=0;index<scores.Length;index++)
            {
                Console.Write(scores[index] + " ");
            }
        }
        public void  ToString()
        {
            Console.WriteLine(firstname+" / "+lastname+" / "+studentnumber+" / "+age + " / "+fullname+" / ²"+full_address+" / " + average_score);
            address.ToString();
            Console.WriteLine();
            PrintScore();

        }
    }
}
