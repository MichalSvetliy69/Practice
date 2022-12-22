﻿using Microsoft.AspNetCore.Mvc;
using WebAppMVC1.interfaces;
using WebAppMVC1.ViewModels;

namespace WebAppMVC1.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCarsCategory;

        public CarsController(IAllCars iallCars, ICarsCategory iallCarsCategory)
        {
            _allCars = iallCars;
            _allCarsCategory = iallCarsCategory;
        }

        public ViewResult List()
        {
            
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Автомобили";
            var cars = _allCars.Cars;
            return View(obj);
        }
    }
}
