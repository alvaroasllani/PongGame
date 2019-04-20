using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour
{
public Button Play;
public Button Quit;    

    public void Play_Game(){
        SceneManager.LoadScene(1);
    }
    public void Quit_Game(){
        Application.Quit();
    }
}
