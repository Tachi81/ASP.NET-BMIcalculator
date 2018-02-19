using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BMIcalculator.Models;
using BMIcalculator.BusinessLogic;
using System.Web.Mvc;

namespace BMIcalculator.BusinessLogic
{
    public class BMILogic
    {
        public string ServeModel(BMI model)
        {
            CountBMI(model);
          return  CheckBMI(model);
        }


        private BMI CountBMI(BMI modelBmi)
        {
            modelBmi.YourBMI = modelBmi.Enumerator == CreateEnumerator.KilogramsAndCentimeters
                ? modelBmi.Weight * 10000 / modelBmi.Height / modelBmi.Height
                : modelBmi.Weight * 703 / modelBmi.Height / modelBmi.Height;
           return modelBmi;
        }

        private string CheckBMI(BMI modelBmi)
        {
            if (CheckHour())
            {
                return modelBmi.YourBMI < 18.5
                    ? "~/Views/BMI/BMItoLow.cshtml"
                    : (modelBmi.YourBMI < 25 ? "~/Views/BMI/BMIok.cshtml" : "~/Views/BMI/BMItoHigh.cshtml");
            }

            return "~/Views/BMI/BMItoLate.cshtml";
        }

        private bool CheckHour()
        {
            return DateTime.Now.Hour < 22 && DateTime.Now.Hour >= 6;
        }
    }
}
