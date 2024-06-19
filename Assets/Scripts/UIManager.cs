using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public Text puntuacionText;

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

    private void OnEnable()
    {
        GameManager.Instance.onMonedaRecogida.AddListener(ActualizarPuntuacion);
    }

    private void OnDisable()
    {
        GameManager.Instance.onMonedaRecogida.RemoveListener(ActualizarPuntuacion);
    }

    public void ActualizarPuntuacion()
    {
        puntuacionText.text = "Puntuación: " + GameManager.Instance.Jugador.Score;
    }
}
