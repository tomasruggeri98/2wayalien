using UnityEngine;

public abstract class Enemigo : MonoBehaviour
{
    protected int salud = 100;
    protected int daño = 10;

    public abstract void Atacar(Jugador jugador);
    public abstract void Moverse();

    public void RecibirDaño(int cantidad)
    {
        salud -= cantidad;
        if (salud <= 0)
        {
            Muerte();
        }
    }

    protected void Muerte()
    {
        Destroy(gameObject);
    }
}
