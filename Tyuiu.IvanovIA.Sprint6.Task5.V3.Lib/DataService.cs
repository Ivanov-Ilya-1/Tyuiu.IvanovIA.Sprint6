using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.IvanovIA.Sprint6.Task5.V3.Lib
{
    public class DataService : ISprint6Task5V3
    {
        public int len;

        public double[] LoadFromDataFile(string path)
        {
            List<double> realNumbers = new List<double>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разбиваем строку на части (поддерживаем разные разделители)
                    string[] parts = line.Split(new[] { ' ', '\t', ',', ';' },
                        StringSplitOptions.RemoveEmptyEntries);

                    foreach (string part in parts)
                    {
                        // Пробуем преобразовать в double (поддерживаем разные форматы)
                        if (double.TryParse(part.Replace(',', '.'),
                            NumberStyles.Any,
                            CultureInfo.InvariantCulture,
                            out double number))
                        {
                            // Проверяем, что это вещественное число (имеет дробную часть)
                            // И не является специальными значениями
                            if (!double.IsInfinity(number) &&
                                !double.IsNaN(number) &&
                                Math.Abs(number % 1) > 0.0000000001) // Эпсилон-проверка
                            {
                                // Округляем до 3 знаков после запятой
                                double rounded = Math.Round(number, 3);
                                realNumbers.Add(rounded);
                            }
                        }
                    }
                }
            }

            return realNumbers.ToArray();
        }
    }
}
