using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirPorTiempo : MonoBehaviour
{
    public float tiempoDeVida;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tiempoDeVida);
    }
}
