Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sum = 0;
for (int i = 0; i <size; i++){
    array[i] = new Random().Next(1,100);
    //да, по идее стоит вынести генерацию массива в отдельную функцию по всем задачам
    //и не выполнять поиск в этом же цикле. Но так эффективнее и быстрее.
    if (i % 2 != 0){
        sum += array[i];
    }
}

ArrayPrint(array);
Console.WriteLine("Сумма нечетных позиций: " + sum);

void ArrayPrint(int[] array){
    Console.WriteLine("Массив: ");
    foreach (int a in array){
        Console.Write(a + " ");
    }
    Console.WriteLine();
}
