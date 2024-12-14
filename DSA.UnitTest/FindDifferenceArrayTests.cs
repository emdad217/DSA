using DSA.ArrayProblems;
using FluentAssertions;

namespace DSA.UnitTest;

public class FindDifferenceArrayTests
{
    [Fact]
    public void GetFindDifferenceArray_ShouldReturnEmptyArray_WhenInputIsEmpty()
    {
        // Arrange
        var service = new FindDifferenceArray(); 
        var nums = Array.Empty<int>();

        // Act
        var result = service.GetFindDifferenceArray(nums);

        // Assert
        result.Should().BeEmpty();
    }

    [Fact]
    public void GetFindDifferenceArray_ShouldReturnZero_WhenInputHasSingleElement()
    {
        // Arrange
        var service = new FindDifferenceArray();
        var nums = new[] { 5 };

        // Act
        var result = service.GetFindDifferenceArray(nums);

        // Assert
        result.Should().Equal(0);
    }

    [Fact]
    public void GetFindDifferenceArray_ShouldHandleMultipleElementsCorrectly()
    {
        // Arrange
        var service = new FindDifferenceArray();
        var nums = new[] { 1, 2, 3, 4 };

        // Act
        var result = service.GetFindDifferenceArray(nums);

        // Assert
        result.Should().Equal(9, 6, 1, 6);
        // Explanation:
        // For index 0: leftSum = 0, rightSum = 2 + 3 + 4 = 9, difference = |0 - 9| = 9
        // For index 1: leftSum = 1, rightSum = 3 + 4 = 7, difference = |1 - 7| = 6
        // For index 2: leftSum = 1 + 2 = 3, rightSum = 4, difference = |3 - 4| = 1
        // For index 3: leftSum = 1 + 2 + 3 = 6, rightSum = 0, difference = |6 - 0| = 6
    }

    [Fact]
    public void GetFindDifferenceArray_ShouldHandleNegativeNumbersCorrectly()
    {
        // Arrange
        var service = new FindDifferenceArray();
        var nums = new[] { -1, -2, -3, -4 };

        // Act
        var result = service.GetFindDifferenceArray(nums);

        // Assert
        result.Should().Equal(9, 6, 1, 6);
        // Explanation is similar to the positive numbers but with negative values.
    }

    [Fact]
    public void GetFindDifferenceArray_ShouldHandleZerosCorrectly()
    {
        // Arrange
        var service = new FindDifferenceArray();
        var nums = new[] { 0, 0, 0, 0 };

        // Act
        var result = service.GetFindDifferenceArray(nums);

        // Assert
        result.Should().Equal(0, 0, 0, 0);
    }
}