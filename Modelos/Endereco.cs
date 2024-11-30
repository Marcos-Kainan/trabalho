namespace Modelos{
  class Endereco: IContato{
    public string Local{get;set;}
    public string Postal{get;set;}
    
    public string Informar(){
      string informar ="LocaL:"+this.Local+"\n";
      informar += "Postal:"+this.Postal+"\n";
      return informar;
    }
  }
}