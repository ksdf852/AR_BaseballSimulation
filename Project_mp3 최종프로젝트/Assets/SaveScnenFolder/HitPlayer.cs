using UnityEngine;
using System.Collections;

public class HitPlayer : MonoBehaviour {

	public GUIText m_HelpText=null;
    public GameObject ball;
	public GameObject m_HitPlayer=null;
    public Transform ballRotation;
    public float speed = 10.0f;
	bool bEnd=true;
    int count=0;
	// Use this for initialization
	void Start () {
		m_HelpText.text=m_HelpText.text.Replace("\\","\n");
		m_HitPlayer.GetComponent<Animation>()["idle"].wrapMode=WrapMode.Loop;
		m_HitPlayer.GetComponent<Animation>().Play("idle");
	}
	// Update is called once per frame
	void Update () {
        
		if (bEnd) {
			if (count>=1) {
                count = 0;
				bEnd=false;
                if (ball.transform.position.z > 500 || ball.transform.position.z <200)
                {
                    bEnd = false;
                    StartCoroutine("PlayAni", "fail");
                    //ballOrder();
               

                }
                else
                {
                    StartCoroutine("PlayAni", "hit");
    //                Invoke("delayBall", 0.2f);
                    //ballOrder();
                    return;
                }
			}
		}

    }
    void delayBall()
    {
        ball.GetComponent<flyball>().enabled = true;
    }
    public void hitButtonClick()
    {
        count = Input.touchCount;
    }
    /*
    public void ballOrder()
    {
        if (ball.transform.position.z > 300)
        {
            while (ball.transform.position.z > 1600)
            {
                ball.transform.position = Vector3.MoveTowards(ball.transform.position, ballRotation.position, 300.0f * speed * Time.deltaTime);
            }
        }
        else
        {
            ball.gameObject.GetComponent<fireBallScripts>().enabled = false;
            //ball.GetComponent<fireBallScripts>().enabled = true;
            return;
        }
    }
    */
	IEnumerator PlayAni(string name) {
		m_HitPlayer.GetComponent<Animation>().Play(name);
		yield return new WaitForSeconds(m_HitPlayer.GetComponent<Animation>()[name].length);
		m_HitPlayer.GetComponent<Animation>().Play("idle");
		bEnd=true;
	}
}
