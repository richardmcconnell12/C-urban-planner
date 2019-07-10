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
            building2.setDesigner("Roger Smitley");
            building2.Construct();
            building2.Purchase("Susan Jones");
        }
    }
}
