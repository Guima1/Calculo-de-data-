public class Relatorio : Documento{
    public string nome;
    public long cod;
    public string texto;
    
    public Relatorio(string nome, long cod, string texto){
        this.nome = nome;
        this.cod = cod;
        this.texto = texto;
    }
    
    public Documento clone(){
        string nome = this.nome;
        long cod = this.cod;
        string texto = this.texto;
        
        Relatorio relatorioClone = new Relatorio(nome, cod, texto);
        return relatorioClone;
    }
}
