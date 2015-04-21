using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    private GameObject wayPoint;
    private Transform[] wayPointList;
    public int currentWayPoint = 1;
    private float speed = 0.02f;
    private Animator animator;
    private bool facingRight = false;
    private Health health;

	void Start () {
        animator = GetComponent<Animator>();
        health = GameObject.Find("HealthText").GetComponent<Health>();
	}
	
    void FixedUpdate()
    {
        if (wayPoint)
        {
            if (transform.position != wayPointList[currentWayPoint].position) nextWayPointMovement();
            else
            {
                currentWayPoint += 1;
                if (currentWayPoint >= wayPointList.Length)
                {
                    Destroy(gameObject);
                    health.spendHealth(1);
                }
                else rotateToDirection();
            }
        }
    }

    private void nextWayPointMovement()
    {
        Vector2 position = Vector2.MoveTowards(transform.position, wayPointList[currentWayPoint].position, speed);
        GetComponent<Rigidbody2D>().MovePosition(position);
        
    }

    public void setWayPoint(GameObject wayPoint)
    {
        this.wayPoint = wayPoint;
        wayPointList = wayPoint.GetComponentsInChildren<Transform>();
    }

    void flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void rotateToDirection()
    {
        if (wayPointList[currentWayPoint].position.y > wayPointList[currentWayPoint - 1].position.y)
        {
            animator.SetInteger("Direction", 1); //Arriba
        }
        else if (wayPointList[currentWayPoint].position.y < wayPointList[currentWayPoint - 1].position.y)
        {
            animator.SetInteger("Direction", 2); //Abajo
        }
        else if ((wayPointList[currentWayPoint].position.x > wayPointList[currentWayPoint - 1].position.x))
        {
            animator.SetInteger("Direction", 3); //Derecha
            if(!facingRight)flip();
        }else
        {
            animator.SetInteger("Direction", 3); //Izquierda
            if (facingRight) flip();
        }
    }

}
