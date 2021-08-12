using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToGuild : MonoBehaviour
{
    public void ToGuildScene()
    {
        SceneManager.LoadScene("Guild", LoadSceneMode.Single);
    }
}
