Console.WriteLine ("Введите number = ");
int number = Convert.ToInt32 (Console.ReadLine ());
number = Math.Abs(number);
string result;
if(number % 2 == 0) 
{
    result = "да";
}   
else
{
    result = "нет";
};
Console.WriteLine (result);
