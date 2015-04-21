using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour {
    float delay;
    int contador;
    public GameObject wayPoint;
    private NumberOfMonster[] monstersWave;
    private GameObject instantiatedMonster;
    private int health;

	void Start () {
        delay = 1;
        health = 150;
        monstersWave = new NumberOfMonster[] { new NumberOfMonster(Resources.Load("Prefabs/Enemies/Bulbasaur") as GameObject, 2, health), new NumberOfMonster(Resources.Load("Prefabs/Enemies/Charmander") as GameObject, 2, health)};
        contador = 0;
	}
	
	void Update () {
	    if(delay<=0){
            if (monstersWave[contador].getNumber() > 0)
            {
                spawn();
                delay = 1;
                monstersWave[contador].decreaseNumber();
            }
            else
            {
                if (contador < monstersWave.Length-1) contador++;
            }
        }
        delay -= Time.deltaTime;
	}

    private void spawn()
    {
        instantiatedMonster = Instantiate(monstersWave[contador].getMonster(), transform.position, transform.rotation) as GameObject;
        instantiatedMonster.GetComponent<MonsterMovement>().setWayPoint(wayPoint);
        instantiatedMonster.GetComponent<MonsterHealth>().setHealth(health);
    }

    public void setWave(NumberOfMonster[] newWave)
    {
        monstersWave = newWave;
    }
}
