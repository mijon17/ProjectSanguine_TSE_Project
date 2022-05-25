using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonMouseHandler : MonoBehaviour
{
    //attaches to every button
    //using public position, dot knows where to go
    public UIManager manager;
    public Vector3 dotPosition;
    public GameObject pointer;
    public int buttonIndex;
    void Start()
    {
        if(manager){
            
        }
    }

    //changes UIManager index and pointer position to highlighted button
    public void onHover()
    {
        Debug.Log(this.name);
        manager.index = buttonIndex;
        pointer.transform.localPosition = dotPosition;
    }
    public void newGame()
    {
        SceneManager.LoadScene(1);
    }
    public void loadGame()
    {
        SceneManager.LoadScene(3);
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void quit()
    {
        manager.quitGame();
    }
}
