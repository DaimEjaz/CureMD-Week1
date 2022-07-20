using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccessStudentInfo
{
    public partial class AccessInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            List<Student> studentList = new List<Student>();
            string[] nameArr = { "Edgar Barber", "Marquis Reilly", "Isabell Frank", "Issac Hammond", "Aydan Mcclain", "Daphne Burke", "Mia Duarte", "Phoebe Mcclain", "Dayana Massey", "Maxwell Zhang", "Keith Pineda", "Dustin Camacho", "Alyvia Lam", "Justice Mata", "Alissa Bautista", "Laura Wade", "Howard Flynn", "Marques Wilcox", "Taryn Wang", "Caden Potts" };
            StudentGenerator(nameArr, studentList);
            //Console.WriteLine(studentList);
            list.DataSource = nameArr;
            list.DataBind();
        }

        public static void StudentGenerator(string[] nameArr, List<Student> studentList)
        {
            Random rnd = new Random();

            for (int i = 0; i < nameArr.Length ; i++)
            {
                studentList.Add(new Student(nameArr[i], i+1, rnd.Next(2017, 2022) ));
            }
        }

        public static object Answer(List<Student> studentList )
        {
            //int queryIndex = 
            return studentList[queryIndex];
        }



    }

    public class Student 
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int AdmissionYear { get; set; }   

        public Student(string name, int id, int admissionYear)
        {
            Name = name;
            Id = id;
            AdmissionYear = admissionYear;
        }
    }

    

}