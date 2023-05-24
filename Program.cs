//Задача 1.
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
int Exponentiation(int numberA, int numberB)
{
    int result = 1;
        for(int i=1; i <= numberB; i++)
        {
            result = result * numberA;
        }
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + exponentiation);
*/

// Задача 2.
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int SumNumber(int numberN)
{    
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
}

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
*/

//Задача 3.
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreatNewArray (int size, int min, int max) 
{
    int [] array = new int[size];   
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1); 
    return array;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " ");
}

Console.WriteLine("Enter count of elements: ");

int countOfElem = Convert.ToInt32(Console.ReadLine());
int minVal = 0;
int maxVal = new Random().Next();

int [] array1 = CreatNewArray(countOfElem, minVal, maxVal);
ShowArray(array1);

