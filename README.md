# 💸 Calculadora Salarial com C#

> Um projeto prático para demonstrar domínio de sintaxe C#, estruturas condicionais e modularização.

Este repositório contém a solução para o desafio de cálculo de folha de pagamento, aplicando alíquotas de imposto progressivas baseadas no salário bruto.

## 🎯 O Desafio
Criar um programa que leia o salário bruto e os benefícios de um funcionário e calcule o valor líquido a ser transferido, seguindo a fórmula:

$$
\text{Salário Líquido} = (\text{Salário Bruto} - \text{Imposto}) + \text{Benefícios}
$$

### 📋 Regras de Negócio (Alíquotas de Imposto)

| Faixa Salarial (R$) | Alíquota de Imposto |
| :--- | :---: |
| De **0.00** a **1100.00** | **5.00%** |
| De **1100.01** a **2500.00** | **10.00%** |
| Maior que **2500.00** | **15.00%** |

## 🛠️ Tecnologias Utilizadas
* **C# (.NET 8.0)**: Linguagem principal.
* **Console Application**: Interface de entrada e saída.
* **Conceitos Aplicados**:
    * `TryParse` e `CultureInfo` para tratamento de entrada robusta.
    * Funções (`static void/double`) para separar responsabilidades (Clean Code).
    * Estruturas condicionais (`if/else`) para lógica de negócios.

## 🚀 Como Rodar

1. Clone o repositório:
   ```bash
   git clone [https://github.com/cleofasjunior/conhecendosintaxedoC-](https://github.com/cleofasjunior/conhecendosintaxedoC-)

2. Entre na pasta do código:
```bash
cd src

2. Execute o projeto:
```bash
dotnet run


🧪 Exemplo de Uso


Digite o valor bruto do salário: R$ 2000
Digite o valor adicional dos benefícios: R$ 250

--- 📊 Detalhamento ---
Salário Bruto:  R$ 2000.00
Imposto (10%): - R$ 200.00
Benefícios:   + R$ 250.00
-----------------------
💰 Salário a transferir: R$ 2050.00


Desenvolvido por Cleófas Júnior durante a jornada de transição para Engenharia de Software.