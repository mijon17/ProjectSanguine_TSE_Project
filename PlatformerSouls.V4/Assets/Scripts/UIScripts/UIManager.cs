using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

//this is predominanently for using keys to interact
public class UIManager : MonoBehaviour//also make script for using buttons to click using mouse as well as keys
{
    public List<GameObject> mainMenuElements = new List<GameObject>();//use list to 
    public int index = 1;//used to index button elements to see which button is being selected

    public GameObject background;
    public GameObject pointer;
    public GameObject optionsPanel;
    private Image pointerImage;

    //use positions to place pointer at their locations in canvas space
    private Vector3 newGamePos = new Vector3(-60, -92.30006f, 0);
    private Vector3 loadGamePos = new Vector3(-60, -132.3001f, 0);
    private Vector3 quitPos = new Vector3(-60, -211.7f, 0);
    private Vector3 howToPlayPos = new Vector3(-60, -171.7f, 0);
    private Vector3 backPos = new Vector3(-60, -171.7f, 0);


    void Start()
    {
        pointer.transform.localPosition = newGamePos;
        optionsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void quitGame(){
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

}
