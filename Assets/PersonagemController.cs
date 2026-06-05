using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemController : MonoBehaviour
{
    public Rigidbody2D rb2d; 
    public float vel;
    public float jumpForce;
    public GameObject GroundCheck;
    private GroundCheck GroundCheckScript;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
        GroundCheckScript = GroundCheck.GetComponent<GroundCheck>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        if(rb2d.velocity.magnitude < 5){
        rb2d.velocity += new Vector2(vel,0) *moveHorizontal * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.Space) && GroundCheckScript.isOnGround)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x,jumpForce);
        }
    }
}
