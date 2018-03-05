using System;
using System.Collections.Generic;


namespace Train.Library
{
    public class train
    {
        private string _name;
        private Dictionary<string, string> _termini;
        private List<string> _stationList;


        public train(string name, Dictionary<string, string> termini, List<string> stationList)
        {
            _name = name;
            _termini = termini;
            _stationList = stationList;
        }
        public train(string name, Dictionary<string, string> termini)
        {
            _name = name;
            _termini = termini;
        }
        public train(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public Dictionary<string, string> GetTermini()
        {
            return _termini;
        }
        public void SetTermini(Dictionary<string, string> termini)
        {
            _termini = termini;
        }
        public List<string> GetStationList()
        {
            return _stationList;
        }
        public void SetStationList(List<string> stationList)
        {
            _stationList = stationList;
        }
    }
}
