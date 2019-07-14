using System;
using System.Collections.Generic;

namespace urban_planner
{
    class City
    {
        private string _mayor;

        public string CityName { get; set; }

        public int YearEstablished { get; set; }

        public List<Building> BuildingList { get; set; }

        // Constructor
        public City(string cityname, int YearEst, string MayorName)
        {
            CityName = cityname;
            YearEstablished = YearEst;
            _mayor = MayorName;
            BuildingList = new List<Building>();
        }

        // Method
        public void AddBuildingToCity(Building buildingName)
        {
            BuildingList.Add(buildingName);
        }

        public void LogCityInfo()
        {
            Console.WriteLine(CityName);
            Console.WriteLine("-------------");
            Console.WriteLine($"{_mayor} is mayor of {CityName}");
            Console.WriteLine($"It was established in {YearEstablished}");
            Console.WriteLine("Some of the buildings included:");
            Console.WriteLine("");

            foreach (Building building in BuildingList)
            {
                building.LogInfo();
            }

        }
    }
}