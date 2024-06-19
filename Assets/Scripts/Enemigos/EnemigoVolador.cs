// EnemigoVolador.cs
using UnityEngine;

public class EnemigoVolador : Enemigo
{
    private void Update()
    {
        Moverse();
    }

    public override void Atacar(Jugador jugador)
    {
        // Implementación del ataque para EnemigoVolador
    }

    public override void Moverse()
    {
        transform.Translate(Vector3.up * Time.deltaTime);
    }
}