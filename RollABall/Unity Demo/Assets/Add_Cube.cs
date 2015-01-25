using UnityEngine;
using System.Collections;

public class Add_Cube : MonoBehaviour
{
	public GameObject brick;
	public bool toggle;
	void Start() {
		}
	public void AddObject()
	{
		if (toggle)
		{
			Instantiate(brick, new Vector3(0,0, 0), Quaternion.identity);
			
			}
		}
	//}
}