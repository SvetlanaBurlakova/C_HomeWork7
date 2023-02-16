/* Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] InitMatrix()
{
    int[,] array = new int[3,4];
    Random rnd = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,10);
        }
    }

    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }

        Console.WriteLine();
    }
}
string GetNumber(string message)
{
    string numberString=string.Empty;
    while(true)
    {
        Console.WriteLine(message);
        numberString=Console.ReadLine();
        if(numberString.Length==2 && char.IsDigit(numberString[0])
        && char.IsDigit(numberString[1]))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не индексы двумерного массива. Повторите ввод");
        }
    }
    return numberString;
}
void GetValueFromIndex(int [,] matrix, string indexes)
{
    int i = Convert.ToInt32(indexes[0]-'0');
    int j = Convert.ToInt32(indexes[1]-'0');
    if (i<matrix.GetLength(0) && j<matrix.GetLength(1)) 
        Console.WriteLine($"{matrix[i,j]} - значение массива с индексами i = {i}, j ={j}");
    else Console.WriteLine("Такого числа в массиве нет");

}
int[,] matrix = InitMatrix();

PrintMatrix(matrix);

string indexes = GetNumber("Введите индексы элемента двумерного массива, двухзначное число");

GetValueFromIndex(matrix,indexes);



