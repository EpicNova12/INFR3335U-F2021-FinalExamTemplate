using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreateRoom : MonoBehaviour
{
    public GameObject RoomMenu = new GameObject();
    public GameObject LobbyMenu = new GameObject();
    public GameObject ErrorText = new GameObject();
    public InputField RoomNameInput;
    public Text RoomName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickStart()
    {
        if(RoomNameInput.text!="")
        {
            RoomName.text = RoomNameInput.text;
            ErrorText.SetActive(false);
            RoomMenu.SetActive(true);
            LobbyMenu.SetActive(false);
        }
        else
        {
            ErrorText.SetActive(true);
        }
    }
}
