namespace GameOfLife.Core
{
    public class GameOfLife
    {
        public string CalculateNextGeneration(string input)
        {
            var nextGeneration = string.Empty;

            // *........
            for (var i = 0; i < input.Length; i++)
            {
                var nextNeighbourIndex = i + 1;
                var previousNeighbourIndex = i - 1;
                var numberOfLivingNeighbours = 0;

                if (i == 0) // We don't have a previous neighbour
                {
                    if (input[nextNeighbourIndex] == '*')
                        numberOfLivingNeighbours++;
                }
                else if (i == input.Length - 1) // We don't have a next neighbour
                {
                    if (input[previousNeighbourIndex] == '*')
                        numberOfLivingNeighbours++;
                }
                else
                {
                    if (input[nextNeighbourIndex] == '*')
                        numberOfLivingNeighbours++;

                    if (input[previousNeighbourIndex] == '*')
                        numberOfLivingNeighbours++;
                }

                var status = CalculateIfCellDies(input[i] == '*', numberOfLivingNeighbours);
                if (status)
                    nextGeneration += ".";
                else
                    nextGeneration += "*";
            }

            return nextGeneration;
        }

        private bool CalculateIfCellDies(
            bool alive,
            int numberOfLivingNeighbours)
        {
            if (alive && numberOfLivingNeighbours < 2)
            {
                return true;
            }

            return false;
        }

    }
}