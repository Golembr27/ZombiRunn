using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MovimentacaoClick : MonoBehaviour
{
    public Transform player;

    public float posicaoX;
    public float posicaoY;
    public float posicaoZ;

    public int esquerda = -2;
    public int direita = 2;

    // Start is called before the first frame update
    void Start()
    {
        posicaoX = transform.position.x;
        posicaoY = transform.position.y;
        posicaoZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Esquerda();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Direita();
        }
    }

    public void Direita()
    {
        posicaoX = direita;
        transform.position = new Vector3(posicaoX, posicaoY, posicaoZ);
        Debug.Log($"Voc� Apertou o D {posicaoX}");
    }

    public void Esquerda()
    {
        posicaoX = esquerda;
        transform.position = new Vector3(posicaoX, posicaoY, posicaoZ);
        Debug.Log($"Voc� Apertou o A {posicaoX}");
    }
}