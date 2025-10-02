namespace Helloworld
{
    class Program
    {
        static void Main()
        {
            DateOnly newConverted = new DateOnly();
            String nameInput;
            String birthdayInput;
            Console.WriteLine("Hola bienvenido al calculador de años");
            Console.WriteLine("Escribe tu nombre: ");
            nameInput= Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameInput}");
            Console.WriteLine("Escribe tu fecha de nacimiento en formato DD/MM/AAAA: ");
            birthdayInput= Console.ReadLine();
            bool isValidDate = DateOnly.TryParse(birthdayInput, out newConverted);
            if (!isValidDate) Console.WriteLine("La fecha ingresada no es válida. Por favor, inténtalo de nuevo.");
            var person = new Person
            {
                Name = nameInput,
                Birthday = newConverted,
                Age = DateTime.Now.Year - newConverted.Year
            };

            Console.WriteLine($"Tu nombre es {person.Name}");
            Console.WriteLine($"Tu fecha de nacimiento es {person.Birthday.ToString("yyyy/MM/dd")}");
            Console.WriteLine($"Tu edad es {person.Age} años");  
            
            Console.ReadLine();
        }
    }

    public class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }
    }
}
