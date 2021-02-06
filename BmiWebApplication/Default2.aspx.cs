using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BmiWebApplication
{
    public partial class Default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtName.Text = "" + Session["Name"];
            txtGender.Text = "" + Session["Gender"];
            txtAge.Text = "" + Session["Age"];
            txtBMI.Text = "" + Session["BMI"];
            txtBMICategory.Text = "" + Session["Cat"];
            txtHeartRate.Text = "" + Session["HR"];
        }

        protected void btnBMI_Click(object sender, EventArgs e)
        {
            txtCharts.Visible = true;
            txtCharts.Text = "BMI from 0 - 15: Very Severely Underweight\n\n";
            txtCharts.Text += "BMI from 15 - 16: Severely Underweight\n\n";
            txtCharts.Text += "BMI from 16 - 18.5: Underweight\n\n";
            txtCharts.Text += "BMI from 18.5 - 25: Normal (Healthy weight)\n\n";
            txtCharts.Text += "BMI from 25 - 30: Overweight\n\n";
            txtCharts.Text += "BMI from 30 - 35: Obese Class I (Moderately Obese)\n\n";
            txtCharts.Text += "BMI from 35 - 40: Obese Class II (Severely Obese)\n\n";
            txtCharts.Text += "BMI from 40 to higher: Obese Class III (Very Severely Obese)\n\n";
        }

        protected void btnHeartRate_Click(object sender, EventArgs e)
        {
            txtCharts.Visible = true;
            txtCharts.Text = "Target heart rate for people ages 20 and younger:\nBetween 100 and 170 bpm\n\n";
            txtCharts.Text += "Target heart rate for people between 20 and 30:\nBetween 95 and 162 bpm\n\n";
            txtCharts.Text += "Target heart rate for people between 30 and 35:\nBetween 93 and 157 bpm\n\n";
            txtCharts.Text += "Target heart rate for people between 35 and 40:\nBetween 90 and 153 bpm\n\n";
            txtCharts.Text += "Target heart rate for people between 40 and 45:\nBetween 88 and 149 bpm\n\n";
            txtCharts.Text += "Target heart rate for people between 45 and 50:\nBetween 85 and 145 bpm\n\n";
            txtCharts.Text += "Target heart rate for people between 50 and 55:\nBetween 83 and 140 bpm\n\n";
            txtCharts.Text += "Target heart rate for people between 55 and 60:\nBetween 80 and 136 bpm\n\n";
            txtCharts.Text += "Target heart rate for people between 60 and 65:\nBetween 78 and 132 bpm\n\n";
            txtCharts.Text += "Target heart rate for people 65 or older:\nBetween 75 and 128 bpm\n\n";
        }
    }
}