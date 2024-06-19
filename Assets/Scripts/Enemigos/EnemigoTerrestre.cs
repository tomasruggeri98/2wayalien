using UnityEngine;

public class EnemigoTerrestre : Enemigo
{
    private void Update()
    {
        Moverse();
    }

    public override void Atacar(Jugador jugador)
    {
        // Implementación del ataque para EnemigoTerrestre
    }

    public override void Moverse()
    {
        transform.Translate(Vector3.right * Time.deltaTime);
    }
}