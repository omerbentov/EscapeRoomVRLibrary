using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectsManager : MonoBehaviour
{
    public static GameObject HeadLight;
    public static GameObject LightSwitchOn;
    public static GameObject LightSwitchOff;
    public static GameObject AllLights;
    public static GameObject AllBooks;
    public static GameObject Key;
    public static GameObject BoxMedium;
    public static GameObject BoxLid;
    public static GameObject SwitchSparks;
    public static GameObject DoorPivot;
    public static GameObject Clues;
    public static GameObject BookBrownB;
    public static GameObject BookBrownO;
    public static GameObject BookBrownX;
    public static GameObject XRRig;
    public static GameObject TeleportationSwitch;
    public static GameObject TeleportationClue;
    public static GameObject TeleportationBooks;   
    public static GameObject TeleportationBox;
    public static GameObject TeleportationDoor;
    public static GameObject ButtonsCanvas;
    public static GameObject KeyInTheHole;
    public static GameObject ExteriorSunLight;

    void Awake(){
        Physics.IgnoreLayerCollision(11,12);

        HeadLight = GameObject.Find("HeadLight");

        LightSwitchOn = GameObject.Find("SwitchOn");
        LightSwitchOn.SetActive(false);

        LightSwitchOff = GameObject.Find("SwitchOff");

        AllLights = GameObject.Find("Lights");
        AllLights.SetActive(false);

        BoxMedium = GameObject.Find("BoxMedium");
        BoxLid = GameObject.Find("BoxLid");

        AllBooks = GameObject.Find("BooksContainer");
        AllBooks.SetActive(false);

        Key = GameObject.Find("KeyInBox");
        Key.SetActive(false);

        SwitchSparks = GameObject.Find("SwitchSparks");

        DoorPivot = GameObject.Find("DoorPivot");

        Clues = GameObject.Find("Clues");
        BookBrownB = GameObject.Find("BookBrownB (1)");
        BookBrownB.gameObject.SetActive(false);
        BookBrownO = GameObject.Find("BookBrownO (1)");
        BookBrownO.gameObject.SetActive(false);
        BookBrownX = GameObject.Find("BookBrownX (1)");
        BookBrownX.gameObject.SetActive(false);

        XRRig = GameObject.Find("XR Rig");
        TeleportationSwitch = GameObject.Find("TeleportationSwitch");
        TeleportationClue = GameObject.Find("TeleportationClue");
        TeleportationBooks = GameObject.Find("TeleportationBooks");
        TeleportationBox = GameObject.Find("TeleportationBox");
        TeleportationDoor = GameObject.Find("TeleportationDoor");

        ButtonsCanvas = GameObject.Find("ButtonsCanvas");

        KeyInTheHole = GameObject.Find("KeyInTheHole");
        KeyInTheHole.SetActive(false);

        ExteriorSunLight = GameObject.Find("ExteriorSunLight");
        ExteriorSunLight.SetActive(false);
    }
}
