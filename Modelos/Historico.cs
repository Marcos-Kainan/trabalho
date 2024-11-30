using System;
using System.Collections.Generic;

namespace Modelos {

  class Historico {
    private int faltas = 0;

    public Aluno Aluno {
      get; set;
    }

    public Turma Turma {
      get; set;
    }

    public List<double> notas = new List<double>();

    public int Faltas {
      get => this.faltas;
      set {
        if (value > 0) {
          this.faltas = value;
        }
      }
    }

    public double Soma {
      get {
        double soma = 0.0;
        foreach(double nota in notas) {
          soma += nota;
        }
        return soma;
      }
    }

    public bool Aprovado {
      get {
        return this.Soma >= 60.0 && this.Faltas < 10;
      }
    }

    public void Imprimir() {
      Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
      Console.WriteLine("Historico");
      Console.WriteLine("Nota final: " + this.Soma);
      Console.WriteLine("Faltas: " + this.Faltas);
      if(this.Aprovado) {
        Console.WriteLine("Aprovado");
      } else {
        Console.WriteLine("Reprovado");
      }
      Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
    }

  }

}