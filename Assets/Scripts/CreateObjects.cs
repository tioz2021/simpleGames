using UnityEngine;

public class CreateObjects : MonoBehaviour
{

	public GameObject obj;

	void Start()
	{
		GameObject newObject = Instantiate(obj, new Vector3(0, 5, 0), Quaternion.Euler(12f, -15f, 40f)) as GameObject;
		newObject.GetComponent<Transform>().position = new Vector3(5, 5, 0);
	}

}
