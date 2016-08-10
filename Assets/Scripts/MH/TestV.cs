using UnityEngine;
using System.Collections;
namespace MH
{
    // 미완성 스크립트 사용 불가
    public class TestV : MonoBehaviour
    {
        public float delta = 0.07f;
        float y = 0.0f;
        float gravity = 0.0f;    // 중력느낌용 
        int direction = 0;      // 0:정지상태, 1:점프중, 2:다운중 
        int oneTimeCurrentJumpCount = 0;//한번에 뛸수있는 점프횟수 
        int currentJumpCount = 0;//현재까지 뛴 점프횟수 

        // 설정값 
        public float jump_speed = 0.2f;  // 점프속도 
        public float jump_accell = 0.01f; // 점프가속 
        float y_base = -1.37f;      // 캐릭터가 서있는 기준점 
        public int oneTimeJumpCount = 2;//한번에 뛸수있는 점프횟수 

        void Start()
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().MakeMap();
            //y_base = transform.position.y;
            y = y_base;
            //Application.targetFrameRate = 60;
        }

        void Update()
        {
            float playerX = transform.position.x;
            playerX += delta; // Player 자동이동
            transform.position = new Vector3(playerX, transform.position.y, transform.position.z);
            JumpProcess();
            if (Input.GetButtonDown("Jump"))
            {
                DoJump();
            }
            // y값을 gameObject에 적용. 
            Vector3 pos = gameObject.transform.position;
            pos.y = y;
            gameObject.transform.position = pos;
        }


        public void DoJump() // 점프키 누를때 1회만 호출 
        {
            if (oneTimeCurrentJumpCount == oneTimeJumpCount)
                return;
            direction = 1;
            oneTimeCurrentJumpCount++;
            currentJumpCount++;
            gravity = jump_speed;            
        }

        void JumpProcess()
        {
            switch (direction)
            {
                case 0: // 2단 점프시 처리 
                    {
                        if (y > y_base)
                        {
                            if (y >= jump_accell)
                            {
                                //y -= jump_accell; 
                                y -= gravity;
                            }
                            else
                            {
                                y = y_base;
                                oneTimeCurrentJumpCount = 0;
                            }
                        }

                        break;
                    }

                case 1: // up 
                    {
                        y += gravity;

                        if (gravity <= 0.0f)
                        {
                            direction = 2;
                        }
                        else
                        {
                            gravity -= jump_accell;
                        }

                        break;
                    }
                case 2: // down 
                    {
                        y -= gravity;

                        if (y > y_base)
                        {
                            gravity += jump_accell;
                        }
                        else
                        {
                            direction = 0;
                            oneTimeCurrentJumpCount = 0;
                            y = y_base;
                        }

                        break;
                    }
            }
        }
    }
}