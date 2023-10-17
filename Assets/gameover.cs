using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public contador highScore;

    public static float puntajeMaximo = 0f;
    public Text puntajeMaximoText;

    private bool jugadorPerdio = false;
    private static bool primeraVezEnLaPartida = true;

    void Start()
    {
        gameObject.SetActive(false);
        if (primeraVezEnLaPartida)
        {
            primeraVezEnLaPartida = false;
            Debug.Log("primera vez");
            
        }
        else
        {
            MostrarPuntajeMaximo();
            Debug.Log("otra vez");
        }
    }

    

    public void ActiveScreen()
    {
        jugadorPerdio = true;
        gameObject.SetActive(true);
        Time.timeScale = 0f;

        MostrarPuntajeMaximo();

        // Esta vez, no cambiamos el valor de primeraVezEnLaPartida en el botón de reinicio
    }

    public void MostrarPuntajeMaximo()
    {
        if (jugadorPerdio && highScore.contadorScore > puntajeMaximo)
        {
            puntajeMaximo = highScore.contadorScore;
            puntajeMaximoText.text = "Puntaje Máximo: " + (puntajeMaximo * 10).ToString("0");
        }
        else 
        {
            puntajeMaximoText.text = "Puntaje Máximo: " + (puntajeMaximo * 10).ToString("0");
        }
        
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
