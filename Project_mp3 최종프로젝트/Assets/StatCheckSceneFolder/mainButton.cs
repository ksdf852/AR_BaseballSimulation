using UnityEngine;
using System.Collections;

public class mainButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void mainButtonClicked()
    {
        Application.LoadLevel("LoadingScene");
    }
}
