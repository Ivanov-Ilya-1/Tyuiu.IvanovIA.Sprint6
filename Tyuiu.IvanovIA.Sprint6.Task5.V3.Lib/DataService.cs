using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.IvanovIA.Sprint6.Task5.V3.Lib
{
    public class DataService : ISprint6Task5V3
    {
        public int len;

        public double[] LoadFromDataFile(string path)
        {
            List<double> result = new List<double>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();

                    // Проверяем, содержит ли строка запятую
                    if (line.Contains(','))
                    {
                        // Заменяем запятую на точку для парсинга
                        string normalized = line.Replace(',', '.');

                        if (double.TryParse(normalized, NumberStyles.Any,
                            CultureInfo.InvariantCulture, out double number))
                        {
                            result.Add(number);
                        }
                    }
                }
            }

            return result.ToArray();
        }
    }
}
