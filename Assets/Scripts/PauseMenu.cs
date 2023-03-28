using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseMenu : MonoBehaviour
{
    
    private bool gameIsPaused = false;

    public GameObject pauseMenuUI;
    public Slider speedSlider;
    public TMP_Text speedValue;


    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        speedValue.SetText(speedSlider.value.ToString("f2"));
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = ChangeSpeed();
        gameIsPaused = false;
    }

    public void ResumeBtn()
    {
        Resume();
    }

    public void MenuBtn()
    {
        SceneManager.LoadSceneAsync("Menu");
    }

    public void ExitBtn()
    {
        SceneManager.LoadSceneAsync("Credits");
    }
    
    public float ChangeSpeed()
    {
        Time.timeScale = speedSlider.value;

        return Time.timeScale;
    }
}
