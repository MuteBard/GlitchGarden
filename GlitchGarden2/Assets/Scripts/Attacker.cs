using System.Threading;
using System.Collections;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    float currentSpeed = 1f;

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
