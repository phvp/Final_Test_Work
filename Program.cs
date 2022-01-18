//Прямой вариант решения:
int [] numbers = new int[] {1,2,3,4,5,6,7,8,9};
Console.WriteLine("[{0}]->", string.Join(" ", numbers));

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    Console.WriteLine("[{0}]", string.Join(" ", numbers[i]));
}
//Решение с применением методов:

int[] ArrayАssignment(int[] numbers) // метод задания случайным образом массива из чисел в диапазоне от 1 до 28;
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 28);
    }
    return numbers;
}
void PrintArray(int[] numbers) //метод для вывода массива на экран;
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write("[{0}]", string.Join(" ", numbers[i]));
               
    }
    Console.WriteLine("->");
}

int[] ArraySorting(int[] numbers) //метод для сортировки чисел в заданном массиве;
{
    int[] result = new int[numbers.Length];
    int j = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0) {result[j] = numbers[i]; j++;}
    }
    Array.Resize(ref result, j);
    return result;
}

int[] numbers2 = new int[13];
numbers2 = ArrayАssignment(numbers2);
Console.WriteLine("Исходный массив:");
PrintArray(numbers2);
Console.WriteLine();
Console.WriteLine("Массив после сортировки:");
PrintArray(ArraySorting(numbers2));