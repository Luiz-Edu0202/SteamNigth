using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpBehavior : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Player;
    [SerializeField] private float SpeedOfJump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.AddForce(new Vector2(0, SpeedOfJump * 20));
        }
    }
}
