using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCannonBehavior : MonoBehaviour
{
    public GameObject bullet;
    protected bool fireInput;
    private int coolDown = 0;
    // Start is called before the first frame update
    void Start()
    {
        //testing
    }

    // Update is called once per frame
    void Update()
    {
        fireInput = Input.GetButton("Fire1");
    }

    protected GameObject CreateBullet(Vector3 position, Quaternion rotation)
    {
        var newBullet = Instantiate(bullet, position, rotation);
        newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * BulletBehavior.Speed);
        Destroy(newBullet, 3);
        coolDown++;
        return newBullet;
    }

    abstract protected void Fire();
    void FixedUpdate() 
    {
        if (fireInput && coolDown == 0)
        {
            Fire();
        }
        else if (coolDown > 0)
        {
            coolDown++;
            if (coolDown > 10)
                coolDown = 0;
        }
    }
}
