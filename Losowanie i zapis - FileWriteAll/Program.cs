class Program
{





    static void Main(string[] args)
    {
       
        int suma = 0;
        int srednia = 0;
        int[] wylosowane = new int[101];
        string lotto = "";
        string lotto1 = "";

        Random losowa = new Random();
        for (int i = 0; i < wylosowane.Length; i++)
        {
            wylosowane[i] = losowa.Next(0, 1001);
            
            suma += wylosowane[i];
            lotto += wylosowane[i] + "\n";
           
        }

        srednia = suma / 100;
        
        int min = wylosowane[0];
        int max = wylosowane[0];
        for(int i = 0; i < wylosowane.Length; i++)
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
        File.WriteAllText("liczby.txt",lotto);
        string odczyt = File.ReadAllText("liczby.txt");
        Console.Write(odczyt);
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Średnia: " + srednia);
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Max: " + max);
    }
}