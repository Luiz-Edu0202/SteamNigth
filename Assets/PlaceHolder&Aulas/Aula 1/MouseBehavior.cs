using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBehavior : MonoBehaviour
{
    public GameObject Prefab;
    //Prefab do Circulo que será instansiado
    Vector3 mousePos;
    //Posição do mouse na tela
    Vector2 mousePos2D;
    //Posição do mouse no jogo
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Esse comando converte a posição do mouse da tela para a do jogo
        mousePos.z = 0;
        //Esse comando seta o z para 0, pois a posição do z não é convertida antes
        if (Input.GetMouseButtonDown(0))
        {
           Instantiate(Prefab,mousePos,Quaternion.identity);
           //Esse comando instancia a bolo
        }
        //Essa condicional captura se o mouse foi apertado  
    }
}
