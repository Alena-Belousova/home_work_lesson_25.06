Console.WriteLine("Задача 2 работает");
Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32 (Console.ReadLine());
int max = number1;
if(number2 > max) 
{Console.WriteLine(number2);
}
else{
   Console.WriteLine("максимальное значение из введенных = " + max); 
}