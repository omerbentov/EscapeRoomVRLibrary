using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollisionManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision){
        Debug.Log(collision.collider.tag);
        if(collision.collider.CompareTag("Key")){
            collision.collider.gameObject.SetActive(false);
            transform.GetChild(0).gameObject.SetActive(true);
            
            RoomEnvironmentManager.OpenDoor();
        }
    }

    void OnCollisionStay(Collision collision){
        Debug.Log(collision.collider.tag);
    }
}
