using UnityEngine;
using System.Collections;
namespace SH
{
    public class Player : MonoBehaviour
    {

        private float delta = 0.07f; // Player의 이동속도
        private int life = 3; // Player의 Life

        // GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();

        // 외부에서 position에 간섭
        public void SetPosition(float x, float y, float z)
        {
            transform.position = new Vector3(x, y, z);
        }

        // 외부에서 life Get
        public int GetLife()
        {
            return life;
        }

        // 외부에서 life Set
        public void SetLife(int life)
        {
            this.life = life;
        }

        // Use this for initialization
        void Start()
        {
            //gmComponent.MakeMap();
            GameObject.Find("GameManager").GetComponent<GameManager>().MakeMap();
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