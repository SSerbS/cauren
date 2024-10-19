class Moto : Veiculo{
    public Moto(string modelo) : base(modelo){}

    public override void Dirigir()
    {
        Console.WriteLine($"Pilotando a moto {this.modelo}");
    }
}