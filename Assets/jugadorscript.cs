using UnityEngine;

public class jugadorscript : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public float fuerzasalto = 10f;
    public bool tocandopiso = true;

    [SerializeField] gameover gameover;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && tocandopiso)
        {
            playerRB.AddForce(Vector2.up * fuerzasalto, ForceMode2D.Impulse);
            tocandopiso = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag ("enemigo"))
        {
            gameover.ActiveScreen();
        }
        tocandopiso = true;
    }
}
