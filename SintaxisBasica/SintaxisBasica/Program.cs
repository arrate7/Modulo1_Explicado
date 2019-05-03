using System;

namespace SintaxisBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Ejercicio 1
            //// creamos una variable de tipo string llamada nombre
            //string nombre = "Arrate";
            //// escribimos "Hola" seguido del valor que hemos dado a la variable 'nombre'
            //Console.WriteLine("Hola " + nombre);
            //Console.ReadLine();

            ////Ejercicio 2
            ////creamos dos variables de tipo double llamadas numero1 y numero2
            //double numero1, numero2;
            ////damos un valor a cada una de las variables;                       
            //numero1 = 3;
            //numero2 = 5;
            ////realizamos la suma y escribimos el resultado
            //Console.WriteLine(numero1 + numero2);
            //Console.ReadLine();

            ////Ejercicio 3
            ////creamos dos variables de tipo double llamadas numero1 y numero2
            //double numero1, numero2;
            ////damos un valor a cada una de las variables
            //numero1 = 8;
            //numero2 = 4;
            ////mostramos por pantalla el resultado de la operación
            //Console.WriteLine(numero1 / numero2);
            //Console.ReadLine();

            ////Ejercicio 4
            //Console.WriteLine(-5 + 8 * 6);
            //Console.WriteLine((55 + 9) % 6);
            //Console.WriteLine(20 + -3 * 5 / 8);
            //Console.WriteLine(5 + 15 / 3 * 2 - 8 % 3);
            //Console.ReadLine();

            ////Ejercicio 5
            ////creamos dos variables de tipo double llamadas numero1 y numero2
            //double numero1, numero2;
            ////pedimos al usuario que escriba un número
            //Console.WriteLine("Escribe un número:");
            ////leemos el valor del número y asignamos el valor a la variable numero1                     
            //numero1 = Convert.ToDouble(Console.ReadLine());
            ////pedimos al usuario que escriba otro número                        
            //Console.WriteLine("Escribe otro número:");
            ////leemos el valor del número y asignamos el valor a la variable numero2                     
            //numero2 = Convert.ToDouble(Console.ReadLine());
            ////escribimos el resultado de la operación                       
            //Console.WriteLine(numero1 / numero2);
            //Console.ReadLine();

            ////Ejercicio 6
            //// creamos dos variables de tipo double llamadas numero1 y numero2
            //double numero1, numero2;
            //// pedimos al usuario que escriba un número y almacenamos el valor en la variable numero1                       
            //Console.WriteLine("Escribe un número:");
            //numero1 = Convert.ToDouble(Console.ReadLine());
            //// pedimos al usuario que escriba un número y almacenamos el valor en la variable numero2                       
            //Console.WriteLine("Escribe otro número:");
            //numero2 = Convert.ToDouble(Console.ReadLine());
            //// mostramos los resultados por pantalla
            //Console.WriteLine("El resultado de " + numero1 + " + " + numero2 + " = " + (numero1 + numero2));
            //Console.WriteLine("El resultado de " + numero1 + " - " + numero2 + " = " + (numero1 - numero2));
            //Console.WriteLine("El resultado de " + numero1 + " * " + numero2 + " = " + (numero1 * numero2));
            //Console.WriteLine("El resultado de " + numero1 + " / " + numero2 + " = " + (numero1 / numero2));
            //Console.WriteLine("El resto de " + numero1 + " / " + numero2 + " = " + (numero1 % numero2));
            //Console.ReadLine();

            ////Ejercicio 7
            //// pedimos al usuario que escriba un número
            //Console.WriteLine("Escribe un número:");
            //// leemos el número escrito, lo convertimos de tipo string a tipo double y asignamos el valor a la variable llamada numero1
            //double numero1 = Convert.ToDouble(Console.ReadLine());
            //// escribimos en pantalla el resultado de la tabla de multiplicar
            //Console.WriteLine(numero1 + "x1=" + (numero1 * 1));
            //Console.WriteLine(numero1 + "x2=" + (numero1 * 2));
            //Console.WriteLine(numero1 + "x3=" + (numero1 * 3));
            //Console.WriteLine(numero1 + "x4=" + (numero1 * 4));
            //Console.WriteLine(numero1 + "x5=" + (numero1 * 5));
            //Console.WriteLine(numero1 + "x6=" + (numero1 * 6));
            //Console.WriteLine(numero1 + "x7=" + (numero1 * 7));
            //Console.WriteLine(numero1 + "x8=" + (numero1 * 8));
            //Console.WriteLine(numero1 + "x9=" + (numero1 * 9));
            //Console.WriteLine(numero1 + "x10=" + (numero1 * 10));
            //Console.ReadLine();

            ////Ejercicio 8
            //// escribmos por pantalla el resultado, teniendo en cuenta la jerarquía de operaciones matemáticas
            //Console.WriteLine(((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5)));
            //Console.ReadLine();

            ////Ejercicio 9
            ////mostramos el resultado en pantalla teniendo en cuenta la jerarquía de operaciones matemáticas
            //Console.WriteLine(4.0 * (1 - (1.0 / 3) + (1.0 / 5) - (1.0 / 7) + (1.0 / 9) - (1.0 / 11)));
            //Console.ReadLine();

            ////Ejercicio 10
            ////pedimos al usuario un número
            //Console.WriteLine("Introduce el radio de un círculo:");
            ////leemos el valor del número introducido, lo convertimos en tipo double y lo asignamos a la variable llamada radio
            //double radio = Convert.ToDouble(Console.ReadLine());
            //// creamos una variable de tipo double llamada perimetro y le asignamos el valor de 2 multiplicado por el
            //// valor de la variable PI y el valor de la variable radio
            //double perimetro = 2 * Math.PI * radio;
            //// creamos una variable de tipo double llamada area y le asignamos el valor de la variable PI multiplicado por el
            ////el valor de la variable radio elevado a la segunda potencia
            //double area = Math.PI * Math.Pow(radio, 2);
            //// mostramos por pantalla el valor de la variable perimetro
            //Console.WriteLine("Perímetro del círculo: " + perimetro);
            //// mostramos por pantalla el valor del área del círculo
            //Console.WriteLine("El área del círculo: " + area);
            //Console.ReadLine();

            ////Ejercicio 11
            ////pedimos al usuario que escriba un número
            //Console.WriteLine("Escribe un número:");
            ////creamos una variable de tipo double llamada num1 y almacenamos
            ////en ella el valor del número introducido por el usuario. recuerda
            ////que cuando leemos por pantalla leemos una variable de tipo string
            ////por lo que hay que hacer la conversión al tipo que queremos
            //double num1 = Convert.ToInt32(Console.ReadLine());
            ////pedimos al usuario que escriba otro número, creamos una variable
            ////de tipo double llamada num2 y almacenamos el número en ella
            //Console.WriteLine("Escribe un número:");
            //double num2 = Convert.ToInt32(Console.ReadLine());
            ////pedimos al usuario que escriba otro número, creamos una variable
            ////de tipo double llamada num3 y almacenamos el número en ella
            //Console.WriteLine("Escribe un número:");
            //double num3 = Convert.ToInt32(Console.ReadLine());
            ////mostramos por pantalla el resultado de la operación
            //Console.WriteLine((num1 + num2 + num3) / 3);
            //Console.ReadLine();

            ////Ejercicio 12
            ////pedimos al usuario un número y lo almacenamos en la variable de tipo double
            ////llamada altura
            //Console.WriteLine("Escribe la altura del rectángulo:");
            //double altura = Convert.ToDouble(Console.ReadLine());
            ////pedimos al usuario otro número y lo almacenamos en la variable de tipo doublle
            ////llamada altura
            //Console.WriteLine("Escribe la anchura del rectángulo:");
            //double anchura = Convert.ToDouble(Console.ReadLine());
            ////mostramos por pantalla los resultados de las operaciones
            //Console.WriteLine("El perímetro es: " + ((2 * altura) + (2 * anchura)));
            //Console.WriteLine("El área es: " + altura * anchura);
            //Console.ReadLine();

            //Ejercicio 13

            ////creamos las variables de tipo int llamadas 'a' y 'b'
            //int a, b;
            ////creamos una tercera variable de tipo int llamada 'c' para poder realizar
            ////el intercambio de valores
            //int c;
            ////pedimos al usuario que escriba un número y asignamos el valor a la 
            ////variable 'a'
            //Console.WriteLine("Escribe un número: ");
            //a = Convert.ToInt32(Console.ReadLine());
            ////asignamos el valor de la variable 'a' a la variable 'c'
            //c = a;
            ////pedimos al usuario que escriba otro número y asignamos su valor a la 
            ////variable 'b'
            //Console.WriteLine("Escribe un número");
            //b = Convert.ToInt32(Console.ReadLine());
            ////asignamos el valor de la variable 'b' a la variable 'a'
            //a = b;
            ////asignamos el valor de la variable 'c' a la variable 'b'
            //b = c;
            ////mostramos por pantalla los valores de las variables
            //Console.WriteLine("a: " + a + " y b: " + b);
            //Console.ReadLine();

            ////Ejercicio 14
            ////pedimos al usuario que escriba un número de 3 cifras y almacenamos el valor
            ////en la variable de tipo int llamada 'num'
            //Console.WriteLine("Escribe un número de 3 cifras: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            ////creamos una variable de tipo int llamada 'd1' en la que guardaremos el
            ////primer dígito del número. Como es una variable de tipo int, no guarda 
            ////los decimales, por lo que al hacer la división únicamente se guardará
            ////el primer dígito
            //int d1 = num / 100;
            ////creamos una variable de tipo int llamada 'd2' en la que guardaremos el
            ////segundo  dígito. calculamos el resto de de la división entre 100 y dividimos
            ////entre 10 el resto. como es una variable de tipo int, deshecha los decimales
            //int d2 = (num % 100) / 10;
            ////creamos una variable de tipo int llamada 'd3' en la que guardaremos el
            ////tercer dígito del número. para ello calcularemos el resto de la división
            ////del número entre 10
            //int d3 = num % 10;
            ////mostramos el resultado de la suma por pantalla           
            //Console.WriteLine(d1 + d2 + d3);
            //Console.ReadLine();

            ////Ejercicio 15
            //// pedimos al usuario que escriba un número y lo almacenamos en la variable
            ////de tipo int llamada num. como todo lo que se lee por pantalla es de tipo
            ////string, hay que hacer conversión al tipo de dato con el que queremos
            ////trabajar
            //Console.WriteLine("Escribe un número de 1 dígito: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //// multiplicamos por 11 y 111 la variable 'num' y guardamos los valores en
            //// en las variables 'num2' y 'num3' respectivamente
            //int num2 = num * 11;
            //int num3 = num * 111;
            //// escribimos en pantalla el resultado de la suma
            //Console.WriteLine(num + num2 + num3);
            //Console.ReadLine();
            ////para que se vea más claro, podemos mostrar por pantalla los valores de
            ////las variables num2 y num3:
            ////    Console.WriteLine(num2);
            ////    Console.WriteLine(num3); 
            ///

            ////Ejercicio 16
            ////pedimos al usuario que escriba un número
            //Console.WriteLine("Escribe un número");
            ////creamos una variable de tipo string llamda 'numero' en la que guardamos el valor de lo que hemos leido
            //string numero = Console.ReadLine();
            ////creamos una variable de tipo int llamada 'num' usaremos Convert.X() para convertir 
            ////de string al tipo de dato que queramos. en este caso utilizaremos Convert.ToInt32() para convertir de 
            ////string a int. entre paréntesis se indica el string que queremos convertir
            //int num = Convert.ToInt32(numero);
            //Console.WriteLine(num);

            ////Ejercicio 17
            ////pedimos al usuario que escriba un número y lo almacenamos en la variable
            ////de tipo int llamada 'primerNum'
            //Console.WriteLine("Introduce el primer número");
            //int primerNum = Convert.ToInt32(Console.ReadLine());
            ////pedimos al suario que escriba un número y lo guardamos en la variable
            ////de tipo int llamda 'segundoNum'
            //Console.WriteLine("Introduce el segundo número");
            //int segundoNum = Convert.ToInt32(Console.ReadLine());
            ////calculamos la división entre los dos números y lo guardamos en la variable
            ////llamada 'division'. al ser de tipo int no guarda los decimales, únicamente
            ////números enteros
            //int division = primerNum / segundoNum;
            ////creamos una variable de tipo int llamad 'resto' que utilizaremos para
            ////guardar el resto de la división
            //int resto;
            ////realizamos la operación y guardamos el resultado en la variable 'resto'
            //resto = primerNum - (segundoNum * division);
            ////mostramos por pantalla el resto de la división
            //Console.WriteLine("El resto es: " + resto);
            //Console.ReadLine();

            ////Ejercicio 18
            ////creamos una variable de tipo double llamada 'celsius'
            //double celsius;
            ////creamos una constante de tipo double llamada 'FARENHEIT' y le asignamos un
            ////valor de 32
            //const double FARENHEIT = 32;
            ////creamos una variable de tipo double llamada 'gradosFarenheit'
            //double gradosFarenheit;
            ////pedimos al usuario que escriba la temperatura
            //Console.WriteLine("Escribe la temperatura en grados Celsius:");
            ////guardamos en la variable 'celsius' el número escrito por el usuario
            //celsius = Convert.ToDouble(Console.ReadLine());
            ////realizamos la operación de conversión de celsius a farenheit. para ello
            ////utilizamos la fórmula siguiente: celsius*9/5 + 32. tenemos los grados
            ////celsius guardados en la variable 'celsius' y el 32 que hay que sumar en
            ////la constante 'FARENHEIT'. el resultado de la operación lo guardamos en la
            ////variable 'gradosFarenheit'
            //gradosFarenheit = (celsius * 9) / 5 + FARENHEIT;
            ////escribimos en pantalla los grados Celsius y su conversión a Farenheit
            //Console.WriteLine(celsius + " grados Celsius son " + gradosFarenheit + " grados Farenheit.");
            //Console.ReadLine();

            ////Ejercicio 19
            ////creamos dos variables de tipo double llamdas 'pulgadas' y 'metros'
            //double pulgadas, metros;
            ////creamos una constante de tipo double llamada 'distanciaPulgadas' y le 
            ////asignamos un valor
            //const double distanciaPulgadas = 0.0254;
            ////pedimos al usuario que escriba una distancia en pulgadas y guardamos el
            ////valor en la variable pulgadas
            //Console.WriteLine("Escribe una distancia en pulgadas");
            //pulgadas = Convert.ToDouble(Console.ReadLine());
            ////hacemos la conversión a metros utilizando  la fórmula siguiente: 
            ////metros = pulgadas * 0.0254
            //metros = pulgadas * distanciaPulgadas;
            ////mostramos por pantalla el resultado
            //Console.WriteLine(pulgadas + " pulgadas son " + metros + " metros");

            ////Ejercicio 20
            ////pedimos al usuario un número y guardamos el valor en la variable de tipo 
            ////int llamada 'minutos'
            //Console.WriteLine("Escribe un numero de minutos para convertirlos a años y dias");
            //int minutos = Convert.ToInt32(Console.ReadLine());
            ////creamos la variable de tipo int llamda 'dias' y le asignamos un valor en
            ////función del valor de la variable 'minutos'. hemos calculado el número de
            ////horas que se corresponde al número de minutos y también cuántos días hay
            ////en ese número de horas
            //int dias = (minutos / 60) / 24;
            ////creamos una variable de tipo int llamada 'anos' (si utilizamos la ñ puede
            ////haber problemas al ejecutar el programa) y calculamos cuantos años hay 
            ////en el número de días calculado previamente.
            //int anos = dias / 365;
            ////mostramos por pantalla el resultado. teniendo en cuenta que 365 días hacen
            ////un año, calculamos el resto de la división de la variable 'dias' entre 365
            ////para calcular el número de días
            //Console.Write("Esos minutos son " + anos + " años y " + (dias % 365) + " días ");
            //Console.ReadLine();

            ////Ejercicio 21
            ////creamos variables de tipo double llamadas 'metros', 'km', 'segundos',
            ////'minutos', 'horas', y 'segTotal'
            //double metros, km, segundos, minutos, horas, segTotal;
            ////pedimos al usuario un número que guardaremos en la variable 'metros'
            //Console.WriteLine("Introduce una distancia en metros.");
            //metros = Convert.ToDouble(Console.ReadLine());
            ////hacemos la conversión de metros a kilómetros y guardamos en la variable 'km'
            //km = metros / 1000;
            ////pedimos al usario un número que serán las horas y guardamos el valor en 
            ////la variable 'horas'
            //Console.WriteLine("Introduce un tiempo en horas.");
            //horas = Convert.ToDouble(Console.ReadLine());
            ////pedimos al usuario un número que serán los minutos y guardamos el valor
            ////en la variable 'minutos'
            //Console.WriteLine("Introduce un tiempo en minutos.");
            //minutos = Convert.ToDouble(Console.ReadLine());
            ////pedimos al usuario un número que serán los segundos y guardamos el valor
            ////en la variable 'segundos'
            //Console.WriteLine("Introduce un tiempo en segundos.");
            //segundos = Convert.ToDouble(Console.ReadLine());
            ////hacemos la conversión de horas, minutos y segundos a segundos y guardamos
            ////el valor en la variable 'segTotal'
            //segTotal = segundos + (minutos * 60) + (horas * 3600);
            ////escribimos el resultado
            //Console.WriteLine("La velocidad son " + (metros / segTotal) + " m/seg y " + (km / (segTotal / 3600) + " km/h"));
            //Console.ReadLine();

            ////Ejercicio 22
            ////creamos 3 variables de tipo int en las que guardaremos las horas, los minutos
            ////y los segundos
            //int horas, minutos, segundos;
            ////pedimos al usuario que escriba el tiempo en segundos que vamos a calcular
            ////y guardamos el valor en la variable 'segundos'
            //Console.WriteLine("Escribe los segundos que vamos a pasar a horas, minutos y segundos");
            //segundos = Convert.ToInt32(Console.ReadLine());
            ////convertimos los segundos en horas y guardamos el valor en la variable
            ////'horas'
            //horas = segundos / 3600;
            ////convertimos los segundos en minutos y guardamos el valor en la variable
            ////'minutos'
            //minutos = segundos / 60;
            ////mostramos por pantalla el resultado. como cada 60 minutos son una hora, calculamos
            ////el resto de la divisón del número de minutos (guardado en la variable 'minutos')
            ////entre 60 y hacemos los mismo con los segundos.
            //Console.WriteLine(segundos + " segundos son: " + horas + " horas, " + minutos % 60 + " minutos y " + segundos % 60 + " segundos");

            //Ejercicio 23
            //creamos un objeto de la clase 'Random' llamado 'aleatorio'
            Random aleatorio = new Random();
            //creamos una variable de tipo int llamada 'numerAleatorio'. para asignarle
            //un valor utilizamos la función 'Next(int, int)'. esta función crea un 
            //número aleatorio que se encuentre entre los dos valores que le decimos
            //nosotros, en este caso entre 1 y 100.
            int numeroAleatorio = aleatorio.Next(1, 100);
            //mostramos por pantalla el número aleatorio generado y guardado en la
            //variable 'numeroAleatorio'
            Console.WriteLine(numeroAleatorio);
            Console.ReadLine();

            ////Ejercicio string 1
            //Console.WriteLine("Escribe una frase");
            ////declaramos una variable de tipo string llamada 'frase' a la que le damos el valor que leemos por pantalla
            //string frase = Console.ReadLine();
            ////declaramos una variable de tipo int llamada 'largura' en la que almacenaremos la longitud del string 'frase'
            ////usando el método string.Length;
            //int largura = frase.Length;
            ////escribimos el resultado
            //Console.WriteLine("La largura de la frase es: " + largura);
            //Console.ReadKey();

            ////Ejercicio string 2
            //Console.WriteLine("Escribe una frase en MAYÚSCULAS");
            ////declaramos una variable de tipo string llamada 'frase' en la que almacenamos lo que leemos por pantalla
            //string frase = Console.ReadLine();
            ////declaramos una variable de tipo string en la que almacenamos el valor de la variable 'frase' 
            ////pasado a minúsculas usando el método string.ToLower();
            //string minusculas = frase.ToLower();
            ////escribimos el resultado
            //Console.WriteLine(minusculas);
            //Console.ReadKey();

            ////Ejercicio string 3
            //Console.WriteLine("Escribe una frase en minúsculas");
            ////declaramos una variable de tipo string llamada 'frase' en la que almacenamos lo que leemos por pantalla
            //string frase = Console.ReadLine();
            ////declaramos una variable de tipo string en la que almacenamos el valor de la variable 'frase' 
            ////pasado a mayúsculas usando el método string.ToUpper();
            //string mayusculas = frase.ToUpper();
            ////escribimos el resultado
            //Console.WriteLine(mayusculas);
            //Console.ReadKey();

            ////Ejercicio string 4
            //Console.WriteLine("Escribe una frase");
            ////declaramos una variable tipo string en la que almacenamos lo que leemos por pantalla
            //string frase = Console.ReadLine();
            ////declaramos una variable de tipo string en la que almacenamos una copia del string 'frase'
            ////usando el método string.Copy();
            //string copia = string.Copy(frase);
            ////escribimos el resultado
            //Console.WriteLine(copia);

            ////Ejercicio string 5
            ////declaramos dos variables de tipo string a los que les damos un valor
            //string frase1 = "Hola Arrate";
            //string frase2 = "Hola Iker";
            ////escribimos por pantalla el valor de la primera variable
            //Console.WriteLine("Frase 1: " + frase1);
            ////asignamos un nuevo valor a 'frase1'. usamos el método string.Replace()
            ////para cambiar el valor de 'frase1' por el de 'frase2'
            //frase1 = frase1.Replace(frase1, frase2);
            //Console.WriteLine("Frase 1: " + frase1);

            ////Ejercicio string 6
            ////pedimos al usuario una cadena de caracteres
            //Console.WriteLine("Escribe una frase de más de 10 caracteres");
            ////declaramos una variable de tipo string en la que almacenamos lo que leemos por pantalla
            //string frase = Console.ReadLine();
            ////declaramos una variable de tipo string en la que almacenamos los caracteres colocados
            ////a partir de la posición 5 usando el método string.Substring();
            //string caracteres = frase.Substring(5);
            ////escribimos el resultado
            //Console.WriteLine(caracteres);


        }
    }
}
