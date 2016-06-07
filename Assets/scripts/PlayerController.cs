using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{


    private float movingDistance = 1f;

    //Maximale Auslenkung beim Bewegen in die vier Richtungen.
    private float maxUpDistance = 1.1f;
    private float maxDownDistance = -1.1f;
    private float maxLeftDistance = -1.1f;
    private float maxRightDistance = 1.1f;
    private float distance;

    public bool gameIsActive;

    private Touch initialTouch = new Touch();
    private bool hasSwiped = false;
    // Use this for initialization
    void Start()
    {

        gameIsActive = true;

    }
    void FixedUpdate()
    {
        if (gameIsActive == true)
        {


            foreach (Touch t in Input.touches)
            {
                if (t.phase == TouchPhase.Began)
                {
                    initialTouch = t;
                }
                else if (t.phase == TouchPhase.Moved && !hasSwiped)
                {
                    float deltaX = initialTouch.position.x - t.position.x;
                    float deltaY = initialTouch.position.y - t.position.y;
                    bool swipedSideways = Mathf.Abs(deltaX) > Mathf.Abs(deltaY);
                    distance = Mathf.Sqrt((deltaX * deltaX) + (deltaY * deltaY));

                    if (distance > 100f)
                    { // to continue.

                        if (swipedSideways && deltaX > 0) //swiped left
                        {
                            if (maxLeftDistance + movingDistance <= transform.position.x)
                            {

                                transform.position = new Vector3(transform.position.x - movingDistance, transform.position.y, transform.position.z);
                                hasSwiped = true;
                            }
                        }
                        else if (swipedSideways && deltaX <= 0) //swiped right
                        {
                            if (maxRightDistance - movingDistance >= transform.position.x)
                            {
                                transform.position = new Vector3(transform.position.x + movingDistance, transform.position.y, transform.position.z);
                                hasSwiped = true;
                            }
                        }
                        else if (!swipedSideways && deltaY > 0) //swiped down
                        {
                            if (maxDownDistance + movingDistance <= transform.position.z)
                            {
                                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - movingDistance);
                                hasSwiped = true;
                            }
                        }
                        else if (!swipedSideways && deltaY <= 0) //swiped up
                        {
                            if (maxUpDistance - movingDistance >= transform.position.z)
                            {
                                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + movingDistance);
                                hasSwiped = true;
                            }
                        }
                    }
                }
                else if (t.phase == TouchPhase.Ended)
                {
                    initialTouch = new Touch();
                    hasSwiped = false;
                }


            }
        }
    }        // Update is called once per frame
    void Update()
    {

        if (gameIsActive == true)
        {


            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (maxUpDistance - movingDistance >= transform.position.z)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + movingDistance);
                }
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (maxDownDistance + movingDistance <= transform.position.z)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - movingDistance);
                }
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (maxLeftDistance + movingDistance <= transform.position.x)
                {
                    transform.position = new Vector3(transform.position.x - movingDistance, transform.position.y, transform.position.z);
                }
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (maxRightDistance - movingDistance >= transform.position.x)
                {
                    transform.position = new Vector3(transform.position.x + movingDistance, transform.position.y, transform.position.z);
                }
            }
        }
    }
}