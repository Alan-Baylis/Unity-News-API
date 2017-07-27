using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class News : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }

    int framecount = 0;
    public WWW news;
    public string textWhenFailed = "Failed To Load News";
    public string URL = "http://pineapple8.co.uk/txt/test.txt";

    // Update is called once per frame
    void Update () {

        UnityEngine.UI.Text uitext = GetComponent<UnityEngine.UI.Text>();

        if (framecount == 0) {
            try
            {
                news = new WWW(URL);
            }
            catch {}
        }

        if(news.isDone)
        {
            if (news.text == "")
            {
                uitext.text = textWhenFailed;
            }
            else
            {
                uitext.text = news.text;
            }
        }
        framecount += 1;
    }
}
