namespace Bin2Dec
{
    class Conversor
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.WriteLine("================ Conversor ================");
            Console.WriteLine("1 - Para converter um binario para decimal");
            Console.WriteLine("2 - Para converter um decimal para binario");
            Console.WriteLine("0 - Para sair");
            short res = short.Parse(Console.ReadLine());
            switch (res)
            {
                case 1: BinarioDecimal(); break;
                case 2: DecimalBinario(); break;
                case 0: Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        static void BinarioDecimal()
        {
            Console.Clear();
            Console.WriteLine("==== Conversor Binario para Decimal ====");
            Console.WriteLine("Insira até 8 dígitos Binários, 0's e 1's");

            string bin = Console.ReadLine();
            string reverseString = string.Empty;
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                reverseString += bin[i];
            }

            long dec = Convert.ToInt64(reverseString, 2);
            Console.WriteLine($"O valor binário de {bin} em decimal é {dec}");
            Thread.Sleep(2500);
            Menu();
        }

        static void DecimalBinario()
        {
            Console.Clear();
            Console.WriteLine("==== Conversor Decimal para Binario ====");
            Console.WriteLine("========Insira uma valor decimal========");
            int numero = int.Parse(Console.ReadLine());
            string dec = numero.ToString();

            string bin = "";
            int resto;

            while (numero > 0)
            {
                resto = numero % 2;
                numero /= 2;
                bin = resto.ToString() + bin;
            }
            Console.WriteLine($"O valor Binário de {dec} é {bin.ToString()}");
            Thread.Sleep(2500);
            Menu();
        }
    }

}

