using System;

class Program
{
    static void Main()
    {
        int adultosConsomemBebida = 0, adultosNaoConsomemBebida = 0, criancas = 0;

        Console.Write("Adultos (que consomem bebidas alcoólicas)".PadRight(50, '.') + ": ");
        adultosConsomemBebida = int.Parse(Console.ReadLine());

        Console.Write("Adultos (que não consomem bebidas alcoólicas)".PadRight(50, '.') + ": ");
        adultosNaoConsomemBebida = int.Parse(Console.ReadLine());

        Console.Write("Crianças".PadRight(50, '.') + ": ");
        criancas = int.Parse(Console.ReadLine());

        int totalAdultos = adultosConsomemBebida + adultosNaoConsomemBebida;

        double carneKg = (totalAdultos * 400 + criancas * 200) / 1000.0;
        double acompanhamentosKg = (totalAdultos + criancas) * 200 / 1000.0;
        double cervejaLitros = adultosConsomemBebida * 2.0;
        double refrigeranteLitros = (adultosNaoConsomemBebida + criancas) * 0.5;
        double aguaLitros = (totalAdultos + criancas) * 0.4;

        Console.WriteLine();
        Console.WriteLine("--- Churrasco ---\n");
        Console.WriteLine("Carne".PadRight(30, '.') + $": {carneKg:F1}kg");
        Console.WriteLine("Acompanhamentos".PadRight(30, '.') + $": {acompanhamentosKg:F1}kg");
        Console.WriteLine("Cerveja".PadRight(30, '.') + $": {cervejaLitros:F1}l");
        Console.WriteLine("Refrigerante".PadRight(30, '.') + $": {refrigeranteLitros:F1}l");
        Console.WriteLine("Água".PadRight(30, '.') + $": {aguaLitros:F1}l");
    }
}
