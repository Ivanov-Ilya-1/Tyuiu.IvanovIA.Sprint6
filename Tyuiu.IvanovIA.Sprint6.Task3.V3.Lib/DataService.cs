using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.IvanovIA.Sprint6.Task3.V3.Lib
{
    public class DataService : ISprint6Task3V3
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);


            int[] thirdColumn = new int[5];

            for (int i = 0; i < rows; i++)
            {
                thirdColumn[i] = matrix[i, 2];
            }
            Array.Sort(thirdColumn);

            for (int i = 0; i < rows; i++)
            {
                matrix[i, 2] = thirdColumn[i];
            }
            return matrix;
        }
    }
}
