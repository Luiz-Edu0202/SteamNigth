using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoyStickBehavior : MonoBehaviour
{
    [SerializeField] private float StandartSpeed;
    [SerializeField] private VariableJoystick variable;
    Rigidbody2D rb;
  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        rb.velocity = new Vector2(StandartSpeed * variable.Horizontal,StandartSpeed * variable.Vertical);
        
    }
}
