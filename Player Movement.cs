using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;

    [SerializeField] private LayerMask jumpableGround;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Awake()
    {

    }
    private void FixedUpdate(){
        
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

     if (Input.GetButtonDown("Jump"))
     {
        GetComponent<Rigidbody2D>().velocity = new Vector2(rb.velocity.x,14f);
     }  
    }
    // Update is called once per frame
    private void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

     if (Input.GetButtonDown("Jump")/* && IsGrounded()*/)
     {
        GetComponent<Rigidbody2D>().velocity = new Vector2(rb.velocity.x,14f);
     }   
    }
   /* private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
    */
}
