using DSA.ArrayProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace DSA.UnitTest
{
    public class CheckDuplicateArrayTests
    {
        [Fact]
        public void IsDuplicateArray_ShouldHandleMultipleValuesCorrectly_True()
        {
            //Arrange
            var sut = new CheckDuplicateArray();
            int[] nums = [1, 2, 3, 2];
            //int[] nums = [2, 3];


            //Act
            var result = sut.IsDuplicateArray(nums);

            //Assert
            result.Should().BeTrue();

        }

        [Fact]
        public void IsDuplicateArray_ShouldHandleMultipleValuesCorrectly_False()
        {
            //Arrange
            var sut = new CheckDuplicateArray();
            int[] nums = [1, 2, 3, 5];
            //int[] nums = [2, 3];


            //Act
            var result = sut.IsDuplicateArray(nums);

            //Assert
            result.Should().BeFalse();

        }

        [Fact]
        public void IsDuplicateArrayOn_ShouldHandleMultipleValuesCorrectly_False()
        {
            //Arrange
            var sut = new CheckDuplicateArray();
            int[] nums = [1, 2, 3, 4];
            //int[] nums = [2, 3];


            //Act
            var result = sut.IsDuplicateArrayOn(nums);

            //Assert
            result.Should().BeFalse();

        }

        [Fact]
        public void IsDuplicateArrayOn_ShouldHandleMultipleValuesCorrectly_True()
        {
            //Arrange
            var sut = new CheckDuplicateArray();
            int[] nums = [4, 2, 3, 4];
            //int[] nums = [2, 3];


            //Act
            var result = sut.IsDuplicateArrayOn(nums);

            //Assert
            result.Should().BeTrue();

        }
    }
}
