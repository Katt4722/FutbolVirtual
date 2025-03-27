namespace BibliotecaFut;

public abstract Sesion
{
    public string Nombre { get; set; }
    public void AplicarAJugador (Jugador jugador);
}