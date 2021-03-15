using System;
using revisao;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0; 
            string opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Informe a nota do aluno");
                       
                        
                       if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                       {
                           aluno.Nota = nota;
                       }
                       else
                       {
                           throw new ArgumentException("o valor da nota deve ser decimal");
                       }

                       alunos[indiceAluno] = aluno;
                       indiceAluno++;
                        break;
                    case "2":
                        foreach(var a in alunos)
                        {
                        
                            
                            Console.WriteLine($"Aluno: {a.Nome} - nota {a.Nota}");
                            
                        }

                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for (int i=0; i < alunos.Length; i++)
                        {
                            
                            
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        ConceitoEnum conceitoGeral;

                        if (mediaGeral < 2)
                        {
                            conceitoGeral = ConceitoEnum.E;
                        }
                        else if(mediaGeral < 4)
                        {
                            conceitoGeral = ConceitoEnum.D;
                        }
                        else if(mediaGeral < 6)
                        {
                            conceitoGeral = ConceitoEnum.C;
                        }
                        else if(mediaGeral < 8)
                        {
                            conceitoGeral = ConceitoEnum.B;
                        }
                        else
                        {
                            conceitoGeral = ConceitoEnum.A;
                        }
                        

                        Console.WriteLine($"Media Geral: {mediaGeral} Conceito Geral : {conceitoGeral}");

                        break;
                    default:
                        throw new ArgumentException();
                }
                
                opcaoUsuario = obterOpcaoUsuario();
            }
        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- calcularmedia geral");
            Console.WriteLine("X- sair");

            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
