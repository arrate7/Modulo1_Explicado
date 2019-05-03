using System;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Ejercicio 1
            ////creamos las variables de tipo double
            //double num1, num2, suma, resta, multiplicacion, media, minimo, maximo;
            ////pedimos al usuario un número y asignamos el valor a la variable 'num1'
            //Console.WriteLine("Escribe un número");
            //num1 = Convert.ToDouble(Console.ReadLine());
            ////pedimos al usuariq otro número y asignamos el valor a la variable 'num2'
            //Console.WriteLine("Escribe otro número");
            //num2 = Convert.ToDouble(Console.ReadLine());
            ////asignamos a la variable 'suma' el resultado de sumar los dos números y 
            ////mostramos el resultado por pantalla                        
            //suma = num1 + num2;
            //Console.WriteLine("La suma de " + num1 + " + " + num2 + " es: " + suma);
            ////asignamos el valor de la resta entre los dos números a la variable 'resta'
            ////y mostramos el resultado por pantalla
            //resta = num1 - num2;
            //Console.WriteLine("La resta de " + num1 + " - " + num2 + " es: " + resta);
            ////asignamos el valor de la multiplicación de los dos números a la variable
            ////'multiplicación' y mostramos el resultado por pantalla
            //multiplicacion = num1 * num2;
            //Console.WriteLine("La multiplicación de " + num1 + " * " + num2 + " es: " + multiplicacion);
            ////calculamos la media de los dos números. como ya tenemos el resultado de 
            ////suma de los dos números guardado en la variable 'suma', la utilizamos en vez
            ////de escribir 'num1+num2'. dividimos entre 2 la suma pra obtener la media.
            ////mostramos por pantalla el resultado.
            //media = suma / 2;
            //Console.WriteLine("La media de " + num1 + " y " + num2 + " es: " + media);
            //if (num1 > num2)
            //{
            //    minimo = num2;
            //    maximo = num1;
            //    Console.WriteLine("El mínimo entre " + num1 + " y " + num2 + " es: " + minimo);
            //    Console.WriteLine("El máximo entre " + num1 + " y " + num2 + " es: " + maximo);
            //}
            //else
            //{
            //    minimo = num1;
            //    maximo = num2;
            //    Console.WriteLine("El mínimo entre " + num1 + " y " + num2 + " es: " + minimo);
            //    Console.WriteLine("El máximo entre " + num1 + " y " + num2 + " es: " + maximo);
            //}

            ////Ejercicio 2
            ////pedimos los números al usuario y guardamos sus valores en las variables
            ////'num1', 'num2' y 'num3'
            //Console.WriteLine("Introduce un número:");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Introduce OTRO número:");
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Introduce OTRO número:");
            //int numero3 = Convert.ToInt32(Console.ReadLine());
            ////creamos una variable booleana llamada 'suma' con una valor inicial de 'false'
            //bool suma = false;
            ////usamos un condicional para comprobar la validez de la afirmación
            //if ((numero + numero2) == numero3)
            //{
            //    //si se cumple la condición asignamos un valor de 'true' a la variable 'suma'
            //    suma = true;
            //}
            ////usamos un condicional en el que comprobamos el valor de la variable 'suma'
            //if (suma)
            //{
            //    //si el valor de la variable 'suma' es 'true' mostraremos el siguiente mensaje
            //    Console.WriteLine("La suma de " + numero + " y " + numero2 + " es igual a " + numero3);
            //}
            ////si el valor de la variable 'suma' NO es 'true', entraremos aquí y mostraremos
            ////el siguiente mensaje
            //else
            //{
            //    Console.WriteLine("La suma de " + numero + " y " + numero2 + " no es igual a " + numero3);
            //}
            //Console.ReadKey();


            ////Ejercicio 3
            ////creamos 3 variables de tipo int en las que almacenaremos los valores de
            ////los números que nos indique el usuario
            //int num1, num2, num3;
            ////pedimos al usuario que escriba 3 números y los almacenamos en las variables
            ////'num1', 'num2' y 'num3'
            //Console.WriteLine("Escribe un número");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Escribe un número");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Escribe un número");
            //num3 = Convert.ToInt32(Console.ReadLine());
            ////utilizamos un condicional para comprobar si se cumplen las condiciones:
            ////si num1 es 20 menos que num2 o que num3, entonces escribimos el siguiente
            ////mensaje
            //if (num1 == num2 - 20 || num1 == num3 - 20)
            //{
            //    Console.WriteLine(num1 + " es 20 menos que otro número");
            //}
            ////si la condición anterior no se cumple, entonces comprobaremos la validez
            ////de la siguiente condición: si num2 es 20 menos que num1 o que num3, entonces
            ////escribiremos el siguiente mensaje
            //else if (num2 == num1 - 20 || num2 == num3 - 20)
            //{
            //    Console.WriteLine(num2 + " es 20 menos que otro número");
            //}
            ////si la condición anterior tampoco se cumple, comprobaremos la validez de la
            ////siguiente condición: si num3 es 20 menos que num1 o que num2, 
            ////escribiremos el siguiente mensaje
            //else if (num3 == num1 - 20 || num3 == num1 - 20)
            //{
            //    Console.WriteLine(num3 + " es 20 menos que otro número");
            //}
            ////si ninguna de las condiciones anteriores se ha cumplido, llegaremos a este
            ////punto, en el que escribiremos el siguiente mensaje
            //else
            //{
            //    Console.WriteLine("Ningún número es 20 menos que otro");
            //}
            //Console.ReadKey();

            ////Ejercicio 4
            //Console.WriteLine("¿Has pagado la entrada? (S/N)");
            ////creamos una variable de tipo string llamada 'respuesta' en la que guardamos
            ////la respuesta dada por el usuario. usamos ToUpper() para convertir la
            ////respuesta a mayúscula aunque el usuario la haya escrito en minúscula
            //string respuesta = Console.ReadLine().ToUpper();
            ////usamos un condicional para comprobar que se cumple la condición:
            //if (respuesta == "S")
            //{
            //    //si el usuario ha indicado que ha pagado la entrada, mostraremos el siguiente
            //    //mensaje:
            //    Console.WriteLine("Bienvenido.");
            //}
            ////si no se cumple la condición, mostraremos el siguiente mensaje:
            //else
            //{
            //    Console.WriteLine("Tienes que pagar la entrada.");
            //}
            //Console.ReadLine();
            //Console.WriteLine("¿Eres VIP? (S/N)");
            ////creamos una variable llamada 'string' en la que almacenamos la respuesta
            ////del usuario

            //string vip = Console.ReadLine().ToUpper();
            ////comprobamos la validez de la condición
            //if (vip == "S")
            //{
            //    //si el usuario es VIP, mostraremos el siguiente mensaje
            //    Console.WriteLine("Bienvenido, que pase un buen día.");
            //}
            ////si no se cumple la condición, mostraremos el siguiente mensaje
            //else
            //{
            //    Console.WriteLine("Bienvenido.");
            //}
            //Console.ReadLine();
            //Console.WriteLine("¿De cuanto saldo dispones?");
            ////creamos una variable de tipo double llamada 'saldo' en la que guardaremos
            ////la respuesta del usuario
            //double saldo = Convert.ToDouble(Console.ReadLine());
            ////comprobamos si se cumple la condición
            //if (saldo >= 0)
            //{
            //    //si el usuario tiene un saldo mayor o igual a 0, mostraremos el siguiente 
            //    //mensaje
            //    Console.WriteLine("Bienvenido.");
            //}
            ////comprobamos si se cumple la condición siguiente
            //if (vip == "S" && saldo > 0)
            //{
            //    //si el usuario es VIP y tiene un saldo mayor que 0, mostraremos el siguiente
            //    //mensaje
            //    Console.WriteLine("Bienvenido.");
            //}
            //Console.ReadLine();

            ////Ejercicio 5
            //Console.WriteLine("Introduce una frase");
            ////creamos una variable de tipo string llamada 'frase' en la que guardamos
            ////la frase escrita por el usuario. usamos ToUpper() para pasar el string
            ////a mayúsculas aunque esté escrito en minúsculas
            //string frase = Console.ReadLine().ToUpper();
            ////comprobamos si se cumple la condición.
            //if (frase.Contains("R"))
            //{
            //    //usamos Contains() para comprobar si el string 'frase' contiene la R. si la
            //    //frase contiene R, mostraremos el siguiente mensaje:
            //    Console.WriteLine("Contiene la letra r");
            //}
            ////si no se cumple la condición anterior mostraremos el siguiente mensaje:
            //else
            //{
            //    Console.WriteLine("No contiene la letra r");
            //}
            //Console.ReadLine();

            ////Ejercicio 6
            ////creamos 4 variables de tipo int
            //int num1, num2, resto1, resto2;
            ////pedimos al usuario un número y lo guardamos en la variable 'num1'
            //Console.WriteLine("Escribe un número");
            //num1 = Convert.ToInt32(Console.ReadLine());
            ////pedimos al usuario un número y lo guardamos en la variable 'num2'
            //Console.WriteLine("Escribe un número");
            //num2 = Convert.ToInt32(Console.ReadLine());
            ////calculamos el resto de de la división de cada número entre 6
            //resto1 = num1 % 6;
            //resto2 = num2 % 6;
            ////utilizamos un condicional para comprobar la primera condición. si se cumple
            ////mostraremos por pantalla el siguiente mensaje
            //if (num1 == num2)
            //{
            //   Console.WriteLine(0);
            //}
            ////si la condición anterior no se cumple, comprobaremos si se cumple la siguiente
            ////condición.
            //else if (resto1 == resto2)
            //{
            //    //si el resto de los dos números es igual, comprobaremos cuál de los dos
            //    //números es mayor.
            //    if (num1 > num2)
            //    {
            //        //si 'num1' es mayor, mostraremos por pantalla el valor de 'num2'                        
            //        Console.WriteLine(num2);
            //    }
            //    else if (num1 < num2)
            //    //si 'num2' es mayor, mostraremos por pantalla el valor de 'num1'
            //    {
            //        Console.WriteLine(num1);
            //    }
            //}
            ////si ninguna de las condiciones anteriores se ha cumplido, comprobaremos la 
            ////condición
            //else
            //{
            //    if (num1 > num2)
            //    {
            //        //si 'num1' es mayor, mostraremos por pantalla el valor de 'num1'
            //        Console.WriteLine(num1);
            //    }
            //    //si 'num2' es mayor, mostraremos por pantalla el valor de 'num2'
            //    else if (num1 < num2)
            //    {
            //        Console.WriteLine(num2);
            //    }

            //}

            ////Ejercicio 7
            //Console.WriteLine("Escribe dos número entre 25 y 75 para ver si hay un dígito común entre ellos");
            ////creamos dos variables de tipo int llamadas 'numero1' y 'numero2', en las que
            ////guardamos los valores de los números pedidos al usuario
            //int numero1, numero2;
            //Console.WriteLine("Escribe el primer número");
            //numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Escribe el segundo número");
            //numero2 = Convert.ToInt32(Console.ReadLine());
            ////comprobamos con un condicional si los números cumplen con la condición de
            ////estar entre 25 y 75
            //if (numero1 >= 25 && numero1 <= 75 && numero2 >= 25 && numero2 <= 75)
            //{
            //    //creamos dos variables de tipo int llamadas 'd11' y 'd12' que mostarán la 
            //    //primera cifra de cada número. para ello dividimos entre 10 y, como son
            //    //variables de tipo int, únicamente nos mostará números enteros, no decimales
            //    int d11 = numero1 / 10;
            //    int d12 = numero2 / 10;
            //    //creamos una variable booleana llamada 'coincide' a la que le damos un valor
            //    //inicial de 'false'
            //    bool coincide = false;
            //    //utilizamos un condicional para comprobar si la primera cifra de ambos números
            //    //coincide
            //    if (d11 == d12)
            //    {
            //        //si coinciden, mostraremos en pantalla el siguiente mensaje:
            //        Console.WriteLine("Las dos cifras de las decenas coinciden");
            //        //como hay una cifra que coincide, asignaremos el valor 'true' a la variable
            //        //'coincide'
            //        coincide = true;
            //    }
            //    //realizamos una nueva comprobación. en este caso miraremos si la segunda cifra
            //    //del primer número coincide con la primera cifra del segundo número. para 
            //    //sacar la segunda cifra calculamos el resto de la división del número entre 10
            //    if (numero1 % 10 == d12)
            //    {
            //        //si coinciden, mostraremos el siguiente mensaje y asignaremos el valor 'true'
            //        //a la variable 'coincide'
            //        Console.WriteLine("La cifra de las unidades del primer número coincide con la de las decenas del segundo");
            //        coincide = true;
            //    }
            //    //realizamos una nueva comprobación. ahora miraremos si la segunda cifra del
            //    //primer número coinciden con la segunda cifra del segundo número.
            //    if (numero1 % 10 == numero2 % 10)
            //    {
            //        //si coinciden, mostraremos el siguiente mensaje y asignaremos el valor 'true'
            //        //a la variable 'coincide'
            //        Console.WriteLine("Las cifras de las unidades coinciden ");
            //        coincide = true;
            //    }
            //    //realizamos una nueva comprobación. miraremos si la primera cifra del primer
            //    //número coincide con la segunda cifra del segundo número.
            //    if (d11 == numero2 % 10)
            //    {
            //        //si coinciden, mostraremos el siguiente mensaje y asignaremos el valor 'true'
            //        //a la variable 'coincide'
            //        Console.WriteLine("La cifra de las decenas del primer numero y la de las unidades del segundo coinciden");
            //        coincide = true;
            //    }
            //    //finalmente, realizaremos una comprobación para ver si la variable 'coincide'
            //    //tiene valor 'false'
            //    if (coincide == false)
            //    {
            //        //si la variable 'coincide' tiene valor 'false' es porque ninguna de las 
            //        //condiciones anteriores se ha cumplido, es decir, ninguna cifra coincide.
            //        //por lo tanto, mostraremos el siguiente mensaje
            //        Console.WriteLine("Ninguna cifra coincide.");
            //    }
            //}
            ////si algún número introducido no está dentro del rango establecido mostraremos
            ////el siguien mensaje
            //else
            //{
            //    Console.WriteLine("El número introducido no está dentro del rango 25-75");
            //}
            //Console.ReadLine();

            ////Ejercicio 8
            //Console.WriteLine("¿En qué puesto has acabado?");
            //int puesto = Convert.ToInt32(Console.ReadLine());
            ////Si el valor de puesto es 1 mostramos mensaje con "Ganaste", si no "Lo importante es participar”.
            //if (puesto == 1)
            //{
            //    Console.WriteLine("¡Ganaste!");
            //}
            //else
            //{
            //    Console.WriteLine("Lo importante es participar.");
            //}
            ////Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", si el valor de puesto es 2, 
            ////mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" y al resto 
            ////"Lo importante es participar.
            //if (puesto == 1)
            //{
            //    Console.WriteLine("Medalla de oro");
            //}
            //else if (puesto == 2)
            //{
            //    Console.WriteLine("Medalla de plata");
            //}
            //else if (puesto == 3)
            //{
            //    Console.WriteLine("Medalla de bronce");
            //}
            //else
            //{
            //    Console.WriteLine("Lo importante es participar.");
            //}
            ////Con switch: Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", 
            ////si el valor de puesto es 2, mostramos el mensaje con "Medalla de plata",
            ////si es 3 "Medalla de bronce" y al resto "Lo importante es participar.
            //switch (puesto)
            //{
            //    case 1:
            //        Console.WriteLine("Medalla de oro");
            //        break;
            //    case 2:
            //        Console.WriteLine("Medalla de plata");
            //        break;
            //    case 3:
            //        Console.WriteLine("Medalla de bronce");
            //        break;
            //    default:
            //        Console.WriteLine("Lo importante es participar.");
            //        break;
            //}
            ////Los puestos 1, 2 y 3 ven el mensaje "Sube al podium", el resto ven el mensaje "Se acabó la carrera".
            ////Hazlo usando un if/else y usando switch
            //if (puesto == 1 || puesto == 2 || puesto == 3)
            //{
            //    Console.WriteLine("Sube al podium");
            //}
            //else
            //{
            //    Console.WriteLine("Se acabó la carrera");
            //}
            //switch (puesto)
            //{
            //    case 1:
            //        Console.WriteLine("Sube al podium");
            //        break;
            //    case 2:
            //        Console.WriteLine("Sube al podium");
            //        break;
            //    case 3:
            //        Console.WriteLine("Sube al podium");
            //        break;
            //    default:
            //        Console.WriteLine("Se acabó la carrera");
            //        break;
            //}
            //Console.ReadLine();

            ////Ejercicio 8
            //Console.WriteLine("¿En qué puesto has acabado?");
            //int puesto = Convert.ToInt32(Console.ReadLine());
            //////Si el valor de puesto es 1 mostramos mensaje con "Ganaste", si no "Lo importante es participar”.
            //if (puesto == 1)
            //{
            //    Console.WriteLine("¡Ganaste!");
            //}
            //else
            //{
            //    Console.WriteLine("Lo importante es participar.");
            //}
            //////Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", si el valor de puesto es 2, 
            //////mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" y al resto 
            //////"Lo importante es participar.
            //if (puesto == 1) // si se cumple la condición entramos aquí
            //{
            //    Console.WriteLine("Medalla de oro");
            //}
            //else if (puesto == 2) // si la condición anterior no se cumple evaluamos esta condición. si se cumple entramos aqui
            //{
            //    Console.WriteLine("Medalla de plata");
            //}
            //else if (puesto == 3) // si la condición anterior no se cumple evaluamos esta condición. si se cumple entramos aqui
            //{
            //    Console.WriteLine("Medalla de bronce");
            //}
            //else // si ninguna de las condiciones anteriores se cumple entramos aquí
            //{
            //    Console.WriteLine("Lo importante es participar.");
            //}
            //////Con switch: Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", 
            //////si el valor de puesto es 2, mostramos el mensaje con "Medalla de plata", 
            //////si es 3 "Medalla de bronce" y al resto "Lo importante es participar.
            //switch (puesto)
            //{
            //    case 1:
            //        Console.WriteLine("Medalla de oro");
            //        break;
            //    case 2:
            //        Console.WriteLine("Medalla de plata");
            //        break;
            //    case 3:
            //        Console.WriteLine("Medalla de bronce");
            //        break;
            //    default:
            //        Console.WriteLine("Lo importante es participar.");
            //        break;
            //}
            //////Los puestos 1, 2 y 3 ven el mensaje "Sube al podium", el resto ven el mensaje "Se acabó la carrera".
            //////Hazlo usando un if/else y usando switch
            //if (puesto == 1 || puesto == 2 || puesto == 3) //usamos el || OR para comprobar que se cumple cualquiera de las condiciones
            //{
            //    Console.WriteLine("Sube al podium");
            //}
            //else //si no se cumple ninguna de las condiciones, entramos aquí
            //{
            //    Console.WriteLine("Se acabó la carrera");
            //}
            //switch (puesto)
            //{
            //    case 1:
            //        Console.WriteLine("Sube al podium");
            //        break;
            //    case 2:
            //        Console.WriteLine("Sube al podium");
            //        break;
            //    case 3:
            //        Console.WriteLine("Sube al podium");
            //        break;
            //    default:
            //        Console.WriteLine("Se acabó la carrera");
            //        break;
            //}
            //Console.ReadLine();

            ////Ejercicio 10
            //int edad = Convert.ToInt32(Console.ReadLine()); //creamos una variable de tipo int y le asignamos el valor que leemos por pantalla
            //if (edad <= 8) //si la condición se cumple entramos aquí
            //{
            //    Console.WriteLine("Pasa al tobogán");
            //}
            //else //si la condición no se cumple entramos aquí
            //{
            //    Console.WriteLine("Eres demasiado mayor para usar el tobogán");
            //}

            ////Ejercicio 11
            //Console.WriteLine("Escribe una frase:"); //pedimos al usuario que esciba una frase
            //string frase = Console.ReadLine(); //almacenamos lo que leemos por pantalla en la variable frase
            //int largo = frase.Length; //calculamos la longitud de la frase con el método Length
            //Console.WriteLine("largo:" + largo);
            //if (largo % 2 == 0) //calculamos si la longitud es par. si se cumple, entramos aquí
            //{
            //    string resultado1 = frase.Substring((largo / 2) - 1, 2); //usamos el método Substring() para calcular los dos caracteres centrales. 
            //    //para ello le indicamos el punto de inicio (recuerda que el primer índice es 0) que viene definido por la longitud del string dividido entre 2 y - 1
            //    //el segundo parámetro será el número de caracteres que queremos que recorra, en este caso 2
            //    Console.WriteLine(resultado1);
            //}
            //else // si la condicion anterior no se cumple entramos aquí
            //{
            //    string resultado2 = frase.Substring((largo / 2), 1); //hacemos lo mismo que antes. como es impar, no necesitamos restar 1 al resultado de la división de la longitud
            //    //le pedimos que recorra una posición
            //    Console.WriteLine(resultado2);
            //}

            //Ejercicio 12

            Console.WriteLine("Escribe una día de la semana:"); //pedimos al usuario que escriba un día

            string dia = Console.ReadLine().ToUpper(); //guardamos en la variable dia. usamos el método ToUpper() para pasar a mayúscula y evitarnos problemas



            //switch (dia) //usamos switch y comparamos la variable dia
            //{
            //    case "LUNES":
            //        Console.WriteLine("Hoy es lunes"); //si es LUNES, escribimos esto
            //        break;
            //    case "MARTES":
            //        Console.WriteLine("Hoy es martes"); //si es MARTES, escribimos esto
            //        break;
            //    case "MIERCOLES":
            //        Console.WriteLine("Hoy es miércoles"); //si es MIERCOLES, escribimos esto
            //        break;
            //    case "JUEVES":
            //        Console.WriteLine("Hoy es jueves"); //si es JUEVES, escribimos esto
            //        break;
            //    case "VIERNES":
            //        Console.WriteLine("Hoy es viernes"); //si es VIERNES, escribimos esto
            //        break;
            //    case "SABADO":
            //        Console.WriteLine("Hoy es sábado"); //si es SABADO, escribimos esto
            //        break;
            //    case "DOMINGO":
            //        Console.WriteLine("Hoy es domingo"); //si es DOMINGO, escribimos esto
            //        break;
            //    default:
            //        Console.WriteLine("El día introducido no existe"); //si ningún resultado coincide, escribimos esto
            //        break;
            //}

            //Ejercicio 13
            //Console.WriteLine("Introduce una contraseña:"); // pedimos al usuario una contraseña
            //string password = Console.ReadLine(); // guardamos la contraseña
            //int largo = password.Length; //calculamos la longitud  de la contraseña
            //if (largo >= 8) //hacemos la comprobación. si la condición se cumple entramos aquí
            //{
            //    Console.WriteLine("Contraseña correcta");
            //}
            //else // si la condición no se cumple, entramos aquí
            //{
            //    Console.WriteLine("Contraseña incorrecta");
            //}

            //Ejercicio 14
            // usamos la funcion Now de la clase DateTime para calcular.
            // usamos el metodo ToString para pasarlo a string utilizando el formato dado
            Console.WriteLine("Hoy es " + DateTime.Now.ToString("dd/MM/yyyy"));
            Console.ReadLine();

            ////Ejercicio 15
            //Console.WriteLine("Introduce un número entero:"); //pedimos un número
            //double num = Convert.ToDouble(Console.ReadLine()); // almacenamos el número en la variable num
            //if (num < 0) //hacemos una comprobación. si se cumple, entramos aquí
            //{
            //    Console.WriteLine("El valor absoluto de " + num + " es " + (num * -1));
            //    //escribimos el resultado. para pasar de negativo a positivo, multiplicamos el número por -1
            //}
            //else //si no se cumple la condición, entramos aquí
            //{
            //    Console.WriteLine(num);
            //}

            ////Ejercicio 16
            //Console.WriteLine("¿Cuántos helados quieres?");
            //int helados = Convert.ToInt32(Console.ReadLine()); //declaramos la variable helados y almacenamos el numero de helados
            //int valor = 2; //declaramos la variable valor, que es lo que cuesta cada helado
            //int total = helados * valor; //declaramos la variable total, que será el coste total de todos los helados
            //if (helados > 10) //hacemos una comprobación. si se cumple la condicion, entramos aquí
            //{
            //    total = total - valor; //si tenemos más de 10 helados, el coste será el total menos el valor (1 helado gratis)
            //    Console.WriteLine("Tenemos " + helados + " helados y nos han costado " + total + " euros");
            //}
            //else //si no se cumple la condición, entramos aquí
            //{
            //    Console.WriteLine("Tenemos " + helados + " helados y nos han costado " + total + " euros");
            //}

            //Ejercicio 17
            //int numerador, denominador; //declaramos dos variables de tipo int
            //Console.WriteLine("Escribe dos números");
            //numerador = Convert.ToInt32(Console.ReadLine()); //asignamos a cada variable el valor que leemos por pantalla
            //denominador = Convert.ToInt32(Console.ReadLine());
            //if (denominador != 0) //si se cumple la condición, entramos aquí
            //{
            //    Console.WriteLine("El resultado de la división es " + numerador / denominador);
            //}
            //else //si no se cumple la condición anterior, entramos aquí
            //{
            //    Console.WriteLine("No se puede dividir entre 0");
            //}

            ////Ejercicio 18
            //Console.WriteLine("Introduce el año:"); //pedimos al usuario que ponga un año
            //int ano = Convert.ToInt32(Console.ReadLine());
            //if (DateTime.IsLeapYear(ano)) //usamos el método IsLeapYear de la clase DateTime para calcular si es bisiesto. si se cumple la condición, entramos aquí
            //{
            //    Console.WriteLine("Es bisiesto.");
            //}
            //else //si no se cumple la condición anterior, entramos aquí
            //{
            //    Console.WriteLine("No es bisiesto.");
            //}
            ///////////////////////////////////////////////////////////////////////////////

            //if (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0)) //hacemos una comprobación. si se cumplen las condiciones, entramos aquí
            //{
            //    Console.WriteLine("Es bisiesto.");
            //}
            //else //si no se cumple ninguna de las condiciones anteriores, entramos aquí
            //{
            //    Console.WriteLine("No es bisiesto.");
            //}

            ////////////////////////////////////////////////////////////////////////////////

            //if (ano % 400 == 0) //hacemos una comprobación. si se cumple la condición, entramos aquí
            //{
            //    Console.WriteLine("Es bisiesto.");
            //}
            //else // si no se cumple la condición anterior, entramos aquí
            //{
            //    if (ano % 100 == 0) //anidamos un condicional. si se cumple la condición, entramos aquí
            //    {
            //        Console.WriteLine("No es bisiesto.");
            //    }
            //    else if (ano % 4 == 0) //si no se cumple la condición anterior, entramos aquí
            //    {
            //        Console.WriteLine("Es bisiesto.");
            //    }
            //    else // si no se cumple ninguna de las dos condiciones anteriores, entramos aquí
            //    {
            //        Console.WriteLine("No es bisiesto.");
            //    }
            //}
        }

    }
}

