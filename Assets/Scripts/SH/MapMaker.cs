using UnityEngine;
using System.Collections;

public class MapMaker : MonoBehaviour {

    const int CREATE_MAP_NUM = 24; // 생성될 맵 총 개수
    const int MAP_TYPE_NUM = 8; // 맵 종류의 개수
   // int mapCount = 0; // 만들어진 맵 개수 

    GameObject[] Maps = new GameObject[CREATE_MAP_NUM]; // 생성될 맵 개수만큼의 GameObject 배열

    // 메소드

    public void InputPrefab() // Maps[]에 Map Prefab을 입력
    {
        int randomType;

        for (int i = 0; i < CREATE_MAP_NUM; i++)
        {
            randomType = Random.Range(0,MAP_TYPE_NUM);

            switch(randomType)
            {
                case 0: // Map1
                    Maps[i] = Resources.Load("Map/Map1") as GameObject; // Map1 로드
                    break;

                case 1: // Map2
                    Maps[i] = Resources.Load("Map/Map2") as GameObject; // Map2 로드
                    break;

                case 2: // Map3
                    Maps[i] = Resources.Load("Map/Map3") as GameObject; // Map3 로드
                    break;

                case 3: // Map4
                    Maps[i] = Resources.Load("Map/Map4") as GameObject; // Map4 로드
                    break;

                case 4: // MapA
                    Maps[i] = Resources.Load("Map/MapA") as GameObject; // MapA 로드
                    break;

                case 5: // MapB
                    Maps[i] = Resources.Load("Map/MapB") as GameObject; // MapB 로드
                    break;

                case 6: // MapC
                    Maps[i] = Resources.Load("Map/MapC") as GameObject; // MapC 로드
                    break;

                case 7: // MapD
                    Maps[i] = Resources.Load("Map/MapD") as GameObject; // MapD 로드
                    break;

                default:
                    break;
            }
        }
    }

    public void AutoCreateMap() // 맵 자동 생성 메소드
    {
        InputPrefab(); // Prefab 입력
        
        for (int i = 0; i < CREATE_MAP_NUM; i++)
        {
            Instantiate(Maps[i],new Vector3(50 * i, -3f, 0), Quaternion.identity); // Map을 position위치에 identity만큼(안 돌림) 돌려서 생성 (이름, 위치, 회전률)
        }
    }
}
