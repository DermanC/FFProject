using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float runningSpeed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator animator;
    private Vector2 input;
    private float lastHorizontalMove;
    private float lastVerticalMove;
    private bool running;

    public Vector2 playerPosition;

    private void Start()
    {
        //GameObject.DontDestroyOnLoad(this.gameObject);    
    }

    private void Update()
    {
        MyInput();
    }

    private void FixedUpdate()
    {
        Walk();
    }

    private void MyInput()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        if (input.x != 0)
        {
            lastHorizontalMove = input.x;
        }
        if (input.y != 0)
        {
            lastVerticalMove = input.y;
        }

        //Animator stuffs
        animator.SetFloat("moveX", input.x);
        animator.SetFloat("moveY", input.y);
        animator.SetFloat("movementSpeed", input.sqrMagnitude);

        if (input.x == 1 || input.x == -1 || input.y == 1 || input.y == -1)
        {
            animator.SetFloat("lastMoveX", input.x);
            animator.SetFloat("lastMoveY", input.y);
        }

        // Running stuffs
        if (Input.GetKey(KeyCode.LeftShift))
        {
            running = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            running = false;
        }
    }

    private void Walk()
    {
        if (running)
        {
            rb.MovePosition(rb.position + input * runningSpeed * Time.fixedDeltaTime);
        }
        else
        {
            rb.MovePosition(rb.position + input * moveSpeed * Time.fixedDeltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Enemy"))
        {
            //Debug.Log(GameObject.GetScene());
        }
    }
}
