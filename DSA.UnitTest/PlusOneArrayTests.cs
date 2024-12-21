using System.Numerics;
using DSA.ArrayProblems;
using FluentAssertions;

namespace DSA.UnitTest
{
    public class PlusOneArrayTests
    {
        [Fact]
        public void GetPlusOne_ShouldHandleSingleDigitCorrectly()
        {
            //Arrange
            var sut = new PlusOneArray();
            int[] nums = [9];


            //Act
            var result = sut.GetPlusOne(nums);

            //Assert
            result.Should().Equal(1, 0);
        }

        [Fact]
        public void GetPlusOne_ShouldHandleMultipleDigitsCorrectly()
        {
            //Arrange
            var sut = new PlusOneArray();
            int[] nums = [1, 2, 3];


            //Act
            var result = sut.GetPlusOne(nums);

            //Assert
            result.Should().Equal(1, 2, 4);
        }

        [Fact]
        public void GetPlusOne_ShouldHandleMultipleDigitsCorrectly1()
        {
            //Arrange
            var sut = new PlusOneArray();
            int[] nums = [9, 9];


            //Act
            var result = sut.GetPlusOne(nums);

            //Assert
            result.Should().Equal(1, 0, 0);
        }

        [Fact]
        public void GetPlusOne_ShouldHandleMultipleDigitsCorrectly2()
        {
            //Arrange
            var sut = new PlusOneArray();
            int[] nums = [7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6];


            //Act
            var result = sut.GetPlusOne(nums);

            //Assert
            result.Should().Equal(7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 7);
        }

        [Fact]
        public void GettheSameArray_ShouldReturnTheSameArray()
        {
            //Arrange
            var sut = new PlusOneArray();
            int[] nums = [7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6];


            //Act
            var result = sut.GettheSameArray(nums);

            BigInteger expectedResult = BigInteger.Parse("728509129536673284379577474947011174007");
            //Assert
            result.Should().Be(expectedResult);
        }
    
    }
}
