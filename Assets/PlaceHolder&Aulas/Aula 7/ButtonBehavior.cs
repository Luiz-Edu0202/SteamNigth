using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    public bool varivavel = true;

    [SerializeField] private Sprite spritePositiveOfButton;
    [SerializeField] private Sprite spriteNegativeOfButton;
    [SerializeField] private Sprite spriteNullOfButton;
    public Button button;

    void Start()
    {
        
    }

    void Update()
    {
        ChangeTheSprite();
    }

    public void ChangeTheScene()
    {
        SceneManager.LoadScene("Fim");
    }
     public void ChangeTheValue()
    {
        if(varivavel == true)
        {
            varivavel = false;
        }
        else if (varivavel == false)
        {
            varivavel = true;
        }
    }
    private void ChangeTheSprite()
    {
        if(varivavel == true)
        {
            button.image.sprite = spritePositiveOfButton;
        }
        else if (varivavel == false)
        {
            button.image.sprite = spriteNegativeOfButton;

        }
        else
        {
            button.image.sprite = spriteNullOfButton;

        }
    }
}
