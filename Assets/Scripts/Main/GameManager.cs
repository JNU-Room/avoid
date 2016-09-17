using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    
    public bool IsMapMake = true;

    // Use this for initialization
    void Start () {
        if (IsMapMake)
        {
            GameObject.Find("GameManager").GetComponent<MapMaker>().FirstCreateMap(); // Map 생성 시작
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (IsMapMake)
        {
            GameObject.Find("GameManager").GetComponent<MapMaker>().CreateMap(); // Map 계속 생성
            GameObject.Find("GameManager").GetComponent<MapMaker>().DeleteMap(); // Map 계속 삭제
        }
    }
}
