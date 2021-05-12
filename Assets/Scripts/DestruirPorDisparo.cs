using UnityEngine;
using UnityEngine.SceneManagement;

public class DestruirPorDisparo : MonoBehaviour
{
    public static float enemigosMuertos;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Disparo")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            enemigosMuertos += 1;
        }

        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Derrota");
        }
    }

}
