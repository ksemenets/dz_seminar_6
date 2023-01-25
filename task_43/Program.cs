// Задача 43. Напишите программу, которая найдёт
// точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
//  задаются пользователем.
 Console.WriteLine("Ну что же, милый друг, вспомним школу ;-) ! Проверим, пересекаются ли наши прямые?");
 Console.WriteLine("Введи, пожалуйста, значение b1");
 double b1 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Введи, пожалуйста, значение b2");
 double b2 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Введи, пожалуйста, значение k1");
 double k1 = Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("Введи, пожалуйста, значение k2");
 double k2 = Convert.ToDouble(Console.ReadLine());
 double x;
 double y;
 if (k1 == k2)
 Console.WriteLine("Эти прямые параллельны");
 else
 {
     x = (b2 - b1) / (k1 - k2);
     y = k1 * x + b1;
 
 Console.WriteLine($"Координаты точки пересечения следующие: X = {x:f2}; Y = {y:f2}");
 }
