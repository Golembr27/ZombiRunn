using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Rigidbody rig;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rig.velocity = new Vector3(rig.velocity.x,rig.velocity.y, -speed);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "bala")
        {
            PlayerShutter.intervalo = PlayerShutter.intervalo - 0.2f;
            Destroy(gameObject);
        }
    }
}
