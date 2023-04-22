/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите num1:"); 
int num1 = int.Parse(Console.ReadLine()); 

Console.WriteLine("Введите num2:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(ExponentiationAtoB(num1, num2)); 


int ExponentiationAtoB(int num1, int num2)
{
    int tmp = num1; 
    
    for(int i = 1; i < num2; i++) 
    {
        num1 = num1 * tmp; 
    }

    return num1; 

}

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
Обязательно работать с int как на занятии 4
*/

Console.WriteLine("Введите число:"); 
int number = int.Parse(Console.ReadLine()); 

Console.WriteLine(GetSummNumber(number));


int GetSummNumber(int number)
{
    int [] array = BuildArrayFromNumers(number); 
    int summ = 0; 
    
    for (int i = 0; i < array.Length; i++)
    {
        summ += array[i]; 
    }

    return summ; 

}

int[] BuildArrayFromNumers(int number)
{
    int length = GetSizeNubmer(number); 

    int[] array = new int[length]; 

    for (int i = 0; i < length; i++) 
    {
        array[i] = number % 10; 
        number = number / 10; 
    }

    return array; 
}

int GetSizeNubmer(int number)
{
    int i = 0; 

    while (number != 0) 
    {
        number /= 10; 
        i++; 
    }

    return i; 
}

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
Вывод массива обязательно в виде [число, чилсо, ... ,число]
*/

Console.WriteLine("Введите размер массива:"); 
int sizearray = int.Parse(Console.ReadLine()); 

int[] array = new int[sizearray]; 

for (int i = 0; i < sizearray; i++) 
{
    Console.WriteLine($"Введите значение для элемента массива {i}:"); 
    array[i] = int.Parse(Console.ReadLine()); 
}

PrintArray(array); 


void PrintArray (int[] array)
{
    if (array.Length != 0) 
    {

        for (int i = 0; i < array.Length; i++) 
        {
            if (array.Length == 1) 
            {
                Console.Write($"[{array[i]}]");
            }

            else if (i == 0) 
            {
                Console.Write($"[{array[i]},"); 
            }

            else if (i == array.Length -1) 
            {
                Console.Write($" {array[i]}]");
            }
            
            else 
            {
                Console.Write($" {array[i]},");
            }
        }
    }
}
