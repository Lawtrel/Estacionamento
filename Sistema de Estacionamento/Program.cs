using Sistema_de_Estacionamento.Models;

bool menu = true;
int opcao;
List<string> veiculos = [];

Console.WriteLine("Bem Vindo ao Estacionamento!");

Console.WriteLine("Digite o Preço inicial: ");
decimal preco = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Agora digite o Preço da hora: ");
decimal precoHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(preco, precoHora);


while (menu) {
    Console.Clear();
    Console.WriteLine("1 - Cadastrar Veiculo");
    Console.WriteLine("2 - Editar Veiculo");
    Console.WriteLine("3 - Listar Veiculos");
    Console.WriteLine("0 - Sair");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao) {
    case 0:
        Console.WriteLine("Fechando...");
        Environment.Exit(0);
        break;
    case 1:
        es.AdicionarVeiculo();
        break;

    case 2:
        es.RemoverVeiculo();
        break;
    
    case 3:
        es.ListarVeiculos();
        break;

    default:
        Console.WriteLine("Escolha uma opcao!");
         break;
}
}