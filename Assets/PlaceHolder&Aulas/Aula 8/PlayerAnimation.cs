using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator PlayerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovimentate();
    }

    void PlayerMovimentate()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            PlayerAnimator.SetBool("Up", false);
            PlayerAnimator.SetBool("Left", false);
            PlayerAnimator.SetBool("Rigth", true);
            PlayerAnimator.SetBool("Idle", false);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            PlayerAnimator.SetBool("Up", false);
            PlayerAnimator.SetBool("Left", true);
            PlayerAnimator.SetBool("Rigth", false);
            PlayerAnimator.SetBool("Idle", false);
        }
        else if (Input.GetAxisRaw("Vertical") > 0)
        {
            PlayerAnimator.SetBool("Up", true);
            PlayerAnimator.SetBool("Left", false);
            PlayerAnimator.SetBool("Rigth", false);
            PlayerAnimator.SetBool("Idle", false);
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            PlayerAnimator.SetBool("Up", false);
            PlayerAnimator.SetBool("Left", false);
            PlayerAnimator.SetBool("Rigth", false);
            PlayerAnimator.SetBool("Idle", false);
        }
        else if (Input.GetAxisRaw("Vertical") == 0 && Input.GetAxisRaw("Horizontal") == 0)
        {
            PlayerAnimator.SetBool("Up", false);
            PlayerAnimator.SetBool("Left", false);
            PlayerAnimator.SetBool("Rigth", false);
            PlayerAnimator.SetBool("Idle", true);
        }
    }
}
