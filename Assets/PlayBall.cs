using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBall : MonoBehaviour
{

    public GameObject ballPrefab;
    public GameObject hill;

    public GameObject ballDropper;
    private Vector3 ballDropLocation;

    [SerializeField] float dropCoolTimeLimit;
    private float coolDownTimeCurrent;




    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
            {

                if (Time.time >= coolDownTimeCurrent)
                {
                    ballDropLocation = ballDropper.transform.position;
                    Instantiate(ballPrefab, ballDropLocation, Quaternion.identity);
                    coolDownTimeCurrent = Time.time + dropCoolTimeLimit;
                }
                else
                {
                    Debug.Log("Im still a cooling");
                }
            
            }

        if(Input.GetKey("left"))
        {
            hill.transform.Rotate(new Vector3(1, 0, 0));
        }
        
        if(Input.GetKey("right"))
        {
            hill.transform.Rotate(new Vector3(-1, 0, 0));
        }

        if (Input.GetKey("up"))
        {
            hill.transform.Rotate(new Vector3(0, 0, 1));
        }

        if (Input.GetKey("down"))
        {
            hill.transform.Rotate(new Vector3(0, 0, -1));
        }
    }
}
