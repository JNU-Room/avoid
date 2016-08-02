using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {

            GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();
            gmComponent.RestartGame();
        }
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}
}
