/* Un niño está jugando con una pelota en un nth piso. La altura
 * de ese piso es h.
 * Él tira la pelota por la ventana y esta, por ejemplo,
 * bota 2/3 de su altura (0,66).
 * Su madre le ve desde una ventana que está a 1,5 metros del
 * nivel del suelo.
 * 
 * ¿Cuántas veces verá la madre la pelota pasar enfrente de ella?
 * Incluyendo cuando está cayendo y botando.
 * 
 * Condiciones: La altura del piso "h" del niño tiene que ser mayor
 * que 0. El bote "bounce" tiene que ser más grande que 0 y menos que 1.
 * Y la ventana "windows" tiene que estar por debajo de h.
 * 
 * Devuelve un número positivo de veces que ve la madre la pelota
 * pasar por la ventana y -1 si no es positivo.
 */

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

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(BouncingBall.bouncingBall(3.0, 0.66, 1.5));
        Console.WriteLine(BouncingBall.bouncingBall(30.0, 0.66, 1.5));
    }
}