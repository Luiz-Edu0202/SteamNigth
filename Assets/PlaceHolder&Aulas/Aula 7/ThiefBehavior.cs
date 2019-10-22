using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThiefBehavior : MonoBehaviour
{
    [SerializeField] private bool value;
    [SerializeField] private GameObject buttono;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        if(SceneManager.sceneCount == 0)
        {
            buttono = GameObject.FindGameObjectWithTag("LALA");
        }
    }

    void Update()
    {
        value = buttono.GetComponent<ButtonBehavior>().varivavel;
    }
}
