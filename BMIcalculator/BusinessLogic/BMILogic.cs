using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BMIcalculator.Models;

namespace BMIcalculator.BusinessLogic
{
    public class BMILogic
    {
        public BMI CountBMI(BMI modelBmi)
        {
            modelBmi.Score = modelBmi.Weight*10000 /modelBmi.Height / modelBmi.Height;
            return modelBmi;
        }

        public string CheckBMI(BMI modelBmi)
        {
            return modelBmi.Score < 18.5
                ? "~/Views/BMI/BMItoLow.cshtml"
                : (modelBmi.Score < 25 ? "~/Views/BMI/BMIok.cshtml" : "~/Views/BMI/BMItoHigh.cshtml");
        }
    }
}
