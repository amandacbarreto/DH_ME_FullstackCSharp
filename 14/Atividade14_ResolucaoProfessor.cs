using System.Text.RegularExpressions;

namespace Aula14_Atividade
{

    public class Student
    {
        private string firstName;
        private string lastName;
        private string phone;
        private bool status;
        private double[] Scores;

        // Esses get/set(s) vão permitir acesso externo para atualização e captura de valores.
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                // Criei um validação apenas para demostrar possibilidades de uso de um get/set.
                if (String.IsNullOrWhiteSpace(value))
                    firstName = String.Empty;
                else
                    firstName = value.ToUpperInvariant();
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                // Criei um validação apenas para demostrar possibilidades de uso de um get/set.
                if (String.IsNullOrWhiteSpace(value))
                    lastName = String.Empty;
                else
                    lastName = value.ToUpperInvariant();
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                // Criei um validação apenas para demostrar possibilidades de uso de um get/set.
                // Utilizei uma expressão regular para padronizar o formato dos valores.
                // Nota: Para se utilizada no dia-a-dia falta muita implementação e uma camada de validação, portanto este exemplo é meramente ilustrativo.
                // Fonte: https://pt.stackoverflow.com/questions/46672/como-fazer-uma-express%C3%A3o-regular-para-telefone-celular 
                string pattern = "^\\(?[1-9]{2}\\)? ?(?:[2-8]|9[1-9])[0-9]{3}\\-?[0-9]{4}$";
                phone = Regex.Replace(value, pattern, String.Empty);
            }
        }

        public bool Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public Student(string firstName, string lastName, string phone, bool status = true)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Status = status;
            // Defini um vetor com limite de quatro valores.
            this.Scores = new double[4];
        }

        public bool TrySetOrUpdateScoreByPeriod(int perioded, double score)
        {
            // Validei se os valores bimestre e nota são validos.
            bool periodIsValid = perioded > 0 && perioded <= 4;
            bool scoreIsValid = score >= 0 && score <= 10;
            // Utilizei os resultados de ambas expressões para gerar uma nova validação.
            // Nota: Fiz apenas para facilitar a leitura e entendimento do código.
            bool isValid = periodIsValid && scoreIsValid;

            // Se os valores de bimestre e nota forem válidos adiciono ou atualizo a nota.
            if (isValid)
            {
                Scores.SetValue(score, perioded);
                // Scores[perioded] = score;
            }

            // Retorno o resultado do critério de validação para adicionar a nota do aluno.
            return isValid;
        }

        public void GetScoreByPeriod(int period)
        {
            double score = Scores[period];
            // Console.WriteLine("{0} bimestre / Nota: {1}", period++, score);
            Console.WriteLine($"{period++} bimestre / Nota: {score}");
        }

        public void GetScoreAllPeriod()
        {
            foreach (double score in Scores)
            {
                int period = Array.IndexOf(Scores, score);
                // Console.WriteLine("{0} bimestre / Nota: {1}", period++, score);
                Console.WriteLine($"{period++} bimestre / Nota: {score}");
            }
        }
        public void GetAverageScores()
        {
            // Soma das notas.
            double resultOfTheSumOfAllScores = 0;
            // Resultado da média.
            double resultOfTheAverageScores;

            foreach (double score in Scores)
            {
                resultOfTheSumOfAllScores += score;
            }

            resultOfTheAverageScores = resultOfTheSumOfAllScores / Scores.GetLength(0);

            // Console.WriteLine("Média da pontuação: {0}", resultOfTheAverageScores);
            Console.WriteLine($"Média da pontuação: {resultOfTheAverageScores}");
        }
    }

    public abstract class Administraction
    {
        // Nota: Conforme implementava, realmente não encontrei sentido
        // em implementar sobrescrita nos métodos Cadastrar e Remover.
        public abstract void GetAllRegistered();

    }

    public class School
    {
        private SortedList<int, Student> students;

        public School()
        {
            students = new SortedList<int, Student>();
        }

        public bool Register(int registrationCode, Student student)
        {
            return students.TryAdd(registrationCode, student);
        }

        // public bool Register(int registrationCode, Student student) => students.TryAdd(registrationCode, student);

        public bool Unregister(int registrationCode)
        {
            return students.Remove(registrationCode);
        }

        // public bool Unregister(int registrationCode) => students.Remove(registrationCode);


        public void GetAllRegistered()
        {
            foreach (var student in students.Values)
            {
                // Console.WriteLine("{0} {1} - {2}", student.FirstName, student.LastName, student.Phone);
                Console.WriteLine($"{student.FirstName} {student.LastName} - {student.Phone}");
            }
        }
    }

    //public static class School
    //{
    //    private static SortedList<int, Student> students = new SortedList<int, Student>();

    //    public static bool Register(int registrationCode, Student student)
    //    {
    //        return students.TryAdd(registrationCode, student);
    //    }

    //    // public bool Register(int registrationCode, Student student) => students.TryAdd(registrationCode, student);

    //    public static bool Unregister(int registrationCode)
    //    {
    //        return students.Remove(registrationCode);
    //    }

    //    // public bool Unregister(int registrationCode) => students.Remove(registrationCode);


    //    public static void GetAllRegistered()
    //    {
    //        foreach (var student in students.Values)
    //        {
    //            // Console.WriteLine("{0} {1} - {2}", student.FirstName, student.LastName, student.Phone);
    //            Console.WriteLine($"{student.FirstName} {student.LastName} - {student.Phone}");
    //        }
    //    }
    //}


    public class Employee
    {
        private string firstName;
        private string lastName;
        private string phone;
        private bool status;
        private string cpf;
        private double salary;

        // Esses get/set(s) vão permitir acesso externo para atualização e captura de valores.
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                // Criei um validação apenas para demostrar possibilidades de uso de um get/set.
                if (String.IsNullOrWhiteSpace(value))
                    firstName = String.Empty;
                else
                    firstName = value.ToUpperInvariant();
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                // Criei um validação apenas para demostrar possibilidades de uso de um get/set.
                if (String.IsNullOrWhiteSpace(value))
                    lastName = String.Empty;
                else
                    lastName = value.ToUpperInvariant();
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                // Criei um validação apenas para demostrar possibilidades de uso de um get/set.
                // Utilizei uma expressão regular para padronizar o formato dos valores.
                // Nota: Para se utilizada no dia-a-dia falta muita implementação e uma camada de validação, portanto este exemplo é meramente ilustrativo.
                // Fonte: https://pt.stackoverflow.com/questions/46672/como-fazer-uma-express%C3%A3o-regular-para-telefone-celular 
                string pattern = "^\\(?[1-9]{2}\\)? ?(?:[2-8]|9[1-9])[0-9]{3}\\-?[0-9]{4}$";
                phone = Regex.Replace(value, pattern, String.Empty);
            }
        }

        public bool Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                // Fonte: https://pt.stackoverflow.com/questions/11045/express%C3%A3o-regular-para-validar-um-campo-que-aceita-cpf-ou-cnpj
                string pattern = "([0-9]{2}[\\.]?[0-9]{3}[\\.]?[0-9]{3}[\\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\\.]?[0-9]{3}[\\.]?[0-9]{3}[-]?[0-9]{2})";
                cpf = Regex.Replace(value, pattern, String.Empty);
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public Employee(string firstName, string lastName, string cpf, double salary, bool status = true)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Cpf = cpf;
            this.Salary = salary;
            this.Status = status;
        }
    }

    public class Company : Administraction
    {

        private SortedList<int, Employee> employees;

        public Company()
        {
            employees = new SortedList<int, Employee>();
        }

        public bool Register(int registrationCode, Employee employee)
        {
            return employees.TryAdd(registrationCode, employee);
        }

        public bool Unregister(int registrationCode)
        {
            return employees.Remove(registrationCode);
        }

        public override void GetAllRegistered()
        {
            foreach (var employee in employees.Values)
            {
                Console.WriteLine("{0} {1} - {2}", employee.FirstName, employee.LastName, employee.Phone);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            school.Register(1, new Student("Willian", "Sant Anna", "21972192093"));
            school.Register(2, new Student("Sabrina", "Helena", "31972808944"));
            school.Register(2, new Student("Hugo", "Gonzaga", "71962770068"));
            school.Unregister(1);
            school.GetAllRegistered();

            //School.Register(1, new Student("Willian", "Sant Anna", "21972192093"));
            //School.Register(2, new Student("Sabrina", "Helena", "31972808944"));
            //School.Register(2, new Student("Hugo", "Gonzaga", "71962770068"));
            //School.Unregister(1);
            //School.GetAllRegistered();
        }
    }
}