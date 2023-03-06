using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	public float speed = 5.0f;

	// Start is called before the first frame update
	private void Awake()
	{
	}

	// Update is called once per frame
	void Update()
	{
		// if (Input.GetKey(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
		// {
		// 	transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
		// }
		// else if (Input.GetKey(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
		// {
		// 	transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
		// }

		float v = Input.GetAxis("Vertical");
		float h = Input.GetAxis("Horizontal");
		transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime * v);
		transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime * h);
	}
}
