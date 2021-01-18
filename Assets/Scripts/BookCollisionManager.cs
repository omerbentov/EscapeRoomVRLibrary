using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCollisionManager : MonoBehaviour
{
    private static int count;
    private bool locked = false;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision){
        Debug.Log(collision.collider.tag);
        if(collision.collider.CompareTag(this.gameObject.tag) && !locked){
            
            Debug.Log(collision.collider.gameObject.name);
            Debug.Log(gameObject.tag);

            collision.collider.gameObject.SetActive(false);
            transform.GetChild(0).gameObject.SetActive(true);
            count++;

            if(count == 3){
                RoomEnvironmentManager.EnableBoxLidGrab();
                RiddleManager.Instance().OnSecondCompleted();
                GameObjectsManager.Key.SetActive(true);
                Debug.Log("3 books are in place");
            }
        }
        else{
           if(collision.collider.tag.Contains("Book")){ 
               locked = true;
           }
        }
    }

    void OnCollisionExit(Collision collision){
        if(collision.collider.tag.Contains("Book")){ 
               locked = false;
           }
    }

    
}
