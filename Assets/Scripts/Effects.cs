using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    public void KeyMagicStart(){
        RoomEnvironmentManager.OnOpenBoxLid();
    }

    public void KeyMagicEnd(){
        GameObjectsManager.Key.transform.GetChild(0).gameObject.SetActive(false);
    }
}
