using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerbehavior2 : MonoBehaviour
{
    [SerializeField] private float StandartSpeed;
    [SerializeField] private float StandartJump;
    Rigidbody2D rb;
  
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            rb.velocity = new Vector2(Input.GetAxis("Horizontal")* StandartSpeed * 10, 0);
        if(Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector2(0,StandartJump * 1000));
        }
    }
}
