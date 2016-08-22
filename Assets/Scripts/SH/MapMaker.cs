using UnityEngine;
using System.Collections;

public class MapMaker : MonoBehaviour {

    const int CREATE_MAP_NUM = 20; // 생성될 맵 총 개수
    const int MAP_TYPE_NUM = 8; // 맵 종류의 개수
   // int mapCount = 0; // 만들어진 맵 개수 

    GameObject[] Maps = new GameObject[CREATE_MAP_NUM]; // 생성될 맵 개수만큼의 GameObject 배열

    // 메소드

    public bool OverlapMap(int index) // 중복 Map 체크
    {
        if (Maps[index] == null)
            return false;
        else
            return true;
    }

    public int RandomNumMake(int end) // 랜덤 숫자 반환
    {
        int randomNum;

        while (true)
        {
            randomNum = Random.Range(0, end);

            if (OverlapMap(randomNum) == false) // 중복이 없으면
                break; // 종료 
        }

        return randomNum;
    }

    public void InputPrefab() // Maps[]에 Map Prefab을 입력
    {
        int index;
        
        // Map1
        for (int i = 0; i < CREATE_MAP_NUM / MAP_TYPE_NUM; i++)
        {
            index = RandomNumMake(CREATE_MAP_NUM);
            Maps[index] = Resources.Load("Map/Map1") as GameObject; // Map1 로드
        }

        // Map2
        for (int i = CREATE_MAP_NUM / MAP_TYPE_NUM; i < CREATE_MAP_NUM / MAP_TYPE_NUM * 2; i++)
        {
            index = RandomNumMake(CREATE_MAP_NUM);
            Maps[index] = Resources.Load("Map/Map2") as GameObject; // Map2 로드
        }

        // Map3
        for (int i = CREATE_MAP_NUM / MAP_TYPE_NUM * 2; i < CREATE_MAP_NUM / MAP_TYPE_NUM * 3; i++)
        {
            index = RandomNumMake(CREATE_MAP_NUM);
            Maps[index] = Resources.Load("Map/Map3") as GameObject; // Map3 로드
        }

        // Map4
        for (int i = CREATE_MAP_NUM / MAP_TYPE_NUM * 3; i < CREATE_MAP_NUM / MAP_TYPE_NUM * 4; i++)
        {
            index = RandomNumMake(CREATE_MAP_NUM);
            Maps[index] = Resources.Load("Map/Map4") as GameObject; // Map4 로드
        }

        // MapA
        for (int i = CREATE_MAP_NUM / MAP_TYPE_NUM * 4; i < CREATE_MAP_NUM / MAP_TYPE_NUM * 5; i++)
        {
            index = RandomNumMake(CREATE_MAP_NUM);
            Maps[index] = Resources.Load("Map/MapA") as GameObject; // MapA 로드
        }

        // MapB
        for (int i = CREATE_MAP_NUM / MAP_TYPE_NUM * 5; i < CREATE_MAP_NUM / MAP_TYPE_NUM * 6; i++)
        {
            index = RandomNumMake(CREATE_MAP_NUM);
            Maps[index] = Resources.Load("Map/MapB") as GameObject; // MapB 로드
        }

        // MapC
        for (int i = CREATE_MAP_NUM / MAP_TYPE_NUM * 6; i < CREATE_MAP_NUM / MAP_TYPE_NUM * 7; i++)
        {
            index = RandomNumMake(CREATE_MAP_NUM);
            Maps[index] = Resources.Load("Map/MapC") as GameObject; // MapC 로드
        }

        // MapD
        for (int i = CREATE_MAP_NUM / MAP_TYPE_NUM * 7; i < CREATE_MAP_NUM / MAP_TYPE_NUM * 8; i++)
        {
            index = RandomNumMake(CREATE_MAP_NUM);
            Maps[index] = Resources.Load("Map/MapD") as GameObject; // MapD 로드
        }

    }

    public void AutoCreateMap() // 맵 자동 생성 메소드
    {
        Debug.Log("AutoCreateMap()");
        InputPrefab(); // Prefab 입력
        
        for (int i = 0; i < CREATE_MAP_NUM; i++)
        {
            Debug.Log("생성 " + i);
            Instantiate(Maps[i],new Vector3(50 * i, 0, 0), Quaternion.identity); // stone을 position위치에 identity만큼(안 돌림) 돌려서 생성 (이름, 위치, 회전률)
        }
    }
}
