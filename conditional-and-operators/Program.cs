/*conditional*/
//String respuesta="s";
//while(respuesta=="s"){
    //Console.WriteLine("Ingrese un numero: ");
    //int num = int.Parse(Console.ReadLine());
    //if(num>0) Console.WriteLine("El numero es positivo");
    //else if(num<0) Console.WriteLine("El numero es negativo");
    //else Console.WriteLine("El numero es cero");

    //Console.WriteLine("Desea continuar? (s/n)");
    //respuesta=Console.ReadLine();
//}

/*end conditional*/

/*operators*/
Console.WriteLine("Ingrese el primer numero: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");   
double b = double.Parse(Console.ReadLine());
Console.WriteLine($"la suma es: {a+b}");
Console.WriteLine($"la resta es: {a-b}");
Console.WriteLine($"la multiplicacion es: {a*b}");
if(a == 0 && b == 0) Console.WriteLine("La division es indeterminada");
else
if(b != 0) Console.WriteLine($"la division es: {a/b}");
else Console.WriteLine("No se puede dividir por cero");

if(a > b) Console.WriteLine("El primer numero es mayor que el segundo");
else if(a < b) Console.WriteLine("El primer numero es menor que el segundo");
else Console.WriteLine("Los numeros son iguales");
/*end operators*/