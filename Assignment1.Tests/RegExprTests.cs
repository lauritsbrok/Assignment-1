namespace Assignment1.Tests;

public class RegExprTests
{
    [Fact]
    public void ShouldReturnListOf8intints()
    {
        // Given
        var input = new List<string>{"1920x1080", "1024x768, 800x600, 640x480", "320x200, 320x240, 800x600", "1280x960"};
        var expected = new List<(int, int)>{(1920, 1080), (1024,768), (800,600), (640,480), (320,200), (320,240), (800,600),(1280,960)};
    
        // When

        var result = RegExpr.Resolution(input);
    
        // Then

       // expected.Should().BeEquivalentTo(result);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void ShouldReturnArrayOf8intints()
    {
        // Given
        var input = new string[]{"1920x1080", "1024x768, 800x600, 640x480", "320x200, 320x240, 800x600", "1280x960"};
        var expected = new List<(int, int)>{(1920, 1080), (1024,768), (800,600), (640,480), (320,200), (320,240), (800,600),(1280,960)};
    
        // When

        var result = RegExpr.Resolution(input);
    
        // Then

        //expected.Should().BeEquivalentTo(result);

        Assert.Equal(expected, result);
    }
}