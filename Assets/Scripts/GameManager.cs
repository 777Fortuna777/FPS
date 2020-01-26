using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // // Start is called before the first frame update
    // void Start()
    // {
    //     LockCursor();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if(Input.GetKeyDown(KeyCode.Escape))
    //     {
    //         UnlockCursor();
    //     }

    //     if(Input.GetMouseButton(0))
    //     {
    //         LockCursor();
    //     }
    // }

    // private void LockCursor()
    // {
    //     Cursor.lockState = CursorLockMode.Locked;
    //     Cursor.visible = false;
    // }

    //     private void UnlockCursor()
    // {
    //     Cursor.lockState = CursorLockMode.None;
    //     Cursor.visible = true;
    // }
    
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject Player;

    void Start()
        {
            LockCursor();
        }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        LockCursor();
        Player.GetComponent<PlayerController>().enabled = true;
        Debug.Log("Resume void");
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        UnlockCursor();
        Player.GetComponent<PlayerController>().enabled = false;
        Debug.Log("Pause void");
    }

    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Debug.Log("LockCursor");
    }

    private void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Debug.Log("UnlockCursor");
    }
}
