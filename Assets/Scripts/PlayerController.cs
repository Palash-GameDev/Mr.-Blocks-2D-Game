using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
     Rigidbody2D _rb2D;
    public float speed = 5f;
    
    public GameObject GameOverPanel;
    public GameObject _winPanel ;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()

    {

        _rb2D.velocity = new Vector2(Input.GetAxis("Horizontal")*speed,Input.GetAxis("Vertical")*speed);
      
    }

    void  OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
             GameOverPanel.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

    void  OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Door")
        {
            _winPanel.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
    



}// Class end
