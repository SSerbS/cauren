class Carro : Veiculo{
    public Carro(string modelo) : base(modelo){
    }

    public override void Dirigir(){
        Console.WriteLine($"Dirigindo carro do modelo {this.modelo}");
    }
}