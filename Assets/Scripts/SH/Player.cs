using UnityEngine;
using System.Collections;
namespace SH
{
    public class Player : MonoBehaviour
    {

        private float delta = 0.07f; // Player의 이동속도
        private int life = 3; // Player의 Life

        public void P_ObstacleCollision() // Player -> Obatacle 충돌
        {
            Debug.Log("P_ObstacleCollision()");
        }

        public void OnTriggerEnter(Collider collider) // Trigger 충돌
        {
            Debug.Log("Player의 충돌 발생");
            // Obstacle과 충돌
            if (collider.gameObject.tag == "MoveObstacle" ||
                collider.gameObject.tag == "StopObstacle" ||
                collider.gameObject.tag == "DropObstacle" ||
                collider.gameObject.tag == "RollObstacle")
            {
                P_ObstacleCollision();
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
            float playerX = transform.position.x; // Player의 X좌표
                                                  //  byte jumpNum = 0; // 점프 두 번으로 제한

            //   playerX += Input.GetAxis("Horizontal") * 0.1f; // Player 좌우이동
            playerX += delta; // Player 자동이동
            transform.position = new Vector3(playerX, transform.position.y, transform.position.z);


            // 점프
            if (Input.GetKeyDown(KeyCode.Space)) // Space 입력
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
            }

        }
    }
}