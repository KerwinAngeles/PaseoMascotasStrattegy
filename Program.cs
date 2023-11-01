using PaseoMascotas;

public class Program
{
    public static void Main(string[] args)
    {
        Contexto context= null;
        Console.Clear();

        Console.WriteLine("[C]CHIHUAHUA [L]LABRADOR [H]HUSKY-SIBERIANO");
        string opc = Console.ReadLine();  
        context = new Contexto(Fabrica.paseo(opc));
        context.EjecutaValorPaseo();
        Console.ReadKey();
        Main(args);

    }
}