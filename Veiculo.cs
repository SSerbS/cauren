abstract class Veiculo{
    protected string modelo;
    public Veiculo(string modelo){
        this.modelo = modelo;
        
    }

    public abstract void Dirigir();
}