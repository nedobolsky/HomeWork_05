// Задача №34
// int UserSizeArray(){
//     Console.Write("Введите размер массива: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     return size;
// }

// int[] array = new int[UserSizeArray()];

// int[] RandomArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }
// array = RandomArray(array);
// int CountNumberPositive(int[] array){
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}; ");
//         if(array[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     Console.WriteLine();
//     return count;
// }
// Console.WriteLine($"Количество положительных чисел в массиве {CountNumberPositive(array)}");

// Задача №36
// int UserSizeArray(){
//     Console.Write("Введите размер массива: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     return size;
// }

// int[] array = new int[UserSizeArray()];

// int[] RandomArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }
// array = RandomArray(array);

// void PrintArray(int[] array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}; ");
//     }
//     Console.WriteLine();
// }
// PrintArray(array);

// int SumNumberNegative(int[] array){
//     int sum = 0;
//     for (int i = 1; i < array.Length; i+=2)
//     {
//         sum = sum + array[i];
//     }
//     return sum;
// }
// Console.WriteLine($"Сумма чисел в массиве, стоящих на нечётных позициях: {SumNumberNegative(array)}");

// Задача №38
int UserSizeArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

double[] array = new double[UserSizeArray()];

double[] RandomArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().Next(1, 100) * new Random().NextDouble(), 3);
    }
    return array;
}
array = RandomArray(array);

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.WriteLine();
}
PrintArray(array);


double MinNumberArray(double[] array)
{   
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min){
            min = array[i];
        }
    }
    return min;
}

double MaxNumberArray(double[] array)
{   
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > max){
            max = array[i];
        }
    }
    return max;
}

Console.WriteLine($"Минимальное значение массива = {MinNumberArray(array)}");
Console.WriteLine($"Максимальное значение массива = {MaxNumberArray(array)}");
Console.WriteLine($"Разница между максимальным значение массива и минамальным = {MaxNumberArray(array) - MinNumberArray(array)}");