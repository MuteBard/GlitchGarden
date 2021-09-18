using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOptions : MonoBehaviour
{
    //NOTES:
    
    //Sin
    //https://docs.unity3d.com/ScriptReference/Mathf.Sin.html

    //Vector2
    //https://docs.huihoo.com/unity/5.4/Documentation/en/ScriptReference/Vector2.html

    //Translate
    //https://docs.unity3d.com/Manual/EventFunctions.html

    //Scale
    //https://docs.unity3d.com/ScriptReference/Transform-localScale.html

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

    public void Pulsate(){
        var randomFactor = Random.Range(0.95f, 1.05f);
        var scaleChange = new Vector2(randomFactor, randomFactor);
        transform.localScale = scaleChange;
    }
}
