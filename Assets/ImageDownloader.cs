using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class ImageDownloader : MonoBehaviour {

    public GameObject quad;
    public float gazeTime = 2f;


    private float timer;

    private bool gazedAt;
    public static int var = 1;
    
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
        //Debug.Log("var is "+imageback.vari);

        //if (imageback.vari > 0)// && LESS THAN VAR + 1
        //{ int var2 = imageback.vari;
        //    var = var2 + 1;
        //    Debug.Log("var is " + var);

        //}

        //else
        //{
        //    var = var + 1;

        //}
        
        if (File.Exists(Application.persistentDataPath + "test1.jpg") && var==1)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test1.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;
            Debug.Log(Application.persistentDataPath + "test1.jpg");
            
        }

        else if (File.Exists(Application.persistentDataPath + "test2.jpg") && var == 2)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test2.jpg");
            Texture2D texture = new Texture2D(2, 2,TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;
            
        }

        else if (File.Exists(Application.persistentDataPath + "test3.jpg") && var == 3)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test3.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (File.Exists(Application.persistentDataPath + "test4.jpg") && var == 4)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test4.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (File.Exists(Application.persistentDataPath + "test5.jpg") && var == 5)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test5.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (File.Exists(Application.persistentDataPath + "test6.jpg") && var == 6)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test6.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (File.Exists(Application.persistentDataPath + "test7.jpg") && var == 7)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test7.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (File.Exists(Application.persistentDataPath + "test8.jpg") && var == 8)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test8.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (File.Exists(Application.persistentDataPath + "test9.jpg") && var == 9)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test9.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (File.Exists(Application.persistentDataPath + "test10.jpg") && var == 10)
        {
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test10.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;

        }
        else if (var >= 10 && File.Exists(Application.persistentDataPath + "test1.jpg"))
        {
            var = 1;
            byte[] byteArray = File.ReadAllBytes(Application.persistentDataPath + "test1.jpg");
            Texture2D texture = new Texture2D(2, 2, TextureFormat.BGRA32, false);
            texture.LoadImage(byteArray);
            quad.GetComponent<Renderer>().material.mainTexture = texture;
            Debug.Log(Application.persistentDataPath + "test1.jpg");
        }

        var = var + 1;

    }

}




