using UnityEngine;
using System.Collections;

public class PitcherPlayer : MonoBehaviour {

	public GameObject m_PitcherPlayer=null;
    public GameObject ball = null;
	public bool bEnd=true;
    int count;
    public Transform ballStartLotation;

    // Use this for initialization
    void Start () {
		m_PitcherPlayer.GetComponent<Animation>()["idle"].wrapMode=WrapMode.Loop;
		m_PitcherPlayer.GetComponent<Animation>().Play("idle");
	}
	
	// Update is called once per frame
	void Update () {
    }
    public void startButtonClick()
    {
        //Instantiate(ball,ballStartLotation.position,ballStartLotation.rotation);
        ball.transform.position = ballStartLotation.position;
        
        if (bEnd)
        {
                bEnd = false;
                StartCoroutine("PlayAni", "shoot");

        }
    }

    void ballStart()
    {
        ball.SetActive(true);
        ball.GetComponent<fireBallScripts>().enabled = true;
    }
	IEnumerator PlayAni(string name) {
        Invoke("ballStart" , 1f);
        m_PitcherPlayer.GetComponent<Animation>().Play(name);
        yield return new WaitForSeconds(m_PitcherPlayer.GetComponent<Animation>()[name].length);
		m_PitcherPlayer.GetComponent<Animation>().Play("idle");
		bEnd=true;
        //ball.transform.position = new Vector3(650, 930, 1200);
        // ball.SetActive(true);
    }
}
