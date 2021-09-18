using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOptions : MonoBehaviour
{
    // Start is called before the first frame update
    public void SinusoidalRight(float currentSpeed){
        float x = (Time.deltaTime) * 1000;
        float y = Mathf.Sin(2 * Mathf.PI * x);
        var vector = new Vector2(1, Random.Range(-y * 5, y * 5));
        transform.Translate(vector * currentSpeed * Time.deltaTime);
    }

    public void SinusoidalLeft(float currentSpeed){
        float x = (Time.deltaTime) * 1000;
        float y = Mathf.Sin(2 * Mathf.PI * x);
        var vector = new Vector2(-1, Random.Range(-y * 5, y * 5));
        transform.Translate(vector * currentSpeed * Time.deltaTime);
    }

    public void LinearRight(float currentSpeed){
        transform.Translate(Vector2.right * currentSpeed * Time.deltaTime);
    }

    public void LinearLeft(float currentSpeed){
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }
}
