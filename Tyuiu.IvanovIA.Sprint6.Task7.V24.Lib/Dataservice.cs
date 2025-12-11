using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.IvanovIA.Sprint6.Task7.V24.Lib
{
    public class DataService : ISprint6Task7V24
    {
        public int[,] GetMatrix(string path)
        {
            // Читаем все строки файла
            string[] lines = File.ReadAllLines(path);

            // Проверяем, что файл не пустой
            if (lines.Length == 0)
            {
                return new int[0, 0];
            }

            // Определяем размеры матрицы
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            // Создаем матрицу
            int[,] matrix = new int[rows, columns];

            // Заполняем матрицу данными
            for (int i = 0; i < rows; i++)
            {
                string[] rowValues = lines[i].Split(';');

                // Проверяем, что количество элементов в строке соответствует ожидаемому
                if (rowValues.Length != columns)
                {
                    throw new InvalidDataException($"Строка {i + 1} содержит {rowValues.Length} элементов вместо {columns}");
                }

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = Convert.ToInt32(rowValues[j].Trim());
                }
            }

            // Изменяем четные элементы во второй строке (индекс 1) на 1
            if (rows > 1) // Проверяем, что есть хотя бы 2 строки
            {
                for (int j = 0; j < columns; j++)
                {
                    // Проверяем, четное ли число
                    if (matrix[1, j] % 2 == 0)
                    {
                        matrix[1, j] = 1;
                    }
                }
            }

            return matrix;
        }
    }
}
