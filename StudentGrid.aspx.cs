using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentGrid
{
    public partial class Studentgrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] nameArr = { "Edgar Barber", "Marquis Reilly", "Isabell Frank", "Issac Hammond", "Aydan Mcclain", "Daphne Burke", "Mia Duarte", "Phoebe Mcclain", "Dayana Massey", "Maxwell Zhang" };
            string[] addressArr = { "753 Schinner Lake", "15504 O'Kon Plaza", "10281 Moore Island", "58552 Fermin Harbors", "786 Schmitt Crescent", "4028 Swaniawski Pass", "12616 Allison Inlet", "19745 Emily Street", "5733 Winifred Motorway", "678 McClure Course"};
            List<Student> studentList = new Student().StudentGenerator(nameArr, addressArr);
        }
    }

    
}