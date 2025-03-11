using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_2
{
    internal class Student
    {
        public int Id;
        public string Name;
        public int[] grade;
        public int count;

        public Student(int id,string name)
        {
            Name=name;
            Id=id;
            grade = new int[3];
            count=0;
        }

        public void addgrade(int grade)
        {
            this.grade[count++] = grade;
        }

        public double Avg()
        {
            if (count == 0)
            {
                return 0;
            }
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += grade[i];
            }
            return sum / count;
        }
        public void display()
        {
            double average=Avg();
            Console.WriteLine("\nName of student is :" + Name);
            Console.WriteLine("ID is :"+ Id);   
            Console.WriteLine("Average is :" + average);
        }

    }
}
