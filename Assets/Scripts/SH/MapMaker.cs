using UnityEngine;
using System.Collections;

public class MapMaker : MonoBehaviour {

    const int CREATE_MAP_NUM = 20; // 생성될 맵 총 개수
    const int MAP_TYPE_NUM = 4; // 맵 종류의 개수
    int mapCount = 0; // 만들어진 맵 개수 

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
            Maps[index] = Resources.Load("Prefabs/Map1") as GameObject; // Map1 로드
        }

        // Map2
        for (int i = CREATE_MAP_NUM / MAP_TYPE_NUM; i < CREATE_MAP_NUM / MAP_TYPE_NUM * 2; i++)
        {
            index = RandomNumMake(CREATE_MAP_NUM);
            Maps[index] = Resources.Load("Prefabs/Map2") as GameObject; // Map2 로드
        }

        // Map3
        for (int i = CREATE_MAP_NUM / MAP_TYPE_NUM * 2; i < CREATE_MAP_NUM / MAP_TYPE_NUM * 3; i++)
        {
            index = RandomNumMake(CREATE_MAP_NUM);
            Maps[index] = Resources.Load("Prefabs/Map3") as GameObject; // Map3 로드
        }

        // Map4
        for (int i = CREATE_MAP_NUM / MAP_TYPE_NUM * 3; i < CREATE_MAP_NUM / MAP_TYPE_NUM * 4; i++)
        {
            index = RandomNumMake(CREATE_MAP_NUM);
            Maps[index] = Resources.Load("Prefabs/Map4") as GameObject; // Map4 로드
        }
    }
}
