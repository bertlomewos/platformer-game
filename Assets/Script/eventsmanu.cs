using UnityEngine.SceneManagement;
using UnityEngine;

public class eventsmanu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadlevel(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
