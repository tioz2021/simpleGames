using UnityEngine;

public class CreateObjects : MonoBehaviour
{

	public GameObject[] obj;

	void Start()
	{
		for (int i = 0; i < 5; i++)
		{
			Instantiate(obj[RandomNumber(0, obj.Length)],
				new Vector3(RandomNumber(), RandomNumber(), RandomNumber()),
				Quaternion.Euler(RandomNumber(), RandomNumber(), RandomNumber()));
		}
		// GameObject newObject = Instantiate(obj, new Vector3(0, 5, 0), Quaternion.Euler(12f, -15f, 40f)) as GameObject;
		// newObject.GetComponent<Transform>().position = new Vector3(5, 5, 0);
	}

	private int RandomNumber(int start = 0, int end = 10)
	{
		return Random.Range(start, end);
	}

}
