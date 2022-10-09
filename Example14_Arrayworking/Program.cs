// Задание отсрочтировать цифры внутри массива.
//1. Найти позицию минимального значения в неотсортированном массиве
//2. Произвести обмен этого значения со значением первой неотсортированноый позиции в массиве
//3. Повторять пока есть неотсортированные элементы

int [] arr = {1,3,4,5,2,6,7,1,1,1}; // ввели массив который будем отсортировывать
// вводим отдельный метод для вывода массива на экран

void PrintArray(int[] array) // задаем метод войд, в качестве аргумента задаем массив
{
    int count = array.Length; // получение количества элементов
    
    for( int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); //показываем на экран
    }
    Console.WriteLine(); // вывод пустой строки

}
void SelectionSort(int[] array) // упорядочивание массива
{
    for( int i = 0; i < array.Length - 1; i++) // array.Length- обращение к длине массива
    {
         int minPosition = i; // int minPosition-элемент на который смотрим, i- позиция элемента для которой будем производить действия
        for( int j = i+1; j < array.Length; j++)  // поиск минимального элемента
        {
            if(array[j] < array[minPosition]) minPosition=j;         
         
        }
        int temporary = array[i];
        array[i]=array[minPosition]; // обмен двух переменных местами
        array[minPosition]= temporary;
   }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);


