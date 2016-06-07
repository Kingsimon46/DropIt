using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelController : MonoBehaviour {

    public static LevelController instance;
    public PlayerController PlayerController;
    public ColorChanger cChanger;
    public ObjectSpawner objSpawner;

    public ScoreManager scoreManager;
    public HealthManager hManager;
    public DeathMenu theDeathScreen;

    private int points = 0;
    private int cycleCount = 1;

    public Text scoreTextToDisable;
    public Text highScoreTextToDisable;

    // Use this for initialization
    void Start () {

        cChanger = GameObject.Find("ColorChanger").GetComponent<ColorChanger>();
        cChanger.SetUp();
        
        objSpawner.spawnNewDrop();
    

    }
	
	// Update is called once per frame
	void Update () {
       
        if(hManager.lives <= 0)
        {
            GameOver();
        }
        
	}

    // Called after good color-check
    public void StartNewCycle(GameObject oldDrop)
    {
        Debug.Log("Load New Level initated");
        // Call class for adding points
        scoreManager.AddScore();
        // Call class for increasing cycleCount and difficulty
        // Call ObjectPooler to remove current drop and setup platform for new cicle
        // Call ObjectSpawner to spawn new drop
        
        objSpawner.setDropDeactive(oldDrop);
        
        objSpawner.spawnNewDrop();

    }

    void GameOver()
    {
        //deactivate gamecontrolls.
        PlayerController.gameIsActive = false;
        // disable active score texts.
        scoreTextToDisable.gameObject.SetActive(false);
        highScoreTextToDisable.gameObject.SetActive(false);
        //Activating theDeathScreen overlay.
        
        StartCoroutine(wait());
        StopCoroutine(wait());

    }


    void increaseDifficulty()
    {

    }
    
    IEnumerator wait()
    {
        yield return new WaitForSeconds(.3f);
        
        theDeathScreen.gameObject.SetActive(true);

    }

}
