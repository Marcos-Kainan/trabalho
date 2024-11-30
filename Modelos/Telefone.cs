namespace Modelos {

  class Telefone : IContato {

    public string Numero {get; set;}

    public string Informar() {
      string informar = "Numero: " + this.Numero + "\n";
      return informar;
    }

  }

}