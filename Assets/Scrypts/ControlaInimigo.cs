using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaInimigo : MonoBehaviour
{
    public GameObject jogador;
    public float velicidade = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {


        float distancia = Vector3.Distance(transform.position, jogador.transform.position);

        if (distancia > 2.5)
        {

            Vector3 direcao = jogador.transform.position - transform.position;

            GetComponent<Rigidbody>()
            .MovePosition(GetComponent<Rigidbody>()
            .position + direcao.normalized * velicidade * Time.deltaTime);
        
        Quaternion novaRotacao = Quaternion.LookRotation(direcao);
            GetComponent<Rigidbody>().MoveRotation(novaRotacao);
        }
    }
}
