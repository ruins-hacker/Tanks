using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public Text text;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void stopGameWithPlayer1()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
        text.text = "Winner is Handsome-Kong";
    }

    public void stopGameWithPlayer2()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
        text.text = "Winner is LuGou";
    }

    public void loadScene()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
