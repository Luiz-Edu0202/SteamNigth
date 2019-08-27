using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerbehavior : MonoBehaviour
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
            rb.velocity = new Vector2(Input.GetAxis("Horizontal")* StandartSpeed, Input.GetAxis("Vertical") * StandartSpeed);
    }
}
