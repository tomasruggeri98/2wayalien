using UnityEngine;

public class Moneda : Coleccionable
{
    public int puntos;

    public override void Recoger()
    {
        GameManager.Instance.Jugador.IncrementarPuntuacion(puntos);
        Destroy(gameObject);
    }


}
