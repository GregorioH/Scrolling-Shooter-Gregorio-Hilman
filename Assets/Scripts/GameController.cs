using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject enemigo;
    public Vector2 valoresSpawn;
    public int cantidadEnemigos;
    public float esperarSpawn;
    public float empezarEspera;
    public float esperarOleada;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnearOleadas());
        DestruirPorDisparo.enemigosMuertos = 0f;
    }

    IEnumerator SpawnearOleadas()
    {
        yield return new WaitForSeconds(empezarEspera);
        while (true)
        {
            for (int i = 0; i < cantidadEnemigos; i++)
            {
                Vector2 spawnPosition = new Vector2(Random.Range(-valoresSpawn.x, valoresSpawn.x), valoresSpawn.y);
                Instantiate(enemigo, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(esperarSpawn);
            }
            yield return new WaitForSeconds(esperarOleada);
        }
    }

    private void Update()
    {
        if (DestruirPorDisparo.enemigosMuertos == 10f)
        {
            SceneManager.LoadScene("Victoria");
        }
    }
}
