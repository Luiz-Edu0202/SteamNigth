using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchBehavior : MonoBehaviour
{
    [SerializeField] private GameObject Obj;
    Vector3 mousePos;
    //Posição do mouse na tela
    Vector2 touchPos;
    //Posição do mouse na tela
    Touch touch;
    void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Esse comando converte a posição do mouse da tela para a do jogo
        mousePos.z = 0;
        
        if (Input.GetMouseButtonDown(0))
        {
           Instantiate(Obj,mousePos,Quaternion.identity);
           //Esse comando instancia a bolo
        }
        //Essa condicional captura se o mouse foi apertado 
#elif UNITY_ANDROID
        if(Input.touchCount > 0)
        {
            touch = Input.Touches[0];
            If(touch.phase == TouchPhase.Began)
            {
                touchPos =  Camera.main.ScreenToWorldPoint(touch.position);
                Instantiate(Obj,touchPos,Quaternion.identity);
            }
           
        }
#endif
    }
}
