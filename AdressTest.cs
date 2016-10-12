using System;
using System.Linq;
using Xunit;

namespace Prov2016
{
    public class AdressTest
    {
        [Fact]
        public void ParseAndSum_EmptyString_ReturnsZero()
        {
            //Arrange
            string testadress1 = "Kalle Anka\nParadisäppelvägen 111\n12345 Ankeborg";

            //Act
            Adress adress = new Adress(testadress1);
            
            //Assert
            Assert.Equal("Kalle Anka", adress.Namn);
            Assert.Equal("12345 Ankeborg", adress.Postadress);
        }
    }
}
