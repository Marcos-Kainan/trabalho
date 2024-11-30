using Modelos;
using System;
using System.Collections.Generic;

class Aula7 {

  private static List<Familiar> familiares = new List<Familiar>();
  
  private static List<Aluno> alunos = new List<Aluno>();

  private static List<Turma> turmas = new List<Turma>();

  private static List<Professor> professores = new List<Professor>();

  private static List<Disciplina> disciplinas = new List<Disciplina>();
  /*parte criada no trabalho:
  editar e adicionar cpf foram criados;
  editarcontatos criados para aluno e professor(funções não criadas);
   */
  private static void  EditarContatosProfessor( Professor professor){
    int opcao = 0;
    do{
      Console.WriteLine("Menu Contatos do Professor");
      Console.WriteLine("0-Voltar para o menu ");
      Console.WriteLine("1-Editar Cpf");
      Console.WriteLine("2-Editar Telefone");
      Console.WriteLine("3-Editar Email");
      Console.WriteLine("4-Editar Endereço");
      Console.WriteLine("5- Imprimir dados do Contato");
      Console.WriteLine("Digite uma das Opções");
      opcao = int.Parse(Console.ReadLine());
      switch(opcao) {
        case 1:
        Console.WriteLine("Digite o novo cpf");
        professor.Cpf = Console.ReadLine();
        break;
        case 2:
        Telefone telefone3 = new Telefone();
        Console.WriteLine ("Digite o telefone do professor:");
        telefone3.Numero = Console.ReadLine();
        professor.contatos.Add(telefone3);
        Console.WriteLine ("Numero editado com sucesso!");
        break;
      case 3:
        Internet internet3 = new Internet();
            Console.WriteLine ("Digite o email do professor:");
            internet3.Link = Console.ReadLine();
            professor.contatos.Add(internet3);
            Console.WriteLine ("Email editado com sucesso!");
            break;
        case 4:
          Endereco endereco3 = new Endereco();
          Console.WriteLine ("Digite o endereço do professor:");
          endereco3.Local = Console.ReadLine();
          Console.WriteLine ("Digite o postal do professor");
          endereco3.Postal = Console.ReadLine();
          professor.contatos.Add(endereco3);
          Console.WriteLine ("Endereço editado com sucesso!");
          break;
      case 5:
        Console.WriteLine("Nome do Professor:" +professor.Nome);
        Console.WriteLine("Cpf do Professor:" + professor.Cpf);
        professor.contatos[0].Informar(); // numeero
        professor.contatos[1].Informar(); // link
        professor.contatos[2].Informar(); // Endereço
        break; 
        }   
    }while (opcao > 0);
    
  }

  private static void EditarContatosAluno(Aluno aluno) {
    int opcao = 0;
    do{
      Console.WriteLine("Menu Contatos");
      Console.WriteLine("0-Voltar para o menu ");
      Console.WriteLine("1-Editar Contato do Alunos");
      Console.WriteLine("2-Editar Contatos do Responsavel");
      opcao = int.Parse(Console.ReadLine());
      switch(opcao) {
        case 1:
        do{
          Console.WriteLine("Menu Contatos do Aluno");
          Console.WriteLine("0 - Voltar para o menu ");
          Console.WriteLine("1 - Editar o Nome do Aluno");
          Console.WriteLine("2 - Editar Cpf do Aluno");
          Console.WriteLine("3 - Editar Telefone do aluno");
          Console.WriteLine("4 - Editar Email do aluno");
          Console.WriteLine("5 - Editar Endereço do aluno");
          Console.WriteLine("6 - Imprimir dados do Contato do aluno");
          Console.WriteLine("Digite uma das Opções");
          opcao = int.Parse(Console.ReadLine());
          switch(opcao) {
            case 1:
            Console.WriteLine ("Digite o nome do aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine ("Nome editado com sucesso!");
            break;
            case 2:
            Console.WriteLine("Digite o novo cpf");
            aluno.Cpf = Console.ReadLine();
            break;
          case 3:
            Telefone telefone = new Telefone();
            Console.WriteLine ("Digite o telefone do aluno:");
            telefone.Numero = Console.ReadLine();
            aluno.contatos.Add(telefone);
            Console.WriteLine ("Numero editado com sucesso!");
            break;
          case 4:
            Internet internet = new Internet();
                Console.WriteLine ("Digite o email do aluno:");
                internet.Link = Console.ReadLine();
                aluno.contatos.Add(internet);
                Console.WriteLine ("Email editado com sucesso!");
                break;
          case 5:
            Endereco endereco = new Endereco();
            Console.WriteLine ("Digite o endereço do aluno:");
            endereco.Local = Console.ReadLine();
            Console.WriteLine ("Digite o postal do aluno:");
            endereco.Postal = Console.ReadLine();
            aluno.contatos.Add(endereco);
            Console.WriteLine ("Endereço editado com sucesso!");
            break;
          case 6:
              Console.WriteLine("Nome do aluno:" + aluno.Nome);
              Console.WriteLine("Cpf do aluno:" + aluno.Cpf);
              aluno.contatos[0].Informar(); // numeero
              aluno.contatos[1].Informar(); // link
              aluno.contatos[2].Informar(); // Endereço
            break;
          }
        }while(opcao > 0);
        break;
        
      case 2:
        do{
            Console.WriteLine("Menu Editar Parente");
            Console.WriteLine ("1- Editar o Nome do Responsavel");
            Console.WriteLine ("2 - Editar o Telefone do Responsavel");
            Console.WriteLine ("3 - Editar o Email do Responsavel");
            Console.WriteLine ("4 - Editar o Endereço do Responsavel");
            Console.WriteLine ("5 - Imprimir dados do Contato do responsavel");
            opcao = int.Parse(Console.ReadLine());
          switch(opcao){
            case 1:
            Console.WriteLine ("Digite o nome do responsavel:");
            aluno.Familiar.Nome = Console.ReadLine();
            
            Console.WriteLine ("Digite o parentesco do aluno e responsavel:");
            aluno.Familiar.Parentesco = Console.ReadLine();
            Console.WriteLine ("Parentesco editado com sucesso!");
            break;
            case 2:
            Telefone telefone2 = new Telefone();
            Console.WriteLine ("Digite o telefone do responsavel:");
            telefone2.Numero = Console.ReadLine();
            aluno.Familiar.contatos.Add(telefone2);
            break;
            case 3:
            Internet internet2 = new Internet();
            Console.WriteLine ("Digite o email do Responsavel:");
            internet2.Link = Console.ReadLine();
            aluno.contatos.Add(internet2);
            break;
            case 4 :
            Endereco endereco2 = new Endereco();
            Console.WriteLine ("Digite o endereço do responsavel:");
            endereco2.Local = Console.ReadLine();
            Console.WriteLine ("Digite o postal do responsavel:");
            endereco2.Postal = Console.ReadLine();
            aluno.Familiar.contatos.Add(endereco2);
            break;
          case 5:
              Console.WriteLine("parentesco do Responsavel:"+aluno.Familiar.Parentesco);
              Console.WriteLine("Nome do Responsavel:" + aluno.Familiar.Nome);
              Console.WriteLine("Cpf do Responsavel:" + aluno.Familiar.Cpf);
              aluno.Familiar.contatos[0].Informar(); // numeero
              aluno.Familiar.contatos[1].Informar(); // link
              aluno.Familiar.contatos[2].Informar(); // Endereço
              break;
          }
        }while (opcao > 0);
        break; 
        }   
    }while (opcao > 0);
    }

 
    
   private static void AdicionarAluno() {
    Aluno aluno = new Aluno();
    Console.WriteLine ("Digite a matricula do aluno:");
    aluno.Matricula = Console.ReadLine();
    if (!alunos.Exists(estudante => estudante.Matricula == aluno.Matricula)) {
      Console.WriteLine ("Digite o nome do aluno:");
      aluno.Nome = Console.ReadLine();
      alunos.Add(aluno);
      Console.WriteLine ("Aluno adicionado com sucesso!");
    } else {
      Console.WriteLine ("Matricula já existente!");
    }
  }

  private static Aluno PesquisarAluno() {
    Console.WriteLine ("Digite a matricula do aluno:");
    string matricula = Console.ReadLine();
    return alunos.Find(estudante => estudante.Matricula == matricula);
  }

  private static void EditarAluno() {
    Aluno aluno = PesquisarAluno();
    if (aluno != null) {
      int opcao = 0;
      do {
        Console.WriteLine ("Digite a opcao:");
        Console.WriteLine ("0 - Voltar ao Menu de Aluno");
        Console.WriteLine ("1 - Editar Nome do Aluno");
        Console.WriteLine ("2 - Editar Periodo do Aluno");
        Console.WriteLine ("3 - Editar Contatos ");
        opcao = int.Parse(
          Console.ReadLine()
        );
        switch(opcao) {
          case 1:
            Console.WriteLine ("Digite o nome do aluno:");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine ("Nome editado com sucesso!");
            break;
        case 2:
            Console.WriteLine ("Digite o periodo do aluno:");
            aluno.Periodo = int.Parse(
              Console.ReadLine()
            );
            Console.WriteLine ("Periodo editado com sucesso!");
            break;
        case 3:
            EditarContatosAluno(aluno);
            break;      
          default:
            break;
        }
      } while (opcao > 0);
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void RemoverAluno() {
    Aluno aluno = PesquisarAluno();
    if (aluno != null) {
      if (aluno.historicos.Count == 0) {
        alunos.Remove(aluno);
        Console.WriteLine ("Aluno removido com sucesso!");
      } else {
        Console.WriteLine ("Desmatricule o aluno das turmas!");
      }
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void ImprimirAlunos() {
    foreach (Aluno aluno in alunos) {
      aluno.Imprimir();
    }
  }

  private static void ImprimirAlunoSelecionado() {
    Aluno aluno = PesquisarAluno();
    if (aluno != null) {
      aluno.Imprimir();
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void AdicionarNotaDoAluno() {
    Turma turma = PesquisarTurma();
    if (turma != null) {
      Aluno aluno = PesquisarAluno();
      if (aluno != null) {
        Historico historico = turma.historicos.Find(grade => aluno.Matricula == grade.Aluno.Matricula);
        if (historico != null) {
          Console.WriteLine ("Digite a nota do aluno:");
          historico.notas.Add(int.Parse(
            Console.ReadLine()
          ));
          Console.WriteLine ("Nota adicionada com sucesso!");
        } else {
          Console.WriteLine ("Aluno não matriculado!");
        }
      } else {
        Console.WriteLine ("Matricula não existente!");
      }
    } else {
      Console.WriteLine ("Turma não existente!");
    }
  }

  private static void AdicionarFaltaDoAluno() {
    Turma turma = PesquisarTurma();
    if (turma != null) {
      Aluno aluno = PesquisarAluno();
      if (aluno != null) {
        Historico historico = turma.historicos.Find(grade => aluno.Matricula == grade.Aluno.Matricula);
        if (historico != null) {
          Console.WriteLine ("Digite as faltas do aluno:");
          historico.Faltas = int.Parse(
            Console.ReadLine()
          );
          Console.WriteLine ("Faltas adicionadas com sucesso!");
        } else {
          Console.WriteLine ("Aluno não matriculado!");
        }
      } else {
        Console.WriteLine ("Matricula não existente!");
      }
    } else {
      Console.WriteLine ("Turma não existente!");
    }
  }

  private static void AdicionarTurma() {
    Turma turma = new Turma();
    Console.WriteLine ("Digite o ano da turma:");
    turma.Ano = int.Parse(
      Console.ReadLine()
    );
    Console.WriteLine ("Digite o semestre da turma (1 ou 2):");
    turma.Semestre = int.Parse(
      Console.ReadLine()
    );
    turma.Disciplina = PesquisarDisciplina();
    if (!turmas.Exists(classe => turma.Codigo == classe.Codigo)) {
      turma.Professor = PesquisarProfessor();
      turmas.Add(turma);
      Console.WriteLine ("Turma adicionada com sucesso!");
    } else {
      Console.WriteLine ("Turma já existente!");
    }
  }

  private static Turma PesquisarTurma() {
    Turma turma = new Turma();
    Console.WriteLine ("Digite o ano da turma:");
    turma.Ano = int.Parse(
      Console.ReadLine()
    );
    Console.WriteLine ("Digite o semestre da turma (1 ou 2):");
    turma.Semestre = int.Parse(
      Console.ReadLine()
    );
    turma.Disciplina = PesquisarDisciplina();
    return turmas.Find(classe => turma.Codigo == classe.Codigo);
  }

  private static void EditarTurma() {
    Turma turma = PesquisarTurma();
    if (turma != null) {
      int opcao = 0;
      do {
        Console.WriteLine ("Digite a opcao:");
        Console.WriteLine ("0 - Voltar ao Menu de Turma");
        Console.WriteLine ("1 - Editar Ano da Turma");
        Console.WriteLine ("2 - Editar Semestre da Turma");
        Console.WriteLine ("3 - Alterar Professor da Turma");
        Console.WriteLine ("4 - Alterar Disciplina da Turma");
        opcao = int.Parse(
          Console.ReadLine()
        );
        switch(opcao) {
          case 1:
            Console.WriteLine ("Digite o ano da turma:");
            turma.Ano = int.Parse(
              Console.ReadLine()
            );
            Console.WriteLine ("Ano editado com sucesso!");
            break;
          case 2:
            Console.WriteLine ("Digite o semestre da turma:");
            turma.Semestre = int.Parse(
              Console.ReadLine()
            );
            Console.WriteLine ("Semestre editado com sucesso!");
            break;
          case 3:
            turma.Professor = PesquisarProfessor();
            Console.WriteLine ("Professor alterado com sucesso!");
            break;
          case 4:
            turma.Disciplina = PesquisarDisciplina();
            Console.WriteLine ("Disciplina alterada com sucesso!");
            break;
          default:
            break;
        }
      } while (opcao > 0);
    } else {
      Console.WriteLine ("Turma não existente!");
    }
  }

  private static void RemoverTurma() {
    Turma turma = PesquisarTurma();
    if (turma != null) {
      if (turma.historicos.Count == 0) {
        turmas.Remove(turma);
        Console.WriteLine ("Turma removida com sucesso!");
      } else {
        Console.WriteLine ("Desmatricule os alunos da turma!");
        int opcao = 0;
        do {
          Console.WriteLine ("Digite a opcao:");
          Console.WriteLine ("0 - Voltar ao Menu de Turma");
          Console.WriteLine ("1 - Desmatricular todos os alunos da turma");
          opcao = int.Parse(
            Console.ReadLine()
          );
          switch(opcao) {
            case 1:
              foreach(Historico historico in turma.historicos) {
                turma.Desmatricular(historico.Aluno);
              }
              Console.WriteLine ("Alunos desmatriculados com sucesso!");
              break;
            default:
              break;
          }
        } while (opcao > 0);
      }
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void ImprimirTurmas() {
    foreach (Turma turma in turmas) {
      turma.Imprimir();
    }
  }

  private static void ImprimirTurmaSelecionada() {
    Turma turma = PesquisarTurma();
    if (turma != null) {
      turma.Imprimir();
    } else {
      Console.WriteLine ("Turma não existente!");
    }
  }

  private static void ImprimirAprovadosDaTurma() {
    Turma turma = PesquisarTurma();
    if (turma != null) {
      foreach(Historico historico in turma.Aprovados) {
        Console.WriteLine(historico.Aluno.Matricula + " - " + historico.Aluno.Nome);
      }
    } else {
      Console.WriteLine ("Turma não existente!");
    }
  }

  private static void ImprimirReprovadosDaTurma() {
    Turma turma = PesquisarTurma();
    if (turma != null) {
      foreach(Historico historico in turma.Reprovados) {
        Console.WriteLine(historico.Aluno.Matricula + " - " + historico.Aluno.Nome);
      }
    } else {
      Console.WriteLine ("Turma não existente!");
    }
  }

  private static void ImprimirMediaDaTurma() {
    Turma turma = PesquisarTurma();
    if (turma != null) {
      Console.WriteLine("Turma: " + turma.Codigo);
      Console.WriteLine("Media: " + turma.Media);
    } else {
      Console.WriteLine ("Turma não existente!");
    }
  }

  private static void ImprimirHistoricoDoAlunoEmTurma() {
    Turma turma = PesquisarTurma();
    if (turma != null) {
      Aluno aluno = PesquisarAluno();
      if (aluno != null) {
        Historico historico = turma.historicos.Find(grade => aluno.Matricula == grade.Aluno.Matricula);
        if (historico != null) {
          historico.Imprimir();
        } else {
          Console.WriteLine ("Aluno não matriculado!");
        }
      } else {
        Console.WriteLine ("Matricula não existente!");
      }
    } else {
      Console.WriteLine ("Turma não existente!");
    }
  }

  private static void MatricularAlunoEmTurma() {
    Turma turma = PesquisarTurma();
    if (turma != null) {
      Aluno aluno = PesquisarAluno();
      if (aluno != null) {
        if (turma.Matricular(aluno) != null) {
          Console.WriteLine ("Aluno matriculado com sucesso!");
        } else {
          Console.WriteLine ("Não foi possível matricular o aluno!");
        }
      } else {
        Console.WriteLine ("Matricula não existente!");
      }
    } else {
      Console.WriteLine ("Turma não existente!");
    }
  }

  private static void DesmatricularAlunoEmTurma() {
    Turma turma = PesquisarTurma();
    if (turma != null) {
      Aluno aluno = PesquisarAluno();
      if (aluno != null) {
        if(turma.Desmatricular(aluno)) {
          Console.WriteLine ("Aluno desmatriculado com sucesso!");
        } else {
          Console.WriteLine ("Não foi possível desmatricular o aluno!");
        }
      } else {
        Console.WriteLine ("Matricula não existente!");
      }
    } else {
      Console.WriteLine ("Turma não existente!");
    }
  }

  private static void AdicionarProfessor() {
    Professor professor = new Professor();
    Console.WriteLine ("Digite a matricula do professor:");
    professor.Matricula = Console.ReadLine();
    if (!professores.Exists(docente => docente.Matricula == professor.Matricula)) {
      Console.WriteLine ("Digite o nome do professor:");
      professor.Nome = Console.ReadLine();
      professores.Add(professor);
      Console.WriteLine ("Professor adicionado com sucesso!");
    } else {
      Console.WriteLine ("Matricula já existente!");
    }
  }

  private static Professor PesquisarProfessor() {
    Console.WriteLine ("Digite a matricula do professor:");
    string matricula = Console.ReadLine();
    return professores.Find(docente => docente.Matricula == matricula);
  }

  private static void EditarProfessor() {
    Professor professor = PesquisarProfessor();
    if (professor != null) {
      int opcao = 0;
      do {
        Console.WriteLine ("Digite a opcao:");
        Console.WriteLine ("0 - Voltar ao Menu de Professor");
        Console.WriteLine ("1 - Editar Nome do Professor");
        Console.WriteLine ("2 - Editar Contatos do Professor");
        opcao = int.Parse(
          Console.ReadLine()
        );
        switch(opcao) {
          case 1:
            Console.WriteLine ("Digite o nome do professor:");
            professor.Nome = Console.ReadLine();
            Console.WriteLine ("Nome editado com sucesso!");
            break;
        case 2:
         EditarContatosProfessor(professor);
          break;
          default:
            break;
        }
      } while (opcao > 0);
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void RemoverProfessor() {
    Professor professor = PesquisarProfessor();
    if (professor != null) {
      if(!turmas.Exists(turma => professor.Matricula == turma.Professor.Matricula)) {
        professores.Remove(professor);
        Console.WriteLine ("Professor removido com sucesso!");
      } else {
        Console.WriteLine ("Remova o professor das turmas!");
        int opcao = 0;
        do {
          Console.WriteLine ("Digite a opcao:");
          Console.WriteLine ("0 - Voltar ao Menu de Professor");
          Console.WriteLine ("1 - Remover todas as turmas do professor");
          Console.WriteLine ("2 - Alterar todas as turmas do professor");
          opcao = int.Parse(
            Console.ReadLine()
          );
          switch(opcao) {
            case 1:
              turmas.RemoveAll(turma => professor.Matricula == turma.Professor.Matricula);
              Console.WriteLine ("Turmas removidas com sucesso!");
              break;
            case 2:
              foreach (Turma turma in turmas.FindAll(turma => professor.Matricula == turma.Professor.Matricula)) {
                turma.Imprimir();
                turma.Professor = PesquisarProfessor();
                Console.WriteLine ("Turma alterada com sucesso!");
              }
              Console.WriteLine ("Turmas alteradas com sucesso!");
            break;
            default:
              break;
          }
        } while (opcao > 0);
      }
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void ImprimirProfessores() {
    foreach (Professor professor in professores) {
      professor.Imprimir();
    }
  }

  private static void ImprimirProfessorSelecionado() {
    Professor professor = PesquisarProfessor();
    if (professor != null) {
      professor.Imprimir();
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void AdicionarDisciplina() {
    Disciplina disciplina = new Disciplina();
    Console.WriteLine ("Digite o codigo da disciplina:");
    disciplina.Codigo = Console.ReadLine();
    if (!disciplinas.Exists(materia => materia.Codigo == disciplina.Codigo)) {
      Console.WriteLine ("Digite o nome da disciplina:");
      disciplina.Nome = Console.ReadLine();
      Console.WriteLine ("Digite o periodo da disciplina:");
      disciplina.Periodo = int.Parse(
        Console.ReadLine()
      );
      disciplinas.Add(disciplina);
      Console.WriteLine ("Disciplina adicionada com sucesso!");
    } else {
      Console.WriteLine ("Codigo já existente!");
    }
  }

  private static Disciplina PesquisarDisciplina() {
    Console.WriteLine ("Digite o codigo da disciplina:");
    string codigo = Console.ReadLine();
    return disciplinas.Find(materia => materia.Codigo == codigo);
  }

  private static void EditarDisciplina() {
    Disciplina disciplina = PesquisarDisciplina();
    if (disciplina != null) {
      int opcao = 0;
      do {
        Console.WriteLine ("Digite a opcao:");
        Console.WriteLine ("0 - Voltar ao Menu de Disciplina");
        Console.WriteLine ("1 - Editar Nome da Disciplina");
        opcao = int.Parse(
          Console.ReadLine()
        );
        switch(opcao) {
          case 1:
            Console.WriteLine ("Digite o nome da disciplina:");
            disciplina.Nome = Console.ReadLine();
            Console.WriteLine ("Nome editado com sucesso!");
            break;
          default:
            break;
        }
      } while (opcao > 0);
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void RemoverDisciplina() {
    Disciplina disciplina = PesquisarDisciplina();
    if (disciplina != null) {
      if(!turmas.Exists(turma => disciplina.Codigo == turma.Disciplina.Codigo)) {
        disciplinas.Remove(disciplina);
        Console.WriteLine ("Disciplina removida com sucesso!");
      } else {
        Console.WriteLine ("Remova as disciplinas das turmas!");
        int opcao = 0;
        do {
          Console.WriteLine ("Digite a opcao:");
          Console.WriteLine ("0 - Voltar ao Menu de Disciplina");
          Console.WriteLine ("1 - Remover todas as turmas da disciplina");
          Console.WriteLine ("2 - Alterar todas as turmas da disciplina");
          opcao = int.Parse(
            Console.ReadLine()
          );
          switch(opcao) {
            case 1:
              turmas.RemoveAll(turma => disciplina.Codigo == turma.Disciplina.Codigo);
              Console.WriteLine ("Turmas removidas com sucesso!");
              break;
            case 2:
              foreach (Turma turma in turmas.FindAll(turma => disciplina.Codigo == turma.Disciplina.Codigo)) {
                turma.Imprimir();
                turma.Disciplina = PesquisarDisciplina();
                Console.WriteLine ("Turma alterada com sucesso!");
              }
              Console.WriteLine ("Turmas alteradas com sucesso!");
            break;
            default:
              break;
          }
        } while (opcao > 0);
      }
    } else {
      Console.WriteLine ("Matricula não existente!");
    }
  }

  private static void ImprimirDisciplinas() {
    foreach (Disciplina disciplina in disciplinas) {
      disciplina.Imprimir();
    }
  }

  private static void ImprimirDisciplinaSelecionada() {
    Disciplina disciplina = PesquisarDisciplina();
    if (disciplina != null) {
      disciplina.Imprimir();
    } else {
      Console.WriteLine ("Codigo não existente!");
    }
  }

  private static void MenuAluno() {
    int opcao = 0;
    do {
      Console.WriteLine ("Digite a opcao:");
      Console.WriteLine ("0 - Voltar ao Menu");
      Console.WriteLine ("1 - Adicionar Aluno");
      Console.WriteLine ("2 - Editar Aluno");
      Console.WriteLine ("3 - Remover Aluno");
      Console.WriteLine ("4 - Imprimir Aluno");
      Console.WriteLine ("5 - Imprimir Todos os Alunos");
      opcao = int.Parse(
        Console.ReadLine()
      );
      switch(opcao) {
        case 1:
          AdicionarAluno();
          break;
        case 2:
          EditarAluno();
          break;
        case 3:
          RemoverAluno();
          break;
        case 4:
          ImprimirAlunoSelecionado();
          break;
        case 5:
          ImprimirAlunos();
          break;
        default:
          break;
      }
    } while (opcao > 0);
  }

  private static void MenuTurma() {
    int opcao = 0;
    do {
      Console.WriteLine ("Digite a opcao:");
      Console.WriteLine ("0 - Voltar ao Menu");
      Console.WriteLine ("1 - Adicionar Turma");
      Console.WriteLine ("2 - Editar Turma");
      Console.WriteLine ("3 - Remover Turma");
      Console.WriteLine ("4 - Imprimir Turma");
      Console.WriteLine ("5 - Imprimir Todas as Turmas");
      Console.WriteLine ("6 - Matricular Aluno Na Turma");
      Console.WriteLine ("7 - Desmatricular Aluno Na Turma");
      Console.WriteLine ("8 - Adicionar Nota Do Aluno Na Turma");
      Console.WriteLine ("9 - Adicionar Falta Do Aluno Na Turma");
      Console.WriteLine ("10 - Imprimir Alunos Aprovados Da Turma");
      Console.WriteLine ("11 - Imprimir Alunos Reprovados Da Turma");
      Console.WriteLine ("12 - Imprimir Media Da Turma");
      Console.WriteLine ("13 - Imprimir Historico do Aluno Na Turma");
      opcao = int.Parse(
        Console.ReadLine()
      );
      switch(opcao) {
        case 1:
          AdicionarTurma();
          break;
        case 2:
          EditarTurma();
          break;
        case 3:
          RemoverTurma();
          break;
        case 4:
          ImprimirTurmaSelecionada();
          break;
        case 5:
          ImprimirTurmas();
          break;
        case 6:
          MatricularAlunoEmTurma();
          break;
        case 7:
          DesmatricularAlunoEmTurma();
          break;
        case 8:
          AdicionarNotaDoAluno();
          break;
        case 9:
          AdicionarFaltaDoAluno();
          break;
        case 10:
          ImprimirAprovadosDaTurma();
          break;
        case 11:
          ImprimirReprovadosDaTurma();
          break;
        case 12:
          ImprimirMediaDaTurma();
          break;
        case 13:
          ImprimirHistoricoDoAlunoEmTurma();
          break;
        default:
          break;
      }
    } while (opcao > 0);
  }

  private static void MenuProfessor() {
    int opcao = 0;
    do {
      Console.WriteLine ("Digite a opcao:");
      Console.WriteLine ("0 - Voltar ao Menu");
      Console.WriteLine ("1 - Adicionar Professor");
      Console.WriteLine ("2 - Editar Professor");
      Console.WriteLine ("3 - Remover Professor");
      Console.WriteLine ("4 - Imprimir Professor");
      Console.WriteLine ("5 - Imprimir Todos os Professores");
      opcao = int.Parse(
        Console.ReadLine()
      );
      switch(opcao) {
        case 1:
          AdicionarProfessor();
          break;
        case 2:
          EditarProfessor();
          break;
        case 3:
          RemoverProfessor();
          break;
        case 4:
          ImprimirProfessorSelecionado();
          break;
        case 5:
          ImprimirProfessores();
          break;
        default:
          break;
      }
    } while (opcao > 0);
  }

  private static void MenuDisciplina() {
    int opcao = 0;
    do {
      Console.WriteLine ("Digite a opcao:");
      Console.WriteLine ("0 - Voltar ao Menu");
      Console.WriteLine ("1 - Adicionar Disciplina");
      Console.WriteLine ("2 - Editar Disciplina");
      Console.WriteLine ("3 - Remover Disciplina");
      Console.WriteLine ("4 - Imprimir Disciplina");
      Console.WriteLine ("5 - Imprimir Todas as Disciplinas");
      opcao = int.Parse(
        Console.ReadLine()
      );
      switch(opcao) {
        case 1:
          AdicionarDisciplina();
          break;
        case 2:
          EditarDisciplina();
          break;
        case 3:
          RemoverDisciplina();
          break;
        case 4:
          ImprimirDisciplinaSelecionada();
          break;
        case 5:
          ImprimirDisciplinas();
          break;
        default:
          break;
      }
    } while (opcao > 0);
  }

  public static void Main (string[] args) {
    int opcao = 0;
    do {
      Console.WriteLine ("Digite a opcao:");
      Console.WriteLine ("0 - Sair");
      Console.WriteLine ("1 - Alunos");
      Console.WriteLine ("2 - Turmas");
      Console.WriteLine ("3 - Professores");
      Console.WriteLine ("4 - Disciplinas");
      opcao = int.Parse(
        Console.ReadLine()
      );
      switch(opcao) {
        case 1:
          MenuAluno();
          break;
        case 2:
          MenuTurma();
          break;
        case 3:
          MenuProfessor();
          break;
        case 4:
          MenuDisciplina();
          break;
        default:
          break;
      }
    } while (opcao > 0);
  }
}