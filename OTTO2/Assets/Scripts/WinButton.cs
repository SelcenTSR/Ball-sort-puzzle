using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void tryagain()
    {
        PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);

            SceneManager.LoadScene("Scenes/LEVEL1");
            //Time.timeScale = 1.0f;

            //levelEnd.SetActive(false);
        
    }
}
