using System;
using System.Collections.Generic;

namespace Modelos {

    class Turma {

        private int semestre = 1;

        public int Ano {
            get; set;
        }

        public int Semestre {
            get => this.semestre;
            set {
                if (value >= 1 && value <= 2) {
                  this.semestre = value;
                }
            }
        }

        public List<Historico> historicos = new List<Historico>();

        public Professor Professor {
            get; set;
        }

        public Disciplina Disciplina {
            get; set;
        }

        public string Codigo {
            get => Disciplina.Codigo + this.Ano + this.Semestre;
        }

        public Historico Matricular(Aluno aluno) {
            if (aluno.Periodo == Disciplina.Periodo) {
                if (!this.historicos.Exists(grade => aluno.Matricula == grade.Aluno.Matricula)) {
                    Historico historico = new Historico();
                    historico.Aluno = aluno;
                    historico.Turma = this;
                    aluno.historicos.Add(historico);
                    this.historicos.Add(historico);
                    return historico;
                }
            }
            return null;
        }

        public bool Desmatricular(Aluno aluno) {
            Historico historico = this.historicos.Find(grade => aluno.Matricula == grade.Aluno.Matricula);
            if (historico != null) {
                aluno.historicos.Remove(historico);
                this.historicos.Remove(historico);
                return true;
            }
            return false;
        }

        public List<Historico> Aprovados {
            get => historicos.FindAll(historico => historico.Aprovado);
        }

        public List<Historico> Reprovados {
            get {
                List<Historico> reprovados = new List<Historico>();
                foreach(Historico historico in this.historicos) {
                    if (!historico.Aprovado) {
                        reprovados.Add(historico);
                    }
                }
                return reprovados;
            }
        }

        public double Media {
            get {
                double somas = 0.0;
                foreach(Historico historico in this.historicos) {
                    somas += historico.Soma;
                }
                if (this.historicos.Count > 0) {
                    return somas / this.historicos.Count;
                } else {
                    return somas;
                }
              }
        }

        public void Imprimir() {
            Console.WriteLine("#######################");
            Console.WriteLine("Turma");
            Console.WriteLine("Codigo: " + this.Codigo);
            this.Disciplina.Imprimir();
            this.Professor.Imprimir();
            Console.WriteLine("#######################");
        }

    }
}