using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.IvanovIA.Sprint6.Task5.V3.Lib
{
    public class DataService : ISprint6Task5V3
    {
        public int len;

        public double[] LoadFromDataFile(string path)
        {
            int len = 0;
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index++] = Convert.ToDouble(line);
                }
            }

            numsArray = numsArray.Where(val => val % 10 != 0).ToArray();

            return numsArray;
        }
    }
}
