using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Игрок : MonoBehaviour{
 
    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    private bool facingRight = true;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    public Animation Anim;

    public bool isPlaying;

    private void Start(){
        rb = GetComponent<Rigidbody2D>();
        isPlaying = true;
    }

    private void FixedUpdate(){
        if (isPlaying){
            moveInput = Input.GetAxis("Horizontal");
        }
        
        if (isGrounded != true) {
            Anim.Play("Jump anim");
            Anim.Stop("Walking anim");
        } else if (moveInput != 0) {
            Anim.Play("Walking anim");
            Anim.Stop("Jump anim");
        } else {
            Anim.Stop("Walking anim");
            Anim.Stop("Jump anim");
        }

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (facingRight == false && moveInput > 0){
            Flip();
        }
        else if(facingRight == true && moveInput < 0){
            Flip();
        }
    }

    private void Update(){
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        if(isGrounded == true && Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void  Flip() {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }


}
