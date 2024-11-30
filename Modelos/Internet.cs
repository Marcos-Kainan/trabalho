namespace Modelos {

  class Internet : IContato {

    public string Link {get; set;}

    public string Informar() {
      string informar = "Link: " + this.Link + "\n";
      return informar;
    }

  }

}