//смотрим как решаются задачи сначала используя ветвления и циклы, потом при помощи рекурсии


// //собрать строку с числами от a до b, a<=b
// // 1
// string NumbersFor(int a, int b)
// {
//   string result = string.Empty;
//   for(int i = a; i <= b; i++)
//   {
//     result += $"{i} ";
//   }
//   return result;
// }

// // 2
// string NumbersRec(int a, int b)
// {
//   if(a <= b) return $"{a} " + NumbersRec(a + 1, b);
//   else return String.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));







// //собрать строку с числами от a до b, a>=b
// // 1
// string NumbersFor(int a, int b)
// {
//   string result = String.Empty;
//   for(int i = a; i >= b; i--)
//   {
//     result += $"{i} ";
//   }
//   return result;
// }

// // 2
// string NumbersRec(int a, int b)
// {
//   if(a <= b) return NumbersRec(a + 1, b) + $"{a} ";
//   else return String.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10));    //не работает
// Console.WriteLine(NumbersRec(1, 10));







// //сумма чисел от 1 до n

// // 1
// int SumFor(int n)
// {
//   int result = 0;
//   for(int i = 1; i <= n; i++) result += i;
//   return result;
// }

// // 2
// int SumRec(int n)
// {
//   if(n == 0) return 0;
//   else return n + SumRec(n - 1);
// }

// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));







// // факториал числа

// // 1
// int FactorialFor(int n)
// {
//   int result = 1;
//   for(int i = 1; i <= n; i++) result *= i;
//   return result;
// }

// // 2
// int FactorialRec(int n)
// {
//   if(n == 1) return 1;
//   else return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRec(10));








// // вычислить a в степени n

// // 1
// int PowerFor(int a, int n)
// {
//   int result = 1;
//   for(int i = 1; i <= n; i++) result *= a;
//   return result;
// }

// // 2
// int PowerRec(int a, int n)
// {
//   //return n == 0 ? 1 : PowerRec(a, n - 1) * a;   - можно записать все одной строкой
//   if(n == 0) return 1;
//   else return PowerRec(a, n - 1) * a;
// }

// //  3
// int PowerRecMath(int a, int n)
// {
//   if(n == 0) return 1;
//   else if(n % 2 == 0) return PowerRecMath(a * a, n / 2);
//   else return PowerRecMath(a, n - 1) * a;
// }

// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));
// Console.WriteLine(PowerRecMath(2, 10));







// Перебор слов. 
// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из T букв, которые можно построить из букв этого алфавита

// void FindWords(string alphabet, char[] word, int length = 0)
// {
//   if (length == word.Length)
//   {
//     Console.WriteLine($"{n++} {new String(word)}"); return;
//   }
  
//   for (int i = 0; i < alphabet.Length; i++)
//   {
//     word[length] = alphabet[i];
//     FindWords(alphabet, word, length + 1);
//   }
// }
// FindWords(“аисв”, new char[5]);   //??????????????








