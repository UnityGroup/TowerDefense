using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour
{
    private GameObject target;
    private float speed = 0.1f;

    void Start()
    {

    }

    void Update()
    {
        if (target)
        {
            Debug.Log("Ataco a: "+ target.name);
            GetComponent<Rigidbody2D>().MovePosition(Vector2.MoveTowards(transform.position, target.transform.position, speed));
        }
        else Destroy(gameObject);
    }

    public void setTarget(GameObject target)
    {
        this.target = target;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!target || other.gameObject == target.gameObject) Destroy(gameObject);
    }
}
