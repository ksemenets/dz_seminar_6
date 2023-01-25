/*Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
 Ввод чисел останавливается при помощи ввода стоп-слова "stop"
  и производится при помощи нажатия Enter
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/
 
int N;
int M = 0;
Console.WriteLine("Введите число или команду STOP");

while(true)
{ 
    string? message = Console.ReadLine();
    if (message == "stop")
    {
        break;
    }
     N = Convert.ToInt32(message);
     if (N > 0)
     M = M + 1;         
}
Console.WriteLine($"Вы ввели {M} положительных чисел");
