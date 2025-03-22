using System;
public class Contrato : Documento{
    public string nome;
    public long cpf;
    public string texto;
    
    public Contrato(string nome, long cpf, string texto){
        this.nome = nome;
        this.cpf = cpf;
        this.texto = texto; 
        
    }
    
    public  Documento clone(){
        string nome = this.nome;
        long cpf = this.cpf;
        string texto = this.texto;
        
        Contrato contratoClone = new Contrato(nome, cpf, texto);
        return contratoClone;
    }
}