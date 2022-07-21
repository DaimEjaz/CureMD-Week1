using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccessStudentInfo
{
    public partial class AccessInfo : System.Web.UI.Page
    {

        public static List<Student> studentList = new List<Student>();

        protected void Page_Load(object sender, EventArgs e)
        {
        string[] nameArr = { "Edgar Barber", "Marquis Reilly", "Isabell Frank", "Issac Hammond", "Aydan Mcclain", "Daphne Burke", "Mia Duarte", "Phoebe Mcclain", "Dayana Massey", "Maxwell Zhang", "Keith Pineda", "Dustin Camacho", "Alyvia Lam", "Justice Mata", "Alissa Bautista", "Laura Wade", "Howard Flynn", "Marques Wilcox", "Taryn Wang", "Caden Potts" };
            StudentGenerator(nameArr, studentList);
            //Console.WriteLine(studentList);
            list.DataSource = nameArr;
            list.DataBind();
        }

        public static void StudentGenerator(string[] nameArr, List<Student> studentList)
        {
            Random rnd = new Random();

            for (int i = 0; i < nameArr.Length; i++)
            {
                studentList.Add(new Student(nameArr[i], i + 1, rnd.Next(2017, 2022)));
            }
        }

        [WebMethod]
        public static Student Answer( string queryIndex)
        {
            int query = Convert.ToInt32(queryIndex);
            Console.WriteLine("ran");
            //queryIndex = Convert.ToInt32(queryIndex);
            return studentList[query];
        }



    }

    public class Student
    {
        public string studentName { get; set; }
        public int studentId { get; set; }
        public int admissionYear { get; set; }

        public Student(string name, int id, int studentAdmissionYear)
        {
            studentName = name;
            studentId = id;
            admissionYear = studentAdmissionYear;
        }
    }



}
