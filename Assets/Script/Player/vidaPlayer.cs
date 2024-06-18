using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaPlayer : MonoBehaviour
{
    public int vida = 5;

    public void MortePlayer()
    {
        vida--;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }

}
