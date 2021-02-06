using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BmiWebApplication
{
    public class BmiCalc
    {
        // instance variables
        private string firstName;
        private string lastName;
        private string gender;
        private static int month;
        private static int day;
        private static int year;
        private double height = 0;
        private double weight = 0;
        private int age;

        //getters
        public string GetName()
        {
            string name;
            return name = firstName + " " + lastName;
        }

        public string GetGender()
        {
            return gender;
        }


        public string GetAge(int mm, int dd, int yy)
        {
            //algorithm from https://www.c-sharpcorner.com/forums/c-sharp-program-to-calculate-age-years-months-days
            DateTime date = DateTime.Now;
            System.DateTime BirthDate = new System.DateTime(yy, mm, dd, 0, 0, 0);
            System.TimeSpan diffResult = date.Subtract(BirthDate);
            string TotalDays = diffResult.Days.ToString();
            string Months = ((diffResult.Days) % 365).ToString();
            string RemainingMonths = (Convert.ToInt32(Months) / 31).ToString();
            string RemainginYears = ((diffResult.Days) / 365).ToString();
            string RemainingDays = (Convert.ToInt32(Months) % 31).ToString();
            age = Int32.Parse(RemainginYears);
            return "Age: " + RemainginYears + " years, " + RemainingMonths + " months, and " + RemainingDays + " days old";
        }
        public double GetHeight()
        {
            return height;
        }

        public double GetWeight()
        {
            return weight;
        }

        //setters
        public void SetName(string fname, string lname)
        {
            if (!string.IsNullOrEmpty(fname) || !string.IsNullOrEmpty(lname))
            {
                firstName = fname;
                lastName = lname;
            }
        }

        public void SetMonth(int m)
        {
            month = m;
        }

        public void SetDay(int d)
        {
            day = d;
        }

        public void SetYear(int y)
        {
            year = y;
        }
        public void SetAge()
        {
            GetAge(month, day, year);
        }

        public void SetGender(string setGender)
        {
            gender = setGender;
        }

        public void SetHeight(double h)
        {
            if (h > 0)
            {
                height = h;
            }
        }

        public void SetWeight(double w)
        {
            if (w > 0)
            {
                weight = w;
            }
        }

        public string BMIWeightCategory()
        {
            double bmi = CalculateBMI();

            // if bmi = certain number, display results for that number
            if (bmi > 40)
            {
                return "You are overweight (Obesity class III: Very Severely Obese)";
            }
            else if (35.0 <= bmi)
            {
                return "You are overweight (Obesity class II: Severely Obese)";
            }
            else if (30.0 <= bmi)
            {
                return "You are overweight (Obesity class I: Moderately Obese)";
            }
            else if (25.0 <= bmi)
            {
                return "You are overweight (Pre-obesity)";
            }
            else if (18.5 <= bmi)
            {
                return "You are at a normal weight";
            }
            else if (16 <= bmi)
            {
                return "You are underweight";
            }
            else if (15 <= bmi)
            {
                return "You are severely underweight";
            }
            else
            {
                return "You are very severely underweight";
            }
        }

        public string HeartRate()
        {

            if (age <= 20)
            {
                return "Your target heart rate is between 100 and 170 bpm.";
            }
            else if (age > 20 && age <= 30)
            {
                return "Your target heart rate is between 95 and 162 bpm.";
            }
            else if (age > 30 && age <= 35)
            {
                return "Your target heart rate is between 93 and 157 bpm.";
            }
            else if (age > 35 && age <= 40)
            {
                return "Your target heart rate is between 90 and 153 bpm.";
            }
            else if (age > 40 && age < 46)
            {
                return "Your target heart rate is between 88 and 149 bpm.";
            }
            else if (age > 45 && age <= 50)
            {
                return "Your target heart rate is between 85 and 145 bpm.";
            }
            else if (age > 50 && age < 56)
            {
                return "Your target heart rate is between 83 and 140 bpm.";
            }
            else if (age > 55 && age <= 60)
            {
                return "Your target heart rate is between 80 and 136 bpm.";
            }
            else if (age > 60 && age <= 65)
            {
                return "Your target heart rate is between 78 and 132 bpm.";
            }
            else
            {
                return "Your target heart rate is between 75 and 128 bpm.";
            }
        }

        public double CalculateBMI()
        {
            double bmi;

            bmi = 703.0 * weight / (height * height);

            return bmi;
        }

        public double CalculateWeight(double bmi)
        {
            double weight;

            weight = bmi * (this.GetHeight() * this.GetHeight()) / 703.0;
            return weight;
        }
    }
}