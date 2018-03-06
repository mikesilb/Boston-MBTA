using System;
using System.Collections.Generic;
using Xunit;

namespace Train.Library.Tests
{
    public class trainTests
    {
        [Fact]
        public void IsDefinedProperly()
        {
            // Arrange
            Dictionary<string, Dictionary<string, string>> terminiMasterList = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> F_train_termini = new Dictionary<string, string>()
            {
                {"North", "The Bronx"},
                {"South", "Coney Island"}
            };
            List<string> F_train_stations = new List<string>()
            {
                "Coney Island", "Kings Highway", "Avenue P"
            };
            train testTrain1 = new train("N_train");
            train testTrain2 = new train("F_train", F_train_termini);
            train testTrain3 = new train("F_train", F_train_termini, F_train_stations);
           
            // Assert
            Assert.Equal(testTrain1.GetName(), "N_train");
            Assert.Equal(testTrain2.GetName(), "F_train");
            Assert.Equal(testTrain2.GetTermini()["North"], "The Bronx");
            Assert.Equal(testTrain3.GetStationList()[2], "Avenue P");
            Assert.Equal(testTrain3.GetStationList().Count, 3);
        }
        [Fact]
        public void ParamsCanBeModifiedAsNeeded()
        {
            // Arrange
            Dictionary<string, Dictionary<string, string>> terminiMasterList = new Dictionary<string, Dictionary<string, string>>();
            Dictionary<string, string> F_train_termini = new Dictionary<string, string>()
            {
                {"North", "The Bronx"},
                {"South", "Coney Island"}
            };
            List<string> F_train_stations = new List<string>()
            {
                "Coney Island", "Kings Highway", "Avenue P"
            };
            train testTrain1 = new train("N_train");
            train testTrain2 = new train("F_train", F_train_termini);
            train testTrain3 = new train("F_train", F_train_termini, F_train_stations);

            //Act
            testTrain1.SetName("N_train_adapted");
            Dictionary<string, string> F_train_termini_adapted = new Dictionary<string, string>()
            {
                {"North", "Flushing Meadows"},
                {"South", "Coney Island"}
            };
            testTrain2.SetTermini(F_train_termini_adapted);
            List<string> F_train_stations_adapted = new List<string>()
            {
                "Coney Island", "Avenue U", "Kings Highway", "Avenue P"
            };
            testTrain3.SetStationList(F_train_stations_adapted);

            // Assert
            Assert.NotEqual(testTrain1.GetName(), "N_train");
            Assert.Equal(testTrain1.GetName(), "N_train_adapted");
            Assert.NotEqual(testTrain2.GetTermini()["North"], "The Bronx");
            Assert.Equal(testTrain2.GetTermini()["North"], "Flushing Meadows");
            Assert.Equal(testTrain3.GetStationList()[2], "Kings Highway");
            Assert.Equal(testTrain3.GetStationList().Count, 4);          
        }
    }
}
