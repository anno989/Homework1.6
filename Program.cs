//*****ДОМАШНЕЕ ЗАДАНИЕ*****

//ЗАДАЧА 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

//Для строки можно использовать данный метод string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)
//(пользователь вводит в консоли числа через пробел и они формируют строку)

// Console.WriteLine("Введите элементы через пробел: ");
// int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
// // // int count = arr.Count(x => x > 0);
// int count = 0; 
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Кол-во элементов больше нуля = {count}");


//ЗАДАЧА 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6) в промежутке от 0 до 100, 
//а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

int[] array = GetArray(7, 0, 100);
Console.WriteLine($"[{String.Join(",", array)}]");

SelectionSort(array);
Console.WriteLine($"[{String.Join(",", array)}]");


//Console.WriteLine($"{GetArray}");
//Console.WriteLine($"{SelectionSort}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void SelectionSort(int[] array) 
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
} 
