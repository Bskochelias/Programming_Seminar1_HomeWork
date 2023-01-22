// По двум заданным числам проверять является ли первое квадратом второго
//По заданному номеру дня недели вывести его название
//Выяснить является ли число чётным
//Показать четные числа от 1 до N
//Показать последнюю цифру трёхзначного числа
//Показать вторую цифру трёхзначного числа
//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
//Удалить вторую цифру трёхзначного числа
//Выяснить, кратно ли число заданному, если нет, вывести остаток.
//Найти третью цифру числа или сообщить, что её нет

int otvet = 1;
string otvet2 = " ";
do
{
  do
  { 
    Console.Clear();

    Console.WriteLine(" ");
    Console.WriteLine("Добрый день прошу выбрать цифру списка что Вы хотите сделать?");
    Console.WriteLine("__________");
    Console.WriteLine("1. По двум заданным числам проверять является ли первое квадратом второго");
    Console.WriteLine("2. По заданному номеру дня недели вывести его название");
    Console.WriteLine("3. Выяснить является ли введенное число чётным");
    Console.WriteLine("4. Показать четные числа от 1 до N");
    Console.WriteLine("5. Показать вторую цифру трёхзначного числа");
    Console.WriteLine("6. Показать последнюю цифру трёхзначного числа");
    Console.WriteLine("7. Найти третью цифру числа или сообщить, что её нет");
    Console.WriteLine("8. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа");
    Console.WriteLine("9. Удалить вторую цифру трёхзначного числа");
    Console.WriteLine("10. Выяснить, кратно ли число заданному, если нет, вывести остаток.");
    Console.WriteLine("__________");
    Console.WriteLine(" ");

    otvet = Convert.ToInt32(Console.ReadLine());


  } while (otvet > 10 ^ otvet < 1);

  Console.Clear();

  //Console.WriteLine(otvet);

  //1. По двум заданным числам проверять является ли первое квадратом второго
  if (otvet == 1)
    {
      int a,b;
      Console.Write("Введите первое число: ");
      a = Convert.ToInt32(Console.ReadLine());
      Console.Write("Введите второе число: ");
      b = Convert.ToInt32(Console.ReadLine());

      if (Math.Sqrt(a) == b)
        {
          Console.WriteLine("Первое число является квадратом второго!");
        }
        else
        {
          if (Math.Sqrt(b) == a)
          {
            Console.WriteLine("Пeрвое число не является квадратом второго, а вот второе число является квадратов первого!");
          }
          else
          {
            Console.WriteLine("Первое число не является квадратом второго!");
          }
        }
      }

//2. По заданному номеру дня недели вывести его название
      if (otvet == 2)
      {
         int a1;
         Console.Write("Введите число недели: ");
         a1 = Convert.ToInt32(Console.ReadLine());
         switch (a1)
         {
              case 1:
                Console.WriteLine("Понедельник");
                break;
              case 2:
                Console.WriteLine("Вторник");
                break;
              case 3:
                Console.Write("Среда");
                break;
              case 4:
                Console.WriteLine("Четверг");
                break;
              case 5:
                Console.WriteLine("Пятница");
                break;
              case 6:
                Console.WriteLine("Суббота");
                break;
              case 7:
                Console.WriteLine("Воскресенье");
                break;
              default:
                Console.WriteLine("Неправильное значение! По пробуйте снова!");
                break;                         
         }
      }
//3. Выяснить является ли введенное число чётным"
      if (otvet == 3)
      {
         int a3;
         Console.Write("Введите число для проверки четности: ");
         a3 = Convert.ToInt32(Console.ReadLine());
         if (a3 % 2 == 0)
          {
            Console.WriteLine("Введенное число четное.");
          } 
          else
          {
            Console.WriteLine("Введенное число нечетное.");
          }
      }
//4. Показать четные числа от 1 до N
      if (otvet == 4)
      {
         int a4, i4=2;
         Console.Write("Введите число до которого будут выходить четные числа: ");
         a4 = Convert.ToInt32(Console.ReadLine());
        if (a4 % 2 == 0)
          {
            while (i4 < a4+2)
              {
                Console.WriteLine(i4);
                i4=i4+2;
              }
          } 
          else
          {
            while (i4 < a4)
              {
                Console.WriteLine(i4);
                i4=i4+2;
              }
          }
      }

//5. Показать вторую цифру трёхзначного числа
      if (otvet == 5)
      {
         int a5;
         string s5;
          do
          {
            Console.Clear();
            Console.Write("Введите трехзначное число: ");
            a5 = Convert.ToInt32(Console.ReadLine());

            if (a5<0) {a5=-a5;}

            if (a5 < 99 ^ a5 > 1000 )  
              {
                Console.WriteLine("Ваше число не трехзначное.");
            
                Console.Write(" Нажмите <Enter> для выхода... ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) {}
              }

          } while (a5 > 99 ^ a5 < 1000);
          
          Console.Write("Вторая цифра трех значного числа равна: ");
          s5 = Convert.ToString(a5);
          s5 = s5.Substring(1,1);
          Console.WriteLine(s5);
      }

//6. Показать последнюю цифру трёхзначного числа
    if (otvet == 6)
      {
         string a6;
         Console.Write("Введите число в котором нужно показать последнию цифру:");
         a6 = Console.ReadLine();
        Console.WriteLine("Последния цифра равна: " + a6.Substring(a6.Length - 1,1));

      }

//7. Найти третью цифру числа или сообщить, что её нет
    if (otvet == 7)
      {
        int a7;
        string s7;
        
        Console.Write("Введите число: ");
        a7 = Convert.ToInt32(Console.ReadLine());
        if (a7<0) {a7=-a7;}
        
        if (a7 > 99)
        {
          s7 = Convert.ToString(a7);
          s7 = s7.Substring(2,1);
          Console.WriteLine("Третий символ числа равен: " + s7);
        }
        else
          Console.WriteLine("Третьего символа нету!");

      }

//8. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа")
    if (otvet == 8)
      {
        int   a8, i8 = 1 , izv,
              min8, max8,
              max_chislo;
        string s8;
        
        Console.WriteLine("Выберите отрезок рандомного числа!");
        Console.Write("Введите минимальное число рандома: ");
        min8 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите максимальное число рандома: ");
        max8 = Convert.ToInt32(Console.ReadLine());

        a8 = new Random().Next( min8, max8);
        Console.WriteLine($"Случайное число равно: {a8}");
        if (a8<0) {a8=-a8;}
        s8 = Convert.ToString(a8);

        max_chislo = Convert.ToInt32(s8.Substring(0,1));
        while (i8 < s8.Length)
        {
            izv = Convert.ToInt32(s8.Substring(i8,1));
            if (max_chislo < izv) max_chislo = izv;
            i8++;
        }
        Console.WriteLine("Наибольшое цифра случайного числа из диапазона (" + min8 + " , "+ max8 + ") равна:"+ max_chislo);
      }

//9. Удалить вторую цифру трёхзначного числа
if (otvet == 9)
      {
         int a9, minus=0;
         string s9;
          do
          {
            Console.Clear();
            Console.Write("Введите трехзначное число для удаления второй цифры: ");
            a9 = Convert.ToInt32(Console.ReadLine());

            if (a9<0) {a9=-a9; minus=1;}

            if (a9 < 99 ^ a9 > 1000 )  
              {
                Console.WriteLine("Ваше число не трехзначное.");
            
                Console.Write(" Нажмите <Enter> для выхода... ");
                while (Console.ReadKey().Key != ConsoleKey.Enter) {}
              }

          } while (a9 > 99 ^ a9 < 1000);
          
          
          s9 = Convert.ToString(a9);
          s9 = s9.Substring(0,1)+s9.Substring(2,1);
          if (minus == 1) s9 = "-"+s9;
          Console.WriteLine($"После удаления получислось слудещее число: {s9}");
      }

//10. Выяснить, кратно ли число заданному, если нет, вывести остаток.
      if (otvet == 10)
      {
         int a10, b10;
         
         Console.Write("Введите число: ");
         a10 = Convert.ToInt32(Console.ReadLine());
         Console.Write("Введите кратное число: ");
         b10 = Convert.ToInt32(Console.ReadLine());
        if (a10%b10 == 0) 
            {
              Console.WriteLine($"Число {a10} кратное числу {b10}!");

            }
          else
          {
              Console.WriteLine("Целое число от деление равно: "+(a10-(a10%b10))/b10 + ". Остаток от деление равно:" + a10%b10);
          }
          
      
      }

  Console.Write(" Нажмите <Enter> для выхода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

  Console.Clear();

 
    Console.WriteLine("Вы хотите воспользоваться еще одним решением? Yes/No");
    Console.WriteLine(" ");
    otvet2 = Console.ReadLine();

}
while (otvet2 != "No" & otvet2 != "no" & otvet2 != "NO" & otvet2 !="n" & otvet2 !="N");

Console.Clear();

Console.WriteLine("Спасибо, что воспользовались программой. Досвидание!!!");
Console.Write(" Нажмите <Enter> для выхода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

Console.Clear();