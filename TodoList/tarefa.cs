using System;

    public class Tarefa{
        public string Descricao {get;set;}
        public Boolean Concluida {get; set;}
//construtor  de tarefas
        public Tarefa(string descricao){
            Descricao = descricao;
            Concluida = false;
        }
        public void Exibir(){
             string status = Concluida ? "[X]" : "[ ]";
            Console.WriteLine($"{status} {Descricao}");
        }
    }
