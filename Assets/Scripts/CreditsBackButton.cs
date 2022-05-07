using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsBackButton : MonoBehaviour
{
    public void CreditsBack() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
