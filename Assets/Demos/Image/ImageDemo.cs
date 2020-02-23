using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Unity3dAzure.StorageServices;
using System.IO;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ImageDemo : MonoBehaviour
{

    /*[Header ("Azure Storage Service")]
	[SerializeField]
	private string storageAccount;
	[SerializeField]
	private string accessKey;
	[SerializeField]
	private string container;

	private StorageServiceClient client;
	private BlobService blobService;*/
    public float gazeTime = 5f;

    public static int vari = 0;
    private float timer;

    private bool gazedAt;

    [Header ("Image Demo")]
	public Image image;
	

	private bool isCaptured = false;

	private string localPath;

	void Start ()
	{
		/*if (string.IsNullOrEmpty (storageAccount) || string.IsNullOrEmpty (accessKey)) {
			Debug.Log( "Storage account and access key are required\nEnter storage account and access key in Unity Editor");
		}

		client = new StorageServiceClient (storageAccount, accessKey);
		blobService = client.GetBlobService ();*/
	}

	void Update ()
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
        ChangeImage(new Texture2D(1, 1));
       
        string url = "https://glareblob.blob.core.windows.net/blob/c1.png";
        Debug.Log("Load: " + url);
        StartCoroutine(LoadImageURL(url));
    }

    public IEnumerator LoadImageURL(string url)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);
        yield return www.Send();
        if (www.isNetworkError)
        {
            Debug.Log("Failed to load image: " + url);
        }
        else
        {
            Texture texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
            ChangeImage(texture);
        }
    }


    private void ChangeImage(Texture2D texture)
    {
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
        image.GetComponent<Image>().sprite = sprite;
    }

    private void ChangeImage(Texture texture)
    {
        ChangeImage(texture as Texture2D);
    }

  

}
