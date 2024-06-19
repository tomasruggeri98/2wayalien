using UnityEngine;

public class Jugador : MonoBehaviour
{
    private Rigidbody2D rb;
    private int score;

    public float velocidadBase = 5f;
    public float gravedadBase = 1f;

    private float velocidadActual;
    private float gravedadActual;

    public int Score // Añadimos la propiedad Score
    {
        get { return score; }
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocidadActual = velocidadBase;
        gravedadActual = gravedadBase;
    }

    private void Update()
    {
        Mover();
    }

    private void Mover()
    {
        float movimiento = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movimiento * velocidadActual, rb.velocity.y);
    }

    public void IncrementarPuntuacion(int cantidad)
    {
        score += cantidad;
        UIManager.Instance.ActualizarPuntuacion(); // Llamar sin argumentos
    }

    public void AplicarPowerUp(PowerUp powerUp)
    {
        powerUp.AplicarEfecto(this.gameObject);
    }

    public void CambiarVelocidad(float nuevaVelocidad)
    {
        velocidadActual = nuevaVelocidad;
    }

    public void CambiarGravedad(float nuevaGravedad)
    {
        rb.gravityScale = nuevaGravedad;
    }

    private int salud = 100;

    public void RecibirDaño(int cantidad)
    {
        salud -= cantidad;
        if (salud <= 0)
        {
            // Lógica para la muerte del jugador
        }
    }
}

