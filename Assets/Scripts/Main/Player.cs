using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public float jumpForce = 350f; //점프 값
    public float delta = 0.07f;
    private bool grounded = false;
    private bool jump;
    Rigidbody rigdbody;

    void Awake()
    {
        rigdbody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        //gmComponent.MakeMap();
        GameObject.Find("GameManager").GetComponent<GameManager>().MakeMap();
    }
    // Update is called once per frame
    void Update()
    {
        float playerX = transform.position.x;
        playerX += delta; // Player 자동이동
        transform.position = new Vector3(playerX, transform.position.y, transform.position.z);
        CheckGround(); //지면 여부 검사
        if (Input.GetButtonDown("Jump") && grounded)
            jump = true;
    }
    void FixedUpdate()
    {

        if (jump)
        {
            rigdbody.AddForce(new Vector3(0f, jumpForce, 0f));
            jump = false;
        }
    }
    void CheckGround() //지면에 닿을경우 점프 제한 
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.9f))
        {
            if (hit.transform.tag == "GROUND")
            {
                grounded = true;
                return;
            }
        }
        grounded = false;
    }
}
