using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstro : MonoBehaviour
{

    public float velocidade = 5f;

    public float tempoDeVida = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestruirMontro", tempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -(velocidade * Time.deltaTime));
    }

    void DestruirMontro()
    {
        Destroy(gameObject);
    }

}
