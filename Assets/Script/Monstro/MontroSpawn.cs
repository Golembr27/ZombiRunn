using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontroSpawn : MonoBehaviour
{
    //public Transform prefabMonstro;
    //public Transform conteinerMontro;
    public float intervalo = 2f;
    public GameObject upgride;
    public GameObject Monstro;
    List<GameObject> spawn = new List<GameObject>();
    
    List<int> posicao = new List<int>();
    public int posicao1 = -2;
    public int posicao2 = 2;

    // Start is called before the first frame update
    void Start()
    {
        //conteinerTiro = GameObject.Find("ConteinerTiro").transform;
        //Atirar();
        posicao.Add(posicao1);
        posicao.Add(posicao2);

        spawn.Add(Monstro);
        spawn.Add(upgride);
        Monstros();
    }

    /*void Atirar()
    {
        Transform tiro = Instantiate(prefabMonstro, conteinerMontro);
        tiro.position = transform.position;
        tiro.parent = prefabMonstro;
        Invoke("Atirar", intervalo);
    }*/



    private void Update()
    {
        transform.position = new Vector3(posicao[Random.Range(0, 2)],transform.position.y, transform.position.z);
    }
    void Monstros()
    {
        Instantiate(spawn[Random.Range(0,2)],transform.position,transform.rotation);
        Invoke("Monstros", Random.Range(0,5));
    }

}
