using System;
class CalculaNumeroNaturais
protected void CalculaNumeroNaturais()

{
int valorSoma = 0;
int restoDivisao = 0;
for (int i = 1; i < 100; i++)
{
valorSoma += i;
}
Console.WriteLine(valorSoma);
}