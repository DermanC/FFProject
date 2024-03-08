using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public SceneManager sceneChange;
    public string scene1 = "SampleScene";
    public string scene2 = "BattleScene";

    public GameObject playerObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        if (sceneName == scene2)
        {
            playerObj.SetActive(false);
        }
        if (sceneName == scene1)
        {
            playerObj.SetActive(true);
        }
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene(scene1);
    }

    public void LoadBattleScene()
    {
        SceneManager.LoadScene(scene2);
    }
}
