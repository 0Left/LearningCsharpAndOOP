using System;
class Imposto
{
    //Esse public poderia ser um protected em
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto padrão VA: R$" + (salario*0.1));
    }
    public void valeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrão VT: R$" + (salario*0.06));
    }
}