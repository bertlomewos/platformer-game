using UnityEngine.SceneManagement;
using UnityEngine;

public class portel : MonoBehaviour
{
 
    public static bool didIwin;
    public GameObject gamewinscreen;

    
    private void Awake()
    {
        didIwin = false;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (didIwin)
        {
            gamewinscreen.SetActive(true);
        }

    }
    public void returnToManu(int index)
    {
        SceneManager.LoadScene(index);
    }
}
