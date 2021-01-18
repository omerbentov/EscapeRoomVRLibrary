using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCollisionManager : MonoBehaviour
{
    private bool flipped;
    private float resetTimer;
    private const float resetDuration = 1f;
    private int state = -1;

    // Start is called before the first frame update
    void Start()
    {
        resetTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (flipped == true) {
            if (resetTimer >= resetDuration) {
                resetTimer = 0;
                flipped = false;
            } else {
                resetTimer += Time.deltaTime;
            }            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (flipped == false) {
            flipped = true;

            if (state == 1) {
                // off
                GameObjectsManager.LightSwitchOff.SetActive(true);
                GameObjectsManager.LightSwitchOn.SetActive(false);
                RoomEnvironmentManager.LightsOff();
            } else {
                // on
                GameObjectsManager.LightSwitchOn.SetActive(true);
                RiddleManager.Instance().OnFirstCompleted();
                GameObjectsManager.LightSwitchOff.SetActive(false);
                RoomEnvironmentManager.LightsOn();
            }
        
            state *= -1;
        }
    }
}
