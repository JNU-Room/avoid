using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    public float speed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //float xPosition = transform.localEulerAngles.x;
        // xPosition = speed + Input.GetAxis("Horizontal");

        // float yPosition = transform.localEulerAngles.y;
        // yPosition = speed + Input.GetAxis("Horizontal");

        //  transform.localEulerAngles = new Vector2( xPosition, yPosition );

        MoveObject();
        con();
	}
    void MoveObject()
    {

        float amtMove = speed + Time.smoothDeltaTime;
        float key = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * amtMove * key, Space.World);
    }
    void con()
    {
        float amtMove = speed + Time.smoothDeltaTime;
        float key = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * amtMove * key, Space.World);
    }
}
