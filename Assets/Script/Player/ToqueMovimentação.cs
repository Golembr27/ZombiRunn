using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ToqueMvimentação : MonoBehaviour,IPointerDownHandler, IPointerUpHandler
{
    public enum dire 
    {
        direita, esquerda
    }

    public dire direcao = dire.direita;
    Transform player;

    public float posicaoX;
    public float posicaoY;
    public float posicaoZ;

    public int esquerda = -2;
    public int direita = 2;
    float horizontal = 0;

    public MovimentacaoClick movimentacaoClick;
    public UnityEvent OnTouch;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Jogador").transform;



        posicaoX = player.transform.position.x;
        posicaoY = player.transform.position.y;
        posicaoZ = player.transform.position.z;

        movimentacaoClick = GetComponent<MovimentacaoClick>();
    }

    // Update is called once per frame
    void Update()
    {
        
       /* // Verifica se há toques na tela
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // Pega o primeiro toque

            // Verifica se o toque ocorreu sobre o collider do painel
            if (touch.phase == TouchPhase.Began && IsTouchOverPanel(touch.position))
            {
                // Se sim, dispara o evento de toque
                OnTouch.Invoke();
                Debug.Log("Você apertou a Esquerda");

                float posicaoX = Input.GetTouch(0).position.x;
                horizontal = (Screen.width / 2 < posicaoX) ? 1 : 0;

                if (posicaoX != horizontal)
                {
                    Direita();
                }
                else
                {
                    Esquerda();
                }

            }
        }*/
    }

    private bool IsTouchOverPanel(Vector2 position)
    {
        throw new NotImplementedException();
    }

    public void Direita()
    {
        posicaoX = direita;
        player.transform.position = new Vector3(posicaoX, posicaoY, posicaoZ);
        Debug.Log($"Você Apertou o D {posicaoX}");
    }

    public void Esquerda()
    {
        posicaoX = esquerda;
        player.transform.position = new Vector3(posicaoX, posicaoY, posicaoZ);
        Debug.Log($"Você Apertou o A {posicaoX}");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (direcao == dire.esquerda)
        {
            Esquerda();
        }
        if (direcao == dire.direita)
        {
            Direita();
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new NotImplementedException();
    }
}
