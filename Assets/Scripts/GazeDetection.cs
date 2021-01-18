using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
        RaycastHit hit;
        int layerMask = 1 << 13;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit,  Mathf.Infinity, layerMask)){
            //Debug.Log("Detected");
            if (RiddleManager.Instance().IsInitialState()) {
                GameObjectsManager.SwitchSparks.GetComponent<ParticleSystem>().Play();
            }
        }else {
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward)*1000, Color.white);
        }
    }
}
