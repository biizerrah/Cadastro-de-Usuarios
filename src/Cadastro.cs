namespace CriandoUsuarios.Cadastro // Criando o namespace Cadastro, que usará informações do namespace CriandoUsuarios contidas na classe Usuarios.

{
public class Cadastro
{
List<Usuarios> usuariosList = new(); //Criando uma lista

public void NovoUsuario(){ //Esse metodo crian um novo usuário

    char parada = ' ';
    bool condicao = true;

   while(condicao){

    Console.WriteLine("Digite o nome que deseja cadastrar");
    string nome = Console.ReadLine().ToUpper(); //O ToUpper foi adicionado para padronizar a saida das palavras em maiusculo e evitar erros. 
    Console.WriteLine("Digite o email que deseja cadastrar");
    string e_mail = Console.ReadLine().ToUpper();
    Console.WriteLine("Digite a idade que deseja cadastrar");
    int idade = int.Parse(Console.ReadLine());

    Usuarios usuario = new(nome,e_mail,idade); //Instanciamento da classe Usuarios, adicionando os dados digitados pelo usuário
    usuariosList.Add(usuario); //Usuario adicionado
    Console.WriteLine();
    Console.WriteLine("=================================");
    Console.WriteLine("Usuário cadastrado com sucesso!");
    Console.WriteLine("=================================");
    Console.WriteLine();
    Console.WriteLine("==============================================================");
    Console.WriteLine("Deseja realizar mais um cadastro? [S] para sim e [N] para não");
    Console.WriteLine("==============================================================");

    parada = char.Parse(Console.ReadLine().Trim().ToUpper()); //Trim foi usado para evitar a leitura incorreta de espaços. Já que preciso apenas de uma letra.

    if(parada == 'N'){
    
        condicao = false;
    }

   }
}

public void ListarUsuarios() { //Metodo que lista as informações de todos os usuário.

    if(usuariosList.Count == 0){ //Verifico se há elementos na lista. Se estiver vazia o programa avisa ao usuario.
        Console.WriteLine();
        Console.WriteLine(">>>>>>>>>>>>>>> Não há usuários cadastrados <<<<<<<<<<<<");
    } else {
        Console.WriteLine("=======================");
        Console.WriteLine("Usuários cadastrados");
        Console.WriteLine("=======================");
        foreach( var pessoa in usuariosList){ //Se houver elementos, a lista é percorrida e as informações dos usuários são exibidas.
        Console.WriteLine($"Nome: {pessoa.name} E-mail: {pessoa.email} Idade: {pessoa.age}"); 
    }

    }
    
}

public void BuscarUsuario(){

    if(usuariosList.Count == 0){

        Console.WriteLine();
        Console.WriteLine(">>>>>>>>>>>>>>> Não há usuários cadastrados <<<<<<<<<<<<");

    } else {

        Console.WriteLine(); //Escolhi mostrar a lista de nomes, para que o usuário consulte e digite o nome corretamente.
        Console.WriteLine("=====================================================================");
        Console.WriteLine(">>> Digite o nome que deseja consultar segundo a lista abaixo <<<");
         Console.WriteLine("=====================================================================");
        Console.WriteLine();
        foreach( var pessoa in usuariosList){
            Console.WriteLine($"NOME:{pessoa.name}");
     }

    string usuarioSelecionado = Console.ReadLine().ToUpper();//Guarda o nome selecionado para procurar nas lista.
    var encontraUsuario = usuariosList.Find(usuario => usuario.name == usuarioSelecionado); //Procuro o usuario e se for encontrado ele retorna o objeto correspondente.
    
    if(encontraUsuario != null){ //Se for != null quer dizer que o usuário foi encontrado. Suas informações serão exibidas.

            Console.WriteLine("============================================================");
            Console.WriteLine($" >>> TODAS AS INFORMAÇÕES DE: {encontraUsuario.name} <<<");
            Console.WriteLine("============================================================");
            Console.WriteLine();
            Console.WriteLine($"Nome: {encontraUsuario.name}");
            Console.WriteLine($"Email:{encontraUsuario.email}");
            Console.WriteLine($"Idade:{encontraUsuario.age}");
    } else {
            Console.WriteLine();
            Console.WriteLine(">>>>> Usuario não consta na lista <<<<<");
         }
    }
   
    }

}

}