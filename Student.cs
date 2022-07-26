using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentGrid
{
    public class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
        public string Address { get; set; }

        public List<Student> studentList = new List<Student>();

        public Student()
        {
            //nothing here
        }
        public Student(string studentName, int studentId, string studentAddress)
        {
            Name = studentName;
            RollNo = studentId;
            Address = studentAddress;
        }
        public List<Student> StudentGenerator(string[] nameArr, string [] addressArr)
        {
            //Random rnd = new Random();

            for (int i = 0; i < nameArr.Length; i++)
            {
                studentList.Add(new Student(nameArr[i], i + 1, addressArr[i]));
            }

            return studentList;
        }
    }

   
}