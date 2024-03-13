namespace GameOfLife.Core
{
    public class GameOfLife
    {
        public string CalculateNextGeneration(string input)
        {
            return string.Empty;
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