using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShutter : MonoBehaviour
{
    public Transform prefabTiro;
    public Transform conteinerTiro;
    public static float intervalo = 2f;

    public GameObject bala;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        //conteinerTiro = GameObject.Find("ConteinerTiro").transform;
        //Atirar();
        StartCoroutine(baludo());
    }

    /*void Atirar()
    {
        Transform tiro = Instantiate(prefabTiro, conteinerTiro);
        tiro.position = transform.position;
        tiro.parent = prefabTiro;
        Invoke("Atirar", intervalo);
    }*/
    private void Update()
    {
        Debug.Log(intervalo);
    }
    void atirador()
    {
        Instantiate(bala, player.position, player.rotation);
    }
    IEnumerator baludo()
    {
        yield return new WaitForSeconds(intervalo);
        atirador();
        yield return new WaitForSeconds(intervalo);
        StartCoroutine(baludo());
    }

}