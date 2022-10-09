﻿// Дан текст. В тексте все пробелы нужно заменить черточками, 
//маленькие буквы "к" заменить большими "К", 
//а большие "С" заменить меленькими "с

string text = "Собаки и кошки могут заразиться ленточными паразитами при проглатывании их переносчиков,"
+ "например, блох или мелких грызунов."
+ " Этому риску подвержены и городские животные,"
+ " и жувущие за городом,"
+ "а также те, кого хозяева берут с собой на природу, охоту или дачу";

// string s = "word"
//             0123
// s[3] == d - способ обратиться к конкретному символу строки. третий символ строки это буква d
// используем условный метод 4, где значения и принимаются и возвращаются

string Replace(string text, char oldValue, char newValue)
//возвращается строка, ее назвали Replace (строка и входной текст, char это какой-то конкретный символ с которого меняем, char newValue конкретный символ на который будем менять)

{
    string result = String.Empty;
// инициализация пустой строки    
    int length = text.Length;
// получаем длину строки, обращаясь к свойству количество символов в строке
    for( int i = 0; i < length; i++)
        {
        if (text[i] == oldValue) result = result + $"{newValue}";    // если текст[итое] совпал со значение, которе нужно заменить, то возвращаем результат newValue
        else result = result + $"{text[i]}";  // если совпадений не обнаружено, то в результат вернем тот символ, который был
             
        }
    return result;
}

   string newText = Replace(text, ' ', '|'); // выводим новую строку ей присваиваем замену текста "пробелы" на "|"
   Console.WriteLine(newText); // вывели новый текст
   Console.WriteLine(); // Разделение пустой строкой
   newText = Replace(newText, 'к', 'К'); // получили новый текст и заменили значения
   Console.WriteLine(newText);
   Console.WriteLine(); // Разделение пустой строкой
   newText = Replace(newText, 'С', 'с');
   Console.WriteLine(newText);