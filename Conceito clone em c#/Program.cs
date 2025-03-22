public class GerenciadorDeDocumentos{
  static void Main(string[] args) {
    Relatorio rel = new Relatorio("Leonardo", 12345, "Ranquei fubá");
    Relatorio relclone = (Relatorio)rel.clone();
    Console.WriteLine($"Nome : {rel.nome}, Codigo : {rel.cod}, Texto : {rel.texto}");
    Console.WriteLine($"Nome Clone : {relclone.nome}, Codigo Clone : {relclone.cod}, Texto Clone : {relclone.texto}");
  
    Contrato cont = new Contrato("Henrique", 54321, "Vorta mula");
    Contrato contclone = (Contrato)cont.clone();
    Console.WriteLine($"Nome : {cont.nome}, Codigo : {cont.cpf}, Texto : {cont.texto}");
    Console.WriteLine($"Nome Clone : {contclone.nome}, Codigo Clone : {contclone.cpf}, Texto Clone : {contclone.texto}");
  }
}