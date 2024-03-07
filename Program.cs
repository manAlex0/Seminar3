// ************************************************************************************************
// Задача 1: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// Пример:
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int Summa(int num)
// {
//     int result = 0;
//     for (int i = 1; i <= num; i++)
//         result += i;
//     return result;
// }

// // void Summa2(int num)
// // {
// //     int result = 0;
// //     for (int i = 1; i <= num; i++)
// //         result += i;
// //     System.Console.WriteLine($"Вы ввели: {num}, сумма всех чисел равна: {result}");
// // }


// System.Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// int result = Summa(num);
// System.Console.WriteLine($"Вы ввели: {num}, сумма всех чисел равна: {result}");
// // Summa2(num);



// ************************************************************************************************
// Задача 2: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// Пример:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int QuantityNum(int numbers)
// {
//     int result = 0;
//     if (numbers == 0)
//         result = 1;
//     else
//     {
//         while (numbers != 0)
//         {
//             numbers /= 10;
//             result++;
//         }
//     }
//     return result;
// }

// // void QuantityNum2(int numbers)
// // {
// //     int check = 0;
// //     if (numbers == 0)
// //     {
// //         check++;
// //         System.Console.WriteLine($"В вышем числе состовляет {check} цифр");
// //     }
// //     else 
// //     {
// //         while (numbers != 0)
// //         {
// //             numbers /= 10;
// //             check++;
// //         }
// //         System.Console.WriteLine($"В вышем числе состовляет {check} цифр");
// //     }
// // }

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"В вышем числе: {num} состовляет {QuantityNum(num)} цифр");
// // QuantityNum2(num);


// // ************************************************************************************************
// // А если вещественное число?




// ************************************************************************************************
// Задача 3: Напишите программу, которая принимает
// на вход число N и выдаёт произведение чисел от 1 до N. Найти факториал
// Пример:
// 4 -> 24
// 5 -> 120

// int Factorial(int number)
// {
//     int result = 1;
//     for (int i = 1; i <= number; i++)
//         result = i * result;
//     return result;
// }


// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = Factorial(num);
// System.Console.WriteLine(result);




// ************************************************************************************************
// Задача 4: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и единицами
// в случайном порядке
// Пример:
// [1, 0, 1, 1, 0, 1, 0, 0]

// void RandomArray(int[] mass)
// {
//     int length = mass.Length;
//     Random namb = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         mass[i] = namb.Next(2);
//         System.Console.Write($"{mass[i]} ");
//     }
// }


// int[] array = new int[8];
// RandomArray(array);

// int[] FillArray()
// {
//     int[] array = new int[8];
//     Random random = new Random();
//     for (int i = 0; i < 8; i++)
//     {
//         array[i] = random.Next(2);
//     }
//     return array;
// }

// int[] array = FillArray();
// System.Console.WriteLine(string.Join(", ", array));



// *****************************************************************************Практическое задание********************************

// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Math.Pow юзать нельзя.
// Пример:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// int MathPow(int a, int b)
// {
//     int result = 1;
//     for (int i = 0; i < b; i++)
//     {
//         result *=a;
//     }
//     return result;
// }

// System.Console.WriteLine("Введите число: ");
// int firstNumber = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine("Введите степень: ");
// int secondNumber = int.Parse(Console.ReadLine()!);
// int result = MathPow(firstNumber, secondNumber);
// System.Console.WriteLine($"Возводим число {firstNumber} в натуральную степень {secondNumber}. Получаем: {result}");




// ************************************************************************************************
// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Пример:
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SummNumb(int num)
{
    int summ = 0;
    while (num > 0)
    {
        summ = summ + (num%10);
        num/=10;
    }
    return summ;
}

System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int summ = SummNumb(number);
System.Console.WriteLine(summ);





// ************************************************************************************************
// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Пример:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]




// ************************************************************************************************
// Задача 4: HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// Пример:
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001 -> 4
// 000000 -> 1