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
 //   if (otvet == 2)
 //   {
 //     int a1;
 //     Console.Write("Введите число: ");
 //     a = Convert.ToInt32(Console.ReadLine());
 //     switch (a1)
 //     {
 //       Case 1:
 //         Console.Write("Понедельник");
 //         break;
 //       Case 2:
 //         Console.Write("Понедельник");
 //         break;
 //     }
 //   }

  Console.Write(" Нажмите <Enter> для выхода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

  Console.Clear();

 
    Console.WriteLine("Вы хотите решить воспользоваться еще одним решением? Yes/No");
    Console.WriteLine(" ");
    otvet2 = Console.ReadLine();

}
while (otvet2 != "No" & otvet2 != "no" & otvet2 != "NO");

Console.Clear();

Console.WriteLine("Спасибо, что воспользовались программой. Досвидание!!!");
Console.Write(" Нажмите <Enter> для выхода... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}

Console.Clear();