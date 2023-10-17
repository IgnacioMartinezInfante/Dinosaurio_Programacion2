using UnityEngine;

public class mapamovimiento : MonoBehaviour
{
    public float offsetx = 23;
    public int velocidadpiso;

    void Update()
    {
        transform.position -= new Vector3(velocidadpiso * Time.deltaTime, 0, 0);

        if (transform.position.x <= -offsetx)
        {
            transform.position = new Vector3(offsetx, transform.position.y, 0);
        }
    }
}
