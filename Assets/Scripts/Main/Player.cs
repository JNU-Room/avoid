using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Player : MonoBehaviour
    {
        public const float moveSpeed = 5.0f;

        private float delta = 0.07f; // Player의 이동속도
        private int life = 3; // Player의 Life
        private float stopTime = 1; // 일시정지 시간 (초)
        private float nextMove;
        private bool IsStop = false; // 일시정지용
        private bool IsGameOver = false; // GameOver?
        public Text GameOverText;
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
        
        public void P_ObstacleCollision() // Player -> Obatacle 충돌
        {
            life--; // 라이프 감소
                    // 감소 알림 문구 띄우기 (수정 필요)
            if (life <= 0) // 라이프 0
            {
                // 게임 오버
            }

            // 일시정지
            IsStop = true;
            nextMove = Time.time + stopTime;

            // 뒤로 이동
            transform.position = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z);

        }

        void OnTriggerStay(Collider other)
        {
            // Game Over 구현
            
            if (life <= 0)
            {
               IsGameOver = true;
               GameOverText.enabled = true;     
            }
        }

    public void OnTriggerEnter(Collider collider) // Trigger 충돌
        {
            if (IsStop) // 일시정지 상태면 Trigger가 안 먹힘
                return;

            // Obstacle과 충돌
            if (collider.gameObject.tag == "MoveObstacle" ||
                collider.gameObject.tag == "StopObstacle" ||
                collider.gameObject.tag == "DropObstacle" ||
                collider.gameObject.tag == "RollObstacle" ||
                collider.gameObject.tag == "BounceObstacle" ||
                collider.gameObject.tag == "SpinObstacle")
            {
                P_ObstacleCollision();
                anmi.Play("cat_hurt"); // 애니메이션 실행 -> 피격
            }
            if (collider.gameObject.tag == "GROUND")
            {
                anmi.Play("cat_run"); // GROUND Tag 인식 -> 서있는 상태.
            }
        }

        public void PlayerMove()
        {
            if (Input.GetAxis("Horizontal") < 0)
                return;


            float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            this.gameObject.transform.Translate(distanceX, 0, 0);
            if (Input.GetButtonDown("Jump"))
            {
                rigdbody.velocity = new Vector3(2, 8, 0);
            }


        }
        public void PlayerMotion()
        {
            if (Input.GetButtonDown("Jump"))
            {
                anmi.Play("cat_jump");
            }

        }


        // Use this for initialization
        void Start()
        {
            
            GameObject.Find("GameManager").GetComponent<MapMaker>().AutoCreateMap();
        }

        // Update is called once per frame
        void Update()
        {

            if (IsStop == true) // 일시정지 O
            {
                if (Time.time > nextMove)
                {
                    IsStop = false;
                }
            }
            else // 일시정지 X
                PlayerMove();
            PlayerMotion();
        }
    }
