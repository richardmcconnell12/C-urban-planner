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

        // public void setVolume()
        // {
        //     _Volume = Width * Depth * Stories * 3;
        // }

        public void Purchase(string owner)
        {
            _owner = owner;
            Console.WriteLine($"{_address} ------ Designed by: {_designer} Constructed: {_dateConstructed} Owned by: {_owner} {_Volume} of space");
        }
    }
}



/*
_designer of type string. It will hold your name.
_dateConstructed of type DateTime. This will hold the exact time the building was created.
_address of type string.
_owner of type string. This will store the same of the person who owns the building.
*/

/*
Stories typed as an integer.
Width typed as a double.
Depth typed as a double.
Volume should be read-only and should return width * depth * (3 * # of stories). Each story is 3 meters high.
 */
