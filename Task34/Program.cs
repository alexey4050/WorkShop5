// Задача 34: Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
 Console.WriteLine($"Задача 34.Количество чётных чискл в массиве: ");
 int[] number = new int[10];

 void FillArray(int[] array, int min, int max){
    for(int i = 0; i<array.Length; i++){
        array[i] = new Random().Next(min, max);

    }
 }

 void WriteArray(int[] array){
    for(int i = 0; i<array.Length; i++ ){
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
 }

 int QuantityPositive(int[] array){
    int quantity = 0;
    for(int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
        quantity++;
    }    
  }
  return quantity;
 }
 FillArray(number, 100, 1000);
 WriteArray(number);
 Console.WriteLine();

 int quantity = QuantityPositive(number);
    Console.WriteLine($"Количество чётных чисел в массиве; {quantity}");