using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public UnityEvent onMonedaRecogida;

    public Jugador Jugador;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        if (onMonedaRecogida == null)
            onMonedaRecogida = new UnityEvent();
    }

    public void IncrementarPuntuacion(int puntos)
    {
        Jugador.IncrementarPuntuacion(puntos);
        onMonedaRecogida.Invoke();
    }
}
