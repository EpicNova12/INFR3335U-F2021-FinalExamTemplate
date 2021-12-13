using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LeaveGame : MonoBehaviour
{
    public GameObject RoomMenu = new GameObject();
    public GameObject LobbyMenu = new GameObject();
    // Start is called before the first frame update

    public void OnClickStart()
    {
        RoomMenu.SetActive(false);
        LobbyMenu.SetActive(true);
        SceneManager.LoadScene("LoadGame");
    }

}
