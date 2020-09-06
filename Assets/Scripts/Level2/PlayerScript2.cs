using UnityEngine;
using System.Collections;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerScript2 : MonoBehaviour
{
    Rigidbody2D rb;
    public Vector2 jumpForce;
    Vector2 currentVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (rb.gravityScale != 0.5f)
            {
                rb.gravityScale = 0.5f;
            }
            rb.AddForce(jumpForce);
            SpeedController();
        }
    }
    void SpeedController()
    {
        currentVelocity = rb.velocity;
        currentVelocity.x = Mathf.Clamp(currentVelocity.x, 2, 2);
        currentVelocity.y = Mathf.Clamp(currentVelocity.y, 2, 2);
        rb.velocity = currentVelocity;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "FinishLine")
        {
                // Debug.Log("Finished");
                SceneManager.LoadScene("Win2");
        }
        else if(collision.tag == "Enemy")
        {
                // Debug.Log("DEAD");
                SceneManager.LoadScene("Dead2");
        }
        
    }


}   
