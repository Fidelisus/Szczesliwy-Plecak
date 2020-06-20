﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SzczesliwyPlecak.Models;

namespace SzczesliwyPlecak.Services
{
    public class NutritionCalculatorService : INutritionCalculatorService
    {
        private const int DayCaloriesMale = 2500;
        private const int DayCaloriesFemale = 2000;
        public Trip CalculateNutrition(Trip trip)
        {
            trip.CaloriesNeeded = trip.FemaleParticipants * DayCaloriesFemale + trip.MaleParticipants * DayCaloriesMale;
            trip.CarbohydratesNeeded = trip.FemaleParticipants * 10;
            trip.FatNeeded = 10* trip.TotalTimeHiking;
            trip.FibreNeeded = 345;
            trip.ProteinsNeeded = 13;
            trip.SaltNeeded = 99;

            return trip;
        }
    }
}