// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключитмассивами.
// Примеры: 
// [ "hello", "2", "world", ":-)" ];
// [ "1234", "1567", "-2", "computer science" ]
// [ "Russia", "Denmark", "Kazan"]
using static System.Console;
Clear();
string[] stringA = new string[] { "hello", "2", "world", ":-)" };
string[] stringB = new string[] { "1234", "1567", "-2", "computer science" };
string[] stringC = new string[] { "Russia", "Denmark", "Kazan"};

PrintStrArr(stringA);
Write(" -> ");
PrintStrArr(Find3Symbol(stringA));
WriteLine();

PrintStrArr(stringB);
Write(" -> ");
PrintStrArr(Find3Symbol(stringB));
WriteLine();

PrintStrArr(stringC);
Write(" -> ");
PrintStrArr(Find3Symbol(stringC));
WriteLine();

string[] Find3Symbol(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            size++;
        }
    }
    string[] result = new string[size];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

void PrintStrArr(string[] str)
{
    Write("[");
    for (int i = 0; i < str.Length; i++)
    {
        Write($"\"{str[i]}\"");
        if (i != str.Length - 1)
        {
            Write(",");
        }
    }
    Write("]");
}