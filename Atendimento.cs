using System;
using System.Collections.Generic;

public class Atendimento
{
    private Queue<string> fila = new Queue<string>();

    public void AdicionarPessoa(string nome)
    {
        fila.Enqueue(nome);
        Console.WriteLine($"{nome} entrou na fila.");
    }

    public void ChamarProximo()
    {
        if (fila.Count > 0)
        {
            string pessoa = fila.Dequeue();
            Console.WriteLine($"Atendendo: {pessoa}");
        }
        else
        {
            Console.WriteLine("Fila vazia.");
        }
    }

    public void MostrarFila()
    {
        if (fila.Count == 0)
        {
            Console.WriteLine("Fila vazia.");
            return;
        }

        Console.WriteLine("\nFila atual:");

        foreach (string pessoa in fila)
        {
            Console.WriteLine($"- {pessoa}");
        }
    }

    public void Quantidade()
    {
        Console.WriteLine($"Pessoas aguardando: {fila.Count}");
    }
}