using System.Threading;
using System.Collections;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    float currentSpeed = -2f;

    void Update()
    {
        Move();
    }

    public void SetMovementSpeed(float speed){
        currentSpeed = speed;
    }

    void Move(){
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

}
