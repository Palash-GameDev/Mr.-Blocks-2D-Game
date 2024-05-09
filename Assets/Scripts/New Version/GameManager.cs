using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject _GamePlay ; 
    public GameObject _mainMenu ;

    public void OnPlay()
    {
        _GamePlay.SetActive(true);
        _mainMenu.SetActive(false);
    }
    
}
