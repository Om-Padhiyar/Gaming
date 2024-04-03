using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerDeath : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.CompareTag("death")){
       Die(); 
  //Destroy(gameObject);
      }

    }
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("Death");
    }
    private void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

}
