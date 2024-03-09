internal class Program
{
    private static void Main(string[] args)
    {
        Item item = new Item();

        Console.WriteLine("введите значение");
        string a = Console.ReadLine();
        item.SetName(a);

        
        Console.WriteLine($"Имя предмета: {item.GetName()}");
    }
   
}
public class Item()
{
    private string Name = "unkown";


    public void SetName(string newName)
    {

        Name= newName;
    }
    public string GetName()
    {
        return Name;
    }
}