using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BmiWebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            BmiCalc calculator = new BmiCalc();

            calculator.SetName(txtFname.Text,txtLname.Text);
            calculator.SetGender(txtGender.Text);
            calculator.SetHeight(Int32.Parse(txtHeight.Text));
            calculator.SetWeight(Int32.Parse(txtWeight.Text));
            calculator.SetMonth(Int32.Parse(txtMonth.Text));
            calculator.SetDay(Int32.Parse(txtDay.Text));
            calculator.SetYear(Int32.Parse(txtYear.Text));

            string name = calculator.GetName();
            string age = calculator.GetAge(Int32.Parse(txtMonth.Text), Int32.Parse(txtDay.Text), Int32.Parse(txtYear.Text));
            string gender = calculator.GetGender();
            double bmi = calculator.CalculateBMI();
            string heartRate = calculator.HeartRate();
            string category = calculator.BMIWeightCategory();

            Session["Name"] = name;
            Session["Gender"] = gender;
            Session["Age"] = age;
            Session["BMI"] = bmi;
            Session["Cat"] = category;
            Session["HR"] = heartRate;

            Response.Redirect("~/Default2.aspx", true);
        }
    }
}