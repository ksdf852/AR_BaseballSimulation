using UnityEngine;
using System.Collections;

public class TitleMenuScripts : MonoBehaviour {
    
    public void saveSceneLoad()
    {
        Application.LoadLevel("save scene");
    }

    public void statSceneLoad()
    {
        Application.LoadLevel("StatCheckScene");
    }
}
