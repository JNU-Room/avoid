using UnityEngine;
using System.Collections;

public class ZSpin : MonoBehaviour
{
    public float speed = 140f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * speed * Time.deltaTime);


    }
}


