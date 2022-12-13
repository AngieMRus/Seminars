Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

string s = Convert.ToString(n);

char[] arr = s.ToCharArray();

int sum = 0;

for (int count = 0; count < arr.Length; count++)
    sum = sum + arr[count];
    
Console.WriteLine(sum);