using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {


    public void GameStartActive()
    {
        SceneManager.LoadScene("Practice one");
    }
    public void HelpActive()
    {
        SceneManager.LoadScene("Help");
    }
    public void RankActive()
    {

    }
    public void ExitActive()
    {
        Application.Quit(); // 게임 종료
    }
}
