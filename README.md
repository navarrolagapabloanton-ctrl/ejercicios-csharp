# Ejercicios de C#

Repositorio personal de aprendizaje y práctica de C#.

Aquí voy guardando ejercicios realizados durante mi aprendizaje, desde programas básicos de consola hasta ejercicios con métodos, colecciones, clases y orientación a objetos.

El objetivo del repositorio no es mostrar aplicaciones terminadas, sino reflejar mi progreso, practicar la resolución de problemas y afianzar los fundamentos de C#.

---

## Conceptos practicados

A lo largo de los ejercicios he trabajado con:

- Variables y tipos de datos
- Condicionales (`if`, `else`, `switch`)
- Bucles (`for`, `while`, `do-while`, `foreach`)
- Validación de entradas con `TryParse`
- Métodos y parámetros
- Métodos con valores de retorno
- Arrays
- `List<T>`
- `Dictionary<TKey, TValue>`
- Manipulación de strings y caracteres
- Acumuladores, máximos, mínimos y medias
- Menús interactivos
- Separación del programa en métodos
- Clases y objetos
- Propiedades
- Constructores
- Métodos de instancia
- Objetos como parámetros de otros métodos
- Listas de objetos
- Interacción entre objetos
- Principios básicos de orientación a objetos

---

# Ejercicios realizados

## 01 - Conversor de minutos

Conversión de minutos a segundos con validación de entrada y posibilidad de repetir el programa.

**Conceptos:**
- `TryParse`
- `do-while`
- Validación
- Variables booleanas

---

## 02 - Clasificador de números

Clasifica un número según sea:

- Positivo
- Negativo
- Cero
- Par
- Impar

Primer ejercicio dividido en métodos.

---

## 03 - Calculadora básica

Calculadora de consola con:

- Suma
- Resta
- Multiplicación
- División
- Control de división entre cero

**Conceptos:**
- Métodos
- Parámetros
- Valores de retorno
- `switch`

---

## 04 - Tabla de multiplicar

Generación de la tabla de multiplicar de un número.

**Concepto principal:** primer uso de bucles `for`.

---

## 05 - Adivina el número

Juego en el que el programa genera un número aleatorio y el usuario debe adivinarlo.

Incluye pistas y contador de intentos.

**Conceptos:**
- `Random`
- Bucles
- Comparaciones
- Control del flujo

---

## 06 - Analizador de notas

Almacena varias notas y calcula:

- Media
- Nota máxima
- Nota mínima

**Conceptos:**
- Arrays
- Recorrido mediante bucles
- Acumuladores

---

## 07 - Contador de vocales

Analiza un texto y cuenta las diferentes vocales, incluyendo vocales acentuadas.

**Conceptos:**
- `string`
- `char`
- `foreach`
- `switch`
- Manipulación de texto

---

## 08 - Lista de la compra

Permite introducir productos dinámicamente hasta finalizar la entrada.

**Concepto principal:** introducción a `List<T>`.

---

## 09 - Gestor de tareas

Aplicación de consola con menú para:

- Añadir tareas
- Mostrar tareas
- Eliminar tareas
- Salir

Primer pequeño gestor CRUD mediante una lista.

---

## 10 - Cajero automático

Simulación sencilla de una cuenta bancaria:

- Consultar saldo
- Ingresar dinero
- Retirar dinero
- Controlar saldo disponible

**Concepto principal:** uso de `decimal` y modificación de estado.

---

## 11 - Registro de gastos

Gestor que permite:

- Añadir gastos
- Mostrar gastos
- Calcular estadísticas
- Eliminar registros

Incluye cálculo de:

- Total
- Media
- Máximo
- Mínimo

---

## 12 - Gestor de videojuegos

Gestión de una colección de videojuegos mediante métodos independientes.

Permite:

- Añadir
- Mostrar
- Buscar
- Eliminar

**Objetivo principal:** dividir un programa grande en métodos más pequeños y reutilizables.

---

## 13 - Carrito de compra

Carrito formado por una lista de precios.

Calcula:

- Subtotal
- IVA
- Total

**Conceptos:**
- Métodos con `return`
- Paso de valores entre métodos
- `List<decimal>`

---

## 14 - Agenda de contactos

Agenda formada por nombres y teléfonos.

Permite:

- Añadir contactos
- Mostrar contactos
- Buscar
- Eliminar

**Concepto principal:** introducción a `Dictionary<TKey, TValue>`.

---

## 15 - Gestor de inventario

Inventario donde cada producto tiene una cantidad asociada.

Permite:

- Añadir productos
- Aumentar stock
- Consultar productos
- Modificar cantidades
- Eliminar productos

**Conceptos:**
- `Dictionary<string, int>`
- Lectura y modificación de valores mediante claves

---

# Orientación a objetos

A partir de estos ejercicios comienzo a trabajar con clases y objetos.

---

## 16 - Gestor de alumnos

Primera aplicación utilizando una clase propia:

`Alumno`

Cada alumno contiene:

- Nombre
- Nota

La aplicación permite:

- Añadir alumnos
- Mostrar alumnos
- Buscar
- Calcular estadísticas
- Eliminar

**Conceptos:**
- Clases
- Objetos
- Propiedades
- `List<Alumno>`

---

## 17 - Biblioteca personal

Gestión de libros mediante una clase `Libro`.

Cada libro contiene:

- Título
- Autor
- Estado de préstamo

Permite:

- Añadir libros
- Mostrar biblioteca
- Buscar
- Prestar
- Devolver

**Conceptos:**
- Constructores
- Propiedades
- Estado de los objetos
- Operador ternario

---

## 18 - Cuenta bancaria

Cuenta bancaria modelada mediante una clase.

Cada cuenta tiene:

- Titular
- Saldo

Y puede:

- Ingresar dinero
- Retirar dinero
- Mostrar información

**Conceptos:**
- Métodos de instancia
- Diferencia entre métodos `static` y métodos pertenecientes a objetos

---

## 19 - Combate RPG

Pequeño sistema de combate mediante objetos `Personaje`.

Los personajes pueden:

- Recibir daño
- Curarse
- Comprobar si están vivos
- Mostrar su estado

**Conceptos:**
- Estado de un objeto
- Métodos que devuelven `bool`
- Reutilización de métodos

---

## 20 - Transferencias bancarias

Dos objetos `CuentaBancaria` pueden realizar transferencias entre ellos.

Ejemplo:

```csharp
cuentaPablo.Transferir(cuentaLaura, cantidad);

```

**Conceptos:**

- Objetos como parámetros
- Interacción entre objetos
- Modificación del estado de varios objetos
- Ámbito de variables dentro de bloques `{ }`

---

## 21 - Arena RPG

Sistema formado por varios personajes almacenados en una lista:

```csharp
List<Personaje> personajes = new List<Personaje>();
```

Permite:

- Mostrar personajes
- Elegir atacante
- Elegir objetivo
- Atacar
- Recibir daño
- Curar personajes
- Gestionar personajes vivos y muertos

Ejemplo:

```csharp
Personaje atacante = personajes[numeroAtacante - 1];
Personaje objetivo = personajes[numeroObjetivo - 1];

atacante.Atacar(objetivo, danio);
```

El método `Atacar` recibe otro objeto `Personaje` como parámetro:

```csharp
public void Atacar(Personaje objetivo, int danio)
{
    objetivo.RecibirDanio(danio);
}
```

**Conceptos:**

- Listas de objetos
- Selección de objetos mediante índices
- Objetos como argumentos
- Interacción entre objetos
- Métodos de instancia
- Métodos que llaman a métodos de otros objetos
- Métodos que devuelven `bool`
- Separación de responsabilidades entre métodos
- Gestión del estado de los objetos

---

# Codewars

También utilizo Codewars para practicar pequeños problemas de programación y mejorar mi capacidad para plantear soluciones.

### Count of positives / sum of negatives

Dado un array de enteros, el ejercicio consiste en devolver otro array donde:

- El primer elemento contiene el número de valores positivos.
- El segundo elemento contiene la suma de los valores negativos.
- El `0` no se considera positivo ni negativo.
- Si el array está vacío o es `null`, se devuelve un array vacío.

Ejemplo de parte de la solución:

```csharp
if (input == null)
{
    return [];
}

if (input.Length == 0)
{
    return [];
}

int positiveCount = 0;
int negativeSum = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] > 0)
    {
        positiveCount++;
    }

    if (input[i] < 0)
    {
        negativeSum += input[i];
    }
}
```

**Conceptos reforzados:**

- Comprobación de `null` antes de acceder a un objeto.
- Diferencia entre un array `null` y un array vacío.
- Uso de `input.Length`.
- Recorrido de arrays mediante `for`.
- Uso de contadores.
- Uso de acumuladores.
- Arrays como valor de retorno.
- Sintaxis moderna `[]` para devolver un array vacío.

---

| Maximum and Minimum Values of a List | Arrays, métodos, valores de retorno, máximos y mínimos, recorrido con `for` |

### Maximum and Minimum Values of a List

Ejercicio basado en dos métodos que reciben un array de enteros:

- `Max()` devuelve el valor más alto.
- `Min()` devuelve el valor más bajo.

La búsqueda comienza utilizando el primer elemento del array como valor inicial y recorriendo posteriormente el resto de elementos.

```csharp
public int Max(int[] list)
{
    int max = list[0];

    for (int i = 1; i < list.Length; i++)
    {
        if (max < list[i])
        {
            max = list[i];
        }
    }

    return max;
}

public int Min(int[] list)
{
    int min = list[0];

    for (int i = 1; i < list.Length; i++)
    {
        if (min > list[i])
        {
            min = list[i];
        }
    }

    return min;
}
```

**Conceptos reforzados:**

- Inicialización de máximos y mínimos utilizando el primer elemento del array.
- Recorrido de arrays mediante `for`.
- Comparación y actualización de valores.
- Métodos que devuelven un `int`.
- Evitar comparar innecesariamente `list[0]` consigo mismo comenzando el bucle en `i = 1`.

---

## Are You Playing Banjo?

La función recibe un nombre y comprueba si su primera letra es una **R**, independientemente de que esté escrita en mayúscula o minúscula.

Si empieza por `R`, devuelve que esa persona toca el banjo. En caso contrario, devuelve que no lo toca.

### Solución

```csharp
class Kata
{
    public static string AreYouPlayingBanjo(string name)
    {
        return name.ToLower()[0] == 'r'
            ? name + " plays banjo"
            : name + " does not play banjo";
    }
}
```

### Versión ejecutable

Para probar la kata desde Visual Studio añadí un `Main` que solicita un nombre y comprueba que la entrada no esté vacía antes de llamar al método:

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa tu nombre:");
        string? entrada = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("Nombre no válido. Ingresa otro nombre.");
            entrada = Console.ReadLine();
        }

        Console.WriteLine(Kata.AreYouPlayingBanjo(entrada));
    }
}
```

### Conceptos reforzados

* Acceso a caracteres individuales de un `string` mediante índices.
* Diferencia entre `string` y `char`.
* Uso de `'r'` para representar un carácter y `"r"` para representar un string.
* Conversión de un string a minúsculas mediante `ToLower()`.
* Uso del operador ternario `condición ? valorSiTrue : valorSiFalse`.
* Validación de entradas mediante `string.IsNullOrWhiteSpace()`.
* Separación entre la lógica de la kata y el código utilizado para probarla en consola.

---

## Validate PIN Code — 7 kyu

Los cajeros automáticos solo aceptan códigos PIN de **4 o 6 dígitos**.

La función debe devolver:

- `true` si el PIN tiene exactamente 4 o 6 caracteres y todos son dígitos.
- `false` en cualquier otro caso.

### Solución

```csharp
public class Kata
{
    public static bool ValidatePin(string pin)
    {
        if (pin.Length == 4 || pin.Length == 6)
        {
            foreach (char character in pin)
            {
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }

            return true;
        }
        else
        {
            return false;
        }
    }
}
```

### Versión ejecutable

Para probar la kata desde consola añadí validación de entrada:

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un PIN.");

        string? entrada = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("Valor no válido. Introduce otro valor.");
            entrada = Console.ReadLine();
        }

        Console.WriteLine(Kata.ValidatePin(entrada));
    }
}
```

### Conceptos reforzados

- Uso de `.Length` para conocer la longitud de un `string`.
- Recorrido de un `string` carácter a carácter mediante `foreach`.
- Uso del tipo `char`.
- Comprobación de caracteres numéricos mediante `char.IsDigit()`.
- Uso de `return false` para detener el método al encontrar un carácter inválido.
- Uso de expresiones booleanas como condiciones.
- Validación de entradas mediante `string.IsNullOrWhiteSpace()`.
- Diferencia entre comprobar si un texto puede convertirse en número con `TryParse()` y comprobar si está formado exclusivamente por dígitos.

### Aprendizaje

Inicialmente utilicé `int.TryParse()` para comprobar si el PIN era numérico.

Sin embargo, `TryParse()` comprueba si una cadena puede interpretarse como un número entero y puede aceptar valores como `+123` o `-123`.

En esta kata era necesario comprobar algo más específico: que **cada carácter del PIN fuese un dígito**.

Por ello, recorrí el `string` con un `foreach` y utilicé `char.IsDigit()` para validar cada carácter.

---

## Is this a Triangle? — 7 kyu

La función recibe tres valores enteros que representan las longitudes de los lados de un triángulo.

Debe devolver:

- `true` si los tres lados pueden formar un triángulo.
- `false` si no cumplen la condición necesaria.

Para que tres lados formen un triángulo, la suma de cada pareja de lados debe ser mayor que el lado restante.

### Solución

```csharp
public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}
```

### Versión ejecutable

Para probar la kata desde consola añadí un método reutilizable que solicita un número entero y valida la entrada:

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer lado del triángulo:");
        int a = LeerNumero();

        Console.WriteLine("Ingrese el segundo lado del triángulo.");
        int b = LeerNumero();

        Console.WriteLine("Ingrese el tercer lado del triángulo.");
        int c = LeerNumero();

        Console.WriteLine(Triangle.IsTriangle(a, b, c));
    }

    public static int LeerNumero()
    {
        string? entrada = Console.ReadLine();

        int num;

        while (!int.TryParse(entrada, out num))
        {
            Console.WriteLine("Valor no válido. Introduce un entero.");
            entrada = Console.ReadLine();
        }

        return num;
    }
}
```

### Conceptos reforzados

- Uso de expresiones booleanas.
- Operadores lógicos `&&`.
- Comparaciones con `>`.
- Devolución directa de un valor `bool` sin necesidad de usar `if`.
- Uso de métodos auxiliares para evitar repetir código.
- Validación de entrada mediante `int.TryParse()`.
- Uso de parámetros y valores de retorno.
- Separación entre la lógica de la kata y el código usado para probarla desde consola.

### Aprendizaje

Inicialmente podía plantearse la comprobación mediante un `if` o un operador ternario, pero la propia condición:

```csharp
a + b > c && a + c > b && b + c > a
```

ya devuelve directamente un valor booleano.

Por ello, no es necesario escribir:

```csharp
return condicion ? true : false;
```

y se puede devolver directamente la expresión.

También se creó el método `LeerNumero()` para reutilizar la validación de números enteros y evitar repetir tres veces el mismo bloque con `int.TryParse()`.

---

## Vowel Count — 7 kyu

La función recibe una cadena de texto formada por letras minúsculas y espacios y debe devolver el número total de vocales que contiene.

Las vocales consideradas son:

```text
a, e, i, o, u
```

### Solución

```csharp
public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        foreach (char character in str)
        {
            if ("aeiou".Contains(character))
            {
                vowelCount++;
            }
        }

        return vowelCount;
    }
}
```

### Versión ejecutable

Para probar la kata desde consola añadí una validación para evitar que el usuario introduzca una cadena vacía:

```csharp
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un texto:");

        string? entrada = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("No puede estar el texto vacío.");
            entrada = Console.ReadLine();
        }

        Console.WriteLine(Kata.GetVowelCount(entrada));
    }
}
```

### Conceptos reforzados

- Recorrido de un `string` carácter a carácter mediante `foreach`.
- Uso del tipo `char`.
- Uso de un contador.
- Incremento de variables mediante `++`.
- Uso de `string.Contains()` para comprobar si una cadena contiene un determinado carácter.
- Validación de entradas mediante `string.IsNullOrWhiteSpace()`.
- Simplificación de condiciones largas.

### Aprendizaje

Inicialmente comprobé cada vocal individualmente:

```csharp
if (character == 'a' ||
    character == 'e' ||
    character == 'i' ||
    character == 'o' ||
    character == 'u')
{
    vowelCount++;
}
```

Aunque esta solución funciona correctamente, puede simplificarse utilizando un `string` que contenga todas las vocales:

```csharp
if ("aeiou".Contains(character))
{
    vowelCount++;
}
```

De esta forma, en lugar de realizar cinco comparaciones distintas, se comprueba directamente si el carácter actual está contenido dentro de `"aeiou"`.

También reforcé la idea de que un `string` puede recorrerse carácter a carácter mediante un `foreach`.

---

## Find the Next Perfect Square! — 7 kyu

La función recibe un número entero no negativo.

Debe comprobar si el número es un **cuadrado perfecto**, es decir, si su raíz cuadrada es un número entero.

- Si es un cuadrado perfecto, devuelve el siguiente cuadrado perfecto.
- Si no lo es, devuelve `-1`.

Por ejemplo:

```text
121 = 11²

El siguiente cuadrado perfecto es:

12² = 144
```

Por tanto:

```text
121 → 144
```

Mientras que:

```text
72 → -1
```

porque `72` no es un cuadrado perfecto.

### Solución

```csharp
using System;

public class Kata
{
    public static long FindNextSquare(long num)
    {
        long sqr = (long)Math.Sqrt(num);

        return sqr * sqr == num
            ? (sqr + 1) * (sqr + 1)
            : -1;
    }
}
```

### Versión ejecutable

Para probar la kata desde consola añadí una entrada validada mediante `long.TryParse()`:

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(@"- Ingresa un número.
- Se hará su raíz cuadrada.
- Si no tiene decimales, se calculará la potencia al cuadrado del
siguiente número.
- Si no, el resultado será -1.");

        string? entrada = Console.ReadLine();

        long result;

        while (!long.TryParse(entrada, out result))
        {
            Console.WriteLine("Ingrese un número entero.");
            entrada = Console.ReadLine();
        }

        Console.WriteLine(Kata.FindNextSquare(result));
    }
}
```

### Conceptos reforzados

- Cálculo de raíces cuadradas mediante `Math.Sqrt()`.
- Conversión explícita o *casting* de `double` a `long`.
- Comprobación de cuadrados perfectos.
- Operador ternario.
- Operaciones con números de tipo `long`.
- Validación mediante `long.TryParse()`.
- Strings multilínea mediante `@"..."`.
- Diferencia entre realizar operaciones con enteros y con `double`.
- Importancia de la precisión numérica al trabajar con números grandes.

### Aprendizaje

Inicialmente intenté encontrar la raíz cuadrada mediante un bucle:

```csharp
long square = 0;

while (square * square < num)
{
    square++;
}
```

Esta solución funciona, pero para números muy grandes puede necesitar una enorme cantidad de iteraciones y provocar que el programa tarde demasiado.

Utilizando:

```csharp
Math.Sqrt(num)
```

se puede obtener directamente la raíz cuadrada.

Como `Math.Sqrt()` devuelve un `double`, convierto el resultado a `long`:

```csharp
long sqr = (long)Math.Sqrt(num);
```

Después compruebo si realmente era un cuadrado perfecto multiplicando el entero obtenido por sí mismo:

```csharp
sqr * sqr == num
```

Si la condición se cumple, el siguiente cuadrado perfecto se obtiene incrementando la raíz en uno:

```csharp
(sqr + 1) * (sqr + 1)
```

### Problema encontrado con `Math.Pow()`

En una primera versión utilicé:

```csharp
(long)Math.Pow(sqr, 2)
```

Aunque funcionaba para números pequeños, algunos tests con números muy grandes fallaban.

`Math.Pow()` trabaja con valores `double`, y estos pueden perder precisión al representar enteros muy grandes.

Por ello, para elevar al cuadrado un valor entero es preferible utilizar directamente:

```csharp
sqr * sqr
```

De esta forma la operación continúa realizándose con valores `long` y se evita la pérdida de precisión producida por `double`.

---

## Sum of Odd Numbers — 7 kyu

La kata muestra un triángulo formado por números impares consecutivos:

```text
             1
          3     5
       7     9     11
    13    15    17    19
 21    23    25    27    29
```

La función recibe el número de una fila `n` y debe devolver la suma de todos los números que contiene esa fila.

Por ejemplo:

```text
Fila 1 → 1
Suma = 1

Fila 2 → 3 + 5
Suma = 8

Fila 4 → 13 + 15 + 17 + 19
Suma = 64
```

### Solución

```csharp
public static class Kata
{
    public static long RowSumOddNumbers(long n)
    {
        long sum = 0;
        long init = n * (n - 1) + 1;

        for (long i = 0; i < n; i++)
        {
            sum += init + (2 * i);
        }

        return sum;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Kata.RowSumOddNumbers(4));
    }
}
```

### Funcionamiento

Primero se calcula cuál es el primer número de la fila:

```csharp
long init = n * (n - 1) + 1;
```

Por ejemplo, para la fila 4:

```text
4 × (4 - 1) + 1
4 × 3 + 1
13
```

Por tanto, la fila comienza en `13`.

Como los números impares consecutivos aumentan de dos en dos, se recorre la fila mediante:

```csharp
for (long i = 0; i < n; i++)
{
    sum += init + (2 * i);
}
```

Para `n = 4`:

```text
i = 0 → 13 + (2 × 0) = 13
i = 1 → 13 + (2 × 1) = 15
i = 2 → 13 + (2 × 2) = 17
i = 3 → 13 + (2 × 3) = 19
```

Finalmente:

```text
13 + 15 + 17 + 19 = 64
```

### Conceptos reforzados

- Uso de bucles `for`.
- Uso de acumuladores.
- Cálculo de posiciones mediante fórmulas.
- Trabajo con secuencias de números impares.
- Uso de variables de tipo `long`.
- Diferencia entre el número de fila `n` y el índice utilizado dentro del bucle.
- Resolución previa del problema mediante dibujo y búsqueda de patrones.

### Aprendizaje

Una de las dificultades del ejercicio fue interpretar correctamente que el enunciado indica que **las filas empiezan a numerarse desde 1**.

Esto no significa que el índice del `for` tenga que comenzar también en `1`.

En esta solución:

```csharp
for (long i = 0; i < n; i++)
```

`n` representa el número de la fila, mientras que `i` se utiliza únicamente para calcular la posición de cada número dentro de esa fila.

También descubrí que el primer número de cada fila puede calcularse mediante:

```csharp
n * (n - 1) + 1
```

y que, a partir de ese número, los siguientes valores se obtienen sumando `2`.

### Patrón matemático

Después de resolverlo mediante el algoritmo anterior, se puede observar otro patrón:

```text
Fila 1 → 1   = 1³
Fila 2 → 8   = 2³
Fila 3 → 27  = 3³
Fila 4 → 64  = 4³
Fila 5 → 125 = 5³
```

Por tanto, la suma de cualquier fila `n` también puede calcularse directamente como:

```csharp
return n * n * n;
```

La solución con el bucle permite entender cómo se construye y se suma cada fila, mientras que la fórmula aprovecha directamente el patrón matemático.

---

## Two to One — 7 kyu

La función recibe dos cadenas formadas únicamente por letras minúsculas de la `a` a la `z`.

Debe devolver una nueva cadena que contenga todas las letras que aparecen en cualquiera de las dos cadenas:

- Sin repetir caracteres.
- Ordenadas alfabéticamente.

Por ejemplo:

```text
s1 = "xyaabbbccccdefww"
s2 = "xxxxyyyyabklmopq"

Resultado:

"abcdefklmopqwxy"
```

### Solución

```csharp
public class TwoToOne
{
    public static string Longest(string s1, string s2)
    {
        string s3 = s1 + s2;
        string finalString = "";

        for (char c = 'a'; c <= 'z'; c++)
        {
            if (s3.Contains(c))
            {
                finalString += c;
            }
        }

        return finalString;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main()
    {
        Console.WriteLine(
            TwoToOne.Longest("lallave", "dealfredo")
        );
    }
}
```

### Conceptos reforzados

- Concatenación de cadenas mediante `+`.
- Uso de `string.Contains()`.
- Recorrido mediante un bucle `for`.
- Uso del tipo `char`.
- Comparación de caracteres.
- Incremento de caracteres mediante `c++`.
- Eliminación indirecta de caracteres repetidos.
- Ordenación alfabética aprovechando el orden de los caracteres.
- Construcción progresiva de un `string`.

### Aprendizaje

Inicialmente resolví el ejercicio creando manualmente un array con todas las letras del alfabeto:

```csharp
string[] abc =
{
    "a", "b", "c", "d", "e", "f", "g", "h",
    "i", "j", "k", "l", "m", "n", "o", "p",
    "q", "r", "s", "t", "u", "v", "w", "x",
    "y", "z"
};
```

Después recorría ese array y comprobaba mediante `Contains()` si cada letra aparecía en las dos cadenas concatenadas.

La solución funcionaba, pero descubrí que no era necesario escribir manualmente todo el alfabeto.

Los caracteres de `'a'` a `'z'` están ordenados consecutivamente, por lo que se pueden recorrer directamente:

```csharp
for (char c = 'a'; c <= 'z'; c++)
{
    if (s3.Contains(c))
    {
        finalString += c;
    }
}
```

De esta forma, el propio bucle garantiza dos cosas:

1. Las letras se añaden en orden alfabético.
2. Cada letra se comprueba una sola vez, por lo que no aparecen caracteres repetidos.

### Primera solución

Antes de simplificarlo, utilicé esta aproximación:

```csharp
string s3 = s1 + s2;
string finalString = "";

string[] abc =
{
    "a", "b", "c", "d", "e", "f", "g", "h",
    "i", "j", "k", "l", "m", "n", "o", "p",
    "q", "r", "s", "t", "u", "v", "w", "x",
    "y", "z"
};

for (int i = 0; i < abc.Length; i++)
{
    if (s3.Contains(abc[i]))
    {
        finalString += abc[i];
    }
}

return finalString;
```

Esta primera solución era válida y permitió llegar al algoritmo antes de conocer una forma más sencilla de recorrer directamente los caracteres del alfabeto.

---

## 🔁 Mumbling — 7 kyu

La función recibe una cadena de texto formada por letras.

Debe construir una nueva cadena siguiendo estas reglas:

- La primera letra aparece una vez.
- La segunda letra aparece dos veces.
- La tercera letra aparece tres veces.
- Y así sucesivamente.
- La primera letra de cada bloque debe estar en mayúscula.
- El resto de letras del bloque deben estar en minúscula.
- Cada bloque debe estar separado por un guion `-`.

Por ejemplo:

```text
"abcd"

A-Bb-Ccc-Dddd
```

### Solución

```csharp
public class Accumul
{
    public static string Accum(string s)
    {
        string accum = "";

        for (int i = 0; i < s.Length; i++)
        {
            accum += char.ToUpper(s[i]);

            for (int f = 1; f <= i; f++)
            {
                accum += char.ToLower(s[i]);
            }

            if (i < s.Length - 1)
            {
                accum += "-";
            }
        }

        return accum;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Accumul.Accum("Juanjo"));
    }
}
```

### Funcionamiento

El primer `for` recorre cada carácter de la cadena:

```csharp
for (int i = 0; i < s.Length; i++)
```

La primera copia de cada letra se añade en mayúscula:

```csharp
accum += char.ToUpper(s[i]);
```

Después, un segundo `for` añade las copias restantes en minúscula:

```csharp
for (int f = 1; f <= i; f++)
{
    accum += char.ToLower(s[i]);
}
```

Por ejemplo, si `i = 3`:

```text
Primera letra → mayúscula

D

Después se añaden 3 letras minúsculas:

d
d
d

Resultado:

Dddd
```

Finalmente se añade un guion entre bloques:

```csharp
if (i < s.Length - 1)
{
    accum += "-";
}
```

La condición evita añadir un guion después del último bloque.

### Conceptos reforzados

- Recorrido de strings mediante `for`.
- Acceso a caracteres mediante índices.
- Uso de `char.ToUpper()`.
- Uso de `char.ToLower()`.
- Bucles anidados.
- Construcción progresiva de strings.
- Uso de condiciones para controlar separadores.
- Relación entre el índice de una posición y el número de repeticiones.

### Aprendizaje

La solución utiliza dos bucles.

El primero controla qué carácter se está procesando:

```csharp
for (int i = 0; i < s.Length; i++)
```

El segundo controla cuántas veces debe repetirse:

```csharp
for (int f = 1; f <= i; f++)
```

Como la primera copia ya se añade en mayúscula antes del segundo bucle, solo es necesario añadir `i` copias adicionales en minúscula.

También fue necesario asegurar que las repeticiones estuvieran en minúscula mediante:

```csharp
char.ToLower(s[i])
```

ya que la cadena original puede contener letras mayúsculas o minúsculas.

### Otra posibilidad

Existe un constructor de `string` que permite repetir directamente un carácter:

```csharp
new string('a', 5)
```

produce:

```text
aaaaa
```

Por tanto, el segundo `for` podría sustituirse por:

```csharp
accum += new string(char.ToLower(s[i]), i);
```

Sin embargo, en esta solución mantengo el doble `for` porque permite ver de forma más explícita cómo se construye cada bloque.

---

# Jaden Case

Ejercicio realizado en C# que transforma una frase haciendo que la primera letra de cada palabra aparezca en mayúscula.

## Ejemplo

Entrada:

`most trees are blue.`

Salida:

`Most Trees Are Blue.`

## Funcionamiento

El programa recorre la frase carácter por carácter.

1. Convierte la primera letra de la frase a mayúscula.
2. Recorre el resto de caracteres mediante un bucle `for`.
3. Cuando encuentra un espacio:
   - Añade el espacio al nuevo texto.
   - Convierte el siguiente carácter a mayúscula.
   - Avanza una posición adicional porque ese carácter ya ha sido procesado.
4. El resto de caracteres se añaden sin modificar.

## Código principal

```csharp
public static string ToJadenCase(this string phrase)
{
    string newString = "" + char.ToUpper(phrase[0]);

    for (int i = 1; i < phrase.Length; i++)
    {
        if (phrase[i] == ' ')
        {
            newString += " " + char.ToUpper(phrase[i + 1]);
            i++;
        }
        else
        {
            newString += phrase[i];
        }
    }

    return newString;
}
```

## Conceptos practicados

- Strings
- Acceso a caracteres mediante índices
- Bucles `for`
- Condicionales `if / else`
- `char.ToUpper()`
- Concatenación de cadenas
- Manipulación manual del índice de un bucle
- Métodos de extensión en C#

## Aprendizaje

En este ejercicio he practicado cómo recorrer una cadena carácter por carácter y detectar el comienzo de cada palabra utilizando los espacios como referencia.

La solución se ha realizado manualmente, sin utilizar métodos como `Split()`, para practicar el manejo de índices, bucles y caracteres.

---

## Categorize New Member — 7 kyu

La función recibe una colección de parejas de números enteros.

Cada pareja contiene:

```text
[edad, hándicap]
```

La función debe clasificar a cada miembro como:

- `"Senior"` si tiene al menos 55 años y un hándicap superior a 7.
- `"Open"` en cualquier otro caso.

Por ejemplo:

```text
[18, 20] → Open
[61, 12] → Senior
[78, 9]  → Senior
```

### Solución

```csharp
using System;
using System.Collections.Generic;

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        List<string> list = new List<string>();

        for (int i = 0; i < data.Length; i++)
        {
            list.Add(data[i][0] >= 55 && data[i][1] > 7
                ? "Senior"
                : "Open");
        }

        return list;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        int[][] array =
        {
            [18, 20],
            [45, 2],
            [61, 12],
            [37, 6],
            [21, 21],
            [78, 9]
        };

        foreach (string member in Kata.OpenOrSenior(array))
        {
            Console.WriteLine(member);
        }
    }
}
```

### Conceptos reforzados

- Uso de arrays de arrays mediante `int[][]`.
- Acceso a datos mediante dos índices.
- Uso de `List<string>`.
- Uso de `IEnumerable<string>` como tipo de retorno.
- Recorrido de colecciones mediante `foreach`.
- Uso de `Add()` para añadir elementos a una lista.
- Uso del operador ternario.
- Uso de operadores lógicos `&&`.
- Separación entre los datos de entrada y los resultados generados.

### Funcionamiento

El parámetro:

```csharp
int[][] data
```

representa un array cuyos elementos son otros arrays.

Cada elemento contiene dos valores:

```text
data[i][0] → edad
data[i][1] → hándicap
```

Por ejemplo:

```text
data[2] → [61, 12]

data[2][0] → 61
data[2][1] → 12
```

La condición utilizada es:

```csharp
data[i][0] >= 55 && data[i][1] > 7
```

Si ambas condiciones se cumplen, se añade:

```text
Senior
```

En caso contrario:

```text
Open
```

El operador ternario permite expresar esta decisión directamente:

```csharp
condicion ? "Senior" : "Open"
```

y el resultado se añade a la lista:

```csharp
list.Add(...);
```

### Aprendizaje

Una de las partes nuevas de esta kata fue trabajar con:

```csharp
int[][]
```

Este tipo puede entenderse como un **array de arrays**.

Por ello, para acceder a un valor concreto se utilizan dos índices:

```csharp
data[i][0]
data[i][1]
```

El primer índice selecciona uno de los arrays internos y el segundo índice selecciona uno de sus valores.

También aprendí el significado básico de:

```csharp
IEnumerable<string>
```

que representa una secuencia de strings que puede recorrerse.

Para construir el resultado utilicé:

```csharp
List<string>
```

y fui añadiendo cada clasificación mediante:

```csharp
list.Add(...)
```

Finalmente, la colección devuelta puede recorrerse mediante:

```csharp
foreach
```

para mostrar cada resultado individualmente.

---

## Reverse Words — 7 kyu

La función recibe una cadena de texto y debe devolver otra cadena en la que **cada palabra esté escrita al revés**, manteniendo los espacios en su posición correspondiente.

Por ejemplo:

```text
"Hola mundo"

→

"aloH odnum"
```

Los espacios también forman parte del resultado, por lo que deben conservarse.

### Solución

```csharp
using System;

public class Kata
{
    public static string ReverseWords(string str)
    {
        string reverseString = "";
        string word = "";

        // Recorro el string
        for (int i = 0; i < str.Length; i++)
        {
            // Si hay una letra, se suma a la nueva palabra.
            if (str[i] != ' ')
            {
                word += str[i];
            }
            else
            {
                reverseString += str[i];
            }

            /* Si hay un espacio en el siguiente índice,
             * se invierte luego la palabra.
             */
            if ((i < str.Length - 1 && str[i] != ' '
                && str[i + 1] == ' ') || (str[i] != ' '
                && i == str.Length - 1))
            {
                for (int f = word.Length - 1; f >= 0; f--)
                {
                    // Se invierte la palabra
                    reverseString += word[f];
                }

                // Se reinicia word.
                word = "";
            }
        }

        return reverseString;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa una frase:");

        string? entrada = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(entrada))
        {
            Console.WriteLine("No puede estar la frase vacía.");
            entrada = Console.ReadLine();
        }

        Console.WriteLine(Kata.ReverseWords(entrada));
    }
}
```

### Conceptos reforzados

- Recorrido de un `string` mediante `for`.
- Acceso a caracteres mediante índices.
- Uso de `str[i + 1]` de forma segura.
- Comprobación de límites con `str.Length`.
- Uso del cortocircuito de `&&`.
- Construcción progresiva de strings.
- Uso de una variable auxiliar para almacenar una palabra.
- Inversión manual de una cadena mediante un segundo `for`.
- Bucles anidados.
- Conservación de espacios.
- Reinicio de variables auxiliares.
- Validación de entrada con `string.IsNullOrWhiteSpace()`.

### Funcionamiento

La solución utiliza dos strings auxiliares:

```csharp
string reverseString = "";
string word = "";
```

`word` almacena temporalmente la palabra que se está leyendo.

`reverseString` almacena el resultado final.

El primer bucle recorre todos los caracteres:

```csharp
for (int i = 0; i < str.Length; i++)
```

Si el carácter actual no es un espacio:

```csharp
if (str[i] != ' ')
{
    word += str[i];
}
```

se añade a la palabra actual.

Si es un espacio:

```csharp
else
{
    reverseString += str[i];
}
```

se añade directamente al resultado para conservarlo.

### Detección del final de una palabra

La palabra debe invertirse en dos situaciones:

1. Cuando el carácter siguiente es un espacio.
2. Cuando se ha llegado al último carácter del string.

La condición utilizada es:

```csharp
if ((i < str.Length - 1 && str[i] != ' '
    && str[i + 1] == ' ') || (str[i] != ' '
    && i == str.Length - 1))
```

Esta comprobación también evita acceder a:

```csharp
str[i + 1]
```

cuando `i` ya se encuentra en la última posición.

Gracias al cortocircuito de `&&`, primero se comprueba:

```csharp
i < str.Length - 1
```

y solo si esta condición es verdadera se evalúa:

```csharp
str[i + 1]
```

### Inversión de la palabra

Cuando se detecta el final de una palabra, se recorre desde su último carácter hasta el primero:

```csharp
for (int f = word.Length - 1; f >= 0; f--)
{
    reverseString += word[f];
}
```

Por ejemplo:

```text
word = "hola"

f = 3 → a
f = 2 → l
f = 1 → o
f = 0 → h

Resultado:

"aloh"
```

Después se reinicia la palabra:

```csharp
word = "";
```

para comenzar a construir la siguiente.

### Aprendizaje

Este ejercicio lo resolví construyendo primero el algoritmo paso a paso antes de escribir la solución final.

La idea fue dividir el problema en varias tareas:

```text
1. Recorrer la frase.
2. Ir almacenando las letras de una palabra.
3. Detectar cuándo termina esa palabra.
4. Recorrerla en sentido contrario.
5. Añadirla al resultado.
6. Mantener los espacios.
7. Reiniciar la palabra y continuar.
```

También fue necesario contemplar un caso especial: la última palabra puede terminar sin que exista un espacio después.

Por ello, además de detectar:

```csharp
str[i + 1] == ' '
```

también se comprueba:

```csharp
i == str.Length - 1
```

Este ejercicio reforzó especialmente la creación de algoritmos a partir de un problema escrito, en lugar de depender directamente de métodos ya preparados del lenguaje.

### Otra posible aproximación

La misma kata también puede resolverse utilizando métodos ya incluidos en C#, como:

```csharp
Split()
ToCharArray()
Array.Reverse()
string.Join()
```

Sin embargo, en esta solución se mantiene la inversión manual porque permite comprender con claridad cómo se recorren, almacenan e invierten las palabras internamente.

---

## You're a Square! — 7 kyu

La función recibe un número entero y debe indicar si ese número es un **cuadrado perfecto**.

Un cuadrado perfecto es un número que puede obtenerse elevando otro número entero al cuadrado.

Por ejemplo:

```text
25 = 5²
36 = 6²
49 = 7²
```

Por tanto:

```text
25 → true
26 → false
36 → true
```

### Solución

```csharp
using System;

public class Kata
{
    public static bool IsSquare(int n)
    {
        int sqrt = (int)Math.Sqrt(n);
        return (int)Math.Pow(sqrt, 2) == n;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa un número entero:");

        string? entrada = Console.ReadLine();

        int n;

        while (!int.TryParse(entrada, out n))
        {
            Console.WriteLine("Error. Ingresa un número entero.");
            entrada = Console.ReadLine();
        }

        Console.WriteLine(Kata.IsSquare(n));
    }
}
```

### Conceptos reforzados

- Uso de `Math.Sqrt()` para calcular raíces cuadradas.
- Uso de `Math.Pow()` para elevar un número a una potencia.
- Conversión explícita de `double` a `int`.
- Comparación de valores numéricos.
- Devolución directa de expresiones booleanas.
- Uso de `int.TryParse()` para validar entradas.
- Trabajo con cuadrados perfectos.

### Funcionamiento

Primero se calcula la raíz cuadrada del número:

```csharp
Math.Sqrt(n)
```

Como `Math.Sqrt()` devuelve un valor de tipo `double`, se convierte a `int`:

```csharp
int sqrt = (int)Math.Sqrt(n);
```

Por ejemplo:

```text
Math.Sqrt(25) → 5
Math.Sqrt(26) → 5,09...
```

Al convertir a `int`:

```text
(int)5      → 5
(int)5,09   → 5
```

Después se vuelve a elevar ese número al cuadrado:

```csharp
Math.Pow(sqrt, 2)
```

y se comprueba si el resultado coincide con el número original:

```csharp
return (int)Math.Pow(sqrt, 2) == n;
```

Por ejemplo:

```text
n = 25

sqrt = 5
5² = 25

25 == 25 → true
```

Mientras que:

```text
n = 26

sqrt = 5
5² = 25

25 == 26 → false
```

### Aprendizaje

La solución aprovecha la raíz cuadrada del número para obtener una posible base del cuadrado.

Después, esa base se vuelve a elevar al cuadrado para comprobar si se recupera exactamente el valor original.

La expresión:

```csharp
(int)Math.Pow(sqrt, 2) == n
```

ya produce directamente un valor booleano, por lo que no es necesario utilizar un `if` para devolver `true` o `false`.

También reforcé el uso de conversiones entre `double` e `int`, ya que tanto `Math.Sqrt()` como `Math.Pow()` trabajan con valores de tipo `double`.

---

## Number of People in the Bus — 7 kyu

La función recibe una lista de paradas de autobús.

Cada parada contiene un array de dos números enteros:

```text
[personas que suben, personas que bajan]
```

La función debe devolver cuántas personas permanecen dentro del autobús después de la última parada.

Por ejemplo:

```text
[3, 0]
[8, 3]
[5, 6]
[10, 8]
[6, 6]
```

El cálculo sería:

```text
Parada 1 → +3 -0 = 3
Parada 2 → +8 -3 = 8
Parada 3 → +5 -6 = 7
Parada 4 → +10 -8 = 9
Parada 5 → +6 -6 = 9
```

Resultado:

```text
9
```

### Solución

```csharp
using System;
using System.Collections.Generic;

public class Kata
{
    public static int Number(List<int[]> peopleListInOut)
    {
        int peopleEnter = 0;
        int peopleOut = 0;

        for (int i = 0; i < peopleListInOut.Count; i++)
        {
            peopleEnter += peopleListInOut[i][0];
            peopleOut += peopleListInOut[i][1];
        }

        return peopleEnter - peopleOut;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        List<int[]> pasajeros =
        [
            new int[] { 3, 0 },
            new int[] { 8, 3 },
            new int[] { 5, 6 },
            new int[] { 10, 8 },
            new int[] { 6, 6 }
        ];

        Console.WriteLine(Kata.Number(pasajeros));
    }
}
```

### Conceptos reforzados

- Uso de `List<int[]>`.
- Listas que contienen arrays.
- Acceso encadenado mediante índices.
- Uso de `.Count` en una `List`.
- Uso de acumuladores.
- Recorrido mediante `for`.
- Diferencia entre el contenedor exterior y el array interior.
- Suma y resta de datos almacenados en estructuras anidadas.

### Funcionamiento

El parámetro:

```csharp
List<int[]> peopleListInOut
```

representa una lista cuyos elementos son arrays de enteros.

Cada array contiene dos valores:

```text
[0] → personas que suben
[1] → personas que bajan
```

Por ejemplo:

```text
peopleListInOut[2]

→ [5, 6]
```

Por tanto:

```csharp
peopleListInOut[2][0]
```

devuelve:

```text
5
```

y:

```csharp
peopleListInOut[2][1]
```

devuelve:

```text
6
```

### Comprendiendo los dos índices

La expresión:

```csharp
peopleListInOut[i][0]
```

puede entenderse en dos pasos.

Primero:

```csharp
peopleListInOut[i]
```

obtiene uno de los arrays almacenados dentro de la lista.

Por ejemplo:

```text
[8, 3]
```

Después:

```csharp
[0]
```

accede al primer valor de ese array.

Por tanto:

```csharp
peopleListInOut[i][0]
```

significa:

```text
Lista
  ↓
Elemento i
  ↓
Primer valor del array
```

Y:

```csharp
peopleListInOut[i][1]
```

accede al segundo valor.

### Aprendizaje

Una de las partes importantes de este ejercicio fue comprender mejor cómo funciona:

```csharp
List<int[]>
```

Puede leerse como:

```text
una lista de arrays de int
```

Es decir, el contenedor exterior es una `List` y cada elemento almacenado dentro es un `int[]`.

Esto explica por qué pueden utilizarse dos índices consecutivos:

```csharp
peopleListInOut[i][0]
```

El primer índice selecciona el array dentro de la lista y el segundo selecciona un valor dentro de ese array.

La solución utiliza dos acumuladores:

```csharp
int peopleEnter = 0;
int peopleOut = 0;
```

Uno suma todas las personas que suben y el otro todas las personas que bajan.

Finalmente:

```csharp
return peopleEnter - peopleOut;
```

devuelve el número de pasajeros que permanecen dentro del autobús.

### Posible simplificación

También podría utilizarse un único acumulador:

```csharp
int people = 0;

for (int i = 0; i < peopleListInOut.Count; i++)
{
    people += peopleListInOut[i][0];
    people -= peopleListInOut[i][1];
}

return people;
```

O recorrer directamente cada array interno mediante `foreach`:

```csharp
int people = 0;

foreach (int[] stop in peopleListInOut)
{
    people += stop[0];
    people -= stop[1];
}

return people;
```

La solución original se mantiene porque permite ver de forma clara la suma total de personas que entran y la suma total de personas que salen.

---

# Square Every Digit — C#

Ejercicio de Codewars que consiste en elevar al cuadrado cada dígito de un número y concatenar los resultados en el orden original.

## Ejemplos

| Entrada | Cuadrados de los dígitos | Resultado |
| --- | --- | --- |
| `0` | `0` | `0` |
| `9119` | `81`, `1`, `1`, `81` | `811181` |
| `2091` | `4`, `0`, `81`, `1` | `40811` |
| `120` | `1`, `4`, `0` | `140` |

## Mi solución

```csharp
using System;

public class Kata
{
    public static int SquareDigits(int n)
    {
        string stringNumber = n.ToString();
        string squareString = "";

        for (int i = 0; i < stringNumber.Length; i++)
        {
            int digit = int.Parse(stringNumber[i].ToString());
            digit *= digit;
            squareString += digit.ToString();
        }

        return int.Parse(squareString);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Kata.SquareDigits(0));
        Console.WriteLine(Kata.SquareDigits(9119));
        Console.WriteLine(Kata.SquareDigits(2091));
    }
}
```

## Cómo funciona

1. Convierto el número en una cadena con `ToString()`.
2. Recorro sus caracteres de izquierda a derecha con un bucle `for`.
3. Convierto cada carácter en un número mediante `int.Parse(stringNumber[i].ToString())`.
4. Elevo el dígito al cuadrado con `digit *= digit`, equivalente a `digit = digit * digit`.
5. Concateno cada cuadrado en `squareString`.
6. Convierto la cadena final en un `int` y lo devuelvo.

El cero se procesa igual que cualquier otro dígito, sin necesitar una condición especial.

### Conversión de cada dígito

```csharp
int digit = int.Parse(stringNumber[i].ToString());
```

Esta instrucción realiza tres pasos:

- `stringNumber[i]` obtiene un carácter, como `'9'`.
- `.ToString()` lo convierte en una cadena, como `"9"`.
- `int.Parse(...)` convierte esa cadena en el número entero `9`.

## Salida esperada

```text
0
811181
40811
```

## Conceptos practicados

- Conversión entre números, caracteres y cadenas.
- Recorrido de un `string` mediante índices y la propiedad `Length`.
- Bucles `for`.
- Multiplicación y asignación compuesta con `*=`.
- Concatenación de cadenas con `+=`.
- Métodos estáticos con parámetros y valor de retorno.

## Aprendizaje

Mi primer enfoque consistía en extraer cada dígito con `% 10` y eliminarlo mediante la división entera `/ 10`. Como eso recorre el número de derecha a izquierda, intenté invertirlo primero.

Sin embargo, convertir una cadena invertida como `"021"` en un entero elimina el cero inicial y hace que se pierda un dígito del número original.

Al trabajar directamente con un `string`, puedo recorrer los dígitos en su orden original y conservar los ceros. La solución queda más sencilla.

También he practicado la reutilización de una variable: como no necesito conservar el dígito original, guardo su cuadrado en la propia variable `digit`.

La idea que me llevo es preguntarme si conviene tratar un número como una cantidad o como una secuencia de dígitos.

## Alcance

La solución está pensada para números enteros no negativos cuyo resultado concatenado quepa en un `int`.

---

## Binary Addition — 7 kyu

La función recibe dos números enteros, los suma y devuelve el resultado representado en **binario** como un `string`.

Por ejemplo:

```text
1 + 1 = 2
2 en binario = 10
```

Por tanto:

```text
AddBinary(1, 1) → "10"
```

Otro ejemplo:

```text
5 + 9 = 14
14 en binario = 1110
```

### Solución

```csharp
using System;

public static class Kata
{
    public static string AddBinary(int a, int b)
    {
        int suma = a + b;

        if (suma == 0)
        {
            return "0";
        }

        string reverseBinaryNumber = "";

        while (suma != 0)
        {
            int rest = suma % 2;
            reverseBinaryNumber += rest;

            suma /= 2;
        }

        string binaryNumber = "";

        for (int i = reverseBinaryNumber.Length - 1;
            i >= 0; i--)
        {
            binaryNumber += reverseBinaryNumber[i];
        }

        return binaryNumber;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Kata.AddBinary(1, 1));
    }
}
```

### Conceptos reforzados

- Conversión manual de decimal a binario.
- Uso del operador módulo `%`.
- División entera entre valores `int`.
- Uso de bucles `while`.
- Inversión manual de un `string`.
- Construcción progresiva de cadenas.
- Conversión automática de valores numéricos al concatenarlos con un `string`.
- Tratamiento de casos especiales.
- Representación de números en distintas bases.

### Funcionamiento

Primero se suman los dos números:

```csharp
int suma = a + b;
```

Si el resultado es `0`, se devuelve directamente:

```csharp
return "0";
```

Esto es necesario porque, si `suma` vale `0`, el bucle principal no llegaría a ejecutarse.

### Conversión a binario

Para convertir el número a binario se realizan divisiones sucesivas entre `2`.

En cada vuelta se obtiene el resto:

```csharp
int rest = suma % 2;
```

Ese resto siempre será `0` o `1`.

Después se añade al string:

```csharp
reverseBinaryNumber += rest;
```

Al concatenar un `int` con un `string`, C# convierte automáticamente el número a su representación textual.

Finalmente se divide el número entre `2`:

```csharp
suma /= 2;
```

Como `suma` es un `int`, la división es entera.

Por ejemplo:

```text
5 / 2 = 2
2 / 2 = 1
1 / 2 = 0
```

Los decimales se descartan.

### Ejemplo paso a paso

Para convertir `14` a binario:

```text
14 % 2 = 0
14 / 2 = 7

7 % 2 = 1
7 / 2 = 3

3 % 2 = 1
3 / 2 = 1

1 % 2 = 1
1 / 2 = 0
```

Los restos obtenidos son:

```text
0 1 1 1
```

pero aparecen en orden inverso.

Por eso se recorre el string desde el final:

```csharp
for (int i = reverseBinaryNumber.Length - 1; i >= 0; i--)
{
    binaryNumber += reverseBinaryNumber[i];
}
```

Resultado:

```text
1110
```

### Aprendizaje

La parte principal de esta kata fue comprender cómo convertir manualmente un número decimal a binario.

El algoritmo se basa en:

```text
1. Dividir entre 2.
2. Guardar el resto.
3. Volver a dividir el cociente entre 2.
4. Repetir hasta llegar a 0.
5. Leer los restos en orden inverso.
```

También aprendí que una división entre dos valores `int` produce una división entera.

Por ejemplo:

```csharp
1 / 2
```

produce:

```text
0
```

y no `0.5`.

### Método incluido en C#

C# también permite realizar directamente esta conversión:

```csharp
Convert.ToString(numero, 2);
```

El segundo argumento indica la base numérica.

Por ejemplo:

```csharp
Convert.ToString(14, 2)
```

devuelve:

```text
"1110"
```

En esta solución mantengo la conversión manual para comprender el algoritmo utilizado para transformar un número decimal a binario.

---

## Odd or Even? — 7 kyu

La función recibe un array de números enteros y debe determinar si la suma de todos sus elementos es **par** o **impar**.

Debe devolver:

- `"even"` si la suma es par.
- `"odd"` si la suma es impar.

Si el array está vacío, su suma se considera `0`, por lo que el resultado debe ser:

```text
"even"
```

### Solución

```csharp
public class Kata
{
    public static string OddOrEven(int[] array)
    {
        int sum = 0;

        foreach (int number in array)
        {
            sum += number;
        }

        return sum % 2 == 0 ? "even" : "odd";
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 0 };
        int[] array2 = { 0, 1, 4 };
        int[] array3 = { 0, -1, -5 };
        int[] emptyArray = { };

        Console.WriteLine(Kata.OddOrEven(array));
        Console.WriteLine(Kata.OddOrEven(array2));
        Console.WriteLine(Kata.OddOrEven(array3));
        Console.WriteLine(Kata.OddOrEven(emptyArray));
    }
}
```

### Ejemplos

```text
[0]

Suma = 0
Resultado = "even"
```

```text
[0, 1, 4]

Suma = 5
Resultado = "odd"
```

```text
[0, -1, -5]

Suma = -6
Resultado = "even"
```

```text
[]

Suma = 0
Resultado = "even"
```

### Conceptos reforzados

- Recorrido de arrays mediante `foreach`.
- Uso de acumuladores.
- Suma de elementos de una colección.
- Uso del operador módulo `%`.
- Comprobación de números pares e impares.
- Uso del operador ternario.
- Devolución directa de un resultado a partir de una condición booleana.
- Comportamiento de un `foreach` sobre un array vacío.

### Funcionamiento

Primero se crea un acumulador:

```csharp
int sum = 0;
```

Después se recorren todos los números del array:

```csharp
foreach (int number in array)
{
    sum += number;
}
```

Cada número se añade al total almacenado en `sum`.

Una vez terminada la suma, se comprueba el resto de dividir el resultado entre `2`:

```csharp
sum % 2
```

Si el resto es `0`, el número es par:

```csharp
sum % 2 == 0
```

La función utiliza un operador ternario para devolver directamente el resultado:

```csharp
return sum % 2 == 0 ? "even" : "odd";
```

Esto equivale a:

```csharp
if (sum % 2 == 0)
{
    return "even";
}
else
{
    return "odd";
}
```

### Array vacío

Un array vacío puede declararse como:

```csharp
int[] emptyArray = { };
```

Como no contiene ningún elemento, el `foreach` no ejecuta ninguna iteración:

```csharp
int sum = 0;

foreach (int number in emptyArray)
{
    sum += number;
}
```

Por tanto, `sum` sigue valiendo:

```text
0
```

Y como:

```text
0 % 2 = 0
```

el resultado es:

```text
"even"
```

No es necesario añadir ninguna condición especial para este caso.

### Aprendizaje

Esta kata refuerza un patrón habitual al trabajar con colecciones:

```text
1. Crear un acumulador.
2. Recorrer los elementos.
3. Actualizar el acumulador.
4. Evaluar el resultado final.
```

También permite utilizar directamente una expresión booleana dentro de un operador ternario:

```csharp
sum % 2 == 0 ? "even" : "odd"
```

evitando un `if/else` cuando únicamente se necesita elegir entre dos valores.

---

## Beginner Series #3 Sum of Numbers — 7 kyu

La función recibe dos números enteros `a` y `b`, que pueden ser positivos o negativos.

Debe devolver la suma de todos los números comprendidos entre ambos, incluyendo los propios extremos.

Por ejemplo:

```text
(3, 5)

3 + 4 + 5 = 12
```

También debe funcionar si el segundo número es menor:

```text
(3, -1)

3 + 2 + 1 + 0 + (-1) = 5
```

Si ambos números son iguales, simplemente se devuelve ese mismo valor.

### Solución

```csharp
using System;

public class Sum
{
    public int GetSum(int a, int b)
    {
        int sum = a;

        if (a == b)
        {
            return a;
        }
        else if (a < b)
        {
            while (a != b)
            {
                a++;
                sum += a;
            }
        }
        else
        {
            while (a != b)
            {
                a--;
                sum += a;
            }
        }

        return sum;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        var sum = new Sum();

        Console.WriteLine(sum.GetSum(3, 5));
        Console.WriteLine(sum.GetSum(3, -1));
        Console.WriteLine(sum.GetSum(1, 0));
        Console.WriteLine(sum.GetSum(1, 2));
        Console.WriteLine(sum.GetSum(0, 1));
        Console.WriteLine(sum.GetSum(1, 1));
        Console.WriteLine(sum.GetSum(-1, 0));
        Console.WriteLine(sum.GetSum(-1, 2));
    }
}
```

### Conceptos reforzados

- Uso de acumuladores.
- Uso de `while`.
- Incremento y decremento con `++` y `--`.
- Comparación de valores con `==`, `<` y `>`.
- Uso de `if / else if / else`.
- Trabajo con números positivos y negativos.
- Inclusión de los valores extremos en una suma.
- Pruebas con distintos casos de entrada.
- Modificación de parámetros dentro de un método.

### Funcionamiento

La variable:

```csharp
int sum = a;
```

empieza guardando el primer número, ya que este también debe formar parte de la suma.

Después se distinguen tres casos.

#### Caso 1: ambos números son iguales

```csharp
if (a == b)
{
    return a;
}
```

Por ejemplo:

```text
(4, 4)

Resultado = 4
```

No es necesario realizar ninguna iteración.

#### Caso 2: `a` es menor que `b`

Si:

```text
a = 3
b = 5
```

se incrementa `a` hasta alcanzar `b`:

```csharp
while (a != b)
{
    a++;
    sum += a;
}
```

El proceso sería:

```text
sum = 3

a = 4
sum = 7

a = 5
sum = 12
```

Resultado:

```text
12
```

#### Caso 3: `a` es mayor que `b`

Si:

```text
a = 3
b = -1
```

se decrementa `a` hasta alcanzar `b`:

```csharp
while (a != b)
{
    a--;
    sum += a;
}
```

El proceso sería:

```text
sum = 3

a = 2
sum = 5

a = 1
sum = 6

a = 0
sum = 6

a = -1
sum = 5
```

Resultado:

```text
5
```

### Aprendizaje

La principal dificultad de esta kata fue tener en cuenta que los números pueden llegar en cualquier orden.

Por ello, dividí el problema en tres situaciones:

```text
a == b
a < b
a > b
```

Si `a` es menor que `b`, avanzo mediante:

```csharp
a++;
```

Si `a` es mayor que `b`, avanzo en sentido contrario mediante:

```csharp
a--;
```

En ambos casos se continúa hasta que:

```csharp
a == b
```

También probé diferentes combinaciones de números positivos, negativos, iguales y con el orden invertido para comprobar que el algoritmo funcionara en distintos casos.

### Otra posible aproximación

También se podría buscar primero cuál es el número menor y cuál es el mayor:

```csharp
int min = Math.Min(a, b);
int max = Math.Max(a, b);
```

y después recorrer siempre el intervalo en una sola dirección:

```csharp
int sum = 0;

for (int i = min; i <= max; i++)
{
    sum += i;
}
```

Esta alternativa evita separar el problema en dos recorridos distintos, aunque la solución original permite ver claramente cómo cambia el recorrido dependiendo del orden de los números.

---

## Remove the Minimum — 7 kyu

La función recibe una lista de números enteros y debe devolver una nueva lista en la que se haya eliminado el valor más pequeño.

Requisitos:

- No se puede modificar la lista original.
- Si el valor mínimo aparece varias veces, solo se elimina la primera aparición.
- No se puede cambiar el orden de los demás elementos.
- Si la lista está vacía, debe devolverse una lista vacía.

Por ejemplo:

```text
[1, 2, 3, 4, 5]

→

[2, 3, 4, 5]
```

Si el mínimo aparece varias veces:

```text
[2, 2, 1, 2, 1]

→

[2, 2, 2, 1]
```

Solo se elimina el primer `1`.

### Solución

```csharp
using System;
using System.Collections.Generic;

public class Remover
{
    public static List<int> RemoveSmallest(List<int> numbers)
    {
        List<int> newNumbers = new List<int>(numbers);

        if (newNumbers.Count == 0)
        {
            return newNumbers;
        }

        int min = newNumbers[0];

        foreach (int number in newNumbers)
        {
            if (min > number)
            {
                min = number;
            }
        }

        newNumbers.Remove(min);

        return newNumbers;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        List<int> score1 = new List<int>()
        {
            1, 2, 3, 4, 5
        };

        Console.WriteLine("Lista 1:\n");

        foreach (int number in Remover.RemoveSmallest(score1))
        {
            Console.Write($"{number}, ");
        }

        Console.WriteLine("\nLista 2:\n");

        List<int> score2 = new List<int>()
        {
            5, 3, 2, 1, 4
        };

        foreach (int number in Remover.RemoveSmallest(score2))
        {
            Console.Write($"{number}, ");
        }

        Console.WriteLine("\nLista 3:\n");

        List<int> score3 = new List<int>()
        {
            2, 2, 1, 2, 1
        };

        foreach (int number in Remover.RemoveSmallest(score3))
        {
            Console.Write($"{number}, ");
        }
    }
}
```

### Conceptos reforzados

- Uso de `List<int>`.
- Creación de una copia de una lista.
- Diferencia entre referencia y copia.
- Recorrido de listas mediante `foreach`.
- Búsqueda manual del valor mínimo.
- Uso de `.Count`.
- Uso de `Remove()`.
- Diferencia entre `Remove()` y `RemoveAt()`.
- Conservación del orden de una colección.
- Tratamiento de listas vacías.
- Modificación segura de listas fuera de un `foreach`.

### Copiar una lista

La asignación:

```csharp
List<int> newNumbers = numbers;
```

no crea una nueva lista.

Las dos variables apuntarían al mismo objeto, por lo que modificar una también modificaría la otra.

Para crear una copia real se utiliza:

```csharp
List<int> newNumbers = new List<int>(numbers);
```

De esta forma:

```text
numbers     → lista original
newNumbers  → nueva lista independiente
```

y se puede modificar `newNumbers` sin alterar `numbers`.

### Lista vacía

Antes de acceder a:

```csharp
newNumbers[0]
```

se comprueba si la lista está vacía:

```csharp
if (newNumbers.Count == 0)
{
    return newNumbers;
}
```

Esto evita intentar acceder a un índice que no existe.

### Buscar el mínimo

Se utiliza el primer elemento como valor mínimo inicial:

```csharp
int min = newNumbers[0];
```

Después se recorren todos los elementos:

```csharp
foreach (int number in newNumbers)
{
    if (min > number)
    {
        min = number;
    }
}
```

Si aparece un número menor que el mínimo actual, se actualiza:

```csharp
min = number;
```

### `Remove()` y `RemoveAt()`

Una de las diferencias importantes aprendidas en esta kata es la diferencia entre:

```csharp
Remove()
```

y:

```csharp
RemoveAt()
```

`Remove()` elimina por **valor**:

```csharp
newNumbers.Remove(3);
```

elimina la primera aparición del valor `3`.

Por ejemplo:

```text
[2, 3, 1, 3]

Remove(3)

→

[2, 1, 3]
```

En cambio, `RemoveAt()` elimina por **índice**:

```csharp
newNumbers.RemoveAt(2);
```

elimina el elemento situado en la posición `2`.

Por ejemplo:

```text
[10, 20, 30, 40]

RemoveAt(2)

→

[10, 20, 40]
```

En esta kata `Remove()` resulta especialmente útil porque elimina automáticamente la primera aparición del valor mínimo:

```csharp
newNumbers.Remove(min);
```

Esto cumple también el requisito de eliminar el mínimo con el índice más bajo cuando aparece varias veces.

### Modificar una lista durante un `foreach`

Durante este recorrido:

```csharp
foreach (int number in newNumbers)
{
    ...
}
```

la lista solo se consulta.

La modificación:

```csharp
newNumbers.Remove(min);
```

se realiza después de terminar el `foreach`.

Esto es importante porque modificar el tamaño de una colección mientras un `foreach` la está recorriendo puede provocar una excepción.

### Otra posible solución

C# también permite obtener directamente el valor mínimo mediante LINQ:

```csharp
int min = newNumbers.Min();
```

Por ejemplo:

```csharp
using System.Linq;

int min = newNumbers.Min();
newNumbers.Remove(min);
```

Esta versión es más corta, pero en la solución principal mantengo la búsqueda manual para practicar el recorrido de listas y comprender cómo se encuentra el valor mínimo.

---

## Shortest Word — 7 kyu

La función recibe una cadena de texto formada por varias palabras y debe devolver la longitud de la palabra más corta.

Por ejemplo:

```text
"La casa donde vamos"

Palabras:

"La"     → 2
"casa"   → 4
"donde"  → 5
"vamos"  → 5

Resultado:

2
```

### Solución

```csharp
public class Kata
{
    public static int FindShort(string s)
    {
        string word = "";
        int minLength = s.Length;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                word += s[i];

                if (i == s.Length - 1 || s[i + 1] == ' ')
                {
                    if (minLength > word.Length)
                    {
                        minLength = word.Length;
                    }
                }
            }
            else
            {
                word = "";
            }
        }

        return minLength;
    }
}
```

### Versión ejecutable

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Kata.FindShort(
            "La casa donde vamos a vivir es muy " +
            "pequeña pero al menos nos da " +
            "la oportunidad de poder vivir " +
            "juntos."
        ));
    }
}
```

### Conceptos reforzados

- Recorrido de un `string` mediante `for`.
- Acceso a caracteres mediante índices.
- Construcción progresiva de palabras.
- Uso de `Length`.
- Detección del final de una palabra.
- Uso seguro de `s[i + 1]`.
- Cortocircuito con el operador `||`.
- Comparación para encontrar un valor mínimo.
- Reinicio de variables auxiliares.

### Funcionamiento

La variable:

```csharp
string word = "";
```

se utiliza para ir almacenando la palabra actual.

La variable:

```csharp
int minLength = s.Length;
```

guarda la longitud mínima encontrada hasta el momento.

Se inicializa con la longitud total del string para comenzar con un valor suficientemente grande.

### Construcción de cada palabra

Mientras el carácter actual no sea un espacio:

```csharp
if (s[i] != ' ')
{
    word += s[i];
}
```

se añade a la palabra actual.

Por ejemplo:

```text
c
ca
cas
casa
```

### Detectar el final de una palabra

Una palabra puede terminar de dos formas:

1. El siguiente carácter es un espacio.
2. Se ha llegado al último carácter del string.

Por eso se utiliza:

```csharp
if (i == s.Length - 1 || s[i + 1] == ' ')
```

Esto permite detectar tanto palabras situadas en medio de la frase como la última palabra.

Además, el operador `||` realiza cortocircuito.

Si:

```csharp
i == s.Length - 1
```

es `true`, C# no necesita evaluar:

```csharp
s[i + 1]
```

evitando intentar acceder a una posición que no existe.

### Buscar la palabra más corta

Cuando se detecta el final de una palabra, se compara su longitud con el mínimo actual:

```csharp
if (minLength > word.Length)
{
    minLength = word.Length;
}
```

Si la palabra actual es más corta, se actualiza el valor mínimo.

### Reiniciar la palabra

Cuando aparece un espacio:

```csharp
else
{
    word = "";
}
```

se vacía la variable para comenzar a construir la siguiente palabra.

### Aprendizaje

Esta kata reutiliza una idea parecida a otros ejercicios anteriores: recorrer un string carácter a carácter y detectar cuándo termina una palabra.

El algoritmo puede resumirse como:

```text
1. Recorrer la frase.
2. Construir cada palabra.
3. Detectar cuándo termina.
4. Comparar su longitud con la mínima encontrada.
5. Reiniciar la palabra.
6. Continuar hasta terminar el string.
```

También reforcé el uso seguro de:

```csharp
s[i + 1]
```

comprobando primero si el índice actual es el último del string.

### Otra posible aproximación

C# permite dividir una frase en palabras mediante:

```csharp
s.Split(' ')
```

y con LINQ se podría obtener directamente la longitud mínima:

```csharp
using System.Linq;

return s.Split(' ').Min(word => word.Length);
```

En esta solución se mantiene el recorrido manual para practicar la creación del algoritmo y el manejo de índices.

---

## Exes and Ohs — 7 kyu

La función recibe una cadena de texto y debe comprobar si contiene la misma cantidad de letras `x` y `o`.

Debe cumplir estas condiciones:

- No se distingue entre mayúsculas y minúsculas.
- La cadena puede contener cualquier otro carácter.
- Si no contiene ninguna `x` ni ninguna `o`, el resultado también debe ser `true`.

Por ejemplo:

```text
"ooxx"   → true
"xooxx"  → false
"ooxXm"  → true
"zpzpzpp" → true
"zzoo"   → false
```

### Solución con LINQ

```csharp
using System;
using System.Linq;

public static class Kata
{
    public static bool XO(string input)
    {
        int counterO = input.Count(c => char.ToLower(c) == 'o');
        int counterX = input.Count(c => char.ToLower(c) == 'x');

        return counterO == counterX;
    }
}
```

### Versión ejecutable

```csharp
public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Kata.XO("ooxx"));
        Console.WriteLine(Kata.XO("xooxx"));
        Console.WriteLine(Kata.XO("ooxXm"));
        Console.WriteLine(Kata.XO("zpzpzpp"));
        Console.WriteLine(Kata.XO("zzoo"));
    }
}
```

### Primera solución sin LINQ

Antes de utilizar LINQ, resolví el ejercicio manualmente mediante un `foreach` y dos contadores:

```csharp
public static class Kata
{
    public static bool XO(string input)
    {
        int counterO = 0;
        int counterX = 0;

        foreach (char character in input)
        {
            if (char.ToLower(character) == 'o')
            {
                counterO++;
            }

            if (char.ToLower(character) == 'x')
            {
                counterX++;
            }
        }

        return counterO == counterX;
    }
}
```

Esta versión recorre todos los caracteres de la cadena y aumenta el contador correspondiente cada vez que encuentra una `o` o una `x`.

### Uso de LINQ

Con LINQ, el recorrido y el contador pueden resumirse mediante:

```csharp
input.Count(c => char.ToLower(c) == 'o')
```

Esta expresión puede leerse como:

```text
Cuenta todos los caracteres c
que, al pasarlos a minúscula,
sean iguales a 'o'.
```

Para las `x` se realiza la misma operación:

```csharp
input.Count(c => char.ToLower(c) == 'x')
```

Los resultados son dos valores enteros:

```csharp
int counterO
int counterX
```

que finalmente se comparan:

```csharp
return counterO == counterX;
```

Como la comparación ya devuelve un valor booleano, no es necesario utilizar un `if`.

### Caso sin `x` ni `o`

Por ejemplo:

```text
"zpzpzpp"
```

produce:

```text
counterO = 0
counterX = 0
```

Por tanto:

```text
0 == 0
```

es:

```text
true
```

No es necesario añadir ningún caso especial.

### Conceptos reforzados

- Uso de LINQ.
- Método `Count()` con una condición.
- Expresiones lambda.
- Uso de `char.ToLower()`.
- Comparación de cantidades.
- Devolución directa de expresiones booleanas.
- Recorrido de strings como secuencias de caracteres.
- Paso de una solución manual a una solución más compacta con LINQ.

### Aprendizaje

Esta kata fue una buena introducción práctica a LINQ.

La solución original utilizaba:

```text
foreach
+
if
+
contador
```

mientras que LINQ permite expresar la misma operación mediante:

```csharp
Count(...)
```

Por ejemplo:

```csharp
input.Count(c => char.ToLower(c) == 'o')
```

sustituye conceptualmente el recorrido manual y el incremento del contador.

La ventaja de haber realizado primero la solución sin LINQ es que permite entender qué trabajo está realizando internamente `Count()` en lugar de utilizarlo simplemente como una función ya preparada.

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

Esta sección irá creciendo a medida que complete nuevas katas y aprenda nuevas herramientas del lenguaje.

---

# Proyectos

Tras practicar los fundamentos de C# y comenzar con orientación a objetos, el siguiente objetivo es aplicar estos conocimientos en aplicaciones más completas.

Actualmente estoy desarrollando proyectos independientes orientados a portfolio utilizando C# y .NET.

---

Estos proyectos se mantienen en repositorios separados de este repositorio de ejercicios.

---

# Tecnologías y herramientas

- C#
- .NET
- Visual Studio
- Git
- GitHub

---

# Sobre este repositorio

Los ejercicios están realizados como parte de mi proceso de aprendizaje.

El código refleja mi evolución: algunos ejercicios podrían resolverse de forma más corta o utilizando técnicas más avanzadas, pero he preferido mantener las soluciones acordes a los conocimientos que tenía en cada momento.

De esta forma, el repositorio sirve también como registro de mi progreso como desarrollador.

El objetivo no es únicamente llegar a la solución, sino comprender progresivamente cómo estructurar programas, dividir problemas en partes más pequeñas y utilizar las herramientas del lenguaje de forma cada vez más natural.
