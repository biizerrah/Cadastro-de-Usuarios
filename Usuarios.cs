namespace CriandoUsuarios 
{
public class Usuarios(string name, string email, int age) { 

    public string name = name, email = email;
    public int age = age;
}

} 


    /* A classe acima é o ponto de partida da aplicação. Ela molda a estrutura de criação de um novo usuário e é 
    instanciada na classe Cadastro. Escolhi essa estrutura para separar a lógica de criação de usuario (Usuarios.cs), 
    criação de metódos para a manipulação da lista de usuarios (Cadastro.cs) e a chamada de cada função, por um menu (Program.cs).
    */
