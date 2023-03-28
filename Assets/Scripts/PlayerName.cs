using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerName : MonoBehaviour
{

    public TMP_InputField enterPlayerName;
    public Canvas canvas;
    public Text playerName;

    void Start()
    {
        enterPlayerName.onEndEdit.AddListener(setName);
    }

    void setName(string name)
    {
        enterPlayerName.text = name;
        DontDestroyOnLoad(enterPlayerName);
    }
    
    
}
