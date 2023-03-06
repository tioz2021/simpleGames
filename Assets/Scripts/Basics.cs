using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics : MonoBehaviour
{

	public GameObject obj;
	public Transform target;

	public Light _light;

	public List<Transform> _transforms = new List<Transform>();
	public float speed = 5.0f;
	public float rotateSpeed = 5.0f;

	void Awake()
	{
		// for (int i = 0; i < _objects.Count; i++)
		// {
		// 	Debug.Log(_objects[i]);
		// 	_objects[i].SetActive(false);
		// }
	}
	void Start()
	{
		// obj.SetActive(false);
		// obj.GetComponent<Transform>().position = new Vector3(10, 0, 5);
		// Debug.Log(obj.GetComponent<Transform>().position);
		// target.position = new Vector3(10, 0, 0);
		// _light.intensity = 0.5f;
	}

	// Update is called once per frame
	void Update()
	{
		for (int i = 0; i < _transforms.Count; i++)
		{
			_transforms[i].Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
			_transforms[i].Rotate(new Vector3(-1, 0, 0) * rotateSpeed * Time.deltaTime);
		}
	}

}
