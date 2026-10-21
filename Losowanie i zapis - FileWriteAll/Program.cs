class Program
{





    static void Main(string[] args)
    {

        int suma = 0;
        int srednia = 0;
        int[] wylosowane = new int[100];
        string lotto = "";
        string lotto1 = "";
        string lotto2 = "";
        string lotto3 = "";
        string lotto4 = "";

        Random losowa = new Random();
        for (int i = 0; i < wylosowane.Length; i++)
        {
            wylosowane[i] = losowa.Next(1, 1001);

            suma += wylosowane[i];
            lotto += wylosowane[i] + "\n";



        }
        suma.ToString();
        lotto1 += "Suma: " + suma + "\n";
        srednia = suma / 100;
        srednia.ToString();
        lotto2 += "Średnia: " + srednia + "\n"; 

        int min = wylosowane[0];
        int max = wylosowane[0];
        for (int i = 0; i < wylosowane.Length; i++)
        {
            if (wylosowane[i] < min)
            {
                min = wylosowane[i];
            }
            else if (wylosowane[i] > max)
            {
                max = wylosowane[i];
            }

        }
        min.ToString();
        lotto3 += "Min: " + min + "\n";
        max.ToString();
        lotto4 += "Max: " + max + "\n";
        try
        {
            File.WriteAllText("liczby.txt", lotto);
            File.AppendAllText("liczby.txt", lotto1);
            File.AppendAllText("liczby.txt", lotto2);
            File.AppendAllText("liczby.txt", lotto3);
            File.AppendAllText("liczby.txt", lotto4);
            string odczyt = File.ReadAllText("liczby.txt");
            Console.Write(odczyt);
        }
        catch (Exception)
        {
            Console.WriteLine("Wystąpił problem z obsługą pliku!");
        }

        //Console.WriteLine("Suma: " + suma);
       // Console.WriteLine("Średnia: " + srednia);
        //Console.WriteLine("Min: " + min);
        //Console.WriteLine("Max: " + max);
    }
}