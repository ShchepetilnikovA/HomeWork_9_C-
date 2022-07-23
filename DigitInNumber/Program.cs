double DigitsInNumber(int number)
{
    
    if(number / 10 > 0)
    {
        return 1 + DigitsInNumber(number / 10);
        
    }
    else return 1;
}

Console.WriteLine("Num");
int number = Convert.ToInt32(Console.ReadLine());

double result = DigitsInNumber(number);


Console.WriteLine(DigitsInNumber(number));
