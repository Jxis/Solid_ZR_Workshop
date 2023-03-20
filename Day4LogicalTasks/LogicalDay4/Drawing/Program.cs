while(true) {
    Console.Write("Enter the number of rows in the pyramid: ");
    int numRows = int.Parse(Console.ReadLine());

    for (int i = 1; i <= numRows; i++)
    {
        // SPACES
        for (int j = 1; j <= numRows - i; j++)
        {
            Console.Write(" ");
        }

        // Leva strana piramide
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }

        //UVEK IMA 2 GAPP
        Console.Write("  ");

        // Desna strana piramide
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }
}











