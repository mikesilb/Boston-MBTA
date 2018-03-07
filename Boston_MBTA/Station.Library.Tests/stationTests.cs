using System;
using System.Collections.Generic;
using Station.Library;
using Train.Library;
using Xunit;

namespace Station.Library.Tests
{
    public class stationTests
    {
        [Fact]
        public void IsDefinedProperly()
        {
            // Arrange
            train F_train = new train("F Train");
            train N_train = new train("N Train");
            train R_train = new train("R Train");

            List<train> KingsHighwayTrains = new List<train> { F_train };
            List<train> ThirtyFourthStreetTrains = new List<train> { F_train, N_train, R_train };

            station KingsHighway = new station("Kings Highway", KingsHighwayTrains);
            station ThirtyFourthStreet = new station("34th Street", ThirtyFourthStreetTrains);

            // Assert
            Assert.Equal(KingsHighway.GetName(), "Kings Highway");
            Assert.Equal(ThirtyFourthStreet.GetName(), "34th Street");
            Assert.Equal(KingsHighway.GetAssociatedTrains()[0], F_train);
            Assert.Equal(KingsHighway.GetAssociatedTrains().Count, 1);
            Assert.Equal(ThirtyFourthStreet.GetAssociatedTrains()[0], F_train);
            Assert.Equal(ThirtyFourthStreet.GetAssociatedTrains()[1], N_train);
            Assert.Equal(ThirtyFourthStreet.GetAssociatedTrains()[2], R_train);
            Assert.Equal(ThirtyFourthStreet.GetAssociatedTrains().Count, 3);
        }
    }
}
