using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

//this is predominanently for using keys to interact
public class UIManager : MonoBehaviour//also make script for using buttons to click using mouse as well as keys
{
    public List<GameObject> mainMenuElements = new List<GameObject>();//use list to 
    public int index = 0;//used to index button elements to see which button is being selected

    public GameObject background;
    public GameObject pointer;
    public GameObject optionsPanel;
    private Image pointerImage;

    //use positions to place pointer at their locations in canvas space
    private Vector3 newGamePos = new Vector3(-60, -100, 0);
    private Vector3 loadGamePos = new Vector3(-60, -140, 0);
    private Vector3 quitPos = new Vector3(-60, -180, 0);
    

    void Start()
    {
        pointer.transform.localPosition = newGamePos;
        optionsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if input enter
        if(Input.GetKeyDown(KeyCode.E)){
            if(index == 0){
                newGame();
            }
            else if(index == 1){
                LoadGame();
            }
            else if(index == 2){
                quitGame();
            }
            //in case optiosn return
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            incrementIndex();
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            decrementIndex();
        }
    }
    public void newGame(){
        Debug.Log("Starting new game");
    }

    public void LoadGame(){
        Debug.Log("loading game");
    }
    public void quitGame(){
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    //might need someoneelse to do
/*    public void openOptions(){
        Debug.Log("opening options");
        foreach(GameObject obj in mainMenuElements){
            obj.SetActive(false);
        }
        optionsPanel.SetActive(true);

    }*/

    public void incrementIndex(){
        if(index == 2){
            index = 0;
            pointer.transform.localPosition = newGamePos;
        }
        else if(index == 1){
            index++;
            pointer.transform.localPosition = quitPos;
        }
        else{
            index++;
            pointer.transform.localPosition = loadGamePos;
        }
    }
    public void decrementIndex(){
        if(index == 0){
            index = 2;
            pointer.transform.localPosition = quitPos;
        }
        else if(index == 1){
            index--;
            pointer.transform.localPosition = newGamePos;
        }
        else{
            index--;
            pointer.transform.localPosition = loadGamePos;
        }
    }
}
