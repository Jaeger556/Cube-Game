using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Menu : MonoBehaviour
{
    public TMP_InputField playerName;

    //Start button
    public void StartGame()
    {
        Debug.Log("Player name is " + playerName.text);
        FollowPlayer.playernamestr = playerName.text;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Quit button
    public void Quit()
    {
        Application.Quit();
    }
}
