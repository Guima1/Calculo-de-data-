using System;
using System.Security.Cryptography.X509Certificates;

public class Program{
    
  static void Main(string[] args) {
    GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();
    while(true){
            Console.Clear();
            Console.WriteLine("=== TO-DO LIST ===");
            Console.WriteLine("\n1. Adicionar Tarefa");
            Console.WriteLine("2. Listar Tarefas");
            Console.WriteLine("3. Marcar Tarefa como Concluída");
            Console.WriteLine("4. Remover Tarefa");
            Console.WriteLine("5. Sair");       
            Console.Write("\nEscolha uma opção: ");
            string? opcao = Console.ReadLine();
            switch (opcao){
                case "1": // Adicionar
                    Console.Write("\nDigite a descrição da tarefa: ");
                    string? descricao = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(descricao)){
                        gerenciador.AdicionarTarefa(descricao);
                    }else{
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Descrição inválida!");
                        Console.ResetColor();
                    }
                    break;

                case "2": // Listar
                    gerenciador.ListarTarefas();
                    break;

                case "3": // Marcar como concluída
                    gerenciador.ListarTarefas();
                    if (gerenciador.TemTarefas()){
                        Console.Write("\nDigite o número da tarefa concluída: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceConcluir) && indiceConcluir > 0){
                            gerenciador.MarcarComoConcluida(indiceConcluir - 1); // Ajusta para índice interno
                        }else{
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Número inválido!");
                            Console.ResetColor();
                        }
                    }
                    break;

                case "4": // Remover
                    gerenciador.ListarTarefas();
                    if (gerenciador.TemTarefas()){
                        Console.Write("\nDigite o número da tarefa a remover: ");
                        if (int.TryParse(Console.ReadLine(), out int indiceRemover) && indiceRemover > 0){
                            gerenciador.RemoverTarefa(indiceRemover - 1);
                        }
                        else{
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Número inválido!");
                            Console.ResetColor();
                        }
                    }
                    break;

                case "5": // Sair
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nAté logo! Pressione qualquer tecla para sair...");
                    Console.ResetColor();
                    Console.ReadKey();
                    return;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    Console.ResetColor();
                    break;
            }
        }
    }
  }

