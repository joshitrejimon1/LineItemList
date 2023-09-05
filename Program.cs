using System.Security.Cryptography.X509Certificates;

namespace LineItemList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<LineItem> items = new List<LineItem>
          { new LineItem(101,"MilkBikies",2,50),
            new LineItem(102, "Diary Milk", 2, 100),
            new LineItem(103, "Book", 3, 100)


          };
            PrintItems(items);






        }

        private static void PrintItems(List<LineItem> items)
        {
            double totalCartCost = 0;
            Console.WriteLine("===============order dertails==============");
            foreach (LineItem item in items)
            {
                Console.WriteLine(item.ToString());
                totalCartCost += item.ItemCost;

            }
            Console.WriteLine("==============");
            Console.WriteLine("total cart cost" + totalCartCost);
        }
    }
}
