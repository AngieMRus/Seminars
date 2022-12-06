Console.Clear();

Console.Write("Введите число, обозначающее день недели: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 1)
    Console.WriteLine("Понедельник. Поработаем!");
else if (n == 2)
    Console.WriteLine("Вторник. Поработаем!");
else if (n == 3)
    Console.WriteLine("Среда. Поработаем!");
else if (n == 4)
    Console.WriteLine("Четверг. Поработаем!");
else if (n == 5)
    Console.WriteLine("Пятница. Поработаем!");
else if (n == 6)
    Console.WriteLine("Суббота. Хорошего отдыха!");
else if (n == 7)
    Console.WriteLine("Воскресенье. Хорошего отдыха!");
else
    Console.WriteLine("В неделе 7 дней. Введите число от 1 до 7.");