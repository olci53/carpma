using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ikinciMenumanager : MonoBehaviour
{
    public void hangioyunAcilsin(string hangiOyun)
    {
        PlayerPrefs.SetString("hangiOyun", hangiOyun);
        SceneManager.LoadScene("gameLevel");
    }
}
