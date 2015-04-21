using UnityEngine;
using System.Collections;

public class BulletDamage : MonoBehaviour {
    private int damage;
    public string damageType;

	void Start () {
        damage = 20;
	}
	
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Enemy"))
        {
            other.gameObject.GetComponent<MonsterHealth>().damage(damage);
        }
    }
}
