using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    public string startGameLevel;

    public void StartGame()
    {
        Application.LoadLevel(startGameLevel);
        
    }

    public void GoToShop()
    {
        //for hopingqueens
    }


}
