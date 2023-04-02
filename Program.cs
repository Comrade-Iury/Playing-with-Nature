
Console.WriteLine("Введите число строк (стратегий).");
string rows_input = Console.ReadLine();
int rows = Convert.ToInt32(rows_input);

Console.WriteLine("Введите число столбцов (переменных).");
string columns_input = Console.ReadLine();
int columns = Convert.ToInt32(columns_input);

Console.WriteLine(columns * rows);

int[,] matrix = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    int n = i + 1;
    Console.WriteLine("Введите все значения " + n + " строки через пробел");
    string  i_row_input = Console.ReadLine();
    string[] i_row_array = i_row_input.Split(' ');


    var i_row = i_row_input.Split(' ').Select(int.Parse).ToArray();

    for (int j = 0; j < i_row.Length; j++)
    {
        matrix[i, j] = i_row[j];
    }
}
/*
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.WriteLine(matrix[i, j]);
    }
}
*/
int[] maxrow = new int[rows];

for (int i = 0; i < rows; i++)
{
    int max = -1000;
    for (int j = 0; j < columns; j++)
    {
        if (matrix[i, j] > max)
        {
            max = matrix[i, j];
        }
    }
    maxrow[i] = max;
}
foreach(int item in maxrow)
{
    Console.WriteLine(item);
}