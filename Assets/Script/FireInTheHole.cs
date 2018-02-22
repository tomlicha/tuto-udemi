using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireInTheHole : MonoBehaviour {

	//variables
	public GameObject prefabBullet;
	private GameObject bullet;
	public float shootRate = 0.2f;
	private float nextShot;
	public int speed = 1000;
	public AudioClip shootingSound;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Time.time > nextShot){

			nextShot = Time.time + shootRate;
			bullet = Instantiate(prefabBullet,transform.position,Quaternion.identity);
			GetComponent<AudioSource>().PlayOneShot(shootingSound);
			bullet.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.right) * speed);
			Destroy(bullet,2f);
		
		}
	}
}
