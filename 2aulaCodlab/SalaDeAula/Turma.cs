using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaDeAula
{
    class Turma
    {
    Turma turma;
        public void iniciar()
    {
            Console.WriteLine("Informe o nome da turma: ");
            string turma = Console.ReadLine();

            Console.WriteLine("Informe o numero de alunos da turma: ");
            int numeroAlunos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A sala {turma} com {numeroAlunos} alunos foi criado com sucesso ");
        }
            
        public void menu()
        {
            Console.Clear();
            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - Cadastrar um novo aluno: "); 
            Console.WriteLine("2 - Mostrar todos os alunos:");
            Console.WriteLine("0 - Sair: ");

        }
    }
}
