Console.Clear();

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

string s = Convert.ToString(n);

char[] ch = s.ToCharArray();

if (ch.Length == 5)
{
    if (ch[0] == ch[4] && ch[1] == ch[3])
        Console.WriteLine("Данное число является палиндромом. Ура!");
    else
        Console.WriteLine("Данное число НЕ является палиндромом. Увы!");
}

else
    Console.WriteLine("Неверные исходные данные. Повторите попытку.");