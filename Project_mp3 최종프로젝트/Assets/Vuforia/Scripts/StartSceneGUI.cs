using UnityEngine;
using System.Collections;

public class StartSceneGUI : MonoBehaviour {

    public GUISkin mySkin;

    void OnGUI()
    {
        GUI.skin = mySkin;
        if(GUI.Button(new Rect(0,0,100,50),"play Game"))
        {
            print("you clicked me!");
        }
    }
}
