using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;

    void Fire(){
        var newProjectile = Instantiate(projectile, gun.transform.position, transform.rotation);
    }
}
