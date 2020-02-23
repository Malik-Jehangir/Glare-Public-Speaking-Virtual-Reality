using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class imageback : MonoBehaviour {

    

    public GameObject quad;
    public float gazeTime = 2f;

    public static int vari = 0;
    private float timer;

    private bool gazedAt;
    

    // Use this for initialization
    void Start()
    {

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
        vari = ImageDownloader.var - 1; 
        Debug.Log("vari is " + vari);
        if (File.Exists(Application.persistentDataPath + "test1.jpg") && vari == 1)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test1.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;
            Debug.Log(Application.persistentDataPath + "test1.jpg");
           
        }

        else if (File.Exists(Application.persistentDataPath + "test2.jpg") && vari == 2)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test2.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (File.Exists(Application.persistentDataPath + "test3.jpg") && vari == 3)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test3.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (File.Exists(Application.persistentDataPath + "test4.jpg") && vari == 4)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test4.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (File.Exists(Application.persistentDataPath + "test5.jpg") && vari == 5)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test5.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (File.Exists(Application.persistentDataPath + "test6.jpg") && vari == 6)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test6.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (File.Exists(Application.persistentDataPath + "test7.jpg") && vari == 7)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test7.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (File.Exists(Application.persistentDataPath + "test8.jpg") && vari == 8)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test8.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (File.Exists(Application.persistentDataPath + "test9.jpg") && vari == 9)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test9.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (File.Exists(Application.persistentDataPath + "test10.jpg") && vari == 10)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test10.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
    }

}




