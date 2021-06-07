using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openingScene : MonoBehaviour
{

    void nextScene()
    {
        SceneManager.LoadScene("2_test");
    }
}
