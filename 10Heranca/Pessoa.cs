using System;

class Pessoa 
{
    // Protected é tipo um testamento, garantindo que só quem cria e quem herda podem usar
    protected string nome;
    protected int idade;
    public int id;
    protected void mensagemPessoa()
    {
        Console.WriteLine("Nome: "+nome);
        Console.WriteLine("Idade: "+idade);
    }

}