using System;

class PF : Padrao
{
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa para Pessoa Fisica R$" +(valor*0.1));
    }
}