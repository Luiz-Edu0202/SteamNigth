using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThiefBehavior : MonoBehaviour
{
    public bool value;
    [SerializeField] private GameObject buttono;
    void Start()
    {
        print(SceneManager.sceneCount);
        DontDestroyOnLoad(this.gameObject);
        if(SceneManager.sceneCount == 0)
        {
            buttono = GameObject.FindGameObjectWithTag("LALA");
        }
    }

    void Update()
    {
        if (SceneManager.sceneCount == 1)
        {
            value = buttono.GetComponent<ButtonBehavior>().varivavel;
        }
    }
}
