using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject _GamePlay ; 
    public GameObject _mainMenu ;

    public void OnPlay()
    {
        _GamePlay.SetActive(true);
        _mainMenu.SetActive(false);
    }
    
    public void OnPlayAgain()
    {
        SceneManager.LoadScene("MainGame");
        
    }
}
