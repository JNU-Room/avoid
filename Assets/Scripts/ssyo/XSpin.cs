using UnityEngine;
using System.Collections;

public class XSpin : MonoBehaviour
{
    public float speed = 140f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        transform.Rotate(new Vector3(1, 0, 0) * speed * Time.deltaTime);


    }
}


