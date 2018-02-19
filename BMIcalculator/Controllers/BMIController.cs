using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BMIcalculator.BusinessLogic;
using BMIcalculator.Models;

namespace BMIcalculator.Controllers
{
    public class BMIController : Controller
    {
        private readonly BMILogic _bmiLogic;

        public BMIController()
        {
            _bmiLogic = new BMILogic();

        }

        // GET: BMI
        public ActionResult Index()
        {
            return View();
        }

        // GET: BMI/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BMI/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: BMI/Create
        [HttpPost]
        public ActionResult Create(BMI model)
        {
            var validatorKg = new BmiValidatorKg();
            var validatorPounds = new BmiValidatorPounds();
            var result = (model.Enumerator == CreateEnumerator.KilogramsAndCentimeters) ? validatorKg.Validate(model) : validatorPounds.Validate(model);

            if (result.IsValid)
            {
                return View(_bmiLogic.ServeModel(model), model);
            }
            ModelState.Clear();
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.ErrorMessage);
            }
            return View(model);

        }

        // GET: BMI/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BMI/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BMI/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BMI/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
