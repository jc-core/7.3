using static Assignment7_3.TextFuncs;
namespace Assignment7_3 {
    internal class Program {

        static void Main(string[] args) {

        startLoop:

            RunTree();

            Console.WriteLine();
            Console.WriteLine("...");
            Console.ReadKey(true);
            Console.Clear();

            goto startLoop;

        }

        static void RunTree() {

            Console.WriteLine("Whole numbers for the tree, separated by spaces.");
            int[] numbers = ReadNumbers("Numbers:");

            if (numbers.Length == 0) {
                Console.WriteLine("No input, try again.");
                return;
            }

            SearchTree tree = new();

            foreach (int number in numbers)
                if (!tree.Add(number))
                    Console.WriteLine($"{number} already in the tree, skipped.");

            Console.WriteLine($"In-order:   {string.Join(" ", tree.InOrder())}");
            Console.WriteLine($"Pre-order:  {string.Join(" ", tree.PreOrder())}");
            Console.WriteLine($"Post-order: {string.Join(" ", tree.PostOrder())}");

            int? target = ReadNumber("Number to find:");

            if (target == null) {
                Console.WriteLine("No input, try again.");
                return;
            }

            if (tree.Search(target.Value))
                Console.WriteLine($"{target} is in the tree.");
            else
                Console.WriteLine($"{target} is not in the tree.");

        }
    }
}
