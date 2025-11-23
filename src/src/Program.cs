using System;
using System.Globalization;

namespace Desafio.Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("=== 💼 Sistema de Cálculo Salarial 💼 ===");

            // 1. Entrada de Dados
            Console.Write("Digite o valor bruto do salário: R$ ");
            double valorSalario = LerDouble();

            Console.Write("Digite o valor adicional dos benefícios: R$ ");
            double valorBeneficios = LerDouble();

            // 2. Processamento (Cálculo do Imposto)
            double valorImposto = CalcularImposto(valorSalario);
            
            // 3. Cálculo Final
            // Fórmula: (Valor Bruto - Imposto) + Benefícios
            double salarioLiquido = (valorSalario - valorImposto) + valorBeneficios;

            // 4. Saída de Dados
            Console.WriteLine("\n--- 📊 Detalhamento ---");
            Console.WriteLine($"Salário Bruto:  R$ {valorSalario.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Imposto ({ObterAliquota(valorSalario)}%): - R$ {valorImposto.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Benefícios:   + R$ {valorBeneficios.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"💰 Salário a transferir: R$ {salarioLiquido.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        // Função auxiliar para ler números sem quebrar com ponto/vírgula
        static double LerDouble()
        {
            // Tenta ler o input. Se for nulo, usa "0".
            string input = Console.ReadLine() ?? "0";
            
            // Tenta converter. Se der erro, retorna 0.
            if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double resultado))
            {
                return resultado;
            }
            return 0.0;
        }

        // Função pura que encapsula a Regra de Negócio do Imposto
        static double CalcularImposto(double salario)
        {
            double aliquota;

            if (salario >= 0 && salario <= 1100)
            {
                aliquota = 0.05; // 5%
            }
            else if (salario >= 1100.01 && salario <= 2500)
            {
                aliquota = 0.10; // 10%
            }
            else
            {
                aliquota = 0.15; // 15%
            }

            return salario * aliquota;
        }

        // Apenas para exibir a porcentagem na tela (Didática)
        static int ObterAliquota(double salario)
        {
            if (salario <= 1100) return 5;
            if (salario <= 2500) return 10;
            return 15;
        }
    }
}