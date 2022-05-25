using System;
using Xunit;
using Biblioteket;

namespace UnitTest_Biblioteket
{
    public class UnitTest1
    {
        [Fact]
        public void LaanerClassTest()
        {
            //Arrange
            string actualNavn = "Emma Niclasen";
            int actualLaanerNr = 1;

            //Act
            Laaner expected = new Laaner(1, "Emma", "Niclasen");

            //Assert
            Assert.Equal(expected.FuldeNavn, actualNavn);
            Assert.Equal(expected.LaanerNummer, actualLaanerNr);
        }
    }
}
