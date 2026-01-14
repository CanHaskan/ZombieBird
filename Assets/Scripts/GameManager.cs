using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    public static GameManager instance = null;

    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject endMenu;
    private bool playerActive = false;
    private bool gameOver = false;
    private bool gameStarted = false;

    public bool PlayerActive
    {
        get { return playerActive; }
    }
    public bool GameOver
    {
        get { return gameOver; }
    }
    public bool GameStarted
    {
        get { return gameStarted; }
    }
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        

        Assert.IsNotNull(mainMenu);
        Assert.IsNotNull(endMenu);


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerCollided()
    {
        gameOver = true;
        endMenu.SetActive(true);
        
    }
    public void PlayerStartedGame()
    {
        playerActive = true;

    }
    public void EnterGame()
    {
        mainMenu.SetActive(false);
        gameStarted = true;

    }
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
        
}
