using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JumpComponent : MonoBehaviour
{
    int score = 0;
    public TextMeshProUGUI scoreText;

    void Start()
    {
      Rigidbody2D rb = GetComponent<Rigidbody2D>();
      rb.velocity = new Vector2(5f, 0);
    }
    
    void Update()
    {
        bool isPressingSpace = Input.GetKeyDown(KeyCode.Space);
        if(isPressingSpace)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(new Vector2(0f, 500f));
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
      if(other.gameObject.CompareTag("Enemy"))
      {
        Debug.Log("Birt died");
        Destroy(gameObject);
      }
      
      if(other.gameObject.CompareTag("Fernado"))
      {
         score++;
         scoreText.text = "Score: " + score;
      }
    }

}