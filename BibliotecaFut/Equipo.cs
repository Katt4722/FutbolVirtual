namespace BibliotecaFut;

public class Equipo
{
    public List<Jugador> jugadores { get; set; };  
    // Instanciar nueva lista y de esa listaa sumar solo las mayores potencias del jugador y que se muestren en la nueva lista.
    public List<Sesion> sesionEntrenamiento { get; set; };
    public void Entrenar {get; set;}
    public double GetPotencial {get; set;}
    public double GetPrecision {get; set;}
    public double GetVision {get; set;}
}