class Program
{
    static void Main(string[] args)
    {
        int row = 0;
        string noteAnglais;

        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Note En Francais: {input}");

            if (input == "La")
                noteAnglais = "A";
            else if (input == "Si")
                noteAnglais = "B";
            else if (input == "Do")
                noteAnglais = "C";
            else if (input == "Re")
                noteAnglais = "D";
            else if (input == "Mi")
                noteAnglais = "E";
            else if (input == "Fa")
                noteAnglais = "F";
            else if (input == "Sol")
                noteAnglais = "G";
            else
                noteAnglais = "Z";

            Console.WriteLine($"Note En Anglais: {noteAnglais}");
            //Console.WriteLine("Note En Anglais" +
            //     $"{(input.StartsWithUpper() ? "Ouaip" : "Nan")}");
            Console.WriteLine();
            row += 4;
        } while (true);
        return;

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue... mais ou est le Anykey!!?");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Appuie <Enter> pour sortir, sinon une note en francais et <Enter>:{Environment.NewLine}");
            row = 3;
        }
    }
}