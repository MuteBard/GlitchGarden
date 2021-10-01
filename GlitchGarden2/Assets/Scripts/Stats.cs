using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField] float hp = 1;
    [SerializeField] float attack = 50;
    [SerializeField] float defense = 1;
    [SerializeField] float resistance = 10;
    [SerializeField] float speed = 1;
    [SerializeField] int cost = 50;

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
        if(otherStats){
            RecieveDamage(otherStats);
        }

        if(iamProjectile){
            Destroy(gameObject);
        }
    }
    private void RecieveDamage(Stats otherStats){
        StartCoroutine(ReactToDamageFromOther(otherStats));
        if(hp <= 0){
             Perish();
        }
    }
    private IEnumerator ReactToDamageFromOther(Stats otherStats){
        setColor(Color.red);
        yield return new WaitForSeconds(ResistanceTime());
        hp -= otherStats.GetAttack() - defense;
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
    public float GetAttack(){
        return attack;
    }
    public float GetDefense(){
        return defense;
    }
    public void SetCost(int newCost){
        cost = newCost;
    }
    public int GetCost(){
        return cost;
    }
    public float GetSpeed(){
        return speed;
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
