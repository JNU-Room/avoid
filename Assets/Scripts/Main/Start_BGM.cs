using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_BGM : MonoBehaviour {
    public AudioClip startBGM;
    public AudioClip dmgChkBGM;
    public AudioClip itmGetBGM;
    public AudioSource _audio;
    public static Start_BGM instance;
    void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);

    }
    public void StartGame()
    {
        _audio.clip = startBGM;
        _audio.Play();
        //SceneManager.LoadScene("Practice one");
    }
    public void RestartGame()
    {
        _audio.clip = startBGM;
        _audio.Stop();
    }

}
