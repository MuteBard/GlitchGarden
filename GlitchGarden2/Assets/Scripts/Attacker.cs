using System.Threading;
using System.Collections;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    float currentSpeed = 1f;
    float hitStun = .5f;
    [SerializeField] float hp = 100;

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

    void OnTriggerEnter2D(Collider2D other){
        Projectile projectile = other.gameObject.GetComponent<Projectile>();
        if(projectile){
            RecieveDamage(projectile);
        } 
    }

    void RecieveDamage(Projectile projectile){
        hp -= projectile.GetDamage();
        StartCoroutine(ReactToDamage());
        if(hp <= 0){
            Perish();
        }
    }

    IEnumerator ReactToDamage(){
        Color originalColor = gameObject.GetComponent<Renderer>().material.color;
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        transform.Translate(Vector2.left * 0f * Time.deltaTime);
        yield return new WaitForSeconds(hitStun);
        gameObject.GetComponent<Renderer>().material.color = originalColor;
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

    void Perish(){
        Destroy(gameObject);
    }
}
