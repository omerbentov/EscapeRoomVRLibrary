using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomEnvironmentManager : MonoBehaviour
{
    public static void LightsOn(){
        SoundManager._i.playOnce(SoundManager.EConstants.Switch);
        GameObjectsManager.AllLights.SetActive(true);
        GameObjectsManager.AllBooks.SetActive(true);

        GameObjectsManager.HeadLight.SetActive(false);
    }

    public static void LightsOff(){
        SoundManager._i.playOnce(SoundManager.EConstants.Switch);
        GameObjectsManager.AllLights.SetActive(false);
        GameObjectsManager.HeadLight.SetActive(true);
    }

    public static void EnableBoxLidGrab(){
        GameObjectsManager.BoxLid.transform.GetChild(0).gameObject.SetActive(true);
        GameObjectsManager.Key.SetActive(true);
        SoundManager._i.playOnce(SoundManager.EConstants.Box);
        GameObjectsManager.BoxLid.transform.GetComponent<BoxCollider>().enabled = true;
        GameObjectsManager.BoxLid.transform.GetComponent<Rigidbody>().isKinematic = false;
    }

    public static void OnOpenBoxLid(){
        SoundManager._i.playOnce(SoundManager.EConstants.BoxOpen);
        GameObjectsManager.Key.transform.GetChild(0).gameObject.SetActive(true);
        GameObjectsManager.BoxLid.GetComponent<Rigidbody>().useGravity = true;
    }

    public static void OpenDoor(){
        Debug.Log("OpenDoor");
        SoundManager._i.stopBackgroundMusic();
        SoundManager._i.playOnce(SoundManager.EConstants.Door);
        SoundManager._i.playOnce(SoundManager.EConstants.Forest);
        GameObjectsManager.DoorPivot.GetComponent<Animator>().SetTrigger("OpenDoor");
        GameObjectsManager.ExteriorSunLight.SetActive(true);
    }
}
