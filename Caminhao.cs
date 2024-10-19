class Caminhao : Veiculo{
    public Caminhao (string modelo) : base(modelo) {}

    public override void Dirigir()
    {
        Console.WriteLine($"Conduzindo o caminhão {this.modelo}");
    }
}