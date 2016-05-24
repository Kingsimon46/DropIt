using UnityEngine;

public class ColorChanger : MonoBehaviour {


    //array for the colors, public so that u can set them in the inspector from within Unity.
    //public Color[] colors;

    // I don't get that var name :P
    public GameObject objDatChangeColor;
    
    public GameObject[] platformCC = new GameObject[9];
    public PlatformColor[] colors = new PlatformColor[9];
    public Color32[] availColors = new Color32[9];
    
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

    public void setUp()
    {

        //TODO: Randomize color choice
        platformCC[1].GetComponent<Renderer>().material.color = colors[0].color;
        colors[0].setActive(true);
        platformCC[3].GetComponent<Renderer>().material.color = colors[1].color;
        colors[1].setActive(true);
        platformCC[4].GetComponent<Renderer>().material.color = colors[2].color;
        colors[2].setActive(true);
        platformCC[5].GetComponent<Renderer>().material.color = colors[3].color;
        colors[3].setActive(true);
        platformCC[7].GetComponent<Renderer>().material.color = colors[4].color;
        colors[4].setActive(true);
        
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
   

	public void ChangeColorOnDrop()
    {
        //ObjDatChangeColor.GetComponent<Renderer>().sharedMaterial.color = colors[Random.Range(0, colors.Length)];
       
      

    }


    void ChangeCcColors()
    {
      

    }
}
    
  

