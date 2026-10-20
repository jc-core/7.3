namespace Assignment7_3 {
    internal class TextFuncs {

        internal static int[] ReadNumbers(string prompt) {

            while (true) {

                Console.Write($"{prompt} ");
                string? line = Console.ReadLine();

                if (line == null)
                    return new int[0];

                string[] pieces = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (pieces.Length == 0) {
                    Console.WriteLine("Can't be blank, try again.");
                    continue;
                }

                int[] numbers = new int[pieces.Length];
                bool parsed = true;

                for (int spot = 0; spot < pieces.Length; spot++) {
                    if (!int.TryParse(pieces[spot], out int value)) {
                        parsed = false;
                        break;
                    }
                    numbers[spot] = value;
                }

                if (parsed)
                    return numbers;

                Console.WriteLine("Whole numbers only, separated by spaces, try again.");

            }
        }

        internal static int? ReadNumber(string prompt) {

            while (true) {

                Console.Write($"{prompt} ");
                string? line = Console.ReadLine();

                if (line == null)
                    return null;

                if (int.TryParse(line, out int value))
                    return value;

                Console.WriteLine("One whole number only, try again.");

            }
        }
    }
}
