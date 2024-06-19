using UnityEngine;

public class PowerUpGravedad : PowerUp
{
    public float nuevaGravedad;

    public override void AplicarEfecto(GameObject jugador)
    {
        jugador.GetComponent<Jugador>().CambiarGravedad(nuevaGravedad);
    }
}
