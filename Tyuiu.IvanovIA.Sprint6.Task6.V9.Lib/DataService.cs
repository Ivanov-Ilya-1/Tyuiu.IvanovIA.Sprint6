using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.IvanovIA.Sprint6.Task6.V9.Lib
{
    public class DataService : ISprint6Task6V9
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Пропускаем пустые строки
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    // Разбиваем строку на слова
                    string[] words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    // Если в строке есть слова, берем последнее
                    if (words.Length > 0)
                    {
                        string lastWord = words[words.Length - 1];
                        resStr += lastWord + " ";
                    }
                }
            }
            return resStr.Trim();
        }
    }
}
