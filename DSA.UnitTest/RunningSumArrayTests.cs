using DSA.ArrayProblems;
using FluentAssertions;

namespace DSA.UnitTest
{
    public class RunningSumArrayTests
    {
        [Fact]
        public void GettingRunningSumArray_ShouldHandleMultipleValuesCorrectly()
        {
            //Arrange
            var sut = new RunningSumArray();
            int[] nums = [2, 3, 5, 1, 6];
            //int[] nums = [2, 3];


            //Act
            var result = sut.GettingRunningSumArray(nums);

            //Assert
            result.Should().Equal(2, 5, 10, 11, 17);
            //result.Should().Equal(2, 5);

            // Explaination:
            //For rsult[0] = 0: nums[0]= 2
            //For rsult[1] = 1: 2 + 3 = nums[0] + nums[1] = 5
            //For rsult[2] = 2: 2 + 3 + 5 = 10
            //For rsult[3] = 3: 2 + 3 + 5 + 1 = 11
            //For rsult[4] = 4: 2 + 3 + 5 + 1 + 6 = 17

        }
    }
}
