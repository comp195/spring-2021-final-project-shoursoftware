using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevel3 : MonoBehaviour
{
    public void ChangeLevel()
    {
        SceneManager.LoadScene("Level3");
    }
}
