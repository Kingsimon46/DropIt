using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ColorChanger : MonoBehaviour {

    public GameObject dropCube;
    
    public GameObject[] platformCC = new GameObject[9];
    public Color32[] availColors = new Color32[9];
    public PlatformColor[] colors = new PlatformColor[9];

    public List<Color32> usedColors = new List<Color32>();

    public int dropsForFirstLevel;

    void Start () {
        
        for (int i = 0; i < availColors.Length; i++)
        {
            //Debug.Log(i + " Color");
            colors[i] = new PlatformColor(availColors[i]);
        }
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
    public Color32 GetRandColor()
    {
        int rand = Random.Range(0, usedColors.Count);
        Color32 randColor = usedColors[rand];

        return randColor;
    }

	public void ChangeColorOfDrop(GameObject drop)
    {        
        drop.GetComponent<Renderer>().sharedMaterial.color = GetRandColor();
    }

    public void ChangePlatformColor(int sucessfulDrops)
    {
        usedColors.Clear();

        if(sucessfulDrops < dropsForFirstLevel)
        {
            int[] startingNum = new int[5];
            startingNum[0] = 1;
            startingNum[1] = 3;
            startingNum[2] = 4;
            startingNum[3] = 5;
            startingNum[4] = 7;

            for (int i = 0; i < startingNum.Length; i++)
            {

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
        else
        {
            int[] startingNum = new int[9];
            startingNum[0] = 0;
            startingNum[1] = 1;
            startingNum[2] = 2;
            startingNum[3] = 3;
            startingNum[4] = 4;
            startingNum[5] = 5;
            startingNum[6] = 6;
            startingNum[7] = 7;
            startingNum[8] = 8;

            for (int i = 0; i < startingNum.Length; i++)
            {

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
    }
}