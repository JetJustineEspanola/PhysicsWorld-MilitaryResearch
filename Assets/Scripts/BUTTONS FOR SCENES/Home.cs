using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Starting Screen");
    }
    // Update is called once per frame
    void Update()
    {

    }
}