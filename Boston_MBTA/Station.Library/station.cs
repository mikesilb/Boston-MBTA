using System;
using System.Collections.Generic;
using Train.Library;

namespace Station.Library
{
    public class station
    {
        private string _name;
        private List<train> _associatedTrains;
        public station(string name)
        {
            _name = name;
        }
        public station(string name, List<train> associatedTrains)
        {
            _name = name;
            _associatedTrains = associatedTrains;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public List<train> GetAssociatedTrains()
        {
            return _associatedTrains;
        }
        public void SetStationList(List<train> associatedTrains)
        {
            _associatedTrains = associatedTrains;
        }
    }
}
