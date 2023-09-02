internal class Program
{
    public static void Main(string[] args)
    {

        int[] dizi={4,9,6,72,15,43,21};
        
        foreach (var sayi in dizi)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("SORT");
        Array.Sort(dizi);
        foreach (var sayi in dizi)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("CLEAR");
        Array.Clear(dizi,5,2);
        foreach (var sayi in dizi)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("REVERSE");
        Array.Reverse(dizi);
        foreach (var sayi in dizi)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("INDEXOF");
        Console.WriteLine(Array.IndexOf(dizi,21));

        Console.WriteLine("RESİZE");
        Array.Resize<int>(ref dizi,12);
        dizi[10]=54;
        foreach (var sayi in dizi)
        {
            Console.WriteLine(sayi);
        }
    }
}