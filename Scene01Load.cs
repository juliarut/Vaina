using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene01Load : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("SceneBuilder/1,2,3,4/Scene 02_text", LoadSceneMode.Single);
    }

   
}
