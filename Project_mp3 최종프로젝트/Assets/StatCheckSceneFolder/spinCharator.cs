using UnityEngine;
using System.Collections;

public class spinCharator : MonoBehaviour {
    private GameObject player;
    public UnityEngine.UI.Text homerun;
    public UnityEngine.UI.Text hit;
    public UnityEngine.UI.Text foul;
    public UnityEngine.UI.Text miss;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("baseplayer");
    }
	// Update is called once per frame
	void Update () {
            player.transform.Rotate(0, 1, 0);
        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.LoadLevel("LoadingScene");
            }
        }
        homerun.text = "" +hitButton.homeCount;
        hit.text = "" + hitButton.hitCount;
        foul.text = "" + hitButton.foulCount;
        miss.text = "" + hitButton.missCount;
    }
}
