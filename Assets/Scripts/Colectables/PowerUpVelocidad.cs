using UnityEngine;

public class PowerUpVelocidad : PowerUp
{
    public float nuevaVelocidad;

    public override void AplicarEfecto(GameObject jugador)
    {
        jugador.GetComponent<Jugador>().CambiarVelocidad(nuevaVelocidad);
    }
}