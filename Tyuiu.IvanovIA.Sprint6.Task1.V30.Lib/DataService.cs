using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.IvanovIA.Sprint6.Task1.V30.Lib
{
    public class DataService : ISprint6Task1V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[(stopValue - startValue) + 1];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double fx = ((2 * x - 3) / (Math.Cos(x) - 2 * x)) + (5 * x) - 6;
                fx = Math.Round(fx, 2);
                res[count] = fx;
                if (Math.Cos(x) - 2 * x == 0)
                {
                    res[count] = 0;
                }
                count++;
            }
            return res;
        }
    }
}
