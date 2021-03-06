using System.Collections.Generic;
using NUnit.Framework.Constraints;

namespace Towers_cSharp
{
    public class ConferenceRoom
    {
        private int _capacity;
        private string _name;
        private List<Guest> _guests;

        public ConferenceRoom(int capacity, string name)
        {
            _capacity = capacity;
            _name = name;
            _guests = new List<Guest>();
            
        }

        public int Capacity
        {
            get => _capacity;
            set => _capacity = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }


        public int guestListSize()
        {
            return _guests.Count;
        }

        public void checkinGuest(Guest guest)
        {
            if (guestListSize() < Capacity)
            {
                _guests.Add(guest);
            }
        }

        public void checkOutGuests()
        {
            if(guestListSize() > 0)
            {
                _guests.Clear();
            }
        }
    }
}