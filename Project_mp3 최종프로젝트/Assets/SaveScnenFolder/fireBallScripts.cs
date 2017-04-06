using UnityEngine;
using System.Collections;

public class fireBallScripts : MonoBehaviour {

    private GameObject ball;
    private GameObject strikezone;
    public Transform ballRotation;
    private int count=0;
    public UnityEngine.UI.Text text;
    private float speed = 5.0f;

	// Use this for initialization
	void Start () {
        ball = GameObject.Find("ball");
        strikezone = GameObject.Find("Strikezone");
        ball.SetActive(false);
	}
    /* 
    void OnEnable()
    {
        //ball.GetComponent<fireBallScripts>().enabled = true;
        //ball.GetComponent<>().enabled = true;
        
        text.text = "enabled";
        while (ball.transform.position.z > 1600)
        {
            ball.transform.position = Vector3.MoveTowards(ball.transform.position, ballRotation.position, 300.0f * speed * Time.deltaTime);
        }
        
    }
    */

    // Update is called once per frame
    void Update()
    {//Vector3.forward
        ball.transform.position = Vector3.MoveTowards(ball.transform.position, new Vector3(strikezone.transform.position.x, strikezone.transform.position.y, strikezone.transform.position.z), 100.0f * speed * Time.deltaTime);

        if (ball.transform.position.z < 29)
        {
            ball.SetActive(false);
        }
    }
    
}
