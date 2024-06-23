class Program
{
    static void Main()
    {
        List<int> Enteros = new List<int>();
        Enteros.Add(10);
        Enteros.Add(20);
        Enteros.Add(30);
        Enteros.Add(40);
        Enteros.Add(50);
        Console.WriteLine(Enteros[0]);
        Console.WriteLine(Enteros[4]);
        Enteros.Remove(Enteros[2]);
        Console.WriteLine("Escriba un numero a buscar");
        int num = int.Parse(Console.ReadLine());
        if (Enteros.Contains(num))
        {
            Console.WriteLine("El numero se encuentra en la lista");
        }
        else
        {
            Console.WriteLine("El numero no se encuentra en la lista");
        }
    }
}
