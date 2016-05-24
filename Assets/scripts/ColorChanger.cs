using UnityEngine;

public class ColorChanger : MonoBehaviour {


    //array for the colors, public so that u can set them in the inspector from within Unity.
    //public Color[] colors;

    public GameObject ObjDatChangeColor;

    public GameObject CC1;
    public GameObject CC2;
    public GameObject CC3;
    public GameObject CC4;
    public GameObject CC5;
    public GameObject CC6;
    public GameObject CC7;
    public GameObject CC8;
    public GameObject CC9;


    Color[] colors = new Color[9];



// Use this for initialization
    void Start () {

        colors[0] = new Color32(0, 0, 255, 255); //blue
        colors[1] = new Color32(0, 255, 255, 255); //cyan
        colors[2] = new Color32(255, 0, 0, 255); //red
        colors[3] = new Color32(0, 255, 0, 255); //green
        colors[4] = new Color32(255, 255, 51, 255); //yellow
        colors[5] = new Color32(255, 255, 255, 255); //white
        colors[6] = new Color32(127, 0, 255, 255); //purple
        colors[7] = new Color32(127, 0, 255, 255); //purple
        colors[8] = new Color32(127, 0, 255, 255); //purple
        //Start Changing the Colors.        1f= after 1second ingame it starts, 1f = every 1 second after it is going to change again.
        InvokeRepeating("ChangeCcColors", 1f, 1f);

    }

   

	public void ChangeColorOnDrop()
    {
        ObjDatChangeColor.GetComponent<Renderer>().sharedMaterial.color = colors[Random.Range(0, colors.Length)];
       
      

    }


    void ChangeCcColors()
    {
      


            CC1.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
            CC2.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
            CC3.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
            CC4.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
            CC5.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
            CC6.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
            CC7.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
            CC8.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
            CC9.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
        }
       
    


        void Update()
    {


    }

}
    
  

