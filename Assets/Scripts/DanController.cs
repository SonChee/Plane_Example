using UnityEngine;
using System.Collections;

public class DanController : MonoBehaviour {
	public float speed = 5;
	// Use this for initialization
	void Start () {
		transform.position = new Vector3(transform.position.x,transform.position.y + 1,transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * speed * Time.deltaTime);
		if(transform.position.y > 6.2f){
			Destroy(this.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.tag == "dich"){
			Destroy(coll.gameObject);
			Destroy(this.gameObject);
		}
	}
}
