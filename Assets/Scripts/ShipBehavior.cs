using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBehavior : MonoBehaviour
{
    public GameObject gun;
    public Rigidbody2D rb;
    public float thrust = 50;
    public float angularThrust = 10;

    private float horizontalInput;
    private float verticalInput;
    
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.AddRelativeForce(Vector2.up * verticalInput * thrust);
        rb.AddTorque(-horizontalInput * angularThrust);
        transform.WrapOnScreen();
    }
}
