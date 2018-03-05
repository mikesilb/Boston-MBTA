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
        }

    }
}
