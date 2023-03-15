
int SearchNumber = new Random().Next(1, 10);
//Console.WriteLine(SearchNumber);
bool isContinue = true;
do
{
    Console.WriteLine("Təxmin etdiyiniz ədədi daxil edin");
    int number = int.Parse(Console.ReadLine());
    if (number == SearchNumber)
    {
        Console.WriteLine("Təbriklər, siz qalibsiniz!");
        isContinue = false;
    }
    else
    {
        Console.WriteLine("Bəxtinizi bir daha sınayın :( " );
    }


} while (isContinue);
