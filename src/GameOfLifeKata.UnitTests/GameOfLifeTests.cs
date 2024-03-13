using GameOfLifeKata.Core;

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

        var gameOfLife = new GameOfLife();

       // ACT
       var result = gameOfLife.CalculateNextGeneration(matrix);

       // ASSERT
       Assert.Equal(result, @"........
...**...
...**...
........");
    }

    [Fact]
    public void KillNeighbours()
    {
        // ARRANGE
        var matrix = @".*......";

        var gameOfLife = new GameOfLife();

        // ACT
        var result = gameOfLife.CalculateNextGeneration(matrix);

        // ASSERT
        Assert.Equal(result, @"........");
    }
}