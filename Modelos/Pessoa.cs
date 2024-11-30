using System;
using System.Collections.Generic;

namespace Modelos {

  abstract class Pessoa {

    private string cpf;

    public string Nome {
      get; set;
    }

    public List<IContato> contatos = new List<IContato>();

    public string Cpf {
      get => this.cpf;
      set {
        if (this.Validar(value)) {
          this.cpf = value;
        }
      }
    }

    public bool Validar(string cpf) {
      return true;
    }

    public static bool Verificar(IContato contato) {
      return !String.IsNullOrWhiteSpace(contato.Informar());
    }

    protected bool Examinar(IContato contato) {
      return Pessoa.Verificar(contato);
    }

    public virtual bool Investigar(IContato contato) {
      return this.Examinar(contato);
    }

    public abstract bool Validar(IContato contato);

  }

}