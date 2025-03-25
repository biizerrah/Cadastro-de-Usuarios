using CriandoUsuarios.Cadastro;

class Program{
    static Cadastro cadastro = new(); 
    static void Main(){

    int parada;

    do{
        Console.WriteLine();
        Console.WriteLine("===============================================");
        Console.WriteLine(">>>>>>>>>> Escolha uma opção <<<<<<<<<<");    
        Console.WriteLine("Digite [1] para cadastrar um novo usuário");
        Console.WriteLine("Digite [2] para listar os usuários");
        Console.WriteLine("Digite [3] para pesquisar um usuário");
        Console.WriteLine("Digite [4] para sair");
        Console.WriteLine("===============================================");
        parada = int.Parse(Console.ReadLine()); 

       MenuInicial(parada);

    } while(parada != 4);
    
    }

     public static void MenuInicial(int opcao){

        switch(opcao){ 

        case 1:
        cadastro.NovoUsuario();
        break;
        case 2:
        cadastro.ListarUsuarios();
        break;
        case 3:
        cadastro.BuscarUsuario();
        break;
        case 4:
        cadastro.MensagemSaida();
        break;
        default:
        Console.WriteLine(">> Opção Iválida! <<");
        break;
    }
    }
}
