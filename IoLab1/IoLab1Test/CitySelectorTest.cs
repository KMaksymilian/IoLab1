using IoLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoLab1Test
{
    public class CitySelectorTest
    {
        [Fact]
        public void Find_BothExistAndDiff_ReturnsCorrectDist()
        {
            // Arrange
            var cs = new CitySelector();

            // Act
            var result = cs.Find("A", "B");

            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void Find_NoExist_ThrowNExist()
        {
            // Arrange
            var cs = new CitySelector();

            // Act
            Action act = () => cs.Find("A", "C");

            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void Find_BothExistAndSame_ThrowSameCity()
        {
            // Arrange
            var cs = new CitySelector();


            // Act
            Action act = () => cs.Find("A", "A");

            // Assert
            Assert.Throws<ArgumentException>(act);
        }
    }
}
