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

int QuantityNum(int numbers)
{
    int result = 0;
    if (numbers > 0)
    {
        while (numbers > 0)
        {
            numbers /= 10;
            result++;
        }
    }
    else if (numbers == 0)
        result = 1;
    else
        while (numbers < 0)
        {
            numbers /= 10;
            result++;
        }
    return result;
}

// void QuantityNum2(int numbers)
// {
//     int check = 0;
//     if (numbers > 0)
//     {
//         while (numbers > 0)
//         {
//             numbers /= 10;
//             check++;
//         }
//         System.Console.WriteLine($"В вышем числе состовляет {check} цифр");
//     }
//     else if (numbers == 0)
//     {
//         check++;
//         System.Console.WriteLine($"В вышем числе состовляет {check} цифр");
//     }
//     else if (numbers < 0)
//     {
//         while (numbers < 0)
//         {
//             numbers /= 10;
//             check++;
//         }
//         System.Console.WriteLine($"В вышем числе состовляет {check} цифр");
//     }
// }

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"В вышем числе: {num} состовляет {QuantityNum(num)} цифр");
// QuantityNum2(num);