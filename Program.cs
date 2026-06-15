using System;

Atendimento atendimento = new Atendimento();

while (true)
{
    Console.WriteLine("\n===== SISTEMA DE FILA =====");
    Console.WriteLine("1 - Adicionar Pessoa");
    Console.WriteLine("2 - Chamar Próximo");
    Console.WriteLine("3 - Mostrar Fila");
    Console.WriteLine("4 - Quantidade");
    Console.WriteLine("5 - Sair");

    Console.Write("Escolha: ");
    string? opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("Nome: ");
            string? nome = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nome))
            {
                atendimento.AdicionarPessoa(nome);
            }
            break;

        case "2":
            atendimento.ChamarProximo();
            break;

        case "3":
            atendimento.MostrarFila();
            break;

        case "4":
            atendimento.Quantidade();
            break;

        case "5":
            return;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}