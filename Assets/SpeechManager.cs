using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
/*using UnityEngine.Windows.Speech;*/

public class SpeechManager : MonoBehaviour
{   /*
    KeywordRecognizer keywordRecognizer = null;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();*/
    float timer = 0;
    public Text myText = null;
    int intTimer = 0;
    int value;
    public bool starttime = false;
    public bool finishtime = false;
    public bool restarttime = false;

    // Use this for initialization*/
    void Start()
    {

        /*keywords.Add("Start Timer", () =>
        {*/
            // Call the OnReset method on every descendant object.
            // this.BroadcastMessage("onReset");
            onReset();


        /*});
        
        keywords.Add("Finish", () =>
        {
            {
                value = intTimer;
                // Call the OnDrop method on just the focused object.
                //this.SendMessage("OnDrop");
                onFinish();
            }
        });


        keywords.Add("Restart", () =>
        {
            // Call the OnReset method on every descendant object.
            // this.BroadcastMessage("onReset");
            restarting();


        });

        // Tell the KeywordRecognizer about our keywords.
        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());

        // Register a callback for the KeywordRecognizer and start recognizing!
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();*/
    }

    void Update()
    {

       if (starttime == true)
        {
            timer += Time.deltaTime;
            intTimer = (int)timer;
            myText.text = intTimer.ToString();
        }

        if (finishtime == true)
        {
            myText.text = value.ToString();
        }

        /*if (restarttime == true)
        {
            timer += Time.deltaTime;
            intTimer = (int)timer;
            myText.text = "Time: " + intTimer + " seconds";
        }*/
    }
    
    public void onReset()
    {
        starttime = true;
        Update();
    }

    
   /* public void onFinish()
    {
        value = intTimer;
        finishtime = true;
        Update();
    }

    /*
    public void restarting()
    {
        starttime = true;
        Update();
    }




    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }*/
}

