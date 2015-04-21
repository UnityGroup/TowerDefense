using UnityEngine;
using System.Collections;

public class TargetDetector : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            GetComponentInParent<Shooter>().add(other.gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            GetComponentInParent<Shooter>().remove(other.gameObject);
        }
    }
}
