// //                                ДОМАШНЕЕ ЗАДАНИЕ

// // ЗАДАЧА 10: Напишите программу, которая принимает на вход трехзначное число 
// //            и на выходе показывает вторую цифру этого числа

// int SecondDigit(int number)
// {
//     int ed = number % 10;
//     int dec = number % 100;
//     int second = (dec - ed) / 10;
//     return second;
// }
// Console.WriteLine("Enter a three-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number < 100 | number >= 1000)
// {
//     Console.WriteLine($"The entered number {number} does not match the condition");
// }
// else
// {
//     int result = SecondDigit(number);
//     Console.WriteLine($"The second digit of the number {number} is {result}");
// }

// // ЗАДАЧА 13: Напишите программу, которая выводит третью цифру заданного числа
// //            или сообщает, что третьей цифры нет

// int ThirdDigit(int number)
// {
//     int temp = 100;
//     int result = 0;
//     while(temp < number)  
//     {
//         result = (number / (temp / 100)) % 10;
//         temp = temp * 10;
//     }
//     return result;
// }

// Console.WriteLine("Enter any namber: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number > 99) // нужно ли учитывать количество знаков, обрабатываемых Int32?
// {
//     int third = ThirdDigit(number);
//     Console.WriteLine($"The third digit of the number {number} is {third}");  
// }
// else
// {
//     Console.WriteLine($"In the number {number}, the third digit is missing");
// }


// // ЗАДАЧА 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// //            и проверяет, является ли этот день выходным

// bool DayWeek(int day)
// {
//     int index = 0;
//     while(index <= 7)
//     {
//         if(day == 6 | day == 7)
//         {
//             return true;
//         }
//         index++;              
//     }
//     return false;
// }

// Console.WriteLine("Enter the serial number of the day of the week: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if(day < 1 | day > 7)
// {
//     Console.WriteLine($"The entered number {day} does not meet the conditions");
// }
// else
// {
//     bool weekend = DayWeek(day);
//     if(weekend)
//     {
//         Console.WriteLine($"The entered number {day} corresponds to a day off");
//     }
//     else
//     {
//         Console.WriteLine($"The entered number {day} does not correspond to the day off");
//     }
// }







































//ЗАДАЧА 1. Напишите программу, которая выводит случайное число из отрезка от 10 до 99 
//           и показывает наибольшую цифру числа


// int FindBiggestDigit (int number)
// {
//     int ed = number % 10;                  // единицы
//     int dec = number / 10;                 // десятки
//     //int result;

//     if(ed > dec) 
//     {
//         return ed;
//     }

//     else 
//     {
//         return dec;
//     }       
// }

// int randNum = new Random().Next(10, 100);
// int biggestDigit = FindBiggestDigit(randNum); //вызываем метод

// Console.WriteLine($"The biggest digit of {randNum} is {biggestDigit}");

// ЗАДАЧА 2. Напишите программу, которая выводит случайное трехзначное число
//         и удаляет вторую цифру этого числа


// int DeleteSecondDigit (int number)
// {
//     int ed = number % 10;
//     int hun = number / 100;
//     int res = hun * 10 + ed;
//     return res;   
// }

// int randNum = new Random().Next(100, 1000);
// int shortNum = DeleteSecondDigit(randNum);

// Console.WriteLine($"The number {randNum} without the second digit is {shortNum}");

//ЗАДАЧА 3. Напишите программу, которая принимает на вход два числа и выводит, является ли
//        второе число кратным первому, если нет, то выводит остаток от деления


// Console.WriteLine("Enter the first number: ");
// double num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the second number: ");
// double num2 = Convert.ToInt32(Console.ReadLine());

// void MultipleDigit(double num1, double num2)
// {
//     if ((num2 % num1)==0)
//     {
//         Console.WriteLine($"The number {num2} is a multiple of the number {num1}");
//     }
//     else
//     {
//         double result = num2 % num1;
//         Console.WriteLine($"The number {num2} is not a multiple of the number {num1}. The remainder of the division is {result}");
//     }
    
// }

// MultipleDigit(num1, num2);


// ЗАДАЧА 4. Напишите программу, которая принимает на вход число и проверяет, 
//         кратно ли оно одновременно a и b (значения а и b вводит пользователь)


// void MultipleDigit(int number, int a, int b )
// {
//    if(number % a == 0 & number % b == 0)
//    {
//     Console.WriteLine($"The number {number} is a multiple of the numbers {a} and {b}");
//    }
//    else
//    {
//     Console.WriteLine($"The number {number} is not a multiple of the numbers {a} and {b} at the same time");
//    } 
// }

// Console.WriteLine("Enter first number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// MultipleDigit(number, a, b);


//ЗАДАЧА 5. Напишите программу, которая принимает на вход два числа и проверяет, 
//        является ли одно число квадратом другого

//                 через void
// void SquareNumber(int num1, int num2)
// {
//    if(num1 == num2*num2)
//    {
//       Console.WriteLine($"The number {num1} is the square of the number {num2}");
//    }
//    if(num2 == num1*num1)
//    {
//       Console.WriteLine($"The number {num2} is the square of the number {num1}");
//    }
//    else
//    {
//       Console.WriteLine($"The numbers {num1} and {num2} are not squares of one another");
//    }
// }

// Console.WriteLine("Enter first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// SquareNumber(num1, num2);

//                      Через bool
// bool SquareNumber(int num1, int num2)
// {
//    if(num1 == num2*num2)
//    {
//       return true;
//    }
//    if(num2 == num1*num1)
//    {
//       return true;
//    }
//    else
//    {
//       return false;
//    }
// }

// Console.WriteLine("Enter first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// bool Square = SquareNumber(num1, num2);
// //Console.WriteLine(Square);
// if(Square)
// {
//   Console.WriteLine($"One of the numbers is square of another number."); 
// }
// else
// {
// Console.WriteLine($"No one of the numbers is square of another number.");
// }