using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {
    public GameObject target;
    private Vector3 pos;

	void Start () {
        pos = transform.position;
	}
	
	void FixedUpdate () {
        if (target)GetComponent<Rigidbody2D>().MovePosition(Vector2.MoveTowards(transform.position, target.transform.position, 0.05f));
        else Destroy(gameObject);
	}

    public void setTarget(GameObject target)
    {
        this.target = target;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy") Destroy(gameObject);
    }
}
