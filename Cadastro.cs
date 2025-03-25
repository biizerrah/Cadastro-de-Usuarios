namespace CriandoUsuarios.Cadastro 

{
public class Cadastro
{
List<Usuarios> usuariosList = new(); 

public void NovoUsuario(){ 

    char parada;
    do {

        Console.WriteLine("Digite o nome que deseja cadastrar");
        string nome = Console.ReadLine().ToUpper(); 
        Console.WriteLine("Digite o email que deseja cadastrar");
        string e_mail = Console.ReadLine().ToUpper();
        Console.WriteLine("Digite a idade que deseja cadastrar");
        int idade = int.Parse(Console.ReadLine());

        Usuarios usuario = new(nome,e_mail,idade); 
        usuariosList.Add(usuario); 
        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("Usuário cadastrado com sucesso!");
        Console.WriteLine("=================================");
        Console.WriteLine();
        Console.WriteLine("==============================================================");
        Console.WriteLine("Deseja realizar mais um cadastro? [S] para sim e [N] para não");
        Console.WriteLine("==============================================================");

        parada = char.Parse(Console.ReadLine().Trim().ToUpper());  
    }

    while(parada != 'N');
   
}

public void ListarUsuarios() { 

    if(usuariosList.Count == 0){ 
        Console.WriteLine();
        Console.WriteLine(">>>>>>>>>>>>>>> Não há usuários cadastrados <<<<<<<<<<<<");
    } else {
        Console.WriteLine("=======================");
        Console.WriteLine("Usuários cadastrados");
        Console.WriteLine("=======================");
        foreach( var pessoa in usuariosList){ 
        Console.WriteLine($"Nome: {pessoa.name} E-mail: {pessoa.email} Idade: {pessoa.age}"); 
    }

    }
    
}

public void BuscarUsuario(){

    if(usuariosList.Count == 0){

        Console.WriteLine();
        Console.WriteLine(">>>>>>>>>>>>>>> Não há usuários cadastrados <<<<<<<<<<<<");

    } else {

        Console.WriteLine(); 
        Console.WriteLine("=====================================================================");
        Console.WriteLine(">>> Digite o nome que deseja consultar segundo a lista abaixo <<<");
        Console.WriteLine("=====================================================================");
        Console.WriteLine();
        foreach( var pessoa in usuariosList){
            Console.WriteLine($"NOME:{pessoa.name}");
     }

    string usuarioSelecionado = Console.ReadLine().ToUpper();
    var encontraUsuario = usuariosList.Find(usuario => usuario.name == usuarioSelecionado);
    
    if(encontraUsuario != null){

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

    public void MensagemSaida(){
        
        Console.WriteLine("====================");
        Console.WriteLine(">>> SAINDO... <<<");
        Console.WriteLine("====================");
    }

}

}