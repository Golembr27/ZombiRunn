using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    Rigidbody body;
    float velocidade = 10f;
    public VidaMontro monstro;
    public float tempoDeVida = 1f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        Invoke("DestruirBala", tempoDeVida);
        monstro = GetComponent<VidaMontro>();
    }

    // Update is called once per frame
    void Update()
    {
        body.AddForce(Vector3.forward * velocidade);
    }

    void DestruirBala()
    {
        Destroy(gameObject);
    }
}
