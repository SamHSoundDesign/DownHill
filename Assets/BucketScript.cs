using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketScript : MonoBehaviour
{

    private bool bucketComplete = false;
    [SerializeField] Light winLight;

    private void Start()
    {
        //winLight = GetComponentInParent<Light>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            if(!bucketComplete)
            {
                bucketComplete = true;
                winLight.enabled = true;
                Debug.Log("You've filled my bucket");
            }
            else
            {
                Debug.Log("Bucket already filled you douche");
            }
        }
    }
}
