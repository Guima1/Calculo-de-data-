using System;

namespace main;
    public class Program{
        static void Main(string[] args){
            // Criando uma instância da struct Pessoa
            Pessoa pessoa1 = new Pessoa("Leonardo", 22, 1.92);
            // Acessando e exibindo os campos
            pessoa1.ExibirInfo();
            // Modificando os campos
            pessoa1.nome = "Talita";
            pessoa1.idade = 26;
            pessoa1.altura = 1.72;
            // Exibindo as informações atualizadas
            pessoa1.ExibirInfo();
            pessoa1.namoro();
            Console.ReadKey();           
        }
    }
