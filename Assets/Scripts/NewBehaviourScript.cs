using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class NewBehaviourScript : MonoBehaviour
{
	// [NonSerialized]
	// public int _num = 5;
	// public string str;

	// [SerializeField] private int num2 = 10;

	// public int[] numbers = new int[3];

	// public List<string> words = new List<string>();

	void Awake()
	{
		// Debug.Log("awake");
	}

	void Start()
	{
		// Debug.Log("start");
	}

	private void Update()
	{
		// Debug.Log("update");
	}

	private void LateUpdate()
	{
		// Debug.Log("late update");
	}

	private void FixedUpdate()
	{
		// Debug.Log("fixed update");
	}

	private void OnDestroy()
	{
		// Debug.Log("on destroy");
	}

	private void OnEnable()
	{
		// Debug.Log("on enable");
	}
}
