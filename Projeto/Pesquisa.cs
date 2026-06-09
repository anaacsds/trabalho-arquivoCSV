/* Implemente uma funcionalidade de pesquisa, onde o usuário poderá escolher um atributo da classe e
informar um valor para buscar todos os registros correspondentes. Essa busca deverá ser binária, com
os registros ordenados pelo método sort da lista

A pesquisa deve percorrer a lista e exibir os resultados encontrados. */

static void Pesquisar(List<Person> lista)
{
    if (lista.Count == 0)
    {
        Console.WriteLine("Lista vazia.");
        return;
    }

    Console.WriteLine("\nPesquisar por qual atributo?");
    Console.WriteLine("1. Index");
    Console.WriteLine("2. ID");
    Console.WriteLine("3. Primeiro Nome");
    Console.WriteLine("4. Sobrenome");
    Console.WriteLine("5. Sexo");
    Console.WriteLine("6. Email");
    Console.WriteLine("7. Telefone");
    Console.WriteLine("8. Data de Nascimento");
    Console.WriteLine("9. Cargo");
    Console.Write("Opcao: ");
    int opcao = int.Parse(Console.ReadLine());

    Console.Write("Digite o valor a buscar: ");
    string valor = Console.ReadLine(); 

}