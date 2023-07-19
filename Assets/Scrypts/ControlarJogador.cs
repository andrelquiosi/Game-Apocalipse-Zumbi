using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float velocidade = 10;
    // Update is called once per frame
    void Update()
    {
        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");


        Vector3 direcao = new Vector3(eixoX, 0, eixoZ);
        transform.Translate(direcao * velocidade * Time.deltaTime);

        if(direcao != Vector3.zero){
            GetComponent<Animator>().SetBool("Movendo", true);
        }else{
            GetComponent<Animator>().SetBool("Movendo", false);
        }

    }
}
