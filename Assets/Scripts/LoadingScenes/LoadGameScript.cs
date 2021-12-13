using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using Photon.Pun;

public class LoadGameScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Commented out because photon is not working for some reason
        //PhotonNextwork.ConnectUsingSettings();
    }

    // Update is called once per frame
    void Update()
    {
        //PhotonNetwork.JoinLobby();
        SceneManager.LoadScene("Lobby");
    }
    //Commented out since photon is not working and OnJoinedLobby() doesnt exsist, LoadScene has been move to Update() so it can still function
    /*public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
    }*/
}
