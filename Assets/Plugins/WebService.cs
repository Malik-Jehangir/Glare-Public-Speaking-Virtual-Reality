/*
 * Web Service
 * 
 * A simple HTTP get / post wrapper with SimpleJSON support.
 * 
 * Max Felker | felkerm@gmail.com
 * 
*/

using System; 
using UnityEngine;
using System.Collections; 
using System.Collections.Generic;
using SimpleJSON;
using System.Linq;

public class WebService : MonoBehaviour {
	
	// general web service
	public string Endpoint;
	public Dictionary<string, string> postVariables;
	public JSONNode responseJSON;
	
	// Set up states
    enum State {Idle,Getting, Posting,Responded};
	State state;
	
	// Set up our call back delegation
    public delegate void CallBack(JSONNode response);
	CallBack callBack;
	
	[HideInInspector]
	public string error;
	
	public void Start() {
	
		state = State.Idle;
		
	}
	
	// GET from the server
    public void Get(string URL, CallBack callBack){
 
	    WWW response = new WWW (URL);
		
		state = State.Getting;
	 
	    StartCoroutine( 
			MakeRequest(response,callBack)
		);
		
    }
 
	// POST to the server
    public void Post(string URL, Dictionary<string,string> post, CallBack callBack){
				
        WWWForm form = new WWWForm();
		
	    foreach(KeyValuePair<String,String> post_arg in post) {
			
	   		form.AddField(post_arg.Key, post_arg.Value);
			
	    }
	    
		WWW response = new WWW(URL, form);
		
		state = State.Posting;
	 
	    StartCoroutine( 
			MakeRequest(response,callBack)
		);

    }

	// Make the Request & Exectute Call Back function
    IEnumerator MakeRequest( WWW response, CallBack callBack ){
	
        yield return response;
		
		state = State.Responded; 
		
		Debug.Log("Web Service Response: "+response.text);
		
		JSONNode responseJSON = JSON.Parse(response.text);
		
		if(responseJSON["error"] == null && callBack != null) {
			
			callBack( responseJSON );
	
		}
		
		if(responseJSON["error"] != null) {
			Debug.LogError("Web Service Error: "+responseJSON["error"]);
		}
		
		state = State.Idle; 
				
    }         

}