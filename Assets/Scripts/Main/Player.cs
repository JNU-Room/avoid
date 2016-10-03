using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Player : MonoBehaviour
    {
        public const float moveSpeed = 5.0f;
        private int life = 3; // Player의 Life
        private float stopTime = 1; // 일시정지 시간 (초)
        private float nextMove;
        private bool IsStop = false; // 일시정지용
        public bool grounded = false;    
        private bool jump = false;
        public bool doubleJump = false;
        Rigidbody rigdbody;
        public Animator anmi;

        void Awake()
        {
            rigdbody = GetComponent<Rigidbody>();
            anmi = GetComponent<Animator>();
        }

        public int GetLife() // Life Getter 함수
        {
            return life;            
        }

        public void SetLife(int life) // Life Setter 함수
        {
         this.life = life;     
        }
        
        public void P_ObstacleCollision() // Player -> Obatacle 충돌
        {
            life--; // 라이프 감소
                    // 감소 알림 문구 띄우기 (수정 필요)
            // 일시정지
            IsStop = true;
            nextMove = Time.time + stopTime;

            // 뒤로 이동
            transform.position = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z);
        }

    public void OnTriggerEnter(Collider collider) // Trigger 충돌
        {
            if (IsStop) // 일시정지 상태면 Trigger가 안 먹힘
                return;

            // Obstacle과 충돌
            if (collider.gameObject.tag == "Obstacle")
            {
                P_ObstacleCollision();
                if (anmi != null) anmi.SetBool("dmgChk", true); //Obstacle Tag 인식시, dmgChk true로 변경
            //GetComponent<AudioSource>().Play();
            }
            if (collider.gameObject.tag == "GROUND")
            {               
                if (anmi != null) anmi.SetBool("jmpChk", false); //GROUND Tag 인식시, jmpChk false로 변경
                if (anmi != null) anmi.SetBool("dmgChk", false);
            }
        }

        public void PlayerMove() // Player 이동 
        {
            if (Input.GetAxis("Horizontal") < 0)
                return;
            float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            this.gameObject.transform.Translate(distanceX, 0, 0);

        }
        public void PlayerMotion() // Player 동작(점프)
        {
            if (Input.GetButton("Horizontal"))
            {
            if (anmi != null) anmi.SetBool("runChk", true);  //->방향키 입력했을때 runChk true로 변경       
            }
            else
            {
                if (anmi != null) anmi.SetBool("runChk", false); //->방향키 미입력시 runChk false로 변경  
            }

            if (Input.GetButton("Jump"))
            {
                if (anmi != null) anmi.SetBool("jmpChk", true); //space 키입력시, jmpChk true로 변경
            }
            
        }
        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            jumpProcess(); //이중점프 프로세스
            CheckGround();//지면 여부 검사
            PlayerMotion();
        if (IsStop == true) // 일시정지 O
            {
                if (Time.time > nextMove)
                {
                    IsStop = false;
                    if (anmi != null) anmi.SetBool("dmgChk", false);
            }
            }
            else // 일시정지 X
                PlayerMove();
 

        }
    void FixedUpdate()
    {
        Jump();
        DoubleJump();
    }
    void CheckGround() // 그라운드 체크
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.78f))
        {
            if (hit.transform.tag == "GROUND" || hit.transform.tag == "Obstacle")
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
    void Jump() // 1단 점프 조건
    {
        if (!jump)
            return;
        rigdbody.velocity = new Vector3(0, 8, 0);
        jump = false;
    }
    void DoubleJump() // 더블 점프 조건
    {
        if (!doubleJump)
            return;
        if (doubleJump)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rigdbody.velocity = new Vector3(0, 8, 0);
                doubleJump = false;
            }
        }
    }
}
