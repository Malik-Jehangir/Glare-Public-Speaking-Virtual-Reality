using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonanalyze : MonoBehaviour
{

    public float gazeTime = 2f;

    public AudioClip abc;
    private float timer;
    public Text helloText;
    public Text helloText2;
    public Button ana;

    public Sprite xyz;
    private bool gazedAt;

    // Use this for initialization
    void Start()
    {
        helloText2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gazedAt)
        {
            timer += Time.deltaTime;
            if (timer >= gazeTime)
            {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;
            }
        }

    }

    public void PointerEnter()
    {
        //Debug.Log("Pointer ENTER");
        gazedAt = true;
    }

    public void PointerExit()
    {
        //Debug.Log("Pointer EXIT");
        gazedAt = false;
    }

    public void PointerDown()
    {

        SceneManager.LoadScene("pano2");


    }
}