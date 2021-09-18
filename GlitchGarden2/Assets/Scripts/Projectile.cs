using System.Threading;
using System.Collections;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    float currentSpeed = 2f;

    void Update()
    {
        Move();
    }

    public void SetMovementSpeed(float speed){
        currentSpeed = speed;
    }

    void Move(){
        var self = gameObject.GetComponent<MovementOptions>();
        self.SinusoidalRight(currentSpeed);
        // self.Pulsate();
    }
}


