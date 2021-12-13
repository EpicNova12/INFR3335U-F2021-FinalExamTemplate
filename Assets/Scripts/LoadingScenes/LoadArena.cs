using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadArena : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("Arena");
    }
}
