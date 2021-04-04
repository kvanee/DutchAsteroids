using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleCannonBehavior : BaseCannonBehavior
{
    protected override void Fire()
    {
        var rotation = transform.parent.rotation;
        float shipAngle = rotation.eulerAngles.z;
        CreateBullet(transform.parent.position, rotation);
        CreateBullet(transform.parent.position, Quaternion.Euler(0,0,shipAngle + 22));
        CreateBullet(transform.parent.position, Quaternion.Euler(0,0,shipAngle - 22));
    }
}
