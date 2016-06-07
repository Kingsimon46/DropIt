using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelController : MonoBehaviour {

    public static LevelController instance;
    public PlayerController playerController;
    public ColorChanger cChanger;
    public ObjectSpawner objSpawner;

    public ScoreManager scoreManager;
    public HealthManager hManager;
    public DeathMenu theDeathScreen;

    public int successfulDrops = 0;

    private float gravitySpeed;

    public Text scoreTextToDisable;
    public Text highScoreTextToDisable;

    // Use this for initialization
    void Start () {

        cChanger = GameObject.Find("ColorChanger").GetComponent<ColorChanger>();
        cChanger.SetUp();

        gravitySpeed = 1f;

        objSpawner.spawnNewDrop(gravitySpeed);
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

        playerController.resetPlatformPosition();

        // Call class for adding points
        scoreManager.AddScore();
        successfulDrops++;
        IncreaseDifficulty();

        // Call class for increasing cycleCount and difficulty
        // Call ObjectPooler to remove current drop and setup platform for new cicle
        // Call ObjectSpawner to spawn new drop

        objSpawner.setDropDeactive(oldDrop);

        cChanger.ChangePlatformColor(successfulDrops);

        objSpawner.spawnNewDrop(gravitySpeed);

    }

    void GameOver()
    {
        //deactivate gamecontrolls.
        playerController.gameIsActive = false;
        // disable active score texts.
        scoreTextToDisable.gameObject.SetActive(false);
        highScoreTextToDisable.gameObject.SetActive(false);
        //Activating theDeathScreen overlay.
        
        StartCoroutine(wait());
        StopCoroutine(wait());
    }

    void IncreaseDifficulty()
    {
        gravitySpeed =+ 1f;
    }
    
    IEnumerator wait()
    {
        yield return new WaitForSeconds(.3f);
        
        theDeathScreen.gameObject.SetActive(true);

    }

}
