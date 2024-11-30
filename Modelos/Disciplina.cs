using System;

namespace Modelos {

    class Disciplina {
      private string codigo;
      private string nome;
      private int periodo;

      public string Codigo {
        get => this.codigo;
        set {
          if(!String.IsNullOrWhiteSpace(value)) {
            this.codigo = value;
          }
        }
      }

      public string Nome {
        get => this.nome;
        set {
          if(!String.IsNullOrWhiteSpace(value)) {
            this.nome = value;
          }
        }
      }

      public int Periodo {
        get => this.periodo;
        set {
          if (value > 0) {
            this.periodo = value;
          } else {
            this.periodo = 1;
          }
        }
      }

      public void Imprimir() {
        Console.WriteLine("-----------------------");
        Console.WriteLine("Disciplina");
        Console.WriteLine("Codigo: " + this.Codigo);
        Console.WriteLine("Nome: " + this.Nome);
        Console.WriteLine("Periodo: " + this.Periodo);
        Console.WriteLine("-----------------------");
      }
    }

}