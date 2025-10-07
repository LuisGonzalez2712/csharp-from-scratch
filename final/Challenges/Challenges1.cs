namespace itm.csharp.basic
{
    /*Determinar si un numero es positivo, negativo o si es cero*/
    public class Challenge1
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0) Console.WriteLine("El numero es positivo");
            else if (num < 0) Console.WriteLine("El numero es negativo");
            else Console.WriteLine("El numero es cero");
        }
    }

    /*Realizar operaciones basicas entre dos numeros*/
    public class Challenge2
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el primer numero: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"la suma es: {a + b}");
            Console.WriteLine($"la resta es: {a - b}");
            Console.WriteLine($"la multiplicacion es: {a * b}");
            if (a == 0 && b == 0) Console.WriteLine("La division es indeterminada");
            else
                if (b != 0) Console.WriteLine($"la division es: {a / b}");
            else Console.WriteLine("No se puede dividir por cero");

            if (a > b) Console.WriteLine("El primer numero es mayor que el segundo");
            else if (a < b) Console.WriteLine("El primer numero es menor que el segundo");
            else Console.WriteLine("Los numeros son iguales");
        }
    }

    /*Solicitar al usuario un numero y determinar su cuadrado*/
    public class Challenge3
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un numero: ");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine($"El cuadrado de {num} es {num * num}");
        }
    }

    /*Solicitar al usuario el radio de un circulo y determinar su area*/
    public class Challenge4
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el radio de un circulo: ");
            double radio = double.Parse(Console.ReadLine());
            double area = Math.PI * radio * radio;
            Console.WriteLine($"El area del circulo es: {area}");
        }
    }

    /*Solicitar al usuario un numero del 1 al 7 y determinar el dia de la semana*/
    public class Challenge5
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un numero del 1 al 7: ");
            int dia = int.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Numero no valido. Por favor, ingrese un numero del 1 al 7.");
                    break;
            }
        }
    }

    /*Solicitar al usuario su salario y si este excede los 1000, se le aplicara el 10%. 
    Determinar el impuesto a pagar*/
    public class Challenge6
    {
        public void Run()
        {
            Console.WriteLine("Ingrese su salario: ");
            double salario = double.Parse(Console.ReadLine());
            if (salario > 1000)
            {
                double impuesto = salario * 0.10;
                Console.WriteLine($"El impuesto a pagar es: {impuesto}");
            }
            else
            {
                Console.WriteLine("No se aplica impuesto.");
            }
        }
    }

    /*Solicitar al usuario dos numeros y determinar la division entre ellos*/
    public class Challenge7
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el numero a dividir: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero divisor: ");
            double b = double.Parse(Console.ReadLine());
            try
            {
                double resultado = a / b;
                Console.WriteLine($"El resultado de la division es: {resultado}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Entrada no valida. Por favor, ingrese numeros validos.");
            }
        }
    }

    /*Determinar la suma de los numeros pares entre 1 y 100*/
    public class Challenge8
    {
        public void Run()
        {
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine($"La suma de los numeros pares entre 1 y 100 es: {suma}");
        }
    }

    /*Solicitar al usuario dos fracciones y determinar su suma*/
    public class Challenge9
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Ingrese el numerador de la primera fraccion: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el denominador de la primera fraccion: ");
                int den1 = int.Parse(Console.ReadLine());
                Fraccion fraccion1 = new Fraccion(num1, den1);

                Console.WriteLine("Ingrese el numerador de la segunda fraccion: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el denominador de la segunda fraccion: ");
                int den2 = int.Parse(Console.ReadLine());
                Fraccion fraccion2 = new Fraccion(num2, den2);

                Fraccion resultado = fraccion1.Sumar(fraccion2);
                Console.WriteLine($"La suma de las fracciones{num1}/{den1} + {num2}/{den2} es: {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no valida. Por favor, ingrese numeros enteros validos.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception)
            {
                Console.WriteLine("Error inesperado. Por favor, intente nuevamente.");
            }
        }
    }

    public class Fraccion
    {
        private int Numerador { get; set; }
        private int Denominador { get; set; }

        public Fraccion(int numerador, int denominador)
        {
            if (denominador == 0) throw new ArgumentException("El denominador no puede ser cero.");
            Numerador = numerador;
            Denominador = denominador;
        }

        public Fraccion Sumar(Fraccion otra)
        {
            int nuevoNumerador = (this.Numerador * otra.Denominador) + (otra.Numerador * this.Denominador);
            int nuevoDenominador = this.Denominador * otra.Denominador;
            return new Fraccion(nuevoNumerador, nuevoDenominador);
        }
        /*Aqui se podria agregar mas metodos*/
        public override string ToString()
        {
            return $"{Numerador}/{Denominador}";
        }
    }

    /*Solicitar al usuario una palabra y mostrarla en inverso*/
    public class Challenge10
    {
        public void Run()
        {
            Console.WriteLine("Ingrese una palabra: ");
            string palabra = Console.ReadLine();
            char[] caracteres = palabra.ToCharArray();
            Array.Reverse(caracteres);
            string palabraInversa = new string(caracteres);
            Console.WriteLine($"La palabra en inverso es: {palabraInversa}");
        }
    }

    /*Solicitar al usuario 3 numeros y determinar su promedio*/
    public class Challenge11
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Ingrese el primer numero: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el tercer numero: ");
                double num3 = double.Parse(Console.ReadLine());

                double promedio = (num1 + num2 + num3) / 3;
                Console.WriteLine($"El promedio de los tres numeros es: {promedio}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no valida. Por favor, ingrese numeros validos.");
            }
            catch (Exception)
            {
                Console.WriteLine("Error inesperado. Por favor, intente nuevamente.");
            }
        }
    }

    /*Solicitar al usuario 5 numeros y determinar el mayor*/
    public class Challenge12
    {
        public void Run()
        {
            try
            {
                double mayor = double.MinValue;
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"Ingrese el numero {i}: ");
                    double num = double.Parse(Console.ReadLine());
                    if (num > mayor)
                    {
                        mayor = num;
                    }
                }
                Console.WriteLine($"El mayor de los cinco numeros es: {mayor}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no valida. Por favor, ingrese numeros validos.");
            }
            catch (Exception)
            {
                Console.WriteLine("Error inesperado. Por favor, intente nuevamente.");
            }
        }
    }
    /*Solicitar al usuario una palabra y determinar si es un palindromo*/
    public class Challenge13
    {
        public void Run()
        {
            Console.WriteLine("Ingrese una palabra: ");
            string palabra = Console.ReadLine();

            if (palabra == new string(palabra.Reverse().ToArray()))
            {
                Console.WriteLine("La palabra es un palindromo");
            }
            else
            {
                Console.WriteLine("La palabra no es un palindromo");
            }
        }
    }

    /*Solicitar al usuario un numero y determinar si es par o impar*/
    public class Challenge14
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Ingrese un numero: ");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("El numero es par");
                }
                else
                {
                    Console.WriteLine("El numero es impar");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no valida. Por favor, ingrese un numero entero valido.");
            }
            catch (Exception)
            {
                Console.WriteLine("Error inesperado. Por favor, intente nuevamente.");
            }
        }
    }

    /*Solicitar al usuario un numero y determinar si esta en el rango de 1 a 10*/
    public class Challenge15
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Ingrese un numero: ");
                int num = int.Parse(Console.ReadLine());
                if (num >= 1 && num <= 10)
                {
                    Console.WriteLine("El numero esta en el rango de 1 a 10");
                }
                else
                {
                    Console.WriteLine("El numero no esta en el rango de 1 a 10");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Entrada no valida. Por favor, ingrese un numero entero valido.");
            }
            catch (Exception)
            {
                Console.WriteLine("Error inesperado. Por favor, intente nuevamente.");
            }
        }
    }  
}