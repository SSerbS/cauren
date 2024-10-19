Carro carro1 = new Carro("Kwid");
Moto moto1 = new Moto("yamaha");
Caminhao caminhao1 = new Caminhao("scania");

List<Veiculo> veiculos = new List<Veiculo>();
veiculos.Add(carro1);
veiculos.Add(moto1);
veiculos.Add(caminhao1);

foreach(Veiculo veic in veiculos){
    veic.Dirigir();
}