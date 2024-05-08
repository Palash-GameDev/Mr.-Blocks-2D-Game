using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D _rb2D;
    public float speed = 5f;
    public GameObject UiPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
       if (Input.GetAxis("Horizontal") > 0)
       {
        _rb2D.velocity = new Vector2(speed,0);
       }
       else if (Input.GetAxis("Horizontal") < 0)
       {
        _rb2D.velocity = new Vector2(-speed,0);
       }
       else if(Input.GetAxis("Vertical")>0)
       {
        _rb2D.velocity = new Vector2(0,speed);
       }
       else if(Input.GetAxis("Vertical")<0)
       {
        _rb2D.velocity = new Vector2(0,-speed);
       }
       else if(Input.GetAxis("Horizontal") ==0 && Input.GetAxis("Vertical")==0 )
       {
        _rb2D.velocity = new Vector2(0,0);
       }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Door")
        {
            UiPanel.SetActive(true);
            Debug.Log("Player collided with " + other.name);
            Debug.Log("Level Completed!!!!!!!!!!!!!!!!!");
        }
        
    }

    public void OnPlayAgain()
    {
        UiPanel.SetActive(false);
        this.transform.position = new Vector3(0,0,0);
    }


}// Class end
