using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroySample : MonoBehaviour
{
    [SerializeField] SceneChange sc;
    [SerializeField] GameObject playerObj;
    private void Start()
    {
        for (int i = 0; i < Object.FindObjectsOfType<DontDestroySample>().Length; i++)
        {
            if (Object.FindObjectsOfType<DontDestroySample>()[i] != this)
            {
                if (Object.FindObjectsOfType<DontDestroySample>()[i].name == gameObject.name)
                {
                    Destroy(gameObject);
                }
            }

        }

        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if(SceneManager.GetActiveScene().Equals(sc.scene2))
        {
            playerObj.SetActive(false);
            //Destroy(gameObject);
        }
        if (SceneManager.GetActiveScene().Equals(sc.scene1))
        {
           playerObj.SetActive(true);
        }
        /*if (SceneManager.GetActiveScene().Equals(sc.scene2))
        {
            Destroy(gameObject);
        }*/
        //Debug.Log(SceneManager.GetActiveScene());
    }
}
