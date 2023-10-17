using UnityEngine;

public class respawnobstaculos : MonoBehaviour
{
    public GameObject[] obstaculo;
    public Vector2 posicionspawn;
    public float tiempoarranque;
    public float tiemporepeticion;

    public contador highScore;
    public obstaculo tiempo;
    public float tiempoaumento = 10f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnobstaculos", tiempoarranque, tiemporepeticion);
        tiempo.velocidadinicial = 5f;
        
    }

    // Update is called once per frame
    void spawnobstaculos()
    {
        int indicealeatorio = Random.Range(0, obstaculo.Length);
        GameObject obstaculoaleatorio = obstaculo[indicealeatorio];
        Instantiate(obstaculoaleatorio, posicionspawn, obstaculoaleatorio.transform.rotation);
    }

    private void Update()
    {
        if (highScore.contadorScore > tiempoaumento)
        {
            tiemporepeticion = (float)(tiemporepeticion - tiempo.velocidadinicial * 0.6);
            tiempo.velocidadinicial = (float) (tiempo.velocidadinicial + tiempo.velocidadinicial * 0.4);
            tiempoaumento = tiempoaumento * 2;
        }
    }
}
