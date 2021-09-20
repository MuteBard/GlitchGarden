using System.Threading;
using System.Collections;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    float currentSpeed = 1f;
    [SerializeField] GameObject deathAnimation;

    void Update()
    {
        Move();
    }

    public void SetMovementSpeed(float speed){
        currentSpeed = speed;
    }

    void Move(){
        var self = gameObject.GetComponent<MovementOptions>();
        var stats = gameObject.GetComponent<Stats>();
        self.LinearLeft(stats.GetSpeed());
    }

    public void Perish(){
        Vector2 explosionPos = new Vector2(transform.position.x - 1.1f, transform.position.y);
        var explosion = Instantiate(deathAnimation, explosionPos, transform.rotation);
        explosion.GetComponent<Animator>().Play("Explosion");
        Destroy(explosion, .6f);
        Destroy(gameObject);
    }
}
