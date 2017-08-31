using UnityEngine;
using System.Collections;

public class Text : MonoBehaviour {
    private int i = 0;
    private bool change = true;
	// Use this for initialization
	void Start () {
        i = 0;
        change = true;
	}
	
	// Update is called once per frame
	void Update () {
        int time = (int)(Time.time * 1000);
        //print(i);
        if(time%500==0&&change)
        {
            //this.enabled = change;
            this.gameObject.SetActive(false);
            //print("Time");
            change = false;
        }
        if (time % 500 == 0 && change == false)
        {
            //this.enabled = change;
            this.gameObject.SetActive(true);
            //print("Time");
            change = true;
        }
    }
}
