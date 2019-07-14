using System;

namespace urban_planner
{
    internal class Building
    {
        private string _designer { get; set; }

        private DateTime _dateConstructed { get; set; }

        private string _address { get; set; }

        private string _owner { get; set; }

        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double _Volume { get; private set; }

        public void setVolume()
        {
            _Volume = Width * Depth * Stories * 3;
        }

        public Building(string address)
        {
            _address = address;
        }

        public void setDesigner(string designer)
        {
            _designer = designer;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string owner)
        {
            _owner = owner;
        }

        public void LogInfo()
        {
            Console.WriteLine($"{_address}");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Designed by: {_designer}");
            Console.WriteLine($"Constructed: {_dateConstructed}");
            Console.WriteLine($"Owned by: {_owner}");
            Console.WriteLine($"{_Volume} of space");
            Console.WriteLine("");
        }
    }
}
