///////// Script Spawn Player pour Udemy //////////////////
///////////////////////////////////////////////////////////
////////  Instructeur Parein Jean-philippe ////////////////
///////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;

public class ScriptSpawn : MonoBehaviour {
    
    public AudioClip soundDeath;
   	void OnTriggerEnter (Collider Other)
    {
        if(Other.gameObject.tag== "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(soundDeath);
            Other.gameObject.transform.position = GameObject.Find("SpawnPoint").transform.position;
            
        }	
	}		
}
