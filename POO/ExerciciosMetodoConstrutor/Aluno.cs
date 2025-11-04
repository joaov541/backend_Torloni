

namespace ExerciciosMetodoConstrutor
{
    public class Aluno
    {
        public string Nome = "";
        public double Nota;

        public Aluno()
        {
            Nome = "Desconhecido";
            Nota = 0;
        }

        public Aluno(string nome, int nota)
        {
            Nome = nome;
            Nota = nota;
        }
    }
}