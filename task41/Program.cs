// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


//Console.WriteLine( "введите любые  числа:");
//int[]array= Convert.    (Console.ReadLine());

//Задать с клавиатуры число элементов массива
int n;
Console.WriteLine("Укажите количество вводимых чисел");
n = Convert.ToInt16(Console.ReadLine());
// Объявим одномерный массив array с n-элементами 
double[] array = new double[n];
int i = 0;
while (i < n)
{
    Console.WriteLine("Введите число");
    /* Вводим элементы массива с клавиатуры 
     * и заполняем ими массив */
    array[i] = double.Parse(Console.ReadLine());
    Console.WriteLine();
    i++;
   
}
int count=0;
for (i = 0; i < n; i = i + 1)
{
    Console.Write($"{array[i]} "); //выводим массив 

    if (array[i] > 0) //считаем числе больше нуля
    {
      count++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество чисел больше нуля равно {count}");
    






