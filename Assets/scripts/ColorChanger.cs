using UnityEngine;

public class ColorChanger : MonoBehaviour {


    //array for the colors, public so that u can set them in the inspector from within Unity.
    //public Color[] colors;

    public GameObject ObjDatChangeColor;

    Color[] colors = new Color[6];



// Use this for initialization
    void Start () {
        colors[0] = Color.blue;
        colors[1] = Color.cyan;
        colors[2] = Color.red;
        colors[3] = Color.green;
        colors[4] = Color.yellow;
        colors[5] = Color.white;

        //Start Changing the Colors.        1f= after 1second ingame it starts, 1f = every 1 second after it is going to change again.
        InvokeRepeating("ChangeColorOnDrop", 1f, 1f);
    }

   

	void ChangeColorOnDrop()
    {
        ObjDatChangeColor.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];

    }

	// Update is called once per frame
	void Update()
    {


    }


}
    
  

