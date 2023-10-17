using UnityEngine;
using UnityEngine.UI;

public class contador : MonoBehaviour
{
    public Text scoreText;
    public float contadorScore = 0f;


    void Update()
    {
        contadorScore += Time.deltaTime;
        scoreText.text = "Puntaje: " + (contadorScore * 10).ToString("0");
    }
}