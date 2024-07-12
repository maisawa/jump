using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// ‚ 
public class Title : MonoBehaviour
{
    [SerializeField] string sceneName = "SampleScene";

    public void LoadScene()
    {
        Debug.Log("Load Scene");
        SceneManager.LoadScene(sceneName);
    }

    void Start()
    {

    }

    void Update()
    {

    }
}