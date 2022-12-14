Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sum = 0;
for (int i = 0; i <size; i++){
    array[i] = new Random().Next(100,900);
    //да, по идее стоит вынести заполнение массива в отдельную функцию по всем задачам
    //и не выполнять поиск в этом же цикле. Но так эффективнее и быстрее.
    if (array[i] %2 == 0){
        sum++;
    }
}
ArrayPrint(array);
Console.WriteLine("Четных чисел: " + sum);

void ArrayPrint(int[] array){
    Console.WriteLine("Массив: ");
    foreach (int a in array){
        Console.Write(a + " ");
    }
    Console.WriteLine();
}
