using System;
using Train.Library;
using Station.Library;
using System.Collections.Generic;

namespace Boston_MBTA
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> terminiMasterList = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> BlueLine_termini = new Dictionary<string, string>()
            {
                {"North", "Bowdoin"},
                {"South", "Wonderland"}
            };
            Dictionary<string, string> GreenLineB_termini = new Dictionary<string, string>()
            {
                {"West", "Boston College"},
                {"East", "Park Street"}
            };
            Dictionary<string, string> GreenLineC_termini = new Dictionary<string, string>()
            {
                {"West", "Cleveland Circle"},
                {"East", "North Station"}
            };
            Dictionary<string, string> GreenLineD_termini = new Dictionary<string, string>()
            {
                {"West", "Riverside"},
                {"East", "Government Center"}
            };
            Dictionary<string, string> GreenLineE_termini = new Dictionary<string, string>()
            {
                {"West", "Heath Street"},
                {"East", "Lechmere"}
            };
            Dictionary<string, string> OrangeLine_termini = new Dictionary<string, string>()
            {
                {"North", "Oak Grove"},
                {"South", "Forest Hills"}
            };
            Dictionary<string, string> RedLine1_termini = new Dictionary<string, string>()
            {
                {"West", "Alewife"},
                {"East", "Ashmont"}
            };
            Dictionary<string, string> RedLine2_termini = new Dictionary<string, string>()
            {
                {"West", "Alewife"},
                {"North", "Braintree"}
            };
            Dictionary<string, string> SilverLineSL1_termini = new Dictionary<string, string>()
            {
                {"West", "Alewife"},
                {"North", "Braintree"}
            };
            Dictionary<string, string> SilverLineSL2_termini = new Dictionary<string, string>()
            {
                {"West", "Alewife"},
                {"North", "Braintree"}
            };
            Dictionary<string, string> SilverLineSL3_termini = new Dictionary<string, string>()
            {
                {"West", "Alewife"},
                {"North", "Braintree"}
            };
            Dictionary<string, string> SilverLineSL4_termini = new Dictionary<string, string>()
            {
                {"West", "Alewife"},
                {"North", "Braintree"}
            };
            Dictionary<string, string> SilverLineSL5_termini = new Dictionary<string, string>()
            {
                {"West", "Alewife"},
                {"North", "Braintree"}
            };

            terminiMasterList.Add("BlueLine", BlueLine_termini);
            terminiMasterList.Add("GreenLineB", GreenLineB_termini);
            terminiMasterList.Add("GreenLineC", GreenLineC_termini);
            terminiMasterList.Add("GreenLineD", GreenLineD_termini);
            terminiMasterList.Add("GreenLineE", GreenLineE_termini);
            terminiMasterList.Add("OrangeLine", OrangeLine_termini);
            terminiMasterList.Add("RedLine1", RedLine1_termini);
            terminiMasterList.Add("RedLine2", RedLine2_termini);

            train BlueLine = new train("Blue Line", BlueLine_termini);
            train GreenLineB = new train("Green Line B", GreenLineB_termini);
            train GreenLineC = new train("Green Line C", GreenLineC_termini);
            train GreenLineD = new train("Green Line D", GreenLineD_termini);
            train GreenLineE = new train("Green Line E", GreenLineE_termini);
            train OrangeLine = new train("Orange Line", OrangeLine_termini);
            train RedLine1 = new train("Red Line", RedLine1_termini);
            train RedLine2 = new train("Red Line", RedLine2_termini);
            train SilverLineSl1 = new train("SilverLine SL1", SilverLineSL1_termini);
            train SilverLineSl2 = new train("SilverLine SL2", SilverLineSL2_termini);
            train SilverLineSl3 = new train("SilverLine SL3", SilverLineSL3_termini);
            train SilverLineSl4 = new train("SilverLine SL4", SilverLineSL4_termini);
            train SilverLineSl5 = new train("SilverLine SL5", SilverLineSL5_termini);

            List<train> ForestHillsTrains = new List<train> { OrangeLine };
            List<train> GreenStreetTrains = new List<train> { OrangeLine };
            List<train> StonyBrookTrains = new List<train> { OrangeLine };
            List<train> JacksonSquareTrains = new List<train> { OrangeLine };
            List<train> RoxburyCrossingTrains = new List<train> { OrangeLine };
            List<train> RugglesTrains = new List<train> { OrangeLine };
            List<train> MassachusettsAvenueTrains = new List<train> { OrangeLine };
            List<train> BackBayTrains = new List<train> { OrangeLine };
            List<train> TuftsMedicalCenterTrains = new List<train> { OrangeLine, SilverLineSl4, SilverLineSl5 };
            List<train> ChinatownTrains = new List<train> { OrangeLine, SilverLineSl4, SilverLineSl5 };
            List<train> DowntownCrossingTrains = new List<train> { OrangeLine, RedLine1, RedLine2 };
            List<train> StateStreetTrains = new List<train> { OrangeLine, BlueLine };
            List<train> HaymarketTrains = new List<train> { OrangeLine, GreenLineC, GreenLineE };
            List<train> NorthStationTrains = new List<train> { OrangeLine, GreenLineC, GreenLineE };
            List<train> CommunityCollegeTrains = new List<train> { OrangeLine };
            List<train> SullivanSquareTrains = new List<train> { OrangeLine };
            List<train> AssemblyTrains = new List<train> { OrangeLine };
            List<train> WellingtonTrains = new List<train> { OrangeLine };
            List<train> MaldenCenterTrains = new List<train> { OrangeLine };
            List<train> OakGroveTrains = new List<train> { OrangeLine };

            station ForestHills = new station("Forest Hills", ForestHillsTrains);
            station GreenStreet = new station("Green Street", GreenStreetTrains);
            station StonyBrook = new station("Stony Brook", StonyBrookTrains);
            station JacksonSquare = new station("Jackson Square", JacksonSquareTrains);
            station RoxburyCrossing = new station("RoxburyCrossing", RoxburyCrossingTrains);
            station Ruggles = new station("Ruggles", RugglesTrains);
            station MassachusettsAvenue = new station("Massachusetts Avenue", MassachusettsAvenueTrains);
            station BackBay = new station("Back Bay", BackBayTrains);
            station TuftsMedicalCenter = new station("Tufts Medical Center", TuftsMedicalCenterTrains);
            station Chinatown = new station("Chinatown", ChinatownTrains);
            station DowntownCrossing = new station("Downtown Crossing", DowntownCrossingTrains);
            station StateStreet = new station("State Street", StateStreetTrains);
            station Haymarket = new station("Haymarket", HaymarketTrains);
            station NorthStation = new station("North Station", NorthStationTrains);
            station CommunityCollege = new station("Community College", CommunityCollegeTrains);
            station SullivanSquare = new station("Sullivan Square", SullivanSquareTrains);
            station Assembly = new station("Assembly", AssemblyTrains);
            station Wellington = new station("Wellington", WellingtonTrains);
            station MaldenCenter = new station("Malden Center", MaldenCenterTrains);
            station OakGrove = new station("Oak Grove", OakGroveTrains);

            //List<string> BlueLine_stations = new List<string>()
            //{
            //    "Wonderland", "Revere Beach", "Beachmont", "Suffolk Downs", "Orient Heights Yard", "Orient Heights",
            //    "Wood Island", "Maverick", "Aquarium", "State", "Government Center", "Bowdoin"
            //};

            List<station> OrangeLine_stations = new List<station>()
            {
                ForestHills, GreenStreet, StonyBrook, JacksonSquare, RoxburyCrossing, Ruggles,
                MassachusettsAvenue, BackBay, TuftsMedicalCenter, Chinatown, DowntownCrossing,
                StateStreet, Haymarket, NorthStation, CommunityCollege, SullivanSquare, Assembly,
                Wellington, MaldenCenter, OakGrove
            };

        }
    }
}
        