using UnityEngine;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using UnityEngine.Networking;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System;

public class webservice1 : MonoBehaviour
{

    void Start() { POST(); }


    string POSTAddUserURL = "https://ussouthcentral.services.azureml.net/workspaces/9190c4122e7e43319d3be5a196d998cd/services/3eac450e47fc421e8c026cc71039302c/execute?api-version=2.0";
    string api_key = "1l5OeZZhInD6zQREWQCN/EPX+qd6ACzUJBG8hQTtdlnnq3SZ7gB0EjF7vsiTprfWawP8wydf6MTiHFViN69B0Q==";
    public void POST()
    {
        string JsonArraystring = "{\"Inputs\": {\"User_HR_input\": {\"ColumnNames\": [\"User_HR\",\"Hall_Type\"],\"Values\": [\"120\",\"Conference room\"]}},\"GlobalParameters\": {}}";

        ServicePointManager.ServerCertificateValidationCallback = MyRemoteCertificateValidationCallback;



        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(POSTAddUserURL);
        request.Headers.Add("Authorization", "Bearer"+api_key);


        ASCIIEncoding encoding = new ASCIIEncoding();
        byte[] byte1 = encoding.GetBytes(JsonArraystring);
        request.ContentType = "application/json";
        request.Method = "POST";
        request.ContentLength = byte1.Length;

        Stream newStream = request.GetRequestStream();

        newStream.Write(byte1, 0, byte1.Length);


        // Close the Stream object.
        newStream.Close();
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        Stream resStream = response.GetResponseStream();
        Debug.Log(resStream);



    }
    public bool MyRemoteCertificateValidationCallback(System.Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
    {
        bool isOk = true;
        // If there are errors in the certificate chain, look at each error to determine the cause.
        if (sslPolicyErrors != SslPolicyErrors.None)
        {
            for (int i = 0; i < chain.ChainStatus.Length; i++)
            {
                if (chain.ChainStatus[i].Status != X509ChainStatusFlags.RevocationStatusUnknown)
                {
                    chain.ChainPolicy.RevocationFlag = X509RevocationFlag.EntireChain;
                    chain.ChainPolicy.RevocationMode = X509RevocationMode.Online;
                    chain.ChainPolicy.UrlRetrievalTimeout = new TimeSpan(0, 1, 0);
                    chain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllFlags;
                    bool chainIsValid = chain.Build((X509Certificate2)certificate);
                    if (!chainIsValid)
                    {
                        isOk = false;
                    }
                }
            }
        }
        return isOk;
    }
}



   