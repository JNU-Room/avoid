using UnityEngine;
using System.Collections;
namespace MH
{
    public class Player : MonoBehaviour
    {
        public float delta = 0.07f;
        public bool grounded = false;
        public float jumpForce = 270f;
        private bool jump = false;
        public bool doubleJump = false; //테스트 완료후 private로 숨김예정
        Rigidbody rigdbody;
        //2단점프 키변경 혹은 횟수 세는 방식으로 변경 여부 고민중..//
        void Awake()
        {
            rigdbody = GetComponent<Rigidbody>();
        }
        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            float playerX = transform.position.x;
            playerX += delta; // Player 자동이동
            transform.position = new Vector3(playerX, transform.position.y, transform.position.z);
            CheckGround();//지면 여부 검사
            jumpProcess();
        }
        void FixedUpdate()
        {
            Jump();
            DoubleJump();
        }
        void CheckGround()
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.5f))
            {
                if (hit.transform.tag == "GROUND")
                {
                    grounded = true;
                    return;
                }
            }
            grounded = false;
        }
        void jumpProcess()//점프 설정
        {
            if (Input.GetButtonDown("Jump") && grounded == true) //지면이면 jump!
            {
                jump = true;
            }
            if (!doubleJump && jump == true) //점프인 상태인 경우 2단점프 활성화
            {
                doubleJump = true;
            }
        }
        void Jump()
        {
            if (!jump)
                return;
            rigdbody.AddForce(transform.up * jumpForce);
            jump = false;
            
        }
        void DoubleJump()
        {
            if (!doubleJump)
                return;
            if (doubleJump)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    rigdbody.AddForce(transform.up * jumpForce);
                    doubleJump = false;
                }
            }
        }
    }
}