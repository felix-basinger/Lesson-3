// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

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
            LineSegment();
            break;

            case "n":
            Work = false;
            break;
        }
    }
}

int Read(string coordinate)
{
    System.Console.Write($"Enter {coordinate}: ");
    int x = int.Parse(Console.ReadLine());
    return x;
}

void LineSegment()
{
    int x1 = Read("x1");
    int y1 = Read("y1");
    int z1 = Read("z1");

    int x2 = Read("x2");
    int y2 = Read("y2");
    int z2 = Read("z2");

    double result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
    System.Console.WriteLine($"The length of the line segment is {result}");
}
