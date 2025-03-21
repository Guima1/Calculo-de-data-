using System;

// Definição da struct
struct Pessoa{
    public string nome; // Use letras minúsculas para os campos
    public int idade;
    public double altura;
    DateTime dataAtual = DateTime.Now.Date;
    // Salvando uma data específica em uma variável
    DateTime datanamoro = new DateTime(2024, 05, 18); // Ano, Mês, Dia
    // Construtor para inicializar os campos
    public Pessoa(string nome, int idade, double altura){
        this.nome = nome; // Use "this" para referenciar os campos da struct
        this.idade = idade;
        this.altura = altura;
    }
    // Método para exibir informações da pessoa
    public void ExibirInfo(){
        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {altura}");
    }
    public void namoro(){
        Console.WriteLine($"Data de hoje: {dataAtual}");
        Console.WriteLine($"Data que começamos a namorar: {datanamoro}");
        TimeSpan tempojuntos = dataAtual - datanamoro;
        int dias = tempojuntos.Days;
        int anos = dias / 365; // Aproximação para anos
        int meses = (dias % 365) / 30; // Aproximação para meses
       /* double horas = tempojuntos.TotalHours;
        double minutos = tempojuntos.TotalMinutes;
        double segundos = tempojuntos.TotalSeconds;
       */ 

        Console.WriteLine($"Tempo de namoro:{anos} anos, {meses} meses e {dias % 30} dias");
        //Console.WriteLine($"{dias} dias, {horas} horas, {minutos} minutos e {segundos} segundos");
    }
}

namespace apresenta{
    class Program{
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
}