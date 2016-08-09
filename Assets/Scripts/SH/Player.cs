using UnityEngine;
using System.Collections;
namespace SH
{
    public class Player : MonoBehaviour
    {

        float delta = 0.07f;

        // GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();

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