using UnityEngine;

public class obstaculo : MonoBehaviour
{
    public float velocidadinicial = 3f;
    private float tiempovivo = 0f;
    public float tiempovidamaximo = 5f;

    void Update()
    {
        transform.position -= new Vector3(velocidadinicial * Time.deltaTime, 0, 0);
        tiempovivo += Time.deltaTime;


        if (tiempovivo > tiempovidamaximo)
        {
            Destroy(this.gameObject);
        }
    }
}
