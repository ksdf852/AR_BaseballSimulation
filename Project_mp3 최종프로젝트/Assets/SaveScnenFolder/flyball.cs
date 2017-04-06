using UnityEngine;
using System.Collections;

public class flyball : MonoBehaviour {

    public GameObject ball;
    public hitButton hit = new hitButton();
    public Transform ballRotation;
    public UnityEngine.UI.Button startbutton;
    private float speed = 4.0f;
    private string result;
    float x, y, z;
    float time = 0.0f;
    // Use this for initialization
    void Start () {
        x = ball.transform.position.x;
        y = 0.1f;
        z = 0.1f;

	}

    // Update is called once per frame
    void Update() {

        if (hitButton.hitting == 1)
        {
            if (time > 0.3)
            {
                ball.GetComponent<fireBallScripts>().enabled = false;
                y = y + 0.38f;
                z = z + 0.2f;
                //if (result == "home run"){
                ball.transform.Translate(2.5f, 0.1f - y, 10 - z);
                //  x + (300.0f * speed * Time.deltaTime);
            }
            else
            {
                time += Time.deltaTime;
            }

        }
        else if (hitButton.hitting == 2)
        {
            if (time > 0.3)
            {
                ball.GetComponent<fireBallScripts>().enabled = false;
                y = y + 0.38f;
                z = z + 0.2f;
                //if (result == "home run"){
                ball.transform.Translate(0.1f, 0.1f - y, 8 - z);
                //  x + (300.0f * speed * Time.deltaTime);
            }
            else
            {
                time += Time.deltaTime;
            }

        }
        else if (hitButton.hitting == 3)
        {
            if (time > 0.3)
            {
                ball.GetComponent<fireBallScripts>().enabled = false;
                y = y + 0.38f;
                z = z + 0.2f;
                //if (result == "home run"){
                ball.transform.Translate(-4, -y, 3);
                //  x + (300.0f * speed * Time.deltaTime);
            }
            else
            {
                time += Time.deltaTime;
            }

        }

        //       ball.transform.position = Vector3.MoveTowards(ball.transform.position, ballRotation.position, 300.0f * speed * Time.deltaTime);
        if (ball.transform.position.z > ballRotation.position.z - 20)
        {
            y = 0;
            z = 0;
            ball.SetActive(false);
            ball.gameObject.GetComponent<flyball>().enabled = false;

        }
        
        //}
        //else if(result == "foul")
        //{
        //  ball.transform.position = Vector3.MoveTowards(ball.transform.position, ballRotation.position, 20.0f * speed * Time.deltaTime);
        //}
    }
    public void startButton()
    {
        time = 0.0f;
    }
    public void cons(string res)
    {
        result = res;
        Update();
    }
}
