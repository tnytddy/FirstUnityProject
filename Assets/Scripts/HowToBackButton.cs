using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToBackButton : MonoBehaviour
{
    public void HowBackButton() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
