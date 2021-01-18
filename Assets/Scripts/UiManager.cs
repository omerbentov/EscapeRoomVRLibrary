using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
using System.Collections.Generic;

public class UiManager : MonoBehaviour
{
    public GameObject MenuPanel;

    public GameObject MenuBtn;

    private List<InputDevice> inputDevices;

    public void ActivateMainMenu(){
        MenuPanel.SetActive(true);
        MenuBtn.SetActive(false);
    }

    public void Resume(){
        MenuPanel.SetActive(false);
        MenuBtn.SetActive(true);
    }

    public void Quit(){
        if (Application.isEditor)
        {
            Application.Quit();
        }
        else{
           Application.Quit(); 
        }
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }
}
