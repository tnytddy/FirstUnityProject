using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsButton : MonoBehaviour
{
    public void CredsButton() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
