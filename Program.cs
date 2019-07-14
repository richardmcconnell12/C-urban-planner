using System;

namespace urban_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building("512 8th Avenue")
            {
                Width = 500.50,
                Depth = 30.50,
                Stories = 3,
            };
            building1.setVolume();
            building1.setDesigner("Ricky McConnell");
            building1.Construct();
            building1.Purchase("Bob Ross");

            Building building2 = new Building("123 Sesame St.")
            {
                Width = 650.25,
                Depth = 250.75,
                Stories = 6
            };
            building2.setVolume();
            building2.setDesigner("Joey Driscoll");
            building2.Construct();
            building2.Purchase("Dance Storm");

            var Smashville = new City("Smashville", 2019, "Richy Rich");

            Smashville.AddBuildingToCity(building1);
            Smashville.AddBuildingToCity(building2);

            Smashville.LogCityInfo();
        }
    }
}
