Console.WriteLine ("Введите день недели ");
int Number = Convert.ToInt32 (Console.ReadLine ());
string NumberText = Convert.ToString(Number);
void CheckingTheday (int Number) {
if (Number == 6 || Number == 7) 
    { Console.WriteLine("этот день выходной? - да");


    }    
    else if (Number < 1 || Number > 7) 
        { Console.WriteLine ("это вообще не день недели");

        }
    else Console.WriteLine("этот день выходной? - нет");
}
CheckingTheday (Number);
