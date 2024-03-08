using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] SceneChange sc;
    [SerializeField] GameObject playerObj;

    private void Start()
    {
        // Check if the current scene is not the BattleScene
        if (SceneManager.GetActiveScene().name != "BattleScene")
        {
            // Check for existing instances and destroy duplicates
            DontDestroySample[] existingInstances = Object.FindObjectsOfType<DontDestroySample>();
            for (int i = 0; i < existingInstances.Length; i++)
            {
                if (existingInstances[i] != this && existingInstances[i].name == gameObject.name)
                {
                    Destroy(gameObject);
                    
                }
            }

            // If it's not a duplicate, don't destroy on load
            DontDestroyOnLoad(gameObject);
        }
    }
}
