# Codewars — 6 kyu

[← Volver al README principal](./README.md)

Ejercicios de nivel **6 kyu** realizados en C#. En estas katas aparecen problemas con algo más de análisis, transformaciones de datos, bucles anidados y estructuras de colección.

## Katas incluidas

- Equal Sides Of An Array
- Replace With Alphabet Position
- Build Tower
- Count the Smiley Faces!
- Take a Ten Minute Walk
- Bouncing Balls
- Take a Number And Sum Its Digits Raised To The Consecutive Powers And ....¡Eureka!!

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

Esta sección irá creciendo a medida que complete nuevas katas y aprenda nuevas herramientas del lenguaje.

---
