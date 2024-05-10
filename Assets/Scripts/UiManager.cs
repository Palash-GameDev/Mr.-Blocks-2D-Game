using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject PausePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            PausePanel.SetActive(true);
        }
    }

    public void OnResume()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
    }
}
