using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerLoadLevel(2D) : MonoBehaviour
{

    public GameObject enterText;
    public string levelToLoad;

    void Start()
    {
        enterText.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            enterText.SetActive(true);
            if (Input.GetButtonDown("Use"))
            {
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            enterText.SetActive(false);
        }
    }
}
