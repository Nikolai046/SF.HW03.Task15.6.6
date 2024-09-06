namespace SF.HW03.Task15._6._6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var classes = new[]
            {
                new Classroom { Students = { "Evgeniy", "Sergey", "Andrew" }, },
                new Classroom { Students = { "Anna", "Viktor", "Vladimir" }, },
                new Classroom { Students = { "Bulat", "Alex", "Galina" }, }
            };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        /// <summary>
        /// Собирает всех студентов из всех классов в один массив.
        /// </summary>
        /// <param name="classes">Массив классов, содержащих студентов.</param>
        /// <returns>Массив имен всех студентов.</returns>
        private static string[] GetAllStudents(Classroom[] classes)
        {
            return classes
                .SelectMany(s => s.Students)
                .ToArray();
        }
    }
}