using UnityEngine;

public class Disparo : MonoBehaviour
{
    private Rigidbody2D rb;

    public float velocidad;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Start()
    {
        rb.velocity = transform.up * velocidad;
    }
}
