namespace Modelos {

  class Familiar : Pessoa, IContato {

    public string Parentesco {get; set;}

    public override bool Validar(IContato contato) {
      return Pessoa.Verificar(contato);
    }

    public string Informar() {
      string informar = "Parentesco: " + this.Parentesco + "\n";
      foreach (IContato contato in this.contatos) {
        informar += contato.Informar();
      }
      return informar;
    }

  }

}
