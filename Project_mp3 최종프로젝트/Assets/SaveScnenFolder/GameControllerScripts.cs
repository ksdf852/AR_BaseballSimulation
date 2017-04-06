using UnityEngine;
using System.Collections;

public class GameControllerScripts : MonoBehaviour {

    public GameObject ball;
    public UnityEngine.UI.Text text;
	// Use this for initialization
	void Start () {
        ball.SetActive(false);
    }
    
    void OnGUI()
    {
       
    }
	
	// Update is called once per frame
	void Update () {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.LoadLevel("LoadingScene");
            }
        }
	}
}
