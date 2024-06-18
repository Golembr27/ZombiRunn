using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MontroDestroy : MonoBehaviour
{
    GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Parede")
        {
            player.GetComponent<vidaPlayer>().MortePlayer();
            Destroy(gameObject);
        }
    }

   

}
