using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DeathMenu : MonoBehaviour {

    public string startGameLevel;








    public void RestartGame()
    {
        Application.LoadLevel(startGameLevel);
    }



}
