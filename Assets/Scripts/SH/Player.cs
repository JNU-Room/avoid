using UnityEngine;
using System.Collections;
namespace SH
{
    public class Player : MonoBehaviour
    {

        private float delta = 0.07f; // Player의 이동속도
        private int life = 3; // Player의 Life
        private float stopTime = 1; // 일시정지 시간 (초)
        private float nextMove;
        private bool IsStop = false; // 일시정지용
        Rigidbody rigdbody;
        void Awake()
        {
            rigdbody = GetComponent<Rigidbody>();
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

        public void OnTriggerEnter(Collider collider) // Trigger 충돌
        {
            // Obstacle과 충돌
            if (collider.gameObject.tag == "MoveObstacle" ||
                collider.gameObject.tag == "StopObstacle" ||
                collider.gameObject.tag == "DropObstacle" ||
                collider.gameObject.tag == "RollObstacle")
            {
                P_ObstacleCollision();
            }
        }

        public void PlayerMove()
        {
            float playerX = transform.position.x; // Player의 X좌표
                                                  //  byte jumpNum = 0; // 점프 두 번으로 제한

            //   playerX += Input.GetAxis("Horizontal") * 0.1f; // Player 좌우이동
            playerX += delta; // Player 자동이동
            transform.position = new Vector3(playerX, transform.position.y, transform.position.z);


            // 점프

            if (Input.GetButtonDown("Jump"))
            {
               rigdbody.velocity = new Vector3(0, 9, 0);
            }
        }

        // Use this for initialization
        void Start()
        {
            //GameObject.Find("GameManager").GetComponent<GameManager>().MakeMap();
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
        }
    }
}