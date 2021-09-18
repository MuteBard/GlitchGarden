using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField] float hp = 1;
    [SerializeField] float damage = 50;
    [SerializeField] float defense = 1;
    [SerializeField] float resistance = 10;

    Color originalColor;

    void Start(){
        if(!!gameObject){
            originalColor = gameObject.GetComponent<Renderer>().material.color;
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(!other){
            return;
        }

        Stats otherStats = other.gameObject.GetComponent<Stats>();
        Projectile iamProjectile = gameObject.GetComponent<Projectile>();
        if(otherStats && !iamProjectile){
            RecieveDamage(otherStats);
        }

        if(iamProjectile){
            Destroy(gameObject);
        }
    }
    private void RecieveDamage(Stats stats){
        StartCoroutine(ReactToDamageFromOther(stats));
        if(hp <= 0){
             Perish();
        }
    }
    private IEnumerator ReactToDamageFromOther(Stats stats){
        setColor(Color.red);
        yield return new WaitForSeconds(ResistanceTime());
        hp -= stats.GetDamage() - defense;
        setColor(getOriginalColor());
    }
    private Color getOriginalColor(){
        return originalColor;
    }
    private Color getColor(){
        return gameObject.GetComponent<Renderer>().material.color;
    }
    private void setColor(Color color){
        gameObject.GetComponent<Renderer>().material.color = color;
    }
    private float ResistanceTime(){
        return resistance / 25;
    }
    public float GetDamage(){
        return damage;
    }
    private void Perish(){
        Attacker attacker = gameObject.GetComponent<Attacker>();
        if(attacker){
           attacker.Perish();
        }else{
            Destroy(gameObject);
        }
    }
}
