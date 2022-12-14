Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
double min = int.MaxValue;
double max = int.MinValue;
for (int i = 0; i <size; i++){
    array[i] = new Random().Next(1,200);
    //ленивый способ заполнить массив не-целыми числами
    if (array[i] %2 == 0){
        array[i] /= 3;
    }
    else {
        array[i] /= 2;
    }
    if (array[i] < min){
        min = array[i];
    }
    else if (array[i] > max){
        max = array[i];
    }
}


ArrayPrint(array);
Console.WriteLine("Разница мин и макс: " + (max - min));

void ArrayPrint(double[] array){
    Console.WriteLine("Массив: ");
    foreach (double a in array){
        Console.Write(a + " ");
    }
    Console.WriteLine();
}