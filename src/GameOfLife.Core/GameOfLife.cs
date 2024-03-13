namespace GameOfLife.Core
{
    public class GameOfLife
    {
        public string CalculateNextGeneration(string input)
        {
            var nextGeneration = string.Empty;

            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == '.')
                {
                    nextGeneration += '.';
                    continue;
                }
                
                var nextNeighbourIndex = i + 1;
                var previousNeighbourIndex = i - 1;

                if (i == 0) // We don't have a previous neighbour
                {
                    nextGeneration = ".";
                }
                else if (i == input.Length - 1) // We don't have a next neighbour
                {
                    nextGeneration += ".";
                } 
                else
                {
                    if (input[previousNeighbourIndex] == '*' && input[nextNeighbourIndex] == '*')
                        nextGeneration += "*";
                    else
                        nextGeneration += ".";
                }
            }

            return nextGeneration;
        }
    }
}