namespace aula13_atividade
{
    internal class Program
    {
        enum ErrorStatusCode
        {
            Ok = 200,
            Redirect = 301,
            TemporaryRedirec = 302,
            NoFound = 404,
            NoAuthorized = 405,
            UnavailableServer = 503,
            TimeOut = 504
        }

        class Student
        {
            public int Matricula;
            public string Nome;
            public string Sobrenome;
            public string Telefone;
        }

        //class Student
        //{

        //    private int matricula;
        //    private string nome;
        //    private string sobrenome;
        //    private string telefone;

        //    public int Matricula { 
        //        get { 
        //            return matricula; 
        //        } 
        //        set { 
        //            matricula = value; 
        //        } 
        //    }

        //    public string Nome
        //    {
        //        get
        //        {
        //            return nome;
        //        }
        //        set
        //        {
        //            nome = value;
        //        }
        //    }

        //    public string Sobrenome
        //    {
        //        get
        //        {
        //            return sobrenome;
        //        }
        //        set
        //        {
        //            sobrenome = value;
        //        }
        //    }

        //    public string Telefone
        //    {
        //        get
        //        {
        //            return telefone;
        //        }
        //        set
        //        {
        //            telefone = value;
        //        }
        //    }

        //    public Student(string nome, string sobrenome, string telefone)
        //    {
        //        this.nome = nome;
        //        this.sobrenome = sobrenome;
        //        this.telefone = telefone;
        //    }
        //}

        class School
        {
            private Dictionary<int, Student> subscribers = new Dictionary<int, Student>();

            public bool Register(Student student)
            {
                // Estou atribuíndo a matrícula de acordo com o "indice" da coleção.
                student.Matricula = subscribers.Count;

                // Testou e adiciono o estudante na Coleção.
                bool registered = subscribers.TryAdd(subscribers.Count, student);

                // Retorno se o Registo aconteceu ou não.
                return registered;
            }

            public bool RemoveByKey(int keyStudent)
            {
                // Tento e caso ele exista na coleção, removo o Aluno a partir de sua chave.
                bool removed = subscribers.Remove(keyStudent);

                // Retorno se a Remoção aconteceu ou não.
                return removed;
            }

            public void GetAllSubscribers()
            {
                // Itero todos os valores dos Alunos inscritos na coleção.
                foreach(Student student in subscribers.Values)
                {
                    Console.WriteLine($"{student.Matricula} - {student.Nome}");
                }
            }
        }

        static void Main(string[] args)
        {
            
            School school = new School();

            // 1. Adicionar Aluno
            school.Register(new Student()
            {
                Nome = "Willian",
                Sobrenome = "Sant Anna",
                Telefone = "972902045"
            });

            school.Register(new Student()
            {
                Nome = "Hugo",
                Sobrenome = "Gonzaga",
                Telefone = "985003026"
            });

            school.Register(new Student()
            {
                Nome = "Lany",
                Sobrenome = "Aragão",
                Telefone = "9997240031"
            });

            // 1. Adicionar Aluno
            //school.Register(new Student("Willian", "Sant Anna", "972902045"));
            //school.Register(new Student("Hugo", "Gonzaga", "985003026"));
            //school.Register(new Student("Lany", "Aragão", "9997240031"));


            // 2. Remover Aluno
            school.RemoveByKey(0);

            // 3. Listar todos os Alunos
            Console.WriteLine("3. Lista de Alunos matriculados\n");
            school.GetAllSubscribers();

        }
    }
}