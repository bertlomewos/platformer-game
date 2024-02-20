using UnityEngine.SceneManagement;
using UnityEngine;

public class ballmanager : MonoBehaviour
{
    public static bool isgameover;
    public GameObject gameoverscreen;

    public static Vector2 lastcheckpointpos = new Vector2(-8.91160011f, 4.38689995f);
    private void Awake()
    {
        isgameover = false;
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject player in players)
        {
            player.transform.position = lastcheckpointpos;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isgameover)
        {
            gameoverscreen.SetActive(true);
        }
        
    }
    public void replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
