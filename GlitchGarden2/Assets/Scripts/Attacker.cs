using System.Threading;
using System.Collections;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] [Range(0f, 5f)]  float walkSpeed = 1f;
    [SerializeField] [Range(0f, 5f)]  float spawnWait = 1f;
    bool moveForward = false;

    IEnumerator Start()
    {
        yield return StartCoroutine(Wait());
        moveForward = true;
    }

    void Update()
    {
        if(moveForward){
            Move();
        }
    }

    IEnumerator Wait(){
        yield return new WaitForSeconds(spawnWait);
    }

    void Move(){
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
    }
}
