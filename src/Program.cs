using CriandoUsuarios.Cadastro;

class Program{

 
    static void Main(){

    Cadastro cadastro = new(); //Instanciando a classe Cadastro para utilizar seu metodos.

    bool parada = true; //Condição para que o loop while comece a ser executado.

    while (parada){
    Console.WriteLine();
    Console.WriteLine("===============================================");
    Console.WriteLine(">>>>>>>>>> Escolha uma opção <<<<<<<<<<");    
    Console.WriteLine("Digite [1] para cadastrar um novo usuário");
    Console.WriteLine("Digite [2] para listar os usuários");
    Console.WriteLine("Digite [3] para pesquisar um usuário");
    Console.WriteLine("Digite [4] para sair");
    Console.WriteLine("===============================================");

    int opcao = int.Parse(Console.ReadLine());

        switch(opcao){ //Menu de opções para interação com o usuário. Cada "case" chama um metodo. 

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
        Console.WriteLine("====================");
        Console.WriteLine(">>> SAINDO... <<<");
        Console.WriteLine("====================");
        parada = false; //Ao receber o valor "false" o loop while para de ser executado
        break;

    }

 }
    
    }
}
