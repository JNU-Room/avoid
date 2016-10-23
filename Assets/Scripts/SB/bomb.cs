using UnityEngine;
using System.Collections;

public class bomb : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
            DestroyObstacles();                       
        }
    }

    void DestroyObstacles()
    {
        GameObject[] Obstalce = GameObject.FindGameObjectsWithTag("Obstacle");
        for (int i = 0; i < 15; i++)
        {
            Destroy(Obstalce[i]);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
