using UnityEngine;
using System.Collections;

public class hitButton : MonoBehaviour {



    public GameObject ball;
    public GameObject strike;
    public UnityEngine.UI.Text text;
    public UnityEngine.UI.Text vectorText;
    public UnityEngine.UI.Button hitbutton;
    public GameObject m_HitPlayer = null;
    private float zVector;
    float a = 0.0f;
    public static int hitting=0;
    public static int homeCount=0;
    public static int hitCount = 0;
    public static int foulCount = 0;
    public static int missCount = 0;
    int click = 0;
    bool bEnd = true;
    // Use this for initialization
    void Start () {
        m_HitPlayer.GetComponent<Animation>()["idle"].wrapMode = WrapMode.Loop;
        m_HitPlayer.GetComponent<Animation>().Play("idle");
        ball.gameObject.GetComponent<flyball>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (bEnd)
        {
         /*   if (click==1)
            {
                bEnd = false;
                StartCoroutine("PlayAni", "hit");
                click = 0;
                return;
            }
            */
            /*
            if (click==1)
            {
                bEnd = false;
                StartCoroutine("PlayAni", "fail");
            }*/
        }
    }
    /*
    void OncollisionEnter(Collision other)
    {
        zVector = ball.transform.position.z;
        if (other.transform.tag == "ball")
        {
            if (bEnd)
            {
                if (30 < zVector && zVector < 150)
                {
                    text.text = "home run";
                    bEnd = false;
                    StartCoroutine("PlayAni", "hit");
                    ball.gameObject.GetComponent<fireBallScripts>().enabled = false;
                    ball.gameObject.GetComponent<flyball>().enabled = true;
                    ball.gameObject.GetComponent<flyball>().cons("home run");
                }
                else if (150 < zVector && zVector < 300)
                {
                    text.text = "foul";
                    bEnd = false;
                    StartCoroutine("PlayAni", "hit");
                    ball.gameObject.GetComponent<fireBallScripts>().enabled = false;
                    ball.gameObject.GetComponent<flyball>().enabled = true;
                    ball.gameObject.GetComponent<flyball>().cons("foul");
                }
                else
                {
                    text.text = "miss";
                    bEnd = false;
                    StartCoroutine("PlayAni", "fail");
                }
            }
        }
    }
    */
    public void hitButtonClicked()
    {
//        vectorText.gameObject.SetActive(false);
        zVector = ball.transform.position.z;
        click = 1;

 
        if (bEnd)
        {
            if (200 < zVector && zVector < 300)
            {
                text.text = "home run";
                bEnd = false;
                hitting = 1;
                homeCount++;
                StartCoroutine("PlayAni", "hit");
                Invoke("delayBall", 0.2f);
            }else if (300 < zVector && zVector < 400)
            {
                hitting = 2;
                hitCount++;
                text.text = "hit";
                bEnd = false;

                StartCoroutine("PlayAni", "hit");
                Invoke("delayBall", 0.2f);
            }
            else if (400< zVector && zVector < 500)
            {
                foulCount++;
                text.text = "foul";
                bEnd = false;
                hitting = 3;
                StartCoroutine("PlayAni", "hit");


               Invoke("delayBall", 0.2f);
            }
            else
            {
                missCount++;
                text.text = "miss";
                bEnd = false;
                StartCoroutine("PlayAni", "fail");
            }
        }

    
 
        //        System.Threading.Thread.Sleep(1000);
        //        text.text = "";
        //        Application.LoadLevel("save scene");

    }
    void delayBall()
    {
//        ball.GetComponent<fireBallScripts>().enabled = false;
        ball.GetComponent<flyball>().enabled = true;
    }

    IEnumerator PlayAni(string name)
    {
        m_HitPlayer.GetComponent<Animation>().Play(name);
        yield return new WaitForSeconds(m_HitPlayer.GetComponent<Animation>()[name].length);
        m_HitPlayer.GetComponent<Animation>().Play("idle");
        bEnd = true;
    }
}
