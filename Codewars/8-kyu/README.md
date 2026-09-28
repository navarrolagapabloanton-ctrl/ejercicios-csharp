# Codewars — 8 kyu

[← Volver al README principal](https://github.com/navarrolagapabloanton-ctrl/ejercicios-csharp)
Ejercicios de nivel **8 kyu** realizados durante mi aprendizaje de C#.

## Katas incluidas

- Count of positives / sum of negatives
- Maximum and Minimum Values of a List
- Are You Playing Banjo?

---

## Count of positives / sum of negatives — 8 kyu

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


## Maximum and Minimum Values of a List — 8 kyu

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

## Are You Playing Banjo? — 8 kyu

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
