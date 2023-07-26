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
        Vector3 direcao = jogador.transform.position - transform.position;

        Quaternion novaRotacao = Quaternion.LookRotation(direcao);
        GetComponent<Rigidbody>().MoveRotation(novaRotacao);

        if (distancia > 2.5)
        {

            GetComponent<Rigidbody>()
            .MovePosition(GetComponent<Rigidbody>()
            .position + direcao.normalized * velicidade * Time.deltaTime);
            GetComponent<Animator>().SetBool("Atacando", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("Atacando", true);
        }
    }
    void AtacaJogador()
    {

        Time.timeScale = 0;
        jogador.GetComponent<ControlarJogador>().textoGameOver.SetActive(true);
        jogador.GetComponent<ControlarJogador>().vivo = false;
    }
}
