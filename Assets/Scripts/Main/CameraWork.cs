using UnityEngine;
using System.Collections;

public class CameraWork : MonoBehaviour
{
    GameObject player;
    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player");
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x + 4.61f, transform.position.y, transform.position.z);
    }

}
