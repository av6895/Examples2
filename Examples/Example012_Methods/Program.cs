// Вид 1    ничего не принимают, в конце программы что-то показывают,например имя автора
void Method1()
{
  Console.WriteLine("Автор ...");
}
// Method1();   - для демонстрации на экран







// Вид 2   - ничего не возвращают, но могут принимать какие-то элементы
void Method2(string msg)
{
  Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg,int count)           // если методы принимают какое-то количество аргументов
{
  int i = 0;
  while (i < count)
  {
   Console.WriteLine(msg);
   i++;
  }
}
// Method21(msg: "Текст", count: 4);      //указываем через запятую сколько раз хотим увидеть это сообщение







// Вид 3     - методы что-то возвращают, но ничего не принимают 
int Method3()
{
  return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);










// Вид 4     - методы,которые что-то принимают и что-то возвращают
// string Method4(int count, string text)
// {
  // int i = 0;
  // string result = string.Empty;            // изначально пустая строка

  // while (i < count)
  // {
  //   result = result + text;
  //   i++;
  // }
//   return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);







// цикл FOR

string Method4(int count, string text)
{
  string result = string.Empty;            // изначально пустая строка
  for(int i = 0; i < count; i++)
  {
    result = result + text;
  }
  return result;
}

string res = Method4(10, "z");
// Console.WriteLine(res);







// цикл в цикле
// for(int i = 2; i <= 10; i++)
// {
//   for(int j = 2; j <= 10; j++)
//   {
//     Console.WriteLine($"{i} x {j} = {i*j}");        //интерполяция строк
//   }
//   Console.WriteLine();                               // создали искусственный разрыв между результатами цикла для красивого отображения
// }


// В компьютерном программировании интерполяция строк (или интерполяция переменных, подстановка переменных или расширение переменных) 
// - это процесс вычисления строкового литерала, содержащего один или несколько заполнителей, 
// в результате чего заполнители заменяются соответствующими им значениями.







/* ==== Работа с текстом
Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы "к" заменить большими "К",
а большие "С" заменить маленькими "с".

Ясна ли задача? */

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

      // string s = "qwerty"
      //             012345
      // s[3]  - r

// string Replace(string text, char oldValue, char newValue)
// {
//   string result = string.Empty;

//   int length = text.Length;
//   for(int i = 0; i < length; i++)
//   {
//     if(text[i] == oldValue) result = result + $"{newValue}";
//     else result = result + $"{text[i]}";
//   }

//   return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();                    //только вот в тексте нет больших С 







// функции

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// // 1 этап. выводим данный массив на экран: 
// void PrintArray(int[] array)
// {
//   int count = array.Length;

//   for(int i = 0; i < count; i++)
//   {
//     Console.Write($"{array[i]} ");
//   }
//   Console.WriteLine();
// }

// // 2 этап. пишем метод, который будет упорядочивать наш массив
// void SelectionSort(int[] array)
// {
//   for(int i = 0; i < array.Length - 1; i++)
//   {
//     int minPosition = i;

//     for(int j = i + 1; j < array.Length; j++)
//     {
//       if(array[j] < array[minPosition]) minPosition = j;
//     }

//     int temporary = array[i];
//     array[i] = array[minPosition];
//     array[minPosition] = temporary;
//   }
// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);




int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

// 1 этап. выводим данный массив на экран: 
void PrintArray(int[] array)
{
  int count = array.Length;

  for(int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}

// 2 этап. пишем метод, который будет упорядочивать наш массив
void SelectionSort(int[] array)
{
  for(int i = 0; i < array.Length - 1; i++)
  {
    int maxPosition = i;

    for(int j = i + 1; j < array.Length; j++)
    {
      if(array[j] > array[maxPosition]) maxPosition = j;
    }

    int temporary = array[i];
    array[i] = array[maxPosition];
    array[maxPosition] = temporary;
  }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);