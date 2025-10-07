/*clase*/
//var rect = new Rectangulo();
//rect.Base = 20;
//rect.Altura = 40;   
//Console.WriteLine($"Area: {rect.Area()}");
//Console.WriteLine($"Perimetro: {rect.Perimetro()}");
/*end clase*/

var cuad = new cuadrado();
cuad.lado = 20; 
cuad.Altura = 40;   
Console.WriteLine($"Area: {cuad.Area()}");
Console.WriteLine($"Perimetro: {cuad.Perimetro()}");
Console.WriteLine($"Lado: {cuad.lado}");

class Rectangulo
{

    public double Base { get; set; }

    public double Altura { get; set; }
    public double Area() => Base * Altura;
    public double Perimetro() => 2 * (Base + Altura);
    
}
/*herencia*/

class cuadrado : Rectangulo
{
    public double lado{
        set { Base = value; Altura = value; } 
        get { return Base; } 
    }
}

/*end herencia*/