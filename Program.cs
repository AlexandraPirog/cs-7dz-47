/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.*/
int inputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.WriteLine(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("не удалось распознать число");

    }
    return number;
}

Console.Clear();
int m = inputNumber("Введите значение m");
int n = inputNumber("Введите значение n");
double[,] arr = new double[m, n];
FillArrayWithRandomNumbers(arr);

void FillArrayWithRandomNumbers(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToDouble(new Random().Next(-100, 100));
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }   
}
