using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    [SerializeField]
    GameEvent _event;
    
    public void changescene(int index)
    {
        if (_event != null)
        {
            SceneManager.LoadScene(index);
        }
    }
}
