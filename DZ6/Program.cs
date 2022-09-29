//Задача 41
/*
int n = Prompt("Введите число элементов в массиве:");
int[] array = new int[n];
FullArray(array);
PrintArray(array);

int Prompt(string message)
{
    Console.WriteLine(message);
    int num = Int32.Parse(Console.ReadLine());
    return num;
}

void FullArray(int[] array)
{
    for(int i=0;i < array.Length;i++)
    {
       Console.Write("Введите число:");
       array[i] = Int32.Parse(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    int count = 0;
    for(int i=0;i < array.Length;i++)
    {
      if(array[i] > 0)
         count++;
      Console.Write($"{array[i]} ");
    }
    Console.WriteLine("Из них больше 0->"+count);
}
*/
//Задача 43
double b1 = Prompt("b1=");
double k1 = Prompt("k1=");

double b2 = Prompt("b2=");
double k2 = Prompt("k2=");
CheckDirect(b1,k1,b2,k2);

int Prompt(string message)
{
    Console.Write(message);
    int num = Int32.Parse(Console.ReadLine());
    return num;
}

void CheckDirect(double b1,double k1,double b2,double k2)
{
    double x,y;
    if ((k1 == k2) && (b1 == b2))
       Console.WriteLine("Прямые совпадают");
    else if (k1==k2)
        Console.WriteLine("Прямые параллельны");
    else
    {
        x=(b2-b1)/(k1-k2);
        y=(k1*(b2-b1))/(k1-k2)+b1;
        Console.WriteLine("x= " + x  + "y= " + y);
    }
}

