using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ColorChanger : MonoBehaviour {


    //array for the colors, public so that u can set them in the inspector from within Unity.
    //public Color[] colors;

    public GameObject dropCube;
    
    public GameObject[] platformCC = new GameObject[9];
    public Color32[] availColors = new Color32[9];
    public PlatformColor[] colors = new PlatformColor[9];

    public List<Color32> usedColors = new List<Color32>();

    void Start () {
        
        Debug.Log("Start Color");
        for (int i = 0; i < availColors.Length; i++)
        {
            Debug.Log(i + " Color");
            colors[i] = new PlatformColor(availColors[i]);
        }

        /*
        //Start Changing the Colors. 1f= after 1second ingame it starts, 1f = every 1 second after it is going to change again.
        InvokeRepeating("ChangeCcColors", 1f, 1f);
        */
    }

    public void SetUp()
    {
        //Starting blocks to color, 0 is top left block, 1 is top middle etc.
        int[] startingNum= new int[5];
        startingNum[0] = 1;
        startingNum[1] = 3;
        startingNum[2] = 4;
        startingNum[3] = 5;
        startingNum[4] = 7;
        
        for (int i = 0; i < startingNum.Length; i++){

            Color32 randColor;
            int rand;

            do
            {
                rand = Random.Range(0, colors.Length);
                randColor = colors[rand].color;
            } while (usedColors.Contains(randColor));
            
            usedColors.Add(randColor);
            platformCC[startingNum[i]].GetComponent<Renderer>().material.color = randColor;
            colors[rand].setActive(true);
        }
    }

    // Returns a random color value that is currently active on the platform
    public void GetRandColor()
    {
        for (int i = 0; i < availColors.Length; i++)
        {
           /* if (availColors[i].isActive())
            {
                return availColors[i].color;
            }
            */
        }
        
    }

	public void ChangeColorOfDrop(GameObject drop)
    {        
        int rand = Random.Range(0, usedColors.Count);
        Color32 randColor = usedColors[rand];

        drop.GetComponent<Renderer>().sharedMaterial.color = randColor;


        ChangePlatformColor(drop);
    }

    
    void ChangePlatformColor(GameObject drop)
    {
        int collidedPlatformIndex = 0;
        Color32 dropColor = drop.GetComponent<Renderer>().sharedMaterial.color;
        GameObject collidedPlatformCube = null;

        do {
            if(platformCC[collidedPlatformIndex].GetComponent<Renderer>().material.color == dropColor)
            {
                collidedPlatformCube = platformCC[collidedPlatformIndex];
            }
            else
            {
                collidedPlatformIndex++;
            }
        }while (collidedPlatformCube == null);

        // check if collidedPlatformCube == null
        // remove color from platformCube and from usedColors array, setActive(false) for PlatformColor
        // Depending on the collidedPlatformIndex, move other colors around and spawn new ones


        int hitColor = usedColors.IndexOf(dropColor);

        //temp
        //usedColors.RemoveAt(hitColor);



    }
}
    
  

