using UnityEngine;
using System.Collections;

public class MapMaker : MonoBehaviour
{

    const int CREATE_MAP_NUM = 35; // 생성될 맵 총 개수
    const int MAP_TYPE_NUM = 16; // 맵 종류의 개수
    int PlayerMap; // Player 현재 위치 맵

    GameObject[] Maps = new GameObject[CREATE_MAP_NUM]; // 생성될 맵 개수만큼의 GameObject 배열

    // 메소드

    public bool IsExistLast() // 마지막 맵이 생성되었는가?
    {
        if (Maps[CREATE_MAP_NUM - 1] != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public void InputPrefab(int i) // Maps[i]에 Map Prefab을 입력
    {
        int randomType;

        if (i == (CREATE_MAP_NUM - 1 ))
        {
            Maps[i] = Resources.Load("Map/LastMap") as GameObject; // LastMap 로드
            return;
        }

        randomType = Random.Range(0, MAP_TYPE_NUM);

        switch (randomType)
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

            case 4: // Map5
                Maps[i] = Resources.Load("Map/Map5") as GameObject; // Map5 로드
                break;

            case 5: // Map6
                Maps[i] = Resources.Load("Map/Map6") as GameObject; // Map6 로드
                break;

            case 6: // Map7
                Maps[i] = Resources.Load("Map/Map7") as GameObject; // Map7 로드
                break;

            case 7: // Map8
                Maps[i] = Resources.Load("Map/Map8") as GameObject; // Map8 로드
                break;

            case 8: // Map9
                Maps[i] = Resources.Load("Map/Map9") as GameObject; // Map9 로드
                break;

            case 9: // Map10
                Maps[i] = Resources.Load("Map/Map10") as GameObject; // Map10 로드
                break;

            case 10: // Map11
                Maps[i] = Resources.Load("Map/Map11") as GameObject; // Map11 로드
                break;

            case 11: // Map12
                Maps[i] = Resources.Load("Map/Map12") as GameObject; // Map12 로드
                break;

            case 12: // MapA
                Maps[i] = Resources.Load("Map/MapA") as GameObject; // MapA 로드
                break;

            case 13: // MapB
                Maps[i] = Resources.Load("Map/MapB") as GameObject; // MapB 로드
                break;

            case 14: // MapC
                Maps[i] = Resources.Load("Map/MapC") as GameObject; // MapC 로드
                break;

            case 15: // MapD
                Maps[i] = Resources.Load("Map/MapD") as GameObject; // MapD 로드
                break;

            default:
                break;

        }
    }

    public void FirstCreateMap() // 최초 실행 맵생성
    {
        InputPrefab(0);
        InputPrefab(1);

        for (int i = 0; i < 2; i++)
        {
            Maps[i] = (GameObject) Instantiate(Maps[i], new Vector3(50 * i, -3f, 0), Quaternion.identity); // Map을 position위치에 identity만큼(안 돌림) 돌려서 생성 (이름, 위치, 회전률)
        }
    }

    public void CreateMap() // 지속적인 맵 생성
    {
        PlayerMap = (int)(GameObject.Find("Player").transform.position.x / 50); // Player 현재 위치 맵 찾음

        if (Maps[PlayerMap + 1] == null) // 다음 맵이 null이면
        {
            InputPrefab(PlayerMap + 1);

            Maps[PlayerMap + 1] = (GameObject) Instantiate(Maps[PlayerMap + 1], new Vector3(50 * (PlayerMap + 1), -3f, 0), Quaternion.identity); // Map을 position위치에 identity만큼(안 돌림) 돌려서 생성 (이름, 위치, 회전률)
        } 
    }

    public void DeleteMap() // 지난 맵 삭제
    {
        PlayerMap = (int)(GameObject.Find("Player").transform.position.x / 50); // Player 현재 위치 맵 찾음
        
        if (PlayerMap > 1)
        {
            if (Maps[PlayerMap - 2] != null) // 전전 맵이 null이 아니면
            {
                 DestroyImmediate(Maps[PlayerMap - 2], true);
            }
        }
    }
}