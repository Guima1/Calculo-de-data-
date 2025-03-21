using System;

namespace pessoa;
public class Pessoa{
    public string nome; // Use letras minúsculas para os campos
    public int idade;
    public double altura;
    DateTime dataAtual = DateTime.Now.Date;
    // Salvando uma data específica em uma variável
    DateTime datanamoro = new DateTime(2024, 05, 18); // Ano, Mês, Dia
    // Construtor para inicializar os campos
    public Pessoa(string nome, int idade, double altura){
        this.nome = nome; 
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