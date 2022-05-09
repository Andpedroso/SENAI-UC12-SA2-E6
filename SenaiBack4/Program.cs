// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SenaiBack4.Classes;

Console.WriteLine(@$"
=================================================
|       Bem vindo ao sistema de cadastro de     |
|           Pessoas Físicas e Jurídicas         |
=================================================
");

BarraCarregamento( "Carregando ", 500 );

string? opcao;

do
{
    Console.Clear();

    Console.WriteLine(@$"
    =================================================
    |       Escolha uma das opções abaixo           |
    |-----------------------------------------------|
    |       1 - Pessoa Física                       |
    |       2 - Pessoa Jurídica                     |
    |                                               |
    |       0 - Sair                                |
    =================================================
    ");

    opcao = Console.ReadLine(  );

    switch( opcao )
    {
        case "1":
            PessoaFisica metodoPf = new PessoaFisica();

            PessoaFisica novaPf = new PessoaFisica();

            Endereco novoEnd = new Endereco();

            novaPf.nome = "André";

            Console.WriteLine( "Nome: " + novaPf.nome );

            Console.WriteLine( $"Nome: {novaPf.nome}" );

            novaPf.nome = "André";

            novaPf.dataNascimento = "01/01/2000";

            novaPf.cpf = "123456789";

            novaPf.rendimento = 15000.5f;

            novoEnd.logradouro = "Alameda Barão de Limeira";

            novoEnd.numero = 539;

            novoEnd.complemento = "SENAI Informática";

            novoEnd.endComercial = true;

            novaPf.endereco = novoEnd;

            Console.WriteLine($"Nome: {novaPf.nome}");

            Console.WriteLine($"Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");

            Console.Clear();

            Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {(metodoPf.ValidarDataNascimento( novaPf.dataNascimento ) ? "Sim" : "Não" )}
Taxa de imposto a ser paga é: {metodoPf.PagarImposto(novaPf.rendimento).ToString("C")}
            ");

            Console.WriteLine($"Aperte 'Enter' para continuar");
            
            Console.ReadLine();

            break;

        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();

            PessoaJuridica novaPj = new PessoaJuridica();

            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Nome Pj";

            novaPj.cnpj = "00.000.000/0001-00";

            novaPj.razaoSocial = "Razão Social Pj";

            novaPj.rendimento = 8000.5f;

            novoEndPj.logradouro = "Alameda Barão de Limeira";

            novoEndPj.numero = 539;

            novoEndPj.complemento = "SENAI Informática";

            novoEndPj.endComercial = true;

            novaPj.endereco = novoEndPj;

            Console.Clear();

            Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ Válido: {(metodoPj.validarCnpj(novaPj.cnpj) ? "Sim" : "Não" )}
Taxa de imposto a ser paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
            ");

            Console.WriteLine($"Aperte 'Enter' para continuar");
            
            Console.ReadLine();

            break;
    
        case "0":
            Console.Clear();

            Console.WriteLine($"Obrigado por utilizar nosso sistema.");

            BarraCarregamento( "Desligando ", 100 );

            Console.Clear();

            break;
    
        default:
            Console.Clear();

            Console.WriteLine($"Opção inválida, por favor digite outra opção.");

            Thread.Sleep( 2000 );
            
            break;
    }
}

while( opcao != "0" );

static void BarraCarregamento( string texto, int tempo )
{
    Console.BackgroundColor = ConsoleColor.Green;

    Console.ForegroundColor = ConsoleColor.Red;

    Console.Write( $"{texto}" );

    for( var contador = 0; contador < 20; contador++ )
    {
        Console.Write( ". " );
        Thread.Sleep( tempo );
    }

    Console.ResetColor();
}