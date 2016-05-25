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
            int rand = Random.Range(0, colors.Length);

            platformCC[startingNum[i]].GetComponent<Renderer>().material.color = colors[rand].color;
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
   

	public void ChangeColorOnDrop()
    {
        //ObjDatChangeColor.GetComponent<Renderer>().sharedMaterial.color = colors[Random.Range(0, colors.Length)];
       
      

    }


    void ChangeCcColors()
    {
      

    }
}
    
  

