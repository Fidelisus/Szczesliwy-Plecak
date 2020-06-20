﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SzczesliwyPlecak.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public int DurationInDays { get; set; }
        public int FemaleParticipants { get; set; }
        public int MaleParticipants { get; set; }
        public int TotalTimeHiking { get; set; }
        public float CaloriesNeeded { get; set; }
        public float FatNeeded { get; set; }
        public float CarbohydratesNeeded { get; set; }
        public float FibreNeeded { get; set; }
        public float ProteinsNeeded { get; set; }
        public float SaltNeeded { get; set; }
        public ICollection<TripProduct> TripProducts { get; set; }
    }
}
