using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using BMIcalculator.BusinessLogic;

namespace BMIcalculator.Models
{
    public class BMI
    {
        public int Height { get; set; }
        public float Weight { get; set; }
        public float YourBMI { get; set; }
        public CreateEnumerator Enumerator { get; set; }
    }
}