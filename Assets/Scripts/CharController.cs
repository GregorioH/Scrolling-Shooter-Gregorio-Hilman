using UnityEngine;

[System.Serializable]
public class Limites
{
    public float xMin, xMax, yMin, yMax;
}
public class CharController : MonoBehaviour
{
    [Header("Movimiento")]
    private Rigidbody2D rb;
    public float velocidad;
    public Limites limites;

    [Header("Disparo")]
    public GameObject disparo;
    public Transform spawnDisparo;
    public float tasaDisparo;
    private float siguienteDisparo;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > siguienteDisparo)
        {
            siguienteDisparo = Time.time + tasaDisparo;
            Instantiate(disparo, spawnDisparo.position, spawnDisparo.rotation);
        }
    }

    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector2 movimiento = new Vector2(movimientoHorizontal, movimientoVertical * 0);
        rb.velocity = movimiento * velocidad;
        rb.position = new Vector2(Mathf.Clamp(rb.position.x, limites.xMin, limites.xMax), Mathf.Clamp(rb.position.y, limites.yMin, limites.yMax));
    }
}
