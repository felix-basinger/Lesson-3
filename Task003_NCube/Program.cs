// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Main();
 
void Main()
{
    bool Work = true;
    while(Work)
    {
        System.Console.Write("Are you ready? Enter y/n: ");
        string a = System.Console.ReadLine();
        switch(a)
        {
            case "y":
            NumCube();
            break;

            case "n":
            Work = false;
            break;
        }
    }
}

int Enter()
{
    Console.Write("Enter the number N: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

void NumCube()
{   
    int N = Enter();
    for(int i = 1; i <= N; i ++)
    {
        Console.Write(Math.Pow(i, 3));
        Console.Write(", ");
    }
    System.Console.WriteLine(" ");
}
 