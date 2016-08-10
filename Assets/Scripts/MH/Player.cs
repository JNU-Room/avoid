using UnityEngine;
using System.Collections;
namespace MH
{
    public class Player : MonoBehaviour
    {
        public float delta = 0.07f;
        public bool grounded = true;
        public float jumpForce = 250f;
        private bool jump = false;
        private bool doubleJump = false;        
        Rigidbody rigdbody;

        void Awake()
        {
            rigdbody = GetComponent<Rigidbody>();
        }
        // Use this for initialization
        void Start()
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().MakeMap();
        }

        // Update is called once per frame
        void Update()
        {
            float playerX = transform.position.x;
            playerX += delta; // Player 자동이동
            transform.position = new Vector3(playerX, transform.position.y, transform.position.z);
            if (!grounded && rigdbody.velocity.y == 0)
            {
                grounded = true;
            }
            if (Input.GetButtonDown("Jump") && grounded == true)
            {
                jump = true;               
            }
            if (!doubleJump && jump == true)
            {
                doubleJump = true;
            }

        }
        void FixedUpdate()
        {
            if (jump)
            {
                rigdbody.AddForce(transform.up * jumpForce);                
                jump = false;
                grounded = false;               
            }
            if (doubleJump)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    rigdbody.AddForce(transform.up * jumpForce);
                    doubleJump = false;
                }
            }
            return;
        }
    }
}