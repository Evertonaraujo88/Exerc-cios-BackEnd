/* Nesta aula vamos aplicar o seguinte projeto para gerenciamento de passagens aéreas pelo console:

Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados:
1- Nome do passageiro
2 -Origem/Destino
3-Data do Voo de 5 passageiros.

*****Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à:
 123456

O sistema deve exibir um menu com as seguintes opções:

1- Cadastrar passagem
2- Listar Passagens
0- Sair

Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).
 */

 //Entreda
 // Acesso por senha
 // se correta "entra no sistema" se errada "digita novamente"

 //processamento
 // Menu: 1- Cadastrar passagem
        //2- Listar Passagens
        //0- Sair
 // entrar com (nome, origem, destino, data do voo) de 5 passageiros


//saida
//perguntar se deseja cadastrar uma nova passagem(s/N)


//Variaveis
int qtdCadastro = 2;
string [] nomes = new string [qtdCadastro] ;
string [] origens= new string [ qtdCadastro] ;
string [] destinos= new string [qtdCadastro] ;
string [] datasVoo= new string [qtdCadastro] ;

int senhaCorreta = 123456;


//Funcoes

 static void cadastroPassagem (string[] nomes, string[] origens, string[] destinos, string[] datasVoo)
 {
    for (int i = 0; i < nomes.Length; i++)
    {
        Console.WriteLine($"Digite o nome: ");
        nomes[i] = Console.ReadLine();

        Console.WriteLine($"Digite a origem do Voo: ");
        origens[i] = Console.ReadLine();
        
        Console.WriteLine($"Digite o destino do Voo: ");
        destinos[i] = Console.ReadLine();
        
        Console.WriteLine($"Digite a data do Voo: ");
        datasVoo[i] = Console.ReadLine();
        Console.WriteLine($"---------------------");
        
        
    }
    
        
 }
  Console.WriteLine($"Digite o nome do usuário: ");
string usuario = Console.ReadLine();

Console.WriteLine($"Digite sua senha: ");
int senhaDigitada = int.Parse(Console.ReadLine());

while (senhaDigitada != senhaCorreta )
{
    Console.WriteLine($"Senha inválida, digite novamente!!!");
    senhaDigitada= int.Parse(Console.ReadLine());
    
} 

char escolha;
do
{
    
Console.WriteLine(@$"
--------------------------------
***PROJETO PASSAGENS AEREAS***
--------------------------------
");

Console.WriteLine(@$"
-----------------------------------
|                                 |
| Escolha a opção que deseja:     |
|                                 |
| 1 - Cadastrar Passagem          |
| 2 - Listar Passagen             |
| 0 - Sair                        |
-----------------------------------
");

escolha = char.Parse(Console.ReadLine().ToUpper());

switch (escolha)
{
    case '1':
    string resposta;
    do
    {
        
    cadastroPassagem(nomes, origens, destinos, datasVoo);
    Console.WriteLine($"Gostaria de cadastrar uma nova passagem ? s/n");
    resposta = Console.ReadLine().ToLower();

    } while (resposta == "s");

    break;

    case '2':
    
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($@"
        -----------------
        Dados do Bilhete:
        -----------------
        ");
        Console.WriteLine(@$"
        Nome: {nomes[i]}
        Origem: {origens[i]}
        Destino: {destinos[i]}
        Data do Voo: {datasVoo[i]}
        ");
    }

    break;

    case '0':
    Console.WriteLine($"Até logo!! Obrigado por usar nossos serviços!!!");
    break;
    
    default:
    Console.WriteLine($"Opção inválida!!");
    break;
}
} while (escolha != '0');
