// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Задайте размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

ArrayRandomNumbers(array);// Заполнение массива числами.Вывод созданного массива на экран.
NumberOfPositive(array);// Подсчет чисел больше 0.

void ArrayRandomNumbers(int[] array) 
{
    Console.WriteLine("Введите элементы массива (элемент -> enter):");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write(" ] - созданный массив, ");
}

void NumberOfPositive(int[]array)
{
    int positive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            positive++;
        } 
    }
Console.Write("("+positive+")-колличество чисел больше 0.");
}