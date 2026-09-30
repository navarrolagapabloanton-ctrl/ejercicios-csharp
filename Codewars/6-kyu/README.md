# Codewars — 6 kyu

[← Volver al README principal](https://github.com/navarrolagapabloanton-ctrl/ejercicios-csharp)

Ejercicios de nivel **6 kyu** realizados en C#. En estas katas aparecen problemas con algo más de análisis, transformaciones de datos, bucles anidados y estructuras de colección.

## Katas incluidas

| Kata | Conceptos principales |
|---|---|
| Equal Sides Of An Array | Arrays, bucles anidados, acumuladores |
| Replace With Alphabet Position | Strings, `char`, conversión de caracteres |
| Build Tower | Arrays de strings, bucles anidados, posiciones |
| Count the Smiley Faces! | Arrays, booleanos, validación por posiciones |
| Take a Ten Minute Walk | `foreach`, contadores, lógica |
| Bouncing Balls | `while`, `double`, acumuladores |
| Sum Dig Power | `Math.Pow`, `List<long>`, conversión de tipos |
| Count characters in your string | `Dictionary<char, int>`, `ContainsKey()`, `Add()`, `KeyValuePair`, contadores |
| Find the odd int | LINQ, `Count()`, lambdas, `foreach`, módulo `%` y conteo de apariciones |
| Duplicate Encoder | LINQ, `Count()`, lambdas, `ToLower()`, `foreach` y transformación de strings |
| Playing with digits | `ToString()`, conversión de dígitos, `Math.Pow()`, acumuladores, `%`, divisibilidad y potencias consecutivas |
| Consecutive strings | Arrays, bucles anidados, índices, concatenación, máximos, grupos consecutivos, `Skip()`, `Take()` y rangos |

---

## Equal Sides Of An Array — 6 kyu

La función recibe un array de números enteros y debe encontrar un índice en el que la suma de todos los elementos situados a la izquierda sea igual a la suma de todos los elementos situados a la derecha.

El valor situado en el propio índice no se incluye en ninguna de las dos sumas.

Si no existe ningún índice que cumpla la condición, se devuelve:

```text
-1
```

Por ejemplo:

```text
[1, 2, 3, 4, 3, 2, 1]
```

En el índice `3` se encuentra el valor `4`.

A la izquierda:

```text
1 + 2 + 3 = 6
```

A la derecha:

```text
3 + 2 + 1 = 6
```

Por tanto:

```text
Resultado = 3
```

### Solución

```csharp
public class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            leftSum = 0;
            rightSum = 0;

            for (int f = 0; f < i; f++)
            {
                leftSum += arr[f];
            }

            for (int h = arr.Length - 1; h > i; h--)
            {
                rightSum += arr[h];
            }

            if (leftSum == rightSum)
            {
                return i;
            }
        }

        return -1;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        int[] array1 = { 1, 2, 3, 4, 3, 2, 1 };
        int[] array2 = { 1, 100, 50, -51, 1, 1 };
        int[] array3 = { 20, 10, -80, 10, 10, 15, 35 };
        int[] array4 = { 0, 0, 0, 0, 0 };

        Console.WriteLine(Kata.FindEvenIndex(array1));
        Console.WriteLine(Kata.FindEvenIndex(array2));
        Console.WriteLine(Kata.FindEvenIndex(array3));
        Console.WriteLine(Kata.FindEvenIndex(array4));
    }
}
```

### Conceptos reforzados

- Recorrido de arrays mediante `for`.
- Uso de bucles anidados.
- Uso de acumuladores.
- Trabajo con índices.
- Recorridos de izquierda a derecha y de derecha a izquierda.
- Comparación de sumas.
- Uso de `return` para terminar un método al encontrar una solución.
- Uso de `-1` para representar que no se ha encontrado ningún índice válido.
- Trabajo con números positivos, negativos y ceros.

### Funcionamiento

El primer `for` recorre cada posición del array:

```csharp
for (int i = 0; i < arr.Length; i++)
```

El índice `i` representa la posición que se está comprobando.

Para cada posible índice se reinician las dos sumas:

```csharp
leftSum = 0;
rightSum = 0;
```

### Suma de la izquierda

El primer bucle interno recorre todos los elementos anteriores a `i`:

```csharp
for (int f = 0; f < i; f++)
{
    leftSum += arr[f];
}
```

Por ejemplo, si:

```text
i = 3
```

se recorren:

```text
arr[0]
arr[1]
arr[2]
```

pero no:

```text
arr[3]
```

### Suma de la derecha

El segundo bucle interno comienza desde el final del array:

```csharp
for (int h = arr.Length - 1; h > i; h--)
{
    rightSum += arr[h];
}
```

De esta forma se suman todos los valores situados después del índice actual.

Si:

```text
i = 3
```

se recorren las posiciones:

```text
última posición
...
5
4
```

sin incluir:

```text
3
```

### Comparación

Después de calcular ambas sumas:

```csharp
if (leftSum == rightSum)
{
    return i;
}
```

si coinciden, se devuelve inmediatamente el índice encontrado.

Si se recorren todos los índices sin encontrar ninguno válido:

```csharp
return -1;
```

### Ejemplo paso a paso

Para:

```text
[1, 2, 3, 4, 3, 2, 1]
```

cuando:

```text
i = 3
```

la suma izquierda es:

```text
1 + 2 + 3 = 6
```

y la suma derecha:

```text
3 + 2 + 1 = 6
```

Como:

```text
6 == 6
```

se devuelve:

```text
3
```

### Casos especiales

Si el índice válido es el primero:

```text
i = 0
```

no existen elementos a la izquierda.

Por tanto:

```text
leftSum = 0
```

Del mismo modo, si se comprobara el último índice, no existirían elementos a la derecha:

```text
rightSum = 0
```

También funciona con arrays formados únicamente por ceros:

```text
[0, 0, 0, 0, 0]
```

En el índice `0`:

```text
izquierda = 0
derecha = 0
```

por lo que se devuelve:

```text
0
```

### Aprendizaje

La solución se basa en comprobar cada índice posible de forma independiente.

Para cada posición:

```text
1. Reiniciar las sumas.
2. Sumar los elementos de la izquierda.
3. Sumar los elementos de la derecha.
4. Comparar ambas cantidades.
5. Devolver el índice si coinciden.
```

Esta solución utiliza bucles anidados y recalcula las sumas para cada índice.

Es una forma directa de trasladar el enunciado a un algoritmo y permite ver claramente qué elementos pertenecen a cada lado del índice.

---

## Replace With Alphabet Position — 6 kyu

La función recibe una cadena de texto y debe sustituir cada letra por su posición correspondiente dentro del alfabeto.

Las reglas son:

- `a` corresponde a `1`.
- `b` corresponde a `2`.
- ...
- `z` corresponde a `26`.
- No se distingue entre mayúsculas y minúsculas.
- Cualquier carácter que no sea una letra debe ignorarse.
- Las posiciones deben aparecer separadas por espacios.

Por ejemplo:

```text
"The sunset sets at twelve o' clock."
```

produce:

```text
20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11
```

### Solución

```csharp
public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        string newText = "";
        bool firstSpace = false;

        foreach (char character in text.ToLower())
        {
            if (character >= 'a' && character <= 'z')
            {
                int intCharacter = (int)character - 96;
                string stringCharacter = intCharacter.ToString();

                if (!firstSpace)
                {
                    newText += stringCharacter;
                    firstSpace = true;
                }
                else
                {
                    newText += ' ' + stringCharacter;
                }
            }
        }

        return newText;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(
            Kata.AlphabetPosition(
                "The sunset sets at twelve o' clock."
            )
        );
    }
}
```

### Conceptos reforzados

- Recorrido de un `string` mediante `foreach`.
- Uso del tipo `char`.
- Conversión de caracteres mediante `char.ToLower()`.
- Comparación de caracteres.
- Uso del valor numérico asociado a un `char`.
- Conversión explícita de `char` a `int`.
- Conversión de `int` a `string`.
- Uso de una variable `bool` para controlar el formato.
- Filtrado manual de caracteres.
- Construcción progresiva de un `string`.

### Funcionamiento

Primero se recorre la cadena convirtiendo cada carácter a minúscula:

```csharp
foreach (char character in text.ToLower())
```

Esto permite tratar igual:

```text
'A'
```

y:

```text
'a'
```

### Filtrar únicamente letras

Se comprueba que el carácter esté comprendido entre:

```csharp
'a'
```

y:

```csharp
'z'
```

mediante:

```csharp
if (character >= 'a' && character <= 'z')
```

De esta forma se ignoran:

```text
espacios
puntos
comas
apóstrofes
números
otros símbolos
```

### Obtener la posición en el alfabeto

Los caracteres tienen asociado un valor numérico.

Por ejemplo:

```text
'a' → 97
'b' → 98
'c' → 99
```

Como la letra `a` debe corresponder a la posición `1`, se resta `96`:

```csharp
int intCharacter = (int)character - 96;
```

Por ejemplo:

```text
'a'

97 - 96 = 1
```

```text
'b'

98 - 96 = 2
```

```text
'c'

99 - 96 = 3
```

Así se obtiene directamente la posición de cada letra en el alfabeto.

### Conversión a string

El resultado numérico se transforma después en texto:

```csharp
string stringCharacter = intCharacter.ToString();
```

Esto permite añadirlo al resultado final.

### Control de los espacios

El resultado debe contener espacios entre los números, pero no debe comenzar con uno.

Para controlar esto se utiliza:

```csharp
bool firstSpace = false;
```

La primera posición se añade directamente:

```csharp
if (!firstSpace)
{
    newText += stringCharacter;
    firstSpace = true;
}
```

A partir de la segunda se añade primero un espacio:

```csharp
else
{
    newText += ' ' + stringCharacter;
}
```

De esta forma se obtiene:

```text
20 8 5 19...
```

y no:

```text
 20 8 5 19...
```

### Aprendizaje

Una parte importante de esta kata fue aprovechar que los caracteres tienen valores numéricos asociados.

Al saber que:

```text
'a' = 97
```

se puede obtener la posición en el alfabeto mediante:

```csharp
(int)character - 96
```

También fue necesario controlar manualmente la separación mediante espacios para que el resultado no tuviera un espacio adicional al principio.

El algoritmo utilizado puede resumirse como:

```text
1. Recorrer cada carácter.
2. Pasarlo a minúscula.
3. Comprobar si está entre 'a' y 'z'.
4. Convertirlo a su valor numérico.
5. Restar 96 para obtener su posición.
6. Convertir el resultado a string.
7. Añadirlo al resultado separado por espacios.
```

### Otra posible aproximación

También podría calcularse la posición relativa respecto a la letra `a` mediante:

```csharp
character - 'a' + 1
```

Por ejemplo:

```text
'b' - 'a' + 1

98 - 97 + 1

= 2
```

En esta solución mantengo `-96` porque fue la forma utilizada originalmente para deducir el algoritmo.

---

## Build Tower — 6 kyu

La función recibe un número entero positivo que representa la cantidad de pisos de una torre o pirámide.

Debe devolver un array de strings donde cada elemento representa uno de los pisos.

La torre está formada por asteriscos `*` y espacios.

Por ejemplo, para:

```text
nFloors = 3
```

el resultado es:

```text
  *  
 *** 
*****
```

### Solución

```csharp
public class Kata
{
    public static string[] TowerBuilder(int nFloors)
    {
        string[] newString = new string[nFloors];
        int pyramiBase = nFloors * 2 - 1;
        int middle = pyramiBase / 2;

        for (int i = 0; i < nFloors; i++)
        {
            for (int f = 0; f < pyramiBase; f++)
            {
                if (f >= middle - i && f <= middle + i)
                {
                    newString[i] += "*";
                }
                else
                {
                    newString[i] += " ";
                }
            }
        }

        return newString;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nTorre nº1: ");

        foreach (string asterisks in Kata.TowerBuilder(3))
        {
            Console.WriteLine(asterisks);
        }

        Console.WriteLine("\nTorre nº2: ");

        foreach (string asterisks in Kata.TowerBuilder(6))
        {
            Console.WriteLine(asterisks);
        }
    }
}
```

### Conceptos reforzados

- Creación de arrays de strings.
- Uso de bucles `for` anidados.
- Uso de índices.
- Cálculo de posiciones dentro de un string.
- Construcción progresiva de strings.
- Uso de condiciones con `&&`.
- Cálculo del ancho de una pirámide.
- Cálculo de su posición central.
- Separación entre la lógica del método y la visualización mediante `Console.WriteLine()`.
- Recorrido del resultado mediante `foreach`.

### Calcular el ancho de la torre

La base de la torre debe contener siempre un número impar de posiciones.

Se calcula mediante:

```csharp
int pyramiBase = nFloors * 2 - 1;
```

Por ejemplo, para una torre de 3 pisos:

```text
3 × 2 - 1 = 5
```

La base mide:

```text
*****
```

Para una torre de 6 pisos:

```text
6 × 2 - 1 = 11
```

Por tanto, cada string del array tendrá una longitud de 11 caracteres.

### Encontrar el centro

Una vez conocido el ancho, se calcula la posición central:

```csharp
int middle = pyramiBase / 2;
```

Para una base de longitud 5:

```text
Índices:

0 1 2 3 4
    ↑
  centro
```

Por tanto:

```text
middle = 2
```

### Construcción de cada piso

El primer `for` controla el piso que se está construyendo:

```csharp
for (int i = 0; i < nFloors; i++)
```

El segundo recorre todas las posiciones de ese piso:

```csharp
for (int f = 0; f < pyramiBase; f++)
```

Después se comprueba si la posición actual pertenece a la zona que debe contener asteriscos:

```csharp
if (f >= middle - i && f <= middle + i)
```

Si pertenece:

```csharp
newString[i] += "*";
```

En caso contrario:

```csharp
newString[i] += " ";
```

### Ejemplo con 3 pisos

La base mide:

```text
3 × 2 - 1 = 5
```

y el centro se encuentra en:

```text
5 / 2 = 2
```

#### Piso 0

```text
middle - i = 2
middle + i = 2
```

Solo la posición `2` contiene un asterisco:

```text
  *  
```

#### Piso 1

```text
middle - i = 1
middle + i = 3
```

Las posiciones `1`, `2` y `3` contienen asteriscos:

```text
 *** 
```

#### Piso 2

```text
middle - i = 0
middle + i = 4
```

Todas las posiciones contienen asteriscos:

```text
*****
```

### Mostrar la torre

El método `TowerBuilder()` únicamente construye y devuelve el array:

```csharp
return newString;
```

Después, desde `Main`, se recorren sus elementos:

```csharp
foreach (string asterisks in Kata.TowerBuilder(3))
{
    Console.WriteLine(asterisks);
}
```

De esta forma se separa la lógica de creación de la torre de su visualización en consola.

### Aprendizaje

La solución se construyó pensando la torre como una serie de posiciones.

Primero se calcula:

```text
1. Cuánto mide la base.
2. Dónde está el centro.
3. Qué piso se está construyendo.
4. Qué posiciones de ese piso deben contener asteriscos.
5. Qué posiciones deben contener espacios.
```

La condición:

```csharp
f >= middle - i && f <= middle + i
```

permite ampliar la zona de asteriscos una posición hacia cada lado conforme aumenta el número de piso.

### Otra posible aproximación

C# permite crear un string repitiendo un carácter mediante:

```csharp
new string(char, cantidad)
```

Por ejemplo:

```csharp
new string('*', 5)
```

produce:

```text
*****
```

y:

```csharp
new string(' ', 3)
```

produce tres espacios.

Utilizando esta posibilidad, cada piso podría construirse calculando directamente la cantidad de espacios y asteriscos.

La solución principal mantiene los bucles anidados porque permite ver de forma explícita cómo se calcula cada posición de la pirámide.

---

## Count the Smiley Faces! — 6 kyu

La función recibe un array de strings y debe devolver cuántos de ellos representan emoticonos sonrientes válidos.

Un emoticono válido debe cumplir estas reglas:

- Los ojos deben ser `:` o `;`.
- La nariz es opcional.
- Si existe nariz, debe ser `-` o `~`.
- La boca debe ser `)` o `D`.
- No se permiten caracteres adicionales.

Ejemplos válidos:

```text
:)
:D
;-D
:~)
```

Ejemplos inválidos:

```text
;(
:>
:}
:]
```

### Solución

```csharp
public static class Kata
{
    public static int CountSmileys(string[] smileys)
    {
        int countSmileys = 0;
        bool hasEyes = false;
        bool hasNose = false;
        bool hasMouth = false;

        for (int i = 0; i < smileys.Length; i++)
        {
            hasEyes = false;
            hasNose = false;
            hasMouth = false;

            for (int f = 0; f < smileys[i].Length; f++)
            {
                if (f == 0)
                {
                    if (smileys[i][f] == ':' || smileys[i][f] == ';')
                    {
                        hasEyes = true;
                    }
                }
                else if (f == 1)
                {
                    if (smileys[i][f] == '-' || smileys[i][f] == '~')
                    {
                        hasNose = true;
                    }
                    else if (smileys[i][f] == ')' || smileys[i][f] == 'D')
                    {
                        hasNose = true;
                        hasMouth = true;
                    }
                }
                else if (f == 2)
                {
                    if (smileys[i][f] == ')' || smileys[i][f] == 'D')
                    {
                        hasMouth = true;
                    }
                }

                if (hasEyes && hasNose && hasMouth)
                {
                    countSmileys++;
                }
            }
        }

        return countSmileys;
    }
}
```

### Versión ejecutable

```csharp
public static class Program
{
    public static void Main(string[] args)
    {
        string[] array = { ":)", ";(", ";}", ":-D" };
        string[] array2 = { ";D", ":-(", ":-)", ";~)" };
        string[] array3 = { ";]", ":[", ";*", ":$", ";-D" };

        Console.WriteLine(Kata.CountSmileys(array));
        Console.WriteLine(Kata.CountSmileys(array2));
        Console.WriteLine(Kata.CountSmileys(array3));
    }
}
```

### Conceptos reforzados

- Recorrido de arrays mediante `for`.
- Recorrido de strings mediante índices.
- Uso de bucles anidados.
- Uso de variables booleanas para representar estados.
- Validación de caracteres según su posición.
- Uso de operadores lógicos `||` y `&&`.
- Reinicio de variables en cada iteración.
- Construcción de un algoritmo a partir de reglas concretas.

### Funcionamiento

El primer `for` recorre cada emoticono del array:

```csharp
for (int i = 0; i < smileys.Length; i++)
```

Antes de analizar cada uno se reinician los estados:

```csharp
hasEyes = false;
hasNose = false;
hasMouth = false;
```

Después se recorre cada carácter del emoticono:

```csharp
for (int f = 0; f < smileys[i].Length; f++)
```

### Posición 0: ojos

La primera posición debe contener:

```text
:
```

o:

```text
;
```

Por eso se comprueba:

```csharp
if (smileys[i][f] == ':' || smileys[i][f] == ';')
{
    hasEyes = true;
}
```

### Posición 1: nariz o boca

Si el emoticono tiene nariz, esta debe ser:

```text
-
~
```

Por eso:

```csharp
if (smileys[i][f] == '-' || smileys[i][f] == '~')
{
    hasNose = true;
}
```

Pero la nariz es opcional.

Por ejemplo:

```text
:)
```

tiene la boca directamente en la posición `1`.

En ese caso:

```csharp
else if (smileys[i][f] == ')' || smileys[i][f] == 'D')
{
    hasNose = true;
    hasMouth = true;
}
```

`hasNose` se marca como `true` aunque no exista una nariz real, porque dentro de este algoritmo representa también que **la condición de la nariz es válida al ser opcional**.

### Posición 2: boca

Si existe una tercera posición, debe contener:

```text
)
D
```

Por eso:

```csharp
if (smileys[i][f] == ')' || smileys[i][f] == 'D')
{
    hasMouth = true;
}
```

### Contar un emoticono válido

Cuando se cumplen las tres condiciones:

```csharp
if (hasEyes && hasNose && hasMouth)
{
    countSmileys++;
}
```

se incrementa el contador.

### Ejemplos

Para:

```text
":)"
```

el recorrido sería:

```text
':' → ojos válidos
')' → boca válida y nariz opcional válida
```

Resultado:

```text
válido
```

Para:

```text
":-D"
```

el recorrido sería:

```text
':' → ojos válidos
'-' → nariz válida
'D' → boca válida
```

Resultado:

```text
válido
```

Para:

```text
";("
```

se detectan ojos válidos, pero:

```text
'('
```

no es una boca permitida.

Resultado:

```text
inválido
```

### Aprendizaje

La solución se construyó siguiendo literalmente las reglas del enunciado:

```text
1. Validar los ojos.
2. Comprobar si existe una nariz válida.
3. Validar la boca.
4. Contar el emoticono si todo es correcto.
```

Como cada parte del emoticono aparece siempre en el mismo orden, se utilizaron las posiciones del string para decidir qué carácter debía aparecer en cada momento.

También fue necesario tener en cuenta que la nariz es opcional.

Por ello, un emoticono de dos caracteres como:

```text
:)
```

también se considera válido aunque no tenga nariz.

### Otra posible aproximación

Como los emoticonos válidos solo pueden tener longitud `2` o `3`, también se podría comprobar directamente:

```text
posición 0 → ojos
posición final → boca
posición 1 → nariz solo si la longitud es 3
```

Por ejemplo, C# permite acceder al último carácter mediante:

```csharp
smiley[^1]
```

donde:

```text
^1
```

significa:

```text
primer elemento empezando desde el final
```

La solución principal mantiene el recorrido carácter por carácter porque fue el enfoque utilizado para traducir directamente las reglas del ejercicio a un algoritmo.

---

## Take a Ten Minute Walk — 6 kyu

La función recibe un array de strings que representa las direcciones de un paseo.

Cada elemento puede ser:

```text
"n" → norte
"s" → sur
"e" → este
"w" → oeste
```

Cada movimiento tarda exactamente un minuto.

El paseo solo será válido si cumple dos condiciones:

1. Tiene exactamente 10 movimientos, es decir, dura 10 minutos.
2. Después de realizar todos los movimientos se vuelve al punto de partida.

### Solución

```csharp
public class Kata
{
    public static bool IsValidWalk(string[] walk)
    {
        int nCounter = 0;
        int sCounter = 0;
        int eCounter = 0;
        int wCounter = 0;

        if (walk.Length != 10)
        {
            return false;
        }
        else
        {
            foreach (string direction in walk)
            {
                if (direction == "n")
                {
                    nCounter++;
                }
                else if (direction == "s")
                {
                    sCounter++;
                }
                else if (direction == "e")
                {
                    eCounter++;
                }
                else if (direction == "w")
                {
                    wCounter++;
                }
            }
        }

        return (nCounter - sCounter == 0
               && eCounter - wCounter == 0);
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        string[] array1 =
        {
            "n", "s", "n", "s", "n",
            "s", "n", "s", "n", "s"
        };

        string[] array2 =
        {
            "w", "e", "w", "e", "w", "e",
            "w", "e", "w", "e", "w", "e"
        };

        string[] array3 =
        {
            "w"
        };

        string[] array4 =
        {
            "n", "n", "n", "s", "n",
            "s", "n", "s", "n", "s"
        };

        Console.WriteLine(Kata.IsValidWalk(array1));
        Console.WriteLine(Kata.IsValidWalk(array2));
        Console.WriteLine(Kata.IsValidWalk(array3));
        Console.WriteLine(Kata.IsValidWalk(array4));
    }
}
```

### Conceptos reforzados

- Recorrido de arrays mediante `foreach`.
- Uso de contadores.
- Uso de `Length`.
- Condicionales `if / else if`.
- Operadores lógicos `&&`.
- Comparación de movimientos opuestos.
- Devolución directa de expresiones booleanas.
- Finalización anticipada de un método mediante `return`.

### Comprobar la duración

Como cada dirección representa un minuto de paseo, el array debe contener exactamente 10 elementos:

```csharp
if (walk.Length != 10)
{
    return false;
}
```

Si el número de movimientos es distinto de 10, no es necesario continuar comprobando el recorrido.

Por ejemplo:

```text
["w"]
```

solo representa un minuto, por lo que devuelve:

```text
false
```

### Contar las direcciones

Si el paseo dura exactamente 10 minutos, se recorren todas las direcciones:

```csharp
foreach (string direction in walk)
```

Se utiliza un contador diferente para cada dirección:

```csharp
int nCounter = 0;
int sCounter = 0;
int eCounter = 0;
int wCounter = 0;
```

Por ejemplo:

```csharp
if (direction == "n")
{
    nCounter++;
}
```

incrementa el número de movimientos realizados hacia el norte.

### Volver al punto de partida

Para terminar exactamente en el mismo lugar, todos los movimientos hacia el norte deben compensarse con movimientos hacia el sur.

Por tanto:

```csharp
nCounter - sCounter == 0
```

Del mismo modo, los movimientos hacia el este deben compensarse con los movimientos hacia el oeste:

```csharp
eCounter - wCounter == 0
```

Ambas condiciones deben cumplirse:

```csharp
return (nCounter - sCounter == 0
       && eCounter - wCounter == 0);
```

### Ejemplo válido

```text
["n", "s", "n", "s", "n", "s", "n", "s", "n", "s"]
```

Tiene:

```text
10 movimientos
```

y:

```text
Norte = 5
Sur   = 5

Este = 0
Oeste = 0
```

Por tanto:

```text
5 - 5 = 0
0 - 0 = 0
```

Resultado:

```text
true
```

### Ejemplo inválido por duración

```text
["w"]
```

Solo contiene un movimiento:

```text
walk.Length = 1
```

Resultado:

```text
false
```

### Ejemplo inválido por posición final

```text
["n", "n", "n", "s", "n", "s", "n", "s", "n", "s"]
```

Aunque contiene exactamente 10 movimientos, hay más movimientos hacia el norte que hacia el sur.

Por tanto, el paseo no termina en el punto inicial.

Resultado:

```text
false
```

### Aprendizaje

El problema puede dividirse en dos comprobaciones independientes:

```text
1. ¿El paseo dura exactamente 10 minutos?
2. ¿El desplazamiento final es igual a 0?
```

La primera condición se comprueba mediante:

```csharp
walk.Length == 10
```

Para la segunda se cuentan por separado las cuatro direcciones.

Las direcciones opuestas deben compensarse:

```text
norte ↔ sur
este  ↔ oeste
```

Por ello, si ambas diferencias son `0`, significa que se ha vuelto al mismo punto desde el que comenzó el paseo.

La solución utiliza cuatro contadores porque permite representar de forma directa las cuatro direcciones indicadas por el enunciado.

---

## Bouncing Balls — 6 kyu

La función simula una pelota que se deja caer desde una altura determinada.

Después de cada impacto contra el suelo, la pelota rebota alcanzando una fracción de la altura anterior.

Una persona observa la pelota desde una ventana situada a cierta altura y hay que calcular cuántas veces ve pasar la pelota por delante de ella.

La pelota puede pasar por la ventana:

- Una vez durante la caída inicial.
- Una vez al subir después de cada rebote suficientemente alto.
- Una vez al volver a bajar después de ese mismo rebote.

### Condiciones

Los datos solo son válidos si:

```text
h > 0
0 < bounce < 1
window < h
```

Si alguna de estas condiciones no se cumple, la función devuelve:

```text
-1
```

### Solución

```csharp
public class BouncingBall
{
    public static int bouncingBall(double h, double bounce, double window)
    {
        if (h <= 0 || bounce >= 1 || bounce <= 0 || h <= window)
        {
            return -1;
        }

        double ballHeight = h * bounce;
        int bouncesCounter = 1;

        while (ballHeight > window)
        {
            bouncesCounter++;
            ballHeight *= bounce;
            bouncesCounter++;
        }

        return bouncesCounter;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(
            BouncingBall.bouncingBall(3.0, 0.66, 1.5)
        );

        Console.WriteLine(
            BouncingBall.bouncingBall(30.0, 0.66, 1.5)
        );
    }
}
```

### Funcionamiento

Primero se comprueban las condiciones de entrada:

```csharp
if (h <= 0 || bounce >= 1 || bounce <= 0 || h <= window)
{
    return -1;
}
```

Si alguno de los valores no es válido, el método termina inmediatamente.

### Primera vez que se ve la pelota

La caída inicial siempre cuenta una vez:

```csharp
int bouncesCounter = 1;
```

La persona ve la pelota pasar por delante de la ventana mientras cae por primera vez.

### Calcular la altura del primer rebote

La altura después del primer bote se calcula mediante:

```csharp
double ballHeight = h * bounce;
```

Por ejemplo:

```text
h = 3
bounce = 0,66
```

produce:

```text
3 × 0,66 = 1,98
```

Si la ventana está situada a:

```text
1,5 metros
```

el rebote supera la ventana.

### Contar los rebotes visibles

Mientras la altura alcanzada después del rebote sea superior a la ventana:

```csharp
while (ballHeight > window)
```

la pelota se verá dos veces.

Primero al subir:

```csharp
bouncesCounter++;
```

Después se calcula la altura del siguiente rebote:

```csharp
ballHeight *= bounce;
```

Y se cuenta también el paso al bajar:

```csharp
bouncesCounter++;
```

La separación de los dos incrementos permite representar directamente los dos momentos en los que la pelota pasa por delante de la ventana.

### Ejemplo

Para:

```text
h = 3
bounce = 0,66
window = 1,5
```

la caída inicial cuenta:

```text
1 vez
```

El primer rebote alcanza:

```text
3 × 0,66 = 1,98
```

Como:

```text
1,98 > 1,5
```

la pelota pasa:

```text
1 vez al subir
1 vez al bajar
```

El siguiente rebote alcanza aproximadamente:

```text
1,98 × 0,66 = 1,31
```

Como:

```text
1,31 < 1,5
```

ya no vuelve a pasar por delante de la ventana.

Resultado:

```text
3
```

### Conceptos reforzados

- Uso de valores `double`.
- Uso de bucles `while`.
- Uso de acumuladores.
- Validación de parámetros.
- Uso de operadores lógicos `||`.
- Finalización anticipada de métodos mediante `return`.
- Multiplicaciones sucesivas.
- Modelado de un problema físico mediante programación.
- Diferencia entre caída inicial y rebotes posteriores.

### Aprendizaje

Una de las partes importantes de esta kata fue comprender que cada rebote suficientemente alto puede hacer que la pelota sea visible dos veces:

```text
subida → +1
bajada → +1
```

La caída inicial, en cambio, solo ocurre una vez.

Por ello el contador comienza en:

```csharp
int bouncesCounter = 1;
```

y después cada rebote visible añade dos nuevas observaciones.

El algoritmo puede resumirse como:

```text
1. Validar los valores de entrada.
2. Contar la caída inicial.
3. Calcular la altura del primer rebote.
4. Mientras el rebote supere la ventana:
   - contar la subida;
   - calcular la siguiente altura;
   - contar la bajada.
5. Devolver el número total de veces que se ha visto la pelota.
```

---

## Take a Number And Sum Its Digits Raised To The Consecutive Powers And ....¡Eureka!! — 6 kyu

La función recibe dos números que representan los límites de un rango y debe devolver todos los números que cumplen una condición especial.

Cada dígito del número debe elevarse a una potencia consecutiva empezando por `1`.

Por ejemplo:

```text
89 = 8¹ + 9²

8¹ = 8
9² = 81

8 + 81 = 89
```

Por tanto, `89` cumple la condición.

Otro ejemplo es:

```text
135 = 1¹ + 3² + 5³

1 + 9 + 125 = 135
```

La función debe devolver todos los números que cumplan esta propiedad dentro del rango indicado.

Si no encuentra ninguno, debe devolver un array vacío.

### Solución

```csharp
using System;
using System.Collections.Generic;

public class SumDigPower
{
    public static long[] SumDigPow(long a, long b)
    {
        long min;
        long max;

        if (a < b)
        {
            min = a;
            max = b;
        }
        else if (a > b)
        {
            max = a;
            min = b;
        }
        else
        {
            min = a;
            max = b;
        }

        List<long> result = new List<long>();

        for (long i = min; i <= max; i++)
        {
            string stringNumber = i.ToString();
       
            long digit = 0;
            long digitPowSumResult = 0;

            for (int f = 0; f < stringNumber.Length; f++)
            {
                digit = stringNumber[f] - '0';
                digit = (long)Math.Pow(digit, f + 1);

                digitPowSumResult += digit;
            }

            if (i == digitPowSumResult)
            {
                result.Add(i);
            }
        }

        return result.ToArray();
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nEjemplo 1: \n");

        foreach(long digit in SumDigPower.SumDigPow(1, 10))
        {
            Console.WriteLine(digit);
        }

        Console.WriteLine("\nEjemplo 2: \n");

        foreach (long digit in SumDigPower.SumDigPow(1, 100))
        {
            Console.WriteLine(digit);
        }

        Console.WriteLine("\nEjemplo 3: \n");

        foreach (long digit in SumDigPower.SumDigPow(10, 100))
        {
            Console.WriteLine(digit);
        }

        Console.WriteLine("\nEjemplo 4: \n");

        foreach (long digit in SumDigPower.SumDigPow(90, 100))
        {
            Console.WriteLine(digit);
        }

        Console.WriteLine("\nEjemplo 5: \n");

        foreach (long digit in SumDigPower.SumDigPow(90, 150))
        {
            Console.WriteLine(digit);
        }

        Console.WriteLine("\nEjemplo 6: \n");

        foreach (long digit in SumDigPower.SumDigPow(50, 150))
        {
            Console.WriteLine(digit);
        }

        Console.WriteLine("\nEjemplo 7: \n");

        foreach (long digit in SumDigPower.SumDigPow(10, 150))
        {
            Console.WriteLine(digit);
        }
    }
}
```

### Funcionamiento

Primero se determinan los límites inferior y superior del rango:

```csharp
long min;
long max;
```

Se comprueba qué parámetro es menor:

```csharp
if (a < b)
{
    min = a;
    max = b;
}
else if (a > b)
{
    max = a;
    min = b;
}
else
{
    min = a;
    max = b;
}
```

Esto permite trabajar siempre desde el número menor hasta el mayor.

### Guardar los resultados

Como no se sabe de antemano cuántos números cumplirán la condición, se utiliza una lista:

```csharp
List<long> result = new List<long>();
```

Cada número válido encontrado se añadirá mediante:

```csharp
result.Add(i);
```

### Recorrer el rango

Se recorren todos los números desde `min` hasta `max`, ambos incluidos:

```csharp
for (long i = min; i <= max; i++)
```

La variable `i` representa el número que se está comprobando en cada iteración.

### Convertir el número en un string

Para poder acceder fácilmente a cada uno de sus dígitos, el número se transforma en texto:

```csharp
string stringNumber = i.ToString();
```

Por ejemplo:

```text
135
```

se transforma en:

```text
"135"
```

Esto permite recorrer sus caracteres mediante índices:

```csharp
stringNumber[0] → '1'
stringNumber[1] → '3'
stringNumber[2] → '5'
```

### Convertir un `char` en su valor numérico

Al acceder a un string mediante un índice se obtiene un `char`.

Por ejemplo:

```csharp
stringNumber[0]
```

devuelve:

```text
'1'
```

No devuelve directamente el número `1`.

Si se realiza una conversión directa:

```csharp
(long)stringNumber[f]
```

se obtiene el código numérico del carácter.

Por ejemplo:

```text
'1' → 49
```

Para obtener el valor real del dígito se utiliza:

```csharp
digit = stringNumber[f] - '0';
```

Esto funciona porque los caracteres numéricos están ordenados consecutivamente:

```text
'0' → 48
'1' → 49
'2' → 50
...
```

Por tanto:

```text
'1' - '0'
49  - 48
= 1
```

### Elevar cada dígito a su potencia

El índice del bucle empieza en `0`:

```csharp
for (int f = 0; f < stringNumber.Length; f++)
```

Pero las potencias deben comenzar en `1`.

Por eso se utiliza:

```csharp
f + 1
```

en:

```csharp
digit = (long)Math.Pow(digit, f + 1);
```

Por ejemplo, para `135`:

```text
f = 0 → 1¹
f = 1 → 3²
f = 2 → 5³
```

### Sumar las potencias

Cada resultado se acumula en:

```csharp
long digitPowSumResult = 0;
```

mediante:

```csharp
digitPowSumResult += digit;
```

Para `135`:

```text
1¹ = 1
3² = 9
5³ = 125

1 + 9 + 125 = 135
```

### Comprobar el resultado

Una vez recorridos todos los dígitos, se compara la suma obtenida con el número original:

```csharp
if (i == digitPowSumResult)
{
    result.Add(i);
}
```

Si son iguales, el número cumple la condición y se añade a la lista.

### Devolver el resultado

El método debe devolver un array de `long`, mientras que durante el proceso se ha utilizado una `List<long>`.

Por eso al final se convierte mediante:

```csharp
return result.ToArray();
```

Si no se ha encontrado ningún número válido, la lista estará vacía y se devolverá automáticamente un array vacío.

### Ejemplos

Para:

```csharp
SumDigPow(1, 100)
```

el resultado contiene:

```text
1
2
3
4
5
6
7
8
9
89
```

Para:

```csharp
SumDigPow(90, 100)
```

no existe ningún número que cumpla la condición, por lo que se devuelve:

```text
[]
```

Para:

```csharp
SumDigPow(90, 150)
```

se encuentra:

```text
135
```

porque:

```text
135 = 1¹ + 3² + 5³
```

### Conceptos reforzados

- Bucles `for` anidados.
- Recorrido de rangos numéricos.
- Conversión de números a `string`.
- Acceso a caracteres mediante índices.
- Diferencia entre `char` y su valor numérico.
- Conversión de un dígito mediante `'0'`.
- Uso de `Math.Pow`.
- Uso de `List<long>`.
- Uso de `Add()`.
- Conversión de una lista mediante `ToArray()`.
- Uso de acumuladores.
- Uso del índice de un bucle para generar potencias consecutivas.
- Descomposición de un problema matemático en pasos más pequeños.

### Aprendizaje

La parte principal del algoritmo consiste en dos recorridos:

```text
Primer bucle  → recorrer todos los números del rango.
Segundo bucle → recorrer todos los dígitos de cada número.
```

Para cada número:

```text
1. Se convierte a string.
2. Se obtiene cada dígito.
3. Se convierte el char en su valor numérico.
4. Se eleva a una potencia según su posición.
5. Se suman los resultados.
6. Se compara la suma con el número original.
7. Si son iguales, se guarda el número.
```

Uno de los aprendizajes importantes fue comprender que:

```csharp
stringNumber[f]
```

devuelve un `char`, y que una conversión directa del carácter devuelve su código numérico.

Por ello:

```csharp
stringNumber[f] - '0'
```

permite obtener correctamente el valor del dígito.

También se utilizó el depurador de Visual Studio para observar paso a paso cómo iban cambiando las variables durante la ejecución, evitando depender únicamente de `Console.WriteLine` para comprobar el funcionamiento interno del algoritmo.

---

## Count characters in your string — 6 kyu

La función recibe un `string` y debe devolver un `Dictionary<char, int>` donde:

- La clave representa cada carácter diferente encontrado.
- El valor representa el número de veces que aparece ese carácter.

Por ejemplo:

```text
"aba"
```

debe producir:

```text
'a' → 2
'b' → 1
```

Si el string está vacío, se devuelve un `Dictionary` vacío.

### Solución

```csharp
using System.Collections.Generic;
using System;

public class Kata
{
    public static Dictionary<char, int> Count(string str)
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        char repeatCharacter;
        int charCounter = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (!dictionary.ContainsKey(str[i]))
            {
                repeatCharacter = str[i];

                for (int f = 0; f < str.Length; f++)
                {
                    if (str[f] == repeatCharacter)
                    {
                        charCounter++;
                    }
                }

                dictionary.Add(repeatCharacter, charCounter);

                charCounter = 0;
            }
        }

        return dictionary;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nPrueba 1:\n");

        foreach (KeyValuePair<char, int> valor in Kata.Count("aba"))
        {
            Console.WriteLine($"Letra: {valor.Key} - " +
                $"Contador: {valor.Value}.");
        }

        Console.WriteLine("\nPrueba 2:\n");

        foreach (KeyValuePair<char, int> valor in Kata.Count("Mi coche está cerrado."))
        {
            Console.WriteLine($"Letra: {valor.Key} - " +
                $"Contador: {valor.Value}.");
        }
    }
}
```

### Conceptos reforzados

- Uso de `Dictionary<TKey, TValue>`.
- Uso de caracteres como claves mediante `Dictionary<char, int>`.
- Uso de `ContainsKey()`.
- Uso de `Add()`.
- Recorrido de strings mediante índices.
- Bucles `for` anidados.
- Uso de contadores.
- Uso de `KeyValuePair<TKey, TValue>`.
- Acceso a las propiedades `Key` y `Value`.
- Evitar procesar varias veces un mismo carácter.
- Devolución de un `Dictionary` vacío de forma natural cuando el string no contiene elementos.

### Funcionamiento

Primero se crea un diccionario vacío:

```csharp
Dictionary<char, int> dictionary =
    new Dictionary<char, int>();
```

Cada entrada tendrá esta estructura:

```text
carácter → número de apariciones
```

Por ejemplo:

```text
'a' → 2
'b' → 1
```

Después se recorre todo el string:

```csharp
for (int i = 0; i < str.Length; i++)
```

El carácter situado en `str[i]` será el carácter que se quiere analizar.

### Evitar contar dos veces el mismo carácter

Antes de contar las apariciones se comprueba:

```csharp
if (!dictionary.ContainsKey(str[i]))
```

Esto significa:

```text
Si este carácter todavía NO existe como clave
en el Dictionary, hay que contarlo.
```

Por ejemplo, para:

```text
"aba"
```

cuando se encuentra la primera `a`, todavía no existe:

```text
dictionary.ContainsKey('a') → false
```

por lo que se cuentan sus apariciones.

Cuando posteriormente se alcanza la segunda `a`:

```text
dictionary.ContainsKey('a') → true
```

y ya no es necesario volver a contarla.

### Contar las apariciones

El carácter actual se almacena en:

```csharp
repeatCharacter = str[i];
```

Después se realiza un segundo recorrido completo del string:

```csharp
for (int f = 0; f < str.Length; f++)
```

Cada vez que aparece el mismo carácter:

```csharp
if (str[f] == repeatCharacter)
{
    charCounter++;
}
```

se incrementa su contador.

Para:

```text
"aba"
```

si:

```text
repeatCharacter = 'a'
```

el recorrido encuentra:

```text
posición 0 → 'a' → contador = 1
posición 1 → 'b'
posición 2 → 'a' → contador = 2
```

Por tanto:

```text
'a' → 2
```

### Añadir el resultado al Dictionary

Después de contar todas las apariciones:

```csharp
dictionary.Add(repeatCharacter, charCounter);
```

se guarda:

```text
clave  → repeatCharacter
valor  → charCounter
```

Después se reinicia:

```csharp
charCounter = 0;
```

para poder contar el siguiente carácter diferente.

### String vacío

Si:

```csharp
str = "";
```

entonces:

```csharp
str.Length == 0
```

y el bucle:

```csharp
for (int i = 0; i < str.Length; i++)
```

no se ejecuta ninguna vez.

Por ello, se devuelve directamente el `Dictionary` vacío sin necesidad de realizar una comprobación especial.

### Aprendizaje

La solución se planteó siguiendo esta idea:

```text
1. Seleccionar un carácter.
2. Comprobar si ya ha sido procesado.
3. Si todavía no existe en el Dictionary:
   - recorrer todo el string;
   - contar cuántas veces aparece;
   - guardar carácter y contador.
4. Continuar con el siguiente carácter.
```

El `Dictionary` permite relacionar directamente:

```text
carácter → número de apariciones
```

y `ContainsKey()` permite saber si un carácter ya ha sido contado anteriormente.

Una parte importante del ejercicio fue comprender mejor cómo un `Dictionary` almacena parejas de:

```text
Key → Value
```

y cómo se puede utilizar la clave para identificar cada carácter diferente.

### Otra posible aproximación

Después de resolver la kata con dos bucles, puede aprovecharse el propio valor almacenado en el `Dictionary` como contador.

En lugar de volver a recorrer todo el string para cada carácter, se puede realizar un único recorrido:

```csharp
public static Dictionary<char, int> Count(string str)
{
    Dictionary<char, int> dictionary =
        new Dictionary<char, int>();

    foreach (char character in str)
    {
        if (dictionary.ContainsKey(character))
        {
            dictionary[character]++;
        }
        else
        {
            dictionary.Add(character, 1);
        }
    }

    return dictionary;
}
```

En esta versión:

```text
Primera aparición → se crea con valor 1.
Nueva aparición    → se incrementa el valor existente.
```

Para:

```text
"aba"
```

el proceso sería:

```text
'a' → no existe → a = 1
'b' → no existe → b = 1
'a' → ya existe → a = 2
```

La solución principal se mantiene porque representa el algoritmo utilizado originalmente para resolver el ejercicio antes de conocer esta simplificación.

---

## Find the odd int — 6 kyu

La función recibe un array de enteros y debe devolver el número que aparece un número impar de veces.

Por ejemplo:

```text
[1, 1, 2]
```

El `1` aparece dos veces, mientras que el `2` aparece una vez.

Por tanto, el resultado es:

```text
2
```

### Solución

```csharp
class Kata
{
    public static int find_it(int[] seq)
    {
        foreach(int number in seq)
        {
            if (seq.Count(n => n == number) % 2 != 0)
            {
                return number;
            }
        }

        return -1;
    }
}
```

### Versión ejecutable

```csharp
class Program
{
    public static void Main(string[] args)
    {
        int[] array1 = { 7 };
        int[] array2 = { 0 };
        int[] array3 = { 1, 1, 2 };
        int[] array4 = { 0, 1, 0, 1, 0 };
        int[] array5 = { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 };
        int[] array6 = { 20, 1, -1, 2, -2, 3, 3,
            5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };

        Console.WriteLine(Kata.find_it(array1));
        Console.WriteLine(Kata.find_it(array2));
        Console.WriteLine(Kata.find_it(array3));
        Console.WriteLine(Kata.find_it(array4));
        Console.WriteLine(Kata.find_it(array5));
        Console.WriteLine(Kata.find_it(array6));
    }
}
```

### Conceptos reforzados

- Recorrido de arrays mediante `foreach`.
- Uso de LINQ.
- Uso de `Count()` con una condición.
- Introducción a expresiones lambda.
- Uso de `%` para comprobar si un número es impar.
- Uso de `return` para terminar el método al encontrar el resultado.
- Comparación entre una solución manual con bucles y una solución más compacta con LINQ.

### Funcionamiento

El método recorre todos los números del array:

```csharp
foreach (int number in seq)
```

La variable:

```csharp
number
```

representa el número actual que se está comprobando.

Para cada número se calcula cuántas veces aparece dentro del array mediante:

```csharp
seq.Count(n => n == number)
```

### Uso de `Count()`

`Count()` puede recibir una condición y contar únicamente los elementos que la cumplen.

La estructura general es:

```csharp
coleccion.Count(elemento => condicion)
```

En esta kata:

```csharp
seq.Count(n => n == number)
```

significa:

```text
Recorre los elementos de seq
y cuenta aquellos donde:

n == number
```

Por ejemplo, para:

```text
seq = [1, 1, 2]
number = 1
```

la condición se evalúa así:

```text
n = 1 → 1 == 1 → true
n = 1 → 1 == 1 → true
n = 2 → 2 == 1 → false
```

Por tanto:

```csharp
seq.Count(n => n == number)
```

devuelve:

```text
2
```

### ¿Qué representa `n`?

La `n` es simplemente un nombre temporal utilizado para representar cada elemento de la colección mientras `Count()` la recorre.

Podría llamarse de cualquier manera:

```csharp
seq.Count(x => x == number)
```

o:

```csharp
seq.Count(element => element == number)
```

o:

```csharp
seq.Count(value => value == number)
```

Todas estas expresiones realizan exactamente la misma operación.

La forma:

```csharp
n => n == number
```

es una expresión lambda.

Puede interpretarse como:

```text
Para cada elemento n,
comprueba si n es igual a number.
```

### Comprobar si aparece un número impar de veces

Una vez obtenida la cantidad de apariciones, se utiliza:

```csharp
% 2 != 0
```

para comprobar si es impar.

Por ejemplo:

```text
1 % 2 = 1 → impar
2 % 2 = 0 → par
3 % 2 = 1 → impar
```

Por eso la condición completa es:

```csharp
if (seq.Count(n => n == number) % 2 != 0)
```

Si el número aparece una cantidad impar de veces:

```csharp
return number;
```

termina inmediatamente el método y devuelve ese valor.

### Ejemplo

Para:

```text
[0, 1, 0, 1, 0]
```

el `0` aparece:

```text
3 veces
```

y el `1` aparece:

```text
2 veces
```

Por tanto:

```text
0 → impar
1 → par
```

Resultado:

```text
0
```

### Aprendizaje

La primera idea para resolver esta kata fue utilizar dos bucles:

```text
1. Seleccionar un número.
2. Recorrer todo el array.
3. Contar cuántas veces aparece.
4. Comprobar si el contador es impar.
```

Después se investigó si C# ofrecía alguna herramienta para contar directamente los elementos que cumplen una condición.

Esto llevó al uso de:

```csharp
Count()
```

junto con una expresión lambda:

```csharp
n => n == number
```

De esta forma, una parte del algoritmo que manualmente necesitaría un segundo bucle puede expresarse de forma más compacta mediante LINQ.

La lógica sigue siendo la misma:

```text
seleccionar número
→ contar apariciones
→ comprobar si la cantidad es impar
→ devolver el número
```

### Versión manual equivalente

La misma lógica podría escribirse sin LINQ utilizando dos recorridos:

```csharp
public static int find_it(int[] seq)
{
    foreach (int number in seq)
    {
        int counter = 0;

        foreach (int otherNumber in seq)
        {
            if (otherNumber == number)
            {
                counter++;
            }
        }

        if (counter % 2 != 0)
        {
            return number;
        }
    }

    return -1;
}
```

Esta versión permite ver explícitamente el recorrido que `Count()` realiza internamente.

La solución principal mantiene LINQ porque permite expresar de forma clara y compacta la misma idea.

---

## Duplicate Encoder — 6 kyu

La función recibe un `string` y debe transformarlo en otro `string` siguiendo estas reglas:

- Si un carácter aparece **una sola vez**, se sustituye por `(`.
- Si un carácter aparece **más de una vez**, se sustituye por `)`.
- Las mayúsculas y minúsculas deben considerarse iguales.

Por ejemplo:

```text
"din"
```

Cada carácter aparece una sola vez:

```text
d → (
i → (
n → (
```

Resultado:

```text
(((
```

Otro ejemplo:

```text
"recede"
```

Las letras `e` aparecen varias veces:

```text
r → (
e → )
c → (
e → )
d → (
e → )
```

Resultado:

```text
()()()
```

### Solución

```csharp
using System.Linq;

public class Kata
{
    public static string DuplicateEncode(string word)
    {
        word = word.ToLower();

        string newWord = "";

        foreach (char character in word)
        {
            if (word.Count(s => s == character) > 1)
            {
                newWord += ')';
            }
            else
            {
                newWord += '(';
            }
        }

        return newWord;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{ 
    public static void Main(string[] args)
    {
        Console.WriteLine(Kata.DuplicateEncode("din"));
        Console.WriteLine(Kata.DuplicateEncode("recede"));
        Console.WriteLine(Kata.DuplicateEncode("Success"));
        Console.WriteLine(Kata.DuplicateEncode("(( @"));
    }
}
```

### Conceptos reforzados

- Recorrido de un `string` mediante `foreach`.
- Uso de `char`.
- Uso de LINQ.
- Uso de `Count()` con una condición.
- Uso de expresiones lambda.
- Uso de `ToLower()` para ignorar diferencias entre mayúsculas y minúsculas.
- Construcción progresiva de un nuevo `string`.
- Uso de `+=` para concatenar caracteres.
- Transformación de cada elemento según el número de veces que aparece.
- Diferencia entre transformar la colección recorrida y modificar la variable original.

### Funcionamiento

Primero se convierte todo el texto a minúsculas:

```csharp
word = word.ToLower();
```

Esto permite que:

```text
'S'
```

y:

```text
's'
```

se consideren el mismo carácter.

Por ejemplo:

```text
"Success"
```

pasa a ser:

```text
"success"
```

De esta forma, las comparaciones posteriores no tienen que preocuparse por las mayúsculas.

### Recorrido de los caracteres

Después se recorre el string:

```csharp
foreach (char character in word)
```

En cada iteración:

```csharp
character
```

representa el carácter que se está analizando.

Por ejemplo, para:

```text
"din"
```

el recorrido será:

```text
character = 'd'
character = 'i'
character = 'n'
```

### Contar las apariciones

Para conocer cuántas veces aparece el carácter actual se utiliza:

```csharp
word.Count(s => s == character)
```

La expresión lambda:

```csharp
s => s == character
```

puede interpretarse como:

```text
Para cada carácter s del string,
comprueba si es igual al carácter actual.
```

`Count()` cuenta únicamente aquellos caracteres para los que la condición devuelve `true`.

Por ejemplo:

```text
word = "recede"
character = 'e'
```

la comparación sería:

```text
'r' == 'e' → false
'e' == 'e' → true
'c' == 'e' → false
'e' == 'e' → true
'd' == 'e' → false
'e' == 'e' → true
```

Por tanto:

```csharp
word.Count(s => s == character)
```

devuelve:

```text
3
```

### Elegir `(` o `)`

La condición utilizada es:

```csharp
if (word.Count(s => s == character) > 1)
```

Si el carácter aparece más de una vez:

```csharp
newWord += ')';
```

Si solamente aparece una vez:

```csharp
newWord += '(';
```

De esta forma se va construyendo progresivamente el nuevo string.

### Importancia de `ToLower()`

Una de las partes importantes de esta kata fue comprender dónde debía realizarse la conversión a minúsculas.

Una primera posibilidad era recorrer:

```csharp
foreach (char character in word.ToLower())
```

Sin embargo, esto únicamente hace que el `foreach` recorra una versión en minúsculas.

La variable original:

```csharp
word
```

seguiría conservando las mayúsculas.

Por tanto, en:

```csharp
word.Count(s => s == character)
```

`Count()` seguiría recorriendo el string original.

Por ejemplo:

```text
word = "Success"
```

aunque el `foreach` produjera:

```text
s u c c e s s
```

el `Count()` seguiría viendo:

```text
S u c c e s s
```

y:

```text
'S' != 's'
```

Por eso resulta más sencillo normalizar el string una sola vez al principio:

```csharp
word = word.ToLower();
```

A partir de ese momento, tanto el `foreach` como `Count()` trabajan sobre la misma versión del texto.

### Aprendizaje

Esta kata reutiliza una idea aprendida anteriormente:

```csharp
Count(elemento => condicion)
```

En este caso:

```csharp
word.Count(s => s == character)
```

permite contar cuántas veces aparece cada carácter.

La lógica seguida es:

```text
1. Convertir todo el string a minúsculas.
2. Recorrer cada carácter.
3. Contar cuántas veces aparece.
4. Si aparece más de una vez → añadir ')'.
5. Si aparece una sola vez → añadir '('.
6. Devolver el nuevo string.
```

También reforcé el funcionamiento de las expresiones lambda.

En:

```csharp
s => s == character
```

`s` es una variable temporal que representa cada carácter que `Count()` va recorriendo.

Podría llamarse de cualquier otra manera:

```csharp
word.Count(c => c == character)
```

o:

```csharp
word.Count(letter => letter == character)
```

El nombre elegido no cambia el funcionamiento.

### Otra posible aproximación

También podría utilizarse `Select()` para transformar directamente cada carácter:

```csharp
public static string DuplicateEncode(string word)
{
    word = word.ToLower();

    return string.Concat(
        word.Select(character =>
            word.Count(c => c == character) > 1 ? ')' : '(')
    );
}
```

En esta versión, `Select()` transforma cada carácter en:

```text
')' si está repetido
'(' si no está repetido
```

La solución principal se mantiene porque permite ver de forma más clara el recorrido, la condición y la construcción progresiva del resultado.

---

## Playing with digits — 6 kyu

Algunos números tienen una propiedad especial relacionada con sus dígitos.

Dado un número positivo `n` y una potencia inicial `p`, se toman los dígitos de `n` y se elevan a potencias consecutivas empezando por `p`.

Por ejemplo:

```text
89

8¹ + 9²
= 8 + 81
= 89
= 89 × 1
```

Por tanto:

```text
k = 1
```

Otro ejemplo:

```text
695

6² + 9³ + 5⁴
= 36 + 729 + 625
= 1390

1390 = 695 × 2
```

Por tanto:

```text
k = 2
```

El objetivo es encontrar un entero positivo `k` que cumpla:

```text
aᵖ + bᵖ⁺¹ + cᵖ⁺² + dᵖ⁺³ + … = n × k
```

Si existe, se devuelve `k`.

Si no existe, se devuelve:

```text
-1
```

### Solución

```csharp
using System;

public class DigPow
{
    public static long digPow(int n, int p)
    {
        string numberN = n.ToString();
        long digit;
        long result = 0;

        for (int i = 0; i < numberN.Length; i++)
        {
            digit = long.Parse(numberN[i].ToString());
            result += (long)Math.Pow(digit, p + i);
        }

        if (result % n == 0)
        {
            long k = result / n;

            return k;
        }
        else
        {
            return -1;
        }
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(DigPow.digPow(89, 1));
        Console.WriteLine(DigPow.digPow(92, 1));
        Console.WriteLine(DigPow.digPow(695, 2));
        Console.WriteLine(DigPow.digPow(46288, 3));
    }
}
```

### Conceptos reforzados

- Conversión de un número a `string` mediante `ToString()`.
- Recorrido de los dígitos de un número mediante índices.
- Conversión de un `char` numérico a un valor numérico.
- Uso de `Math.Pow()`.
- Uso de potencias consecutivas.
- Relación entre el índice `i` y la potencia `p + i`.
- Uso de un acumulador.
- Uso del operador módulo `%`.
- Comprobación de divisibilidad.
- Uso de división para obtener un factor desconocido.
- Trabajo con valores `long`.
- Traducción de una fórmula matemática a un algoritmo.

### Funcionamiento

Primero se convierte el número `n` a un `string`:

```csharp
string numberN = n.ToString();
```

Esto permite recorrer sus dígitos de izquierda a derecha mediante índices.

Por ejemplo:

```text
n = 695
```

se convierte en:

```text
"695"
```

Por tanto:

```text
numberN[0] → '6'
numberN[1] → '9'
numberN[2] → '5'
```

### Obtener cada dígito

Cada carácter se convierte de nuevo en un número mediante:

```csharp
digit = long.Parse(numberN[i].ToString());
```

Por ejemplo:

```text
numberN[i]       → '6'
.ToString()      → "6"
long.Parse(...)  → 6
```

De esta forma se puede utilizar posteriormente el dígito en operaciones matemáticas.

### Potencias consecutivas

El recorrido utiliza:

```csharp
for (int i = 0; i < numberN.Length; i++)
```

y la potencia de cada dígito se calcula mediante:

```csharp
p + i
```

Esto permite que las potencias aumenten automáticamente en cada posición.

Por ejemplo:

```text
n = 695
p = 2
```

El recorrido sería:

```text
i = 0 → dígito 6 → potencia 2 + 0 = 2
i = 1 → dígito 9 → potencia 2 + 1 = 3
i = 2 → dígito 5 → potencia 2 + 2 = 4
```

Por tanto:

```text
6² + 9³ + 5⁴
```

La operación se realiza mediante:

```csharp
result += (long)Math.Pow(digit, p + i);
```

`Math.Pow()` devuelve un `double`, por lo que el resultado se convierte a `long`.

### Uso del acumulador

La variable:

```csharp
long result = 0;
```

va almacenando la suma de todas las potencias.

Para:

```text
695, 2
```

el proceso es:

```text
6² = 36
result = 36

9³ = 729
result = 765

5⁴ = 625
result = 1390
```

Al terminar:

```text
result = 1390
```

### Encontrar `k`

Una vez calculada la suma, necesitamos comprobar si existe un número entero `k` que cumpla:

```text
result = n × k
```

En lugar de buscar posibles valores de `k`, se comprueba directamente si `result` es divisible entre `n`:

```csharp
if (result % n == 0)
```

Si el resto es `0`, la división es exacta y existe un valor entero de `k`.

Entonces:

```csharp
long k = result / n;
```

Para:

```text
result = 1390
n = 695
```

tenemos:

```text
1390 % 695 = 0
```

y:

```text
1390 / 695 = 2
```

Por tanto:

```text
k = 2
```

Si la división no es exacta:

```csharp
return -1;
```

### Ejemplo sin solución

Para:

```text
n = 92
p = 1
```

se calcula:

```text
9¹ + 2²
= 9 + 4
= 13
```

Como:

```text
13 % 92 != 0
```

no existe un entero positivo `k` que cumpla:

```text
13 = 92 × k
```

Por tanto, se devuelve:

```text
-1
```

### Aprendizaje

Una de las decisiones de esta kata fue cómo separar un número en sus dígitos.

Una posibilidad sería trabajar matemáticamente utilizando:

```csharp
n % 10
```

para obtener el último dígito y:

```csharp
n /= 10;
```

para eliminarlo.

Sin embargo, este procedimiento obtiene los dígitos de derecha a izquierda.

Por ejemplo:

```text
695
```

se obtendría como:

```text
5
9
6
```

En esta kata el orden es importante porque cada dígito recibe una potencia diferente:

```text
6²
9³
5⁴
```

Por ello, convertir el número a un `string` permite recorrer los dígitos directamente en el orden original:

```text
6 → 9 → 5
```

La lógica del algoritmo puede resumirse como:

```text
1. Convertir n a string.
2. Recorrer sus dígitos de izquierda a derecha.
3. Convertir cada carácter en un número.
4. Elevarlo a p + i.
5. Acumular los resultados.
6. Comprobar si la suma es divisible entre n.
7. Si lo es, calcular k = resultado / n.
8. Si no, devolver -1.
```

### Otra forma de convertir el carácter a número

La conversión:

```csharp
digit = long.Parse(numberN[i].ToString());
```

también puede escribirse utilizando la posición de los caracteres numéricos:

```csharp
long digit = numberN[i] - '0';
```

Por ejemplo:

```text
'6' - '0' → 6
'9' - '0' → 9
'5' - '0' → 5
```

Así, el bucle podría escribirse:

```csharp
for (int i = 0; i < numberN.Length; i++)
{
    long digit = numberN[i] - '0';
    result += (long)Math.Pow(digit, p + i);
}
```

La solución principal mantiene `long.Parse()` porque fue la forma utilizada originalmente para resolver la kata.

---

## Consecutive strings — 6 kyu

La función recibe:

- Un array de strings `strarr`.
- Un número entero `k`.

El objetivo es encontrar el **primer string de mayor longitud** que pueda formarse concatenando `k` elementos consecutivos del array, manteniendo su orden original.

Por ejemplo:

```text
["zone", "abigail", "theta", "form"]

k = 2
```

Las posibles concatenaciones son:

```text
"zone" + "abigail"
"abigail" + "theta"
"theta" + "form"
```

Después se compara la longitud de cada resultado y se devuelve el primero que tenga la mayor longitud.

Si:

```text
n = número de elementos del array
```

se debe devolver un string vacío cuando:

```text
n == 0
k > n
k <= 0
```

### Solución

```csharp
public class LongestConsecutives
{
    public static string LongestConsec(string[] strarr, int k)
    {
        string longestWord = "";
        int n = strarr.Length;

        if (n == 0 || k > n || k <= 0)
        {
            return "";
        }

        for (int i = 0; i < n; i++)
        {
            string newWord = strarr[i];

            if (n >= i + k)
            {
                newWord = "";

                for (int f = i; f < i + k; f++)
                {
                    newWord += strarr[f];
                }
            }

            if (newWord.Length > longestWord.Length)
            {
                longestWord = newWord;
            }
        }

        return longestWord;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        string[] array1 =
        {
            "zone", "abigail", "theta", "form",
            "libe", "zas", "theta", "abigail"
        };

        string[] array2 =
        {
            "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx",
            "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh"
        };

        string[] array3 = { };

        string[] array4 =
        {
            "itvayloxrp",
            "wkppqsztdkmvcuwvereiupccauycnjutlv",
            "vweqilsfytihvrzlaodfixoyxvyuyvgpck"
        };

        string[] array5 =
        {
            "wlwsasphmxx",
            "owiaxujylentrklctozmymu",
            "wpgozvxxiu"
        };

        string[] array6 =
        {
            "zone", "abigail", "theta",
            "form", "libe", "zas"
        };

        string[] array7 =
        {
            "it", "wkppv", "ixoyx", "3452",
            "zzzzzzzzzzzz"
        };

        string[] array8 =
        {
            "it", "wkppv", "ixoyx", "3452",
            "zzzzzzzzzzzz"
        };

        string[] array9 =
        {
            "it", "wkppv", "ixoyx", "3452",
            "zzzzzzzzzzzz"
        };

        Console.WriteLine(
            LongestConsecutives.LongestConsec(array1, 2)
        );

        Console.WriteLine(
            LongestConsecutives.LongestConsec(array2, 1)
        );

        Console.WriteLine(
            LongestConsecutives.LongestConsec(array3, 3)
        );

        Console.WriteLine(
            LongestConsecutives.LongestConsec(array4, 2)
        );

        Console.WriteLine(
            LongestConsecutives.LongestConsec(array5, 2)
        );

        Console.WriteLine(
            LongestConsecutives.LongestConsec(array6, -2)
        );

        Console.WriteLine(
            LongestConsecutives.LongestConsec(array7, 3)
        );

        Console.WriteLine(
            LongestConsecutives.LongestConsec(array8, 15)
        );

        Console.WriteLine(
            LongestConsecutives.LongestConsec(array9, 0)
        );
    }
}
```

### Conceptos reforzados

- Recorrido de arrays mediante `for`.
- Uso de bucles anidados.
- Concatenación de strings.
- Trabajo con grupos de elementos consecutivos.
- Uso de `Length`.
- Uso de índices.
- Cálculo de límites dentro de un array.
- Comparación de longitudes.
- Búsqueda de un máximo.
- Conservación del primer resultado en caso de empate.
- Validación de parámetros.
- Construcción de una especie de ventana de tamaño `k`.

### Funcionamiento

Primero se guarda el número de elementos del array:

```csharp
int n = strarr.Length;
```

Después se comprueban los casos en los que no puede existir una solución válida:

```csharp
if (n == 0 || k > n || k <= 0)
{
    return "";
}
```

Esto cubre:

```text
Array vacío
k mayor que el número de elementos
k igual a 0
k negativo
```

### Recorrer las posibles posiciones iniciales

El primer `for` controla desde qué posición del array comienza cada grupo:

```csharp
for (int i = 0; i < n; i++)
```

Por ejemplo:

```text
["zone", "abigail", "theta", "form"]

k = 2
```

se intenta comenzar desde:

```text
i = 0
i = 1
i = 2
i = 3
```

Sin embargo, solo se pueden concatenar `k` palabras si todavía quedan suficientes elementos.

Por eso se comprueba:

```csharp
if (n >= i + k)
```

### Concatenar `k` elementos consecutivos

Si todavía existen suficientes elementos, se crea un nuevo string:

```csharp
newWord = "";
```

y se utiliza un segundo `for`:

```csharp
for (int f = i; f < i + k; f++)
{
    newWord += strarr[f];
}
```

El índice:

```csharp
f
```

empieza en:

```text
i
```

y termina justo antes de:

```text
i + k
```

Por ejemplo:

```text
i = 1
k = 3
```

el recorrido será:

```text
f = 1
f = 2
f = 3
```

Es decir, se concatenan exactamente tres elementos consecutivos.

### Ejemplo

Para:

```text
["zone", "abigail", "theta", "form"]

k = 2
```

la primera vuelta genera:

```text
i = 0

"zone"
+
"abigail"

→ "zoneabigail"
```

La siguiente:

```text
i = 1

"abigail"
+
"theta"

→ "abigailtheta"
```

Después:

```text
i = 2

"theta"
+
"form"

→ "thetaform"
```

Cada resultado se compara con el mayor encontrado hasta ese momento.

### Buscar el string más largo

La variable:

```csharp
string longestWord = "";
```

almacena el resultado más largo encontrado.

Después de construir cada combinación:

```csharp
if (newWord.Length > longestWord.Length)
{
    longestWord = newWord;
}
```

se actualiza únicamente si el nuevo string es estrictamente más largo.

Es importante utilizar:

```csharp
>
```

y no:

```csharp
>=
```

porque el ejercicio pide devolver el **primer** string de longitud máxima.

Si dos resultados tienen la misma longitud:

```text
primero  → longitud 15
segundo  → longitud 15
```

el segundo no sustituye al primero.

### Aprendizaje

Este ejercicio resultó algo más complejo porque no consiste simplemente en procesar cada elemento individualmente.

Es necesario trabajar con **grupos consecutivos de tamaño `k`**.

El algoritmo planteado fue:

```text
1. Comprobar que k es válido.
2. Elegir una posición inicial i.
3. Tomar k strings consecutivos desde esa posición.
4. Concatenarlos.
5. Comparar su longitud con el máximo actual.
6. Avanzar una posición.
7. Repetir hasta recorrer todas las combinaciones válidas.
```

La parte más importante fue controlar correctamente los índices:

```text
desde i
hasta i + k
```

y asegurarse de no intentar acceder fuera del array.

### Una simplificación del recorrido

La solución original recorre:

```csharp
for (int i = 0; i < n; i++)
```

y posteriormente comprueba:

```csharp
if (n >= i + k)
```

También se puede evitar directamente recorrer posiciones desde las que ya no caben `k` elementos.

La última posición inicial válida es:

```text
n - k
```

Por tanto, puede escribirse:

```csharp
for (int i = 0; i <= n - k; i++)
```

Así la solución manual podría quedar:

```csharp
public static string LongestConsec(string[] strarr, int k)
{
    string longestWord = "";
    int n = strarr.Length;

    if (n == 0 || k > n || k <= 0)
    {
        return "";
    }

    for (int i = 0; i <= n - k; i++)
    {
        string newWord = "";

        for (int f = i; f < i + k; f++)
        {
            newWord += strarr[f];
        }

        if (newWord.Length > longestWord.Length)
        {
            longestWord = newWord;
        }
    }

    return longestWord;
}
```

Esta versión mantiene exactamente el mismo algoritmo, pero evita recorrer posiciones que no pueden formar un grupo completo.

### Uso de LINQ: `Skip()` y `Take()`

Durante la resolución se buscó si C# disponía de algún método para obtener los siguientes `k` elementos de un array.

Con LINQ existen:

```csharp
Skip()
```

y:

```csharp
Take()
```

La expresión:

```csharp
strarr.Skip(i).Take(k)
```

significa:

```text
Saltar los primeros i elementos
y tomar los siguientes k.
```

Por ejemplo:

```text
["zone", "abigail", "theta", "form"]

Skip(1)
```

produce conceptualmente:

```text
["abigail", "theta", "form"]
```

Después:

```text
Take(2)
```

produce:

```text
["abigail", "theta"]
```

Finalmente se pueden unir mediante:

```csharp
string.Concat(...)
```

Por tanto:

```csharp
string newWord =
    string.Concat(strarr.Skip(i).Take(k));
```

sustituye al segundo `for`.

Una versión utilizando LINQ sería:

```csharp
using System.Linq;

public static string LongestConsec(string[] strarr, int k)
{
    string longestWord = "";
    int n = strarr.Length;

    if (n == 0 || k > n || k <= 0)
    {
        return "";
    }

    for (int i = 0; i <= n - k; i++)
    {
        string newWord =
            string.Concat(strarr.Skip(i).Take(k));

        if (newWord.Length > longestWord.Length)
        {
            longestWord = newWord;
        }
    }

    return longestWord;
}
```

### Otra posibilidad: rangos

C# también permite seleccionar una parte de un array utilizando rangos:

```csharp
strarr[i..(i + k)]
```

Por ejemplo:

```csharp
strarr[1..3]
```

selecciona los índices:

```text
1
2
```

El límite final no está incluido.

Por tanto:

```csharp
string.Concat(strarr[i..(i + k)])
```

también permite unir los `k` elementos consecutivos.

La solución principal mantiene los dos bucles porque fue la forma utilizada para construir y comprender inicialmente el algoritmo.

---

Esta sección irá creciendo a medida que complete nuevas katas y aprenda nuevas herramientas del lenguaje.

---
