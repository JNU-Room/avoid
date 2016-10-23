using UnityEngine;
using System.Collections;

public class redbomb : MonoBehaviour
{

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
        GameObject[] GROUND = GameObject.FindGameObjectsWithTag("GROUND");
        for (int i = 0; i < 15; i++)
        {
            Destroy(GROUND[i]);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}