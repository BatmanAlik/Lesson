Console.WriteLine ("Введите number1 ");
int number1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите number2 ");
int number2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите number3 ");
int number3 = Convert.ToInt32 (Console.ReadLine ());
int max;
if(number1 > number2) 
{
    max = number1
  ;
}   
else
{
    max = number2;
};
if(number3 > max)
{
    max = number3;
};
Console.WriteLine (max);
