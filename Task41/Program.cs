// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine);

int[] ArrayTo(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    
    return array;

}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int CheckInArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
        {
            count++;
        }
    }
    return count;
}


Console.WriteLine("Укажите, какое количество чисел вы желаете ввести");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] MyBestArray = ArrayTo(numbers);
ShowArray(MyBestArray);
Console.WriteLine("Количество чисел больше 0 - "+ CheckInArray(MyBestArray)) ;