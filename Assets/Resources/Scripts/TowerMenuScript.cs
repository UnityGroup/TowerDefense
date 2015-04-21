using UnityEngine;
using System.Collections;

public class TowerMenuScript : MonoBehaviour {
    private GameObject menu;
    private bool abierta;

	void Start () {
        menu = Resources.Load("Prefabs/Towers/Menu") as GameObject;
        abierta = false;
	}
	
	void Update () {
	
	}

    void OnMouseDown()
    {
        abierta = true;
        spawnMenu();
    }

    public void spawnMenu()
    {
        GetComponent<Renderer>().enabled = true;
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
    }

    public void hideMenu()
    {
        GetComponent<Renderer>().enabled = false;
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
        abierta = false;
    }

    public bool isOpen()
    {
        return abierta;
    }
    public void setIsOpen(bool prueba)
    {
        this.abierta = prueba;
;
    }
}
