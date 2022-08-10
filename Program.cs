using System;

namespace Aula03 {
    class Program {
        static void Main(string[] args) {
            /*
            string usuario, senha;

            Console.WriteLine("Digite seu usário: ");
            usuario = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            senha = Console.ReadLine();

            if (usuario == "admin" && senha == "admin")
                Console.WriteLine("Acesso autorizado, bem vindo adm!!");
            else
                Console.WriteLine("Usuário ou senha inválidos\nAcesso negado!");
            */

            /*
            double totalCompras, valorFinal;
            string cupom;

            Console.WriteLine("Total da compra: ");
            totalCompras = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cupom de desconto: ");

            cupom = Console.ReadLine();

            if (totalCompras > 1000 || cupom == "desconto20")
                valorFinal = totalCompras - (totalCompras * 0.2);
            else
                valorFinal = totalCompras;

            Console.WriteLine("Valor final: R${0} ", valorFinal.ToString("0.00"));
            */

            string tipoUsuario;

            Console.WriteLine("Informe o tipo do usuario: ");
            tipoUsuario = Console.ReadLine();

            if (!(tipoUsuario == "Administrador"))
                Console.WriteLine("Atenção, usuário sem poderes administrativos. Algumas tarefas serão bloqueadas!");
            else
                Console.WriteLine("Seja muito bem vindo!");


            Console.ReadKey();
        }
    }
}
