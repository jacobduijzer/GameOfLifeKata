namespace GameOfLifeKata.UnitTests;

public class GameOfLifeTests
{
    [Fact]
    public void SendingMatrixShouldResultInAMatrix()
    {
       // ARRANGE
       var matrix = @"........
....*...
...**...
........
";

       // ACT

       // ASSERT
       Assert.Equal(result, @"........
...**...
...**...
........");
    }
    
    
}