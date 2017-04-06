using UnityEngine;
using System.Collections;

public class StartButtonScripts : MonoBehaviour {

    //public Ga?meObject ball;
    public UnityEngine.UI.Button startbutton;
    public UnityEngine.UI.Button hitbutton;
    public UnityEngine.UI.Text text;

    
	// Use this for initialization
	void Start () {
        startbutton.gameObject.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {

	}
    
    public void startButtonClick()
    {
        startbutton.gameObject.SetActive(true);
        hitbutton.gameObject.SetActive(true);
        text.gameObject.SetActive(true);

    }
}
