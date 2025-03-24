using System;
using System.Runtime;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public class GerenciadorDeTarefas{


    private List<Tarefa> _tarefas = new List<Tarefa>();
    public void AdicionarTarefa(string descricao){
        _tarefas.Add(new Tarefa(descricao));
        Console.WriteLine($"Tarefa '{descricao}' adicionada!");
    }

   public void ListarTarefas(){
       if(_tarefas.Count == 0){
        Console.WriteLine($"Nâo há tarefa cadastrada");
        return;
       }
       Console.WriteLine("\n--- Lista de Tarefas ---");
      for (int i = 0; i < _tarefas.Count; i++){
            Console.Write($"{i + 1}. ");
            _tarefas[i].Exibir();
        }
        Console.ReadLine();
    }
    
    public void MarcarComoConcluida(int indice){
        if (indice >= 0 && indice < _tarefas.Count)
        {
            _tarefas[indice] .Concluida = true;
            Console.WriteLine($"Tarefa '{_tarefas[indice].Descricao}' marcada como concluída!");
        }else{
            Console.WriteLine("Índice inválido! Tarefa não encontrada.");
        }
    }

    public void RemoverTarefa(int indice){
        if(indice >= 0 && indice < _tarefas.Count){
            string descricao = _tarefas[indice].Descricao;
            _tarefas.RemoveAt(indice);
            Console.WriteLine($"Nâo há tarefa cadastrada com esse indice");
        }
    }

    public bool TemTarefas() {
    return _tarefas.Any(); // Retorna true se houver tarefas
    }
}
