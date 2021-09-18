## DEV-15, Death FX
### Tags: [animation, keyframe, collision matrix, hp, damage]

### Unity Links

https://docs.unity3d.com/ScriptReference/Animator.html

### Make it so that the fire balls dont hurt while the Lizard spawns

+ Box collider 2D disabled while jump animation is on

![](../images/DEV-15-A.png)

+ Box collider 2D enabled while walk animation is on

![](../images/DEV-15-B.png)

### Add collision for Defenders

+ Rigidbody 2D
+ Box Collider 2D

![](../images/DEV-15-M.png)

### Create a Collision Matrix

+ Add new Layers

![](../images/DEV-15-F.png)

+ Create our new Layers

![](../images/DEV-15-G.png)

+ Add Projectile Layer to Fireball

![](../images/DEV-15-C.png)

+ Add Attacker Layer to Lizard

![](../images/DEV-15-D.png)

+ Add Defender Layer to Cactus

![](../images/DEV-15-E.png)

+ Construct the collision matrix at `Edit > Project Settings > Physics 2D`

![](../images/DEV-15-H.png)

+ Updated Physics Matrix

![](../images/DEV-15-I.png)

## Created Stats Managment

+ Stats.cs

![](../images/DEV-15-J.png)

+ Attacker.cs

![](../images/DEV-15-K.png)

+ Projectile.cs

![](../images/DEV-15-L.png)

Then gave Projectiles and Attackers the script


### Death on Animation

+ create an explosion animation and add it to the attacker
+ make sure the death animation on the right Sorting Layer and Order in Layer

![](../images/DEV-15-N.png)

![](../images/DEV-15-O.png)

![](../images/DEV-15-P.png)