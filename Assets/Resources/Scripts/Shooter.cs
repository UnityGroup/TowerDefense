using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shooter : MonoBehaviour
{
    private GameObject bullet;
    private GameObject fireball;
    private float fireRate;
    private List<GameObject> targets;

    void Start()
    {
        bullet = Resources.Load("Prefabs/Bullets/Fireball") as GameObject;
        targets = new List<GameObject>();
    }

    void Update()
    {
        if (fireRate < 1) shoot();
        fireRate--;
        if (targets.Count > 0 &&  !targets[0]) remove(targets[0]);
    }

    void shoot()
    {
        if (targets.Count > 0)
        {
            fireball = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            fireRate = 20;
            fireball.GetComponent<BulletMovement>().setTarget(targets[0]);
        }
    }

    public void add(GameObject other)
    {
        Debug.Log("Añado al enemigo " + other);
        targets.Add(other.gameObject);
    }

    public void remove(GameObject other)
    {
        Debug.Log("Quito al enemigo " + other);
        targets.Remove(other.gameObject);
    }
}
