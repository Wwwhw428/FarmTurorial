using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float inputX;
    private float inputY;
    private Vector2 movementInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        PlayerInput();
    }

    private void FixedUpdate() {
        Movement();
    }
    private void Movement()
    {
        rb.MovePosition(rb.position + movementInput * speed * Time.deltaTime);
    }

    private void PlayerInput()
    {
        // if (inputY == 0)  // 限制人物只能延 x y 轴移动
        inputX = Input.GetAxisRaw("Horizontal");
        // if (inputX == 0)  // 限制人物只能延 x y 轴移动
        inputY = Input.GetAxisRaw("Vertical");
        
        if (inputX != 0 && inputY != 0)
        {
            inputX *= 0.6f;
            inputY *= 0.6f;
        }

        movementInput = new Vector2(inputX, inputY);
    }
}
