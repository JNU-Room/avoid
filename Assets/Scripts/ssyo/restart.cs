using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    void OnGUI()
    {
        if (GUI.Button ( new Rect( Screen.width - ((Screen.width / 60))- (Screen.width / 20), Screen.height / 60, Screen.width /20, Screen.width / 20),"Rt"))
        {
            SceneManager.LoadScene("Start");
        }
    }
}
