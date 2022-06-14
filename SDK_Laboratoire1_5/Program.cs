using LibrairieConversionNote;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;
        ConversionAlphabetiqueToNote conv = new ConversionAlphabetiqueToNote();

        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Note en anglais: {input}");
            Console.WriteLine($"Note en francais: {conv.Transformer(input)}");
            Console.WriteLine();
            row += 4;
        } while (true);
        return;

        // Reset locale tsé yo.
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue... Mais ou est le Anykey!!?");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Appuie <Enter> pour sortir, sinon, entre une note et appuie <Enter>:{Environment.NewLine}");
            row = 3;
        }
    }


}