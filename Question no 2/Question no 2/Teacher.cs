using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question_no_2
{
    internal class Teacher
    {
        public int id;
        public string name;
        public string subject;

        public Teacher(int id,string name,string subject)
        {
            this.id = id;
            this.name = name;
            this.subject = subject;
        }

        public void assigngrade(Student std1,int grade  )
        {

            std1.addgrade(grade);
            Console.WriteLine($"Teacher \"{name}\" has assigned the grade {grade} to student {std1.Name} in subject {subject}.");
           
        
        }


    }
}
