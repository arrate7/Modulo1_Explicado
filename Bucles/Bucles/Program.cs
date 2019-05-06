using System;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////
            //////EJERCICIO EJEMPLO WHILE

            //int numero = 0;

            ///*usaremos el bucle while. este bucle repetirá la acción definida dentro de él hasta que se cumpla la

            //condición que pongamos. en este caso, el bucle se repetirá mientras el valor de la variable 'numero'

            //sea menor o igual que 100*/

            //while (numero <= 100)

            //{

            //    /*en el bloque de instrucciones del bucle definiremos qué hará el bucle en cada iteración.

            //    mostaremos el valor que la variable 'numero' tenga en cada repetición/iteración y, a continuación,

            //    sumaremos 2 a su valor */

            //    Console.WriteLine(numero);

            //    numero = numero + 2;
            //}

            //////////////////////////////////////////////////////////////////////////////
            //////EJERCICIO EJEMPLO DO WHILE
            //int num;

            ///*el bucle do while es igual al bucle while, con la peculiaridad de que el do while se ejecutará,

            //como mínimo, una vez. el programa primer ejecutará el bloque de instrucciones que está dentro del

            //do y luego comprobará la condición definida en el while. si la condición no se cumple, volverá a

            //ejecutarse el bloque de instrucciones del do */

            //do
            //{
            //    Console.WriteLine("Introduce un número");

            //    num = Convert.ToInt32(Console.ReadLine());

            //} while (num > 0);


            //////EJERCICIO EJEMPLO FOR

            ///*
            // el bucle for viene definido por la siguiente sintaxis. primero declaramos el valor inicial, desde el que 

            // empezará a ejecutarse el bucle. después declaramos la condición que el bucle evaluará en cada iteración: mientras

            // se cumpla, el bucle seguirá ejecutándose; cuando no se cumple, el bucle finaliza. por último, declaramos el valor

            // del incremento que se ejecutará con cada iteración (este valor puede ser negativo).



            //en este caso, declaramos una variable 'i' y le asignamos un valor inicial de 100. la condición para que el bucle

            //siga ejecutándose será de: mientras el valor de i sea mayor o igual a 0. por último, el valor del incremento será de

            //restar 1 al valor que 'i' tenga en cada repetición.

            // */

            //for (int i = 100; i >= 0; i--)
            //{
            //    //mostramos el resultado por pantalla

            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            //////////////////////////////////////////////////////////////////
            //////EJERCICIO EJEMPLO FOR 2

            //int suma = 0;



            ///*valor inicial: 1.

            //  condición: mientras 'i' sea menor o igual a 8

            //  incremento: sumar 1 al valor de i

            //  el bucle se repetirá hasta que se cumpla la condición y ejecutará el bloque de

            //  instrucciones que se encuentra en su interior

            // */

            //for (int i = 1; i <= 8; i++)
            //{

            //    /*

            //     con cada iteración del bucle pediremos un número al usuario y almacenaremos su valor

            //     en la variable de tipo int llamada 'num'. ese valor lo sumaremos al valor que tenga 'suma'

            //     en cada iteración y guardaremos el valor en la variable 'suma'.



            //    hay que tener en cuenta que primero se ejecuta lo que está a la derecha del símbolo = y luego

            //    se asigna el valor, por lo que el valor de 'suma' de la derecha será igual al cálculo realizado

            //    en la iteración anterior del bucle.

            //     */
            //    Console.WriteLine("Introduce un número");

            //    int num = Convert.ToInt32(Console.ReadLine());

            //    suma = suma + num;

            //}

            ////mostramos por pantalla el resultado

            //Console.WriteLine(suma);
            //Console.ReadLine();


            ///////////////////////////////////////////////////////
            ///
            ////EJERCICIO EJEMPLO FOR 2

            //int suma = 0;



            ///*valor inicial: 1.

            //  condición: mientras 'i' sea menor o igual a 8

            //  incremento: sumar 1 al valor de i

            //  el bucle se repetirá hasta que se cumpla la condición y ejecutará el bloque de

            //  instrucciones que se encuentra en su interior

            // */

            //for (int i = 1; i <= 8; i++)

            //{

            //    /*

            //     con cada iteración del bucle pediremos un número al usuario y almacenaremos su valor

            //     en la variable de tipo int llamada 'num'. ese valor lo sumaremos al valor que tenga 'suma'

            //     en cada iteración y guardaremos el valor en la variable 'suma'.



            //    hay que tener en cuenta que primero se ejecuta lo que está a la derecha del símbolo = y luego

            //    se asigna el valor, por lo que el valor de 'suma' de la derecha será igual al cálculo realizado

            //    en la iteración anterior del bucle.

            //     */

            //    Console.WriteLine("Introduce un número");

            //    int num = Convert.ToInt32(Console.ReadLine());



            //    suma = suma + num;



            //}

            ////mostramos por pantalla el resultado

            //Console.WriteLine(suma);
            //Console.ReadLine();

            ///////////////////////////////////////////////////////////////////
            //////EJERCICIO 1
            /////CON WHILE

            ////creamos una variable de tipo int llamada 'numero' a la que le damos un valor inicial de 10    

            //int numero = 10;

            ////usamos el while para iniciar el bucle. 

            //while (numero <= 20)

            //{

            //    //mientras el valor de la variable número sea menor o igual a 20 haremos lo siguiente:

            //    //mostramos por pantalla el valor actual de la variable. usamos \n para dejar un espacio en blanco

            //    Console.WriteLine(numero + "\n");

            //    //otra opción sería no poner \n y escribir la siguiente línea

            //    //Console.WriteLine("");

            //    //una vez mostramos por pantalla el valor de la variable, sumamos 1 a la variable y se realiza de nuevo

            //    //la comprobación. si el valor sigue siendo menor que 20, volveremos a realizar todo este proceso

            //    numero++;

            //}



            //////CON FOR

            ////creamos una variable de tipo int llamada i con un valor inicial de 10. definimos la condición: mientras i

            ////sea menor o igual a 20. por último definimos el incremento: sumar 1 a la variable i por cada iteración del bucle

            //for (int i = 10; i <= 20; i++)
            //{

            //    //mostramos por pantalla el resultado            

            //    Console.WriteLine(i + "\n");
            //}

            ///////////////////////////////////////////////////////////
            /////EJERCICIO 2
            //////CON WHILE

            ////creamos una variable de tipo int llamada 'numero' a la que le damos un valor inicial de 20    

            //int numero = 20;

            ////usamos el while para iniciar el bucle. 

            //while (numero >= 10)

            //{

            //    //mientras el valor de la variable número sea mayor o igual a 10 haremos lo siguiente:

            //    //mostramos por pantalla el valor actual de la variable. usamos \n para dejar un espacio en blanco

            //    Console.WriteLine(numero + "\n");

            //    //otra opción sería no poner \n y escribir la siguiente línea

            //    //Console.WriteLine("");

            //    //una vez mostramos por pantalla el valor de la variable, restamos 1 a la variable y se realiza de nuevo

            //    //la comprobación. si el valor sigue siendo mayor que 10, volveremos a realizar todo este proceso

            //    numero--;

            //}



            //////CON FOR

            ////creamos una variable de tipo int llamada i con un valor inicial de 20. definimos la condición: mientras i

            ////sea mayor o igual a 10. por último definimos el incremento: restar 1 a la variable i por cada iteración del bucle

            //for (int i = 20; i >= 10; i--)

            //{

            //    //mostramos por pantalla el resultado            

            //    Console.WriteLine(i + "\n");



            //}


            //////////////////////////////////////////////////////////
            /////EJERCICIO 3
            /////
            // //creamos dos variables de tipo double llamadas 'numeroIntroducido' y 'suma'. a la variable 'suma' le damos un valor inicial de 0

            //double numeroIntroducido;

            //double suma = 0;



            ////creamos el bucle. creamos una variable de tipo int llamada 'i' a la que asignamos un valor de 0. definimos la condición y el incremento:

            ////mientras i sea menor que 10, sumaremos 1 al valor de la variable i en cada repetición del bucle 

            //for (int i = 0; i < 10; i++)

            //{

            //    //pedimos al usuario que escriba un número

            //    Console.WriteLine("Introduzca un numero");

            //    //guardamos el número en la variable 'numeroIntroducido'

            //    numeroIntroducido = Convert.ToDouble(Console.ReadLine());

            //    //en la variable 'suma' almacenaremos el resultado de la suma de los números que va introduciendo el usuario

            //    //en la primera repetición, la variable suma tiene el valor que le hemos asignado al principio del programa, es

            //    //decir, 0. por lo que si, por ejemplo, el usuario ha escrito el número 7, la siguiente instrucción es igual a "suma = 0 + 7"

            //    //para la siguiente iteración del bucle, suma tendrá un valor de 7, por lo que la variable tomará un valor de

            //    //suma = 7 + numeroIntroducido

            //    suma = suma + numeroIntroducido;

            //}



            //Console.WriteLine(suma);

            ////calculamos la media y mostramos por pantalla el resultado

            //Console.WriteLine(suma / 10);

            //Console.ReadLine();

            /////////////////////////////////////////////////////////
            /////EJERCICIO 4
            /////
            ////creamos dos variables de tipo int llamadas 'num' y 'suma'. 

            //int num;

            //int suma = 0;

            ////usaremos la estructura do...while para asegurarnos de que la sentencia se ejecuta por lo menos una vez

            //do

            //{

            //    //pedimos al usuario que introduzca un numero y lo almacenamos en la variable 'num'

            //    Console.WriteLine("introduce un numero");

            //    num = Convert.ToInt32(Console.ReadLine());

            //    //hacemos una comprobación: si el valor de la variable es mayor o igual a 0, almacenaremos el valor

            //    //en la variable 'suma' y con cada repetición del bucle, sumaremos el numero introducido al valor que

            //    //tenga en cada momento la variable 'suma'

            //    if (num >= 0)

            //    {

            //        suma = suma + num;

            //    }

            //    //si el valor de la variable es negativo, mostraremos el siguiente mensaje por pantalla

            //    else

            //    {

            //        Console.WriteLine("ignoran valores negativos");



            //    }

            //    //realizamos la comprobación del bucle. el bucle se ejecutará siempre y cuando el número introducido por el

            //    //usuario sea distinto de 0

            //} while (num != 0);

            ////mostramos el resultado por pantalla

            //Console.WriteLine("Total valores positivos = " + suma);

            //Console.ReadLine();


            /////////////////////////////////////////////////////////
            /////EJERCICIO 5
            /////
            ////creamos una variable de tipo string llamada 'valor'

            //String valor;

            ////usaremos la estructura do...while para asegurarnos de que el bucle se ejecuta una vez por lo menos

            //do

            //{

            //    //pedimos al usuario que escriba P o I y lo almacenamos en la variable 'valor'. usamos ToUpper() para convertir 

            //    //la letra a mayúsculas independientemente de si el usario la ha escrito en minúsculas, ya que se hace diferenciación 

            //    //entre minúsculas y mayúsculas

            //    Console.WriteLine("Introduzca P para obtener los números pares del 1 al 100 e I para los impares");

            //    valor = Console.ReadLine().ToUpper();

            //    //hacemos una comprobación mediante un if

            //    if (valor == "P")

            //    {

            //        //si la letra almacenada en la variable 'valor' es igual a P, haremos lo siguiente:

            //        //recorreremos todos los números pares hasta el número 100. para ello, creamos la variable 'i' con valor 0

            //        //y le ponemos un incremento de 2. por cada iteración del bucle, sumaremos 2 al valor de la variable i.

            //        for (int i = 0; i <= 100; i += 2)

            //        {

            //            //mostramos por pantalla el valor de 'i' en cada momento

            //            Console.WriteLine(i);



            //        }

            //    }

            //    //si no se cumple la condición anterior, realizaremos una nueva comprobación:

            //    else if (valor == "I")

            //    {

            //        //si la letra almacenada en la variable 'valor' es igual a I, haremos lo siguiente:

            //        //recorreremos todos los números pares hasta el número 100. para ello, creamos la variable 'i' con valor 1

            //        //y le ponemos un incremento de 2. por cada iteración del bucle, sumaremos 2 al valor de la variable i

            //        for (int i = 1; i <= 100; i += 2)

            //        {

            //            //mostramos por pantalla el valor de 'i' en cada momento

            //            Console.WriteLine(i);

            //        }

            //    }

            //    //si no se cumple ninguna de las condiciones anteriores, se ejecuta los siguiente:

            //    else

            //    {

            //        Console.WriteLine("El valor introducido no es correcto.");

            //    }



            //    //definimos la condición para que se repita el bucle. en este caso, el bucle se repetirá mientras el valor introducido

            //    //sea diferente a I o P

            //} while (valor != "P" && valor != "I");



            //Console.ReadLine();



            ////////////////////////////////////////////////////////////////
            /////EJERCICIO 6
            /////

            ////pedimos al usuario que introduzca su edad y almacenamos el valor en la variable de tipo int llamada 'edad'

            //Console.WriteLine("Introduce tu edad:");

            //int edad = Convert.ToInt32(Console.ReadLine());

            ////creamos el bucle con las siguientes características:

            ////creamos una variable de tipo int llamada 'i' y le asignamos el valor de la variable 'edad'

            ////definimos la condición: el bucle se repetirá mientras i sea mayor que 0

            ////por último, definimos el incremento: en este caso, después de cada iteración disminuiremos el valor de 'i' en 1

            //for (int i = edad; i > 0; i--)

            //{

            //    //mostramos el mensaje por pantalla, que se repetirá tantas veces como el valor de la variable 'edad'

            //    Console.WriteLine("Zorionak");



            //}

            //Console.ReadLine();

            //////////////////////////////////////////////////////////////
            /////EJERCICIO 7
            /////
            ////creamos el bucle. declaramos la variable 'i' y le damos un valor

            ////definimos la condición de repetición: mientras 'i' sea menor o igual a 12

            ////definimos un incremento de 1 con cada repetición del bucle

            //for (int i = 1; i <= 12; i++)

            //{

            //    //hacemos una comprobación inicial para saber si el valor de 'i' en cada iteración

            //    //del bucle es par o impar. si el resto de la división del valor 'i' entre 2 es igual a 0

            //    //el número es par, por lo que se cumple la condición

            //    if (i % 2 == 0)

            //    {

            //        //mostramos por pantalla el resultado. usamos Math.Pow() para mostar la potencia. el primer parámetro

            //        //será el número sobre el que queremos hacer el cálculo y el segundo indica a qué potencia vamos a elevar

            //        //"\t" se utiliza para insertar una tabulación en el string

            //        Console.WriteLine(i + "\t" + Math.Pow(i, 3));

            //    }

            //    else

            //    {

            //        //si la condición anterior no se cumple, es decir, si el número es impar, mostraremos por pantalla el resultado

            //        //siguiente:

            //        Console.WriteLine(i + "\t" + Math.Pow(i, 2));

            //    }



            //}

            //Console.ReadLine();

            //////////////////////////////////////////////////////////
            /////EJERCICIO 7
            /////
            // ////FORMA1



            ////pedimos al usuario un número y lo almacenamos en la variable 'alturaPiramide'

            //Console.WriteLine("Introduce un número: ");

            //int alturaPiramide = Convert.ToInt16(Console.ReadLine());



            ////declaramos una variable de tipo string llamada 'asterisco' y le asignamos el valor '*' 

            //string asterisco = "*";

            ////creamos el bucle. declaramos la variable 'i' de tipo int y le asignamos un valor inicial de 1. si fuese 0

            ////la primera línea saldría en blanco.

            ////definimos la condición: el bucle se repetirá mientras el valor de i sea igual o menor al valor de la variable 'alturaPiramide'

            ////por último, definimos un incremento de 1 para la variable 'i' con cada iteración del bucle

            //for (int i = 1; i <= alturaPiramide; i++)

            //{

            //    //creamos un bucle dentro del bucle. declaramos una variable llamada 'j'.

            //    //definimos la condición: el bucle se repetirá mientras el valor de la variable 'j' sea menor que el valor que la variable 'i' tome

            //    //en cada momento.

            //    //el incremento será de 1 con cada iteración del bucle



            //    for (int j = 0; j < i; j++)

            //    {

            //        //con cada iteración del bucle escribiremos un asterisco.

            //        //cuando el programa entra a este bucle no sale de él hasta que se realizan todas las repeticiones

            //        //y como con cada repetición del bucle principal el valor de 'i' va incrementando, este bucle se repetirá tantas

            //        //veces como indique el valor de 'i'

            //        Console.Write(asterisco);

            //    }

            //    //con cada iteración del bucle escribiremos un salto de línea

            //    Console.WriteLine();

            //}





            //Console.ReadLine();



            //////FORMA 2

            ////pedimos al usuario un número y lo almacenamos en la variable 'numero' de tipo int

            //Console.WriteLine("Dame un número");

            //int numero = Convert.ToInt32(Console.ReadLine());



            ////declaramos una variable de tipo string llamada 'dibujo' a la que le damos el valor del string que queremos

            ////dibujar

            //string dibujo = "*";



            ////creamos el bucle. declaramos la variable i, definimos la condición y el incremento

            //for (int i = 1; i <= numero; i++)

            //{

            //    //mostramos por pantalla el valor de la variable 'dibujo' y, después, le asignamos el siguiente valor:

            //    //el valor que tiene en ese momento + un asterisco. con cada repetición del bucle, la variable 'dibujo'

            //    //irá sumando * a su valor, tantos como indique la variable 'numero'

            //    Console.WriteLine(dibujo);

            //    dibujo = dibujo + "*";

            //}

            //Console.ReadLine();



            //////FORMA3

            ////pedimos al usuario que escriba un número y almacenamos el valor en la variable 'resp'

            //Console.WriteLine("Escribe un número, copón.");

            //int resp = Convert.ToInt32(Console.ReadLine());



            ////creamos el bucle. definimos una variable de tipo string llamada 'aster' con valor '*'.

            ////definimos la condición de repetición: mientras la longitud de la variable 'aster' sea menor que el valor de la variable 'resp'

            ////definimos también el incremento: añadiremos un '*' a la variable 'aster'

            //for (string aster = "*"; aster.Length <= resp; aster += "*")

            //{

            //    //mostramos por pantalla el resultado

            //    Console.WriteLine(aster);

            //}



            //Console.ReadLine();

            ///////////////////////////////////////////////////////////
            /////EJERCICIO 8
            /////
            ////creamos el bucle. declaramos la variable 'i' y le damos un valor

            ////definimos la condición de repetición: mientras 'i' sea menor o igual a 12

            ////definimos un incremento de 1 con cada repetición del bucle

            //for (int i = 1; i <= 12; i++)

            //{

            //    //hacemos una comprobación inicial para saber si el valor de 'i' en cada iteración

            //    //del bucle es par o impar. si el resto de la división del valor 'i' entre 2 es igual a 0

            //    //el número es par, por lo que se cumple la condición

            //    if (i % 2 == 0)

            //    {

            //        //mostramos por pantalla el resultado. usamos Math.Pow() para mostar la potencia. el primer parámetro

            //        //será el número sobre el que queremos hacer el cálculo y el segundo indica a qué potencia vamos a elevar

            //        //"\t" se utiliza para insertar una tabulación en el string

            //        Console.WriteLine(i + "\t" + Math.Pow(i, 3));

            //    }

            //    else

            //    {

            //        //si la condición anterior no se cumple, es decir, si el número es impar, mostraremos por pantalla el resultado

            //        //siguiente:

            //        Console.WriteLine(i + "\t" + Math.Pow(i, 2));

            //    }



            //}

            //Console.ReadLine();

            /////////////////////////////////////////////////////////////
            /////EJERCICIO 9
            /////
            // //declaramos una variable de tipo int llamada 'suma' y le asignamos un valor de 0

            //int suma = 0;

            ////creamos el bucle

            //for (int i = 1; i <= 10; i++)



            //{

            //    //hacemos una comprobación: si el valor de 'i' es 1, asignamos el valor de 'i' a la variable

            //    //'suma'

            //    if (i == 1)

            //    {

            //        suma = i;

            //    }

            //    else

            //    {

            //        //si el valor de 'i' NO es 1, asignamos a 'suma' el valor que tenía en la iteración anterior + 5

            //        suma = suma + 5;

            //    }

            //    Console.WriteLine(suma);

            //    //////////////////////////////////////////////////////
            //    ///EJERCICIO 10
            //    ///

            //    //declaramos la variable 'sum' y le asignamos un valor de 0

            //    int sum = 0;

            //    Console.WriteLine("Escribe un numero");

            //    int num = Convert.ToInt32(Console.ReadLine());



            //    //creamos un bucle y definimos su condición y su incremento

            //    for (int i = 1; i <= num; i++)

            //    {

            //        //con cada iteración, asignamos a la variable 'suma' el valor

            //        //resultante de sumar el valor que tenía en la iteración anterior y el valor de 'i'

            //        sum = sum + i;

            //    }

            //    //mostramos el resultado por pantalla

            //    Console.WriteLine(sum);

            //    Console.ReadLine();

            //    ////////////////////////////////////////////////////////////
            //    ///EJERCICIO 11
            //    ///
            //    //declaramos la variable 'num'

            //    int num;

            //    //creamos un bucle do while, que se ejecutará como mínimo una vez, hasta que la condición de comprobación

            //    //se evalúa como falsa

            //    do

            //    {

            //        //declaramos la variable 'sum' y le asignamos un valor de 0

            //        int sum = 0;

            //        //pedimos al usuario un número y almacenamos el valor en la variable 'num'

            //        Console.WriteLine("Escribe un numero");

            //        num = Convert.ToInt32(Console.ReadLine());

            //        //creamos un bucle for con el que iremos sumando los valores que nos vaya dando el usuario

            //        for (int i = 1; i <= num; i++)

            //        {

            //            //asignamos a la variable 'sum' el resultado de sumar el valor que tenía la variable

            //            //en la iteración anterior y el valor de 'i'

            //            sum = sum + i;

            //        }

            //        //mostramos por pantalla el resultado

            //        Console.WriteLine(sum);





            //    } while (num != 0);





            //    Console.ReadLine();

            //    /////////////////////////////////////////////////////////////////
            //    ///EJERCICIO 13
            //    ///
            //    //creamos una variable de tipo string llamada 'num'

            //    string num;

            //    //creamos un bucle do while

            //    do

            //    {

            //        //pedimos al usuario que introduzca un número y almacenamos su valor en la variable 'num'.

            //        //no la convertimos a int porque vamos a trabajar con sus dígitos 1 por 1, para lo cual

            //        //utilizaremos métodos aplicables a variables de tipo string

            //        Console.WriteLine("Introduce un número:");

            //        num = Console.ReadLine();

            //        //declaramos una variable de tipo string llamada 'numInvert'

            //        string numInvert = "";



            //        //creamos el bucle for. declaramos una variable de tipo int llamada i y le asignamos

            //        //el valor de la longitud de la variable num.

            //        //definimos la condición: mientras 'i' sea mayor que 0

            //        //definimos el incremento: con cada iteración del bucle, el valor de 'i' disminuirá en 1

            //        for (int i = num.Length; i > 0; i--)

            //        {

            //            //con el bucle vamos a ir recorriendo los dígitos del número de atrás hacia adelante y vamos a ir guardando

            //            //el valor en la variable 'numInvert'. recordad que es una variable de tipo string, por lo que los valores

            //            //no se sumarán sino que se van a ir concatenando

            //            //como vamos a recorrer el número de atrás hacia adelante, el primer número de numInvert va a ser el último

            //            //del número introducido, por lo que usaremos el método Substring(). el primer parámetro es la posición en la que queremos

            //            //comenzar y el segundo, la longitud del nuevo string.

            //            numInvert = numInvert + num.Substring(i - 1, 1);

            //        }

            //        //mostramos por pantalla el resultado

            //        Console.WriteLine(numInvert);



            //    } while (Convert.ToInt32(num) > 0);

            //    Console.ReadLine();

            //    ///////////////////////////////////////////////////////////////////////
            //    ///EJERCICIO 14
            //    ///
            //    //declaramos la variable factorial y le asignamos un valor

            //    int factorial = 1;

            //    //creamos el bucle. iniciamos el bucle en 1 porque, como vamos a multiplicar, si pusiéramos 0,

            //    //el resultado nos daría todo a 0

            //    for (int i = 1; i <= 10; i++)

            //    {

            //        //calculamos el factorial y lo mostramos por pantalla

            //        factorial = factorial * i;

            //        Console.WriteLine("Número: " + i + "\t Factorial: " + factorial);



            //    }

            //    Console.ReadKey();


            //int x;
            //int number = 0;
            //do
            //{
            //    Console.WriteLine("Introduzca la contraseña");
            //    x = 0;
            //    string password = Console.ReadLine();

            //    if (password.Length < 8)
            //    {
            //        Console.WriteLine("La contraseña debe tener más de 8 dígitos" + "\n");
            //        x++;

            //    }
            //    else 
            //    {
            //        if (!char.IsUpper(Convert.ToChar(password.Substring(0, 1))))
            //        {
            //            Console.WriteLine("La contraseña debe contener una mayúscula en primera posición" + "\n");
            //            x++;
            //        }
            //        else 
            //        {
            //            for (int i = 0; i < password.Length; i++)
            //            {
            //                if (char.IsDigit(Convert.ToChar(password.Substring(i, 1))))
            //                {
            //                    number += 1;
            //                }
            //            }
            //            if (number == 0)
            //            {
            //                Console.WriteLine("La contraseña debe tener al menos un número " + "\n");
            //                x = (x + 1);
            //            }
            //        }
            //    }

            //} while (x != 0);
            //Console.WriteLine("Enhorabuena, la contraseña es adecuada");

            //bool correcto = false;
            //bool numeroEncontrado = false;

            //do
            //{

            //    Console.WriteLine("Introduce una contraseña:");
            //    string pass = Console.ReadLine();

            //    if (pass.Length < 8)
            //    {
            //        Console.WriteLine("La contraseña tiene que contener al menos 8 caracteres ");
            //    }
            //    else
            //    {
            //        for(int i = 1; i < pass.Length; i++)
            //        {
            //            if (char.IsDigit(Convert.ToChar(pass.Substring(i, 1))))
            //            {
            //                numeroEncontrado = true;
            //            }
            //        }

            //        if (numeroEncontrado)
            //        {

            //            if (char.IsUpper(Convert.ToChar(pass.Substring(0, 1))))
            //            {
            //                correcto = true;
                            
            //            }
            //            else
            //            {
            //                Console.WriteLine("La primera letra de la contraseña debe estar en mayúsculas");
            //            }

            //        }
            //        else
            //        {
            //            Console.WriteLine("La contraseña necesita un número");
            //        }


            //    }
            //} while (!correcto);

            //Console.WriteLine("Contraseña correcta");





        }
    }
}