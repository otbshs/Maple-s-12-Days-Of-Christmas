namespace Maple_s_12_Days_Of_Christmas;
class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 12; i++)
        {
            System.Console.WriteLine("On the {0} day of christmas, my true love sent to me",ords[i]);
            for (int j = i; j > 1; j--)
            {
                System.Console.WriteLine("{0} {1}", cards[j], gifts[j]);
            }
            System.Console.WriteLine("And a partridge in a pear tree.");
            System.Console.WriteLine();
        }



        string[] ords = new string["zeroth", "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth", "eleventh", "twelfth"];
        string[] cards = new string["Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve"];
        string[] gifts = new string["nothing", "partridge in a pear tree", "turtle doves", "french hens", "calling birds", "gold rings", "geese a-laying", "maids a-milking", "swans a-swimming", "ladies dancing", "lords a-leaping", "pipers piping", "drummers drumming"];
    }
}
