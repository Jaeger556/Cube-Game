using UnityEngine;
using TMPro;

public class FollowPlayer : MonoBehaviour
{
    
    public Transform player;
    public Vector3 offset;
    public static string playernamestr;
    public TextMeshProUGUI playername;

    void Start()
    {
        playername.text = playernamestr;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
