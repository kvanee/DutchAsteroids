using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCannonBehavior : BaseCannonBehavior
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    protected override void Fire() 
    {
        CreateBullet(transform.parent.position, transform.parent.rotation);
    }
}
