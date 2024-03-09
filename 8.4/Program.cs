using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        Bag bag = new Bag();
        bag.Open();
        bag.Items();
        bag.ItemsInBag();

    }
}

class Bag
{
    private string[] Item = new string[8];
    bool isOpen = false;
    public bool Open()
    {
        Console.WriteLine("открыть сумку y/n?");
        string b = Console.ReadLine();
        if (b == "y")
        {
            Console.WriteLine("Сумка открыта");
            isOpen = true;

        }
        
        return isOpen;
    }
    public void Items()
    {
        int n = 0;
        if (isOpen == true)
        {
            int i = 8;
            do
            {
                Console.WriteLine("введите то что хотите положить в сумку");
                string itembag=Console.ReadLine();
                
                
                Item[n] = itembag;
                n++;
                i--;
                Console.WriteLine("предмет {0} помещен в ячейку {1}",itembag,n);
            }
            while (i > 0);
            Console.WriteLine("сумка заполнена");
        }
       
    }
    public void ItemsInBag()
    {
        string yn;
        if (isOpen == true)
        {
            do
            {
                Console.WriteLine("введите номер предмета,который хотите достать");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y <= 7)
                {
                    Console.WriteLine($"вы достали {Item[y]}");
                }
                else
                {
                    Console.WriteLine("такой ячейки нет");
                }
                Console.WriteLine("хотите продолжить y/n?");
                yn=Console.ReadLine();
            } while (yn=="y");
        }
        Console.WriteLine("Сумка закрыта");
        Console.ReadLine();
        
    
    }    
    
    
}  