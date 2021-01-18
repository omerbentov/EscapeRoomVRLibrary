using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToogleUiByMode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Application.isEditor)
        {
            GameObjectsManager.ButtonsCanvas.SetActive(true);
        }
        else
        {
            GameObjectsManager.ButtonsCanvas.SetActive(false);
        }
    }
}