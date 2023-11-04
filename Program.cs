//-------------Juan Imhoff------------------

using static Materiales;
//debería asignarle valores a los materiales de forma random para cada asteroide

int flag = 1;
var rand = new Random();
//cantidad de asteroides a generar 
string[] asteroides = new string[rand.Next(1, 10)];
string[] tamañoAsteroides = { "chico", "mediano", "grande", "cataclismico" };
//cantidad de asteroides
//  tamañoAsteroide (chico mediano grande cataclismo)

int cantMateriales; 

string generadorDeAsteroides()
{
    //int indexTamaño = rand.Next(tamañoAsteroides.Length);

    tamañoAsteroide tamañoRand = (tamañoAsteroide)random.Next(Enum.GetValues(typeof(tamañoAsteroide)).Length);

    //asigno tamaño a el array de asteroides
    for (int i = 0; i < asteroides.Length; i++)
    {
        asteroides[i] = tamañoRand;
        Console.WriteLine(asteroides[i]);
        if (asteroides[i] == "chico")
        {
            cantMateriales = 1000;
            Materiales.Hierro= rand.Next(0, cantMateriales);


        }
    }
    return "";
}
string generadorDeSistemas()
{
    int stringLength = rand.Next(4, 10);
    int valorRand;
    string str = "";
    char letra; 

    for(int i = 0; i < stringLength; i++)
    {
        valorRand = rand.Next(4, 10);
        letra = Convert.ToChar(valorRand + 65);

        str = str + letra;
    }

    str += stringLength;
    Console.WriteLine("String random: " + str);
    return str;
}

/* 1) entrar en un sistema, al entrar se genera una cantidad random de asteroides de difenentes tamaños:
     - chico (1.000kg de materiales) - mediano (2.000 kg) - grande (5.000 kg) - cataclismicos (10.000 kg)
     - Los materiales que se pueden encontrar son : 
        * Hierro
        * Oro
        * Platino
        * Misceláneos
   2) Procesar todos los asteroides.
   3) Generar un reporte con todos los metales adquiridos y poder volver a entrar a otro sistema.
   4) Si se sale del programa se genera un reporte con TODOS los materiales colectados de TODOS los sistemas.
*/

do
{
    generadorDeAsteroides();
    generadorDeSistemas();
    Console.WriteLine(asteroides.Length);
//    Console.WriteLine($"Bienvenido! Hoy estamos visitando el sistema: {str}");
    flag++;
}

while (flag == 1);


int maxMinerales = (int)(tamañoAsteroide);

enum tamañoAsteroide
{
    chico = 1000,
    mediano = 2000,
    grande = 5000,
    astronómico = 10000
}