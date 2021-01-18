using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInterfaceOps : MonoBehaviour
{
    private int LastButtonIndex = 10;
    private static int state = 0; // the current button state

    /// Buttons Behaviour

    public void LookAtTheSwitch(){
        Debug.Log("UI ELEMENT PRESSERS - " + "LookAtTheSwitch");
        Camera.main.transform.LookAt(GameObjectsManager.SwitchSparks.transform);

        AdvanceToNextPhase();
    }

    public void GoToTheSwitch(){
        Debug.Log("UI ELEMENT PRESSERS - " + "GoToTheSwitch");
        GoToTeleport(GameObjectsManager.TeleportationSwitch);
        Camera.main.transform.LookAt(GameObjectsManager.SwitchSparks.transform);

        AdvanceToNextPhase();
    }

    public void TurnTheLightsOn(){
        Debug.Log("UI ELEMENT PRESSERS - " + "TurnTheLightsOn");
        RoomEnvironmentManager.LightsOn();
        Camera.main.transform.LookAt(GameObjectsManager.Clues.transform);

        AdvanceToNextPhase();
    }

    public void GoToTheClue(){
        Debug.Log("UI ELEMENT PRESSERS - " + "GoToTheClue");
        GoToTeleport(GameObjectsManager.TeleportationClue);
        Camera.main.transform.LookAt(GameObjectsManager.Clues.transform);

        AdvanceToNextPhase();
    }

    public void GoToTheBooks(){
        Debug.Log("UI ELEMENT PRESSERS - " + "GoToTheBooks");
        GoToTeleport(GameObjectsManager.TeleportationBooks);
        Camera.main.transform.LookAt(GameObjectsManager.BookBrownO.transform);

        AdvanceToNextPhase();
    }
    public void ArrangeTheBooks(){
        Debug.Log("UI ELEMENT PRESSERS - " + "ArrangeTheBooks");
        GameObjectsManager.BookBrownB.SetActive(true);
        GameObjectsManager.BookBrownO.SetActive(true);
        GameObjectsManager.BookBrownX.SetActive(true);
        RoomEnvironmentManager.EnableBoxLidGrab();
        Camera.main.transform.LookAt(GameObjectsManager.BoxMedium.transform.position);

        AdvanceToNextPhase();
    }

    public void GoToTheBox(){
        Debug.Log("UI ELEMENT PRESSERS - " + "GoToTheBox");
        GoToTeleport(GameObjectsManager.TeleportationBox);
        Camera.main.transform.LookAt(GameObjectsManager.BoxMedium.transform);

        AdvanceToNextPhase();
    }

    public void OpenTheBox(){
        Debug.Log("UI ELEMENT PRESSERS - " + "OpenTheBox");
        GameObjectsManager.BoxLid.GetComponent<Rigidbody>().AddForce(3,25,0);
        RoomEnvironmentManager.OnOpenBoxLid();

        AdvanceToNextPhase();
    }

    public void TakeTheKey(){
        Debug.Log("UI ELEMENT PRESSERS - " + "TakeTheKey");
        GameObjectsManager.Key.SetActive(true);
        GameObjectsManager.Key.transform.GetChild(0).gameObject.SetActive(false);
        GameObjectsManager.Key.transform.position += new Vector3(0,0.4f,0.2f);
        Camera.main.transform.LookAt(GameObjectsManager.Key.transform);

        AdvanceToNextPhase();
    }

    public void GoToTheDoor(){
        Debug.Log("UI ELEMENT PRESSERS - " + "GoToTheDoor");
        GoToTeleport(GameObjectsManager.TeleportationDoor);

        AdvanceToNextPhase();
    }
    public void OpenTheDoor(){
        Debug.Log("UI ELEMENT PRESSERS - " + "OpenTheDoor");
        GameObjectsManager.KeyInTheHole.SetActive(true);
        RoomEnvironmentManager.OpenDoor();

        AdvanceToNextPhase();
    }

    /// Helper Methods

    private void AdvanceToNextPhase() {
        if (state >=0 && state <= LastButtonIndex) {
            GameObjectsManager.ButtonsCanvas.transform.GetChild(state).GetComponent<Button>().interactable = false;
        }

        state++;

        if (state >=0 && state <= LastButtonIndex) {
            Debug.Log("Enabling" + state);
            GameObjectsManager.ButtonsCanvas.transform.GetChild(state).GetComponent<Button>().interactable = true;
        }
    }
    
    public static void GoToTeleport(GameObject teleport){
        GameObjectsManager.XRRig.transform.position = new Vector3(
                                            teleport.transform.position.x,
                                            GameObjectsManager.XRRig.transform.position.y,
                                            teleport.transform.position.z);
    }
}
