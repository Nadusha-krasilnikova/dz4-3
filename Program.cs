// в одномерном массиве из 123 чисел найти кол-во элементов из отрезка (10,99)
int[]arr=new int[123];
for (int i=0; i<arr.Length; i++)
{
    arr[i]=new Random().Next(0,100);
Console.Write($" {arr[i]} ");
}
int c=0;
for (int i=0; i<arr.Length; i++)
{ 
    if(arr[i]>=10)
    c++;
}
    
Console.WriteLine();
Console.WriteLine($"количество элементов из отрезка [10,99] равно {c}");