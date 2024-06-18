using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class VidaMontro : MonoBehaviour
{
    Vector3 posicaoZ;
    Vector3 posicaoInimigo;

    float velocidade = 5f;

    public int vidaDoMontro =1;

    // Start is called before the first frame update
    void Start()
    {
        posicaoInimigo = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        posicaoZ = new Vector3(2, 0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(0, 0, -(velocidade * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "bala")
        {
            vidaDoMontro--;
            if (vidaDoMontro <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

}
