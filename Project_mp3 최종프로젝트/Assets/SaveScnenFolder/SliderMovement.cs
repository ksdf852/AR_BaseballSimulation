using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderMovement : MonoBehaviour {
    private int count;
    public Slider GaugeBar;

	// Use this for initialization
	void Start()
    {
        GaugeBar.value = 0;
    }

    void OnGUI()
    {
        
    }

	// Update is called once per frame
	void Update () {
        
        //while (GaugeBar.value > GaugeBar.minValue + 1)
           // GaugeBar.value -= Time.deltaTime;
	}
}
