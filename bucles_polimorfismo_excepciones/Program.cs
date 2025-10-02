var circ = new Circulo();
circ.Radio = 20;
var result_area = circ.Area();
var result_perim = circ.Perimetro();
Console.WriteLine($"Area: {result_area}");
Console.WriteLine($"Perimetro: {result_perim}");
Console.WriteLine($"El nuevo radio es : {circ.Add10()}");

int prev = 0, next = 1, sum = 0;
for(int i=0; i<10; i++){
    Console.WriteLine(prev);
    sum = prev + next;
    prev = next;
    next = sum;
}

try
{
    Console.WriteLine("Ingrese un numero a Dividir: ");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese un numero Divisor: ");
    double b = double.Parse(Console.ReadLine());
    if(b == 0)
    {
        throw new DivideByZeroException();
    }
    
    Console.WriteLine($"El resultado es: {a/b}");
}
catch(DivideByZeroException ex)
{
    Console.WriteLine("No se puede dividir por cero");
}
catch(Exception )
{
    Console.WriteLine("Error desconocido");
}

//abstract class Figura{
//    public abstract double Area();
//  public abstract double Perimetro();
//}

interface IExtraCalculations{
    public double Add10();
}

interface IFigura{
    public double Area();
    public double Perimetro();
}
class Circulo : IFigura, IExtraCalculations
{
    public double Radio { get; set; } 
    public double Area() => Math.PI * Radio * Radio;
    public double Perimetro() => 2 * Math.PI * Radio;

    public double Add10(){
        return Radio + 10;
    }
}