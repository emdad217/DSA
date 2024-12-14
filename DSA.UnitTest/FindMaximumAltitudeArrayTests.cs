using DSA.ArrayProblems;
using FluentAssertions;

namespace DSA.UnitTest
{
    public class FindMaximumAltitudeArrayTests
    {
        [Fact]
        public void GetLargestAltitude_ShouldFindTheCorrectHighestAltitude()
        {
            //Arrange
            var sut = new FindMaximumAltitudeArray();
            int[] nums = [4, -3, 2, -1, -2];
            //int[] nums = [2, 3];

            //[4, -3, 2, -1, -2]
            //[4, 1, 3, 2, 0]


            //Act
            var result = sut.GetLargestAltitude(nums);

            //Assert
            result.Should().Be(4);
            //result.Should().Equal(2, 5);

        }
    }
}
