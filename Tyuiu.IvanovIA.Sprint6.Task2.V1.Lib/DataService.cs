using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.IvanovIA.Sprint6.Task2.V1.Lib
{
    public class DataService : ISprint6Task2V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[(stopValue - startValue) + 1];
            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                result[index] = Math.Round((Math.Cos(x)) + ((Math.Sin(x)) / (2 - 2*x)) - (4 * x),2);
                if (2 - 2 * x == 0) 
                {
                    result[index] = 0;
                }
                index++;
            }
            return result;
        }
    }
}
