//  Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//  длина которых меньше либо равна 3 символа.

Console.WriteLine("Введите количество элементов массива:  ");
int element = Convert.ToInt32(Console.ReadLine());
string[] Array = new string[element];
int index = 0;
for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i} - ");
    string word = Convert.ToString(Console.ReadLine());
    Array[index] = word;
    index++;
}

void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write(Array[i] + " ");
    }
    System.Console.WriteLine();
}
string[] Array2 = new string[element];

void Formation(string[] Array, string[] Array2)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            Array2[count] = Array[i];
            count++;
        }
    }
}

System.Console.WriteLine("Заданный массив: ");
PrintArray (Array);
Formation(Array,Array2);
System.Console.WriteLine("Итоговый массив: ");
PrintArray(Array2);
