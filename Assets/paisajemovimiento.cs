using UnityEngine;

public class paisajemovimiento : MonoBehaviour
{
    public float offsetx = 23;
    public int velocidadsol;

    void Update()
    {
        transform.position -= new Vector3(velocidadsol * Time.deltaTime, 0, 0);

        if (transform.position.x <= -offsetx)
        {
            transform.position = new Vector3(offsetx, transform.position.y, 0);
        }
    }
}
