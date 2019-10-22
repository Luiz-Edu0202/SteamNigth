using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResultBehavior : MonoBehaviour
{
    [SerializeField] private GameObject data;
    [SerializeField] private bool mools;
    [SerializeField] private Sprite spritePositiveOfButton;
    [SerializeField] private Sprite spriteNegativeOfButton;
    [SerializeField] private Sprite spriteNullOfButton;
    void Awake()
    {
        data = GameObject.FindGameObjectWithTag("LALA");
        mools = data.GetComponent<ThiefBehavior>().value;
        if(mools == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = spritePositiveOfButton;
        }
        else if(mools == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteNegativeOfButton;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = spriteNullOfButton;
        }
    }

 
}
