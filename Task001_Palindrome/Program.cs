// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

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
            IsItNum();
            break;

            case "n":
            Work = false;
            break;
        }
    }
}

void IsItNum()
{   
    int num;
    System.Console.Write("Enter your number: ");
    if(int.TryParse(Console.ReadLine(), out num))
    {
       IsItFiveDigitNum(num);
    }
    else System.Console.WriteLine("Error! It's not a number");
}

void IsItFiveDigitNum(int num)
{
    string str = num.ToString();
    int length = str.Length;
    if (length == 5) IsItPoliNum(str);
    else System.Console.WriteLine($"Error! Your number {str} isn't five-digit");
}

void IsItPoliNum(string str)
{
    if(str[0] == str[4] && str[1] == str[3])
    {
        int number = Convert.ToInt32(str);
        System.Console.WriteLine($"Your number {number} is a palindrome");
    }
    else 
    {
        int number = Convert.ToInt32(str);
        System.Console.WriteLine($"Error! Your number {number} isn't a palindrome!");
    }
}
