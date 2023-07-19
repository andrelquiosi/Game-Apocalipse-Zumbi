using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaCamera : MonoBehaviour
{

    public GameObject Jogador;
   private Vector3 distanciaCameraJogador;
    // Start is called before the first frame update
    void Start()
    {
      distanciaCameraJogador = transform.position - Jogador.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Jogador.transform.position + distanciaCameraJogador;
    }
}
