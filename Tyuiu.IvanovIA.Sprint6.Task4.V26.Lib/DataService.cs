using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.IvanovIA.Sprint6.Task4.V26.Lib
{
    public class DataService : ISprint6Task4V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] arrayResult = new double[(stopValue - startValue) + 1];
            int count = 0;
            for (double x = startValue; x <= stopValue; x++)
            {
                arrayResult[count] = Math.Round(5 - (3 * x) + ((1 + Math.Sin(x)) / (2 * x - 0.5)), 2);
                count++;
            }
            return arrayResult;
        }
    }
}
