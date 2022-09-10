using System.Collections.Generic;
namespace Assignment1.Tests;


public class IteratorsTests
{
    [Fact]
    public void TestName()
    {
    //     // Given
    //    var intList01 = new List<int> {2,3,4};
    //    var intList02 = new List<int> {3,4,5};
    //    var intList03 = new List<int> {4,5,6};
    //    var listOfLists = new List<List<int>>{intList01, intList02, intList03};

    //     // When
    //     var result = Iterators.Flatten(listOfLists);
    
    //     // Then
        
    }
    
    [Fact]
    public void TestName2()
    {
        // Given
        var input = new List<string>{"1920x1080", "1024x768, 800x600, 640x480", "320x200, 320x240, 800x600", "1280x960"};
        var expected = new List<(int, int)>{(1920, 1080), (1024,768), (800,600), (640,480), (320,200), (320,240), (800,600),(1280,960)};
    
        // When

        var result = RegExpr.Resolution(input);
    
        // Then

        expected.Should().BeEquivalentTo(result);

        //Assert.Equal(expected, result);
    }
}