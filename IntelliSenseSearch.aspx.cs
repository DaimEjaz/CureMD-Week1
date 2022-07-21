using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntelliSenseSearch
{
    public partial class IntelliSenseSearch : System.Web.UI.Page
    {
        public static string[] carList = { "Chevrolet", "Honda", "Nissan", "Ford", "Fiat", "Jeep", "Volkswagen", "Volvo", "Jaguar", "Audi", "Toyota", "Land Rover", "Lexus", "Porsche", "Bugatti", "Bentley", "Rolls Royce", "BMW", "Tesla", "Mercedes- Benz" };
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [WebMethod]
        public static string[] IntelliSense(string query)
        {
            List<string> requiredCars = new List<string>();
            int queryLength = query.Length;
         
         
            for(int i = 0; i < carList.Length; i++)
            {
                string car = carList[i];
                if(car.Length >= queryLength)
                {
                    if (car.Substring(0, queryLength).ToLower() == query.ToLower() && queryLength != 0)
                    {
                        requiredCars.Add(carList[i]);
                    }
                }
            }

            //list.DataSource = requiredCars;
            //list.DataBind();

            string[] reqCars = requiredCars.ToArray();
            return reqCars;

            
        }
    }
}