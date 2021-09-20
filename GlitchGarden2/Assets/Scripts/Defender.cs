using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;

    void Fire(){
        Vector2 flamePos = new Vector2(gun.transform.position.x, gun.transform.position.y + .8f);
        Instantiate(projectile, flamePos, transform.rotation);
    }
}
