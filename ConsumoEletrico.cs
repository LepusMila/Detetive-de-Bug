using System;

class ConsumoEletrico
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Consumo Eletrico");

        Console.Write("Informe a potencia do aparelho em W: ");
        double potencia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Quantas horas por dia o aparelho fica ligado? ");
        double horasPorDia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Quantos dias no mes ele e usado? ");
        int dias = Convert.ToInt32(Console.ReadLine());

        Console.Write("Qual o valor do kWh na sua conta de luz? (ex: 0.95): R$ ");
        double precoKwh = Convert.ToDouble(Console.ReadLine());

        double consumoMensal = (potencia * horasPorDia * dias) / 100; // calculo correto
        double custo = consumoMensal * precoKwh;

       Console.WriteLine("\nRelatório de Consumo Elétrico:");
       Console.WriteLine($"Consumo mensal: {consumoMensal:F2} kWh (estimado)");
       Console.WriteLine($"Custo mensal: R$ {custo:F2} (aproximado)");
    }
}
