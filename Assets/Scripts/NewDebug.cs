using UnityEngine;
using TMPro;

public class NewDebug : MonoBehaviour
{
    public TextMeshProUGUI debugText;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(transform.root.gameObject);
        Application.logMessageReceived += (x, y, z) =>
        {
            debugText.text = x;
        };
    }

}
