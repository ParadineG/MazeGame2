using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {
    public GameObject wall;
    public GameObject level;

	// Use this for initialization
	void Start () {
        GenerateWall();
	}
    public void GenerateWall()
    {
        foreach (Transform child in level.transform)
        {
            Destroy(child.gameObject);
        }
        for (int x = -16; x <= 16; x++)
        {
            Transform wall0 = Instantiate(wall.transform, new Vector3(x, 0.5f, 16), Quaternion.identity);
            Transform wall1 = Instantiate(wall.transform, new Vector3(x, 0.5f, -16), Quaternion.identity);
            wall0.parent = level.transform;
            wall1.parent = level.transform;
        }
        for (int z = -15; z <= 15; z++)
        {
            Transform wall0 = Instantiate(wall.transform, new Vector3(16, 0.5f, z), Quaternion.identity);
            Transform wall1 = Instantiate(wall.transform, new Vector3(-16, 0.5f, z), Quaternion.identity);
            wall0.parent = level.transform;
            wall1.parent = level.transform;
        }
        for (int x = -15; x <= 15; x++)
        {
            for (int z = -15; z <= 15; z++)
            {
                if (!(x == -15 && z == -15 ||
                    x == -15 && z == 15 ||
                    x == 15 && z == -15 ||
                    x == 15 && z == 15)
                    && Random.value < 0.10f)
                {
                    Transform wall0 = Instantiate(wall.transform, new Vector3(x, 0.5f, z), Quaternion.identity);
                    wall0.parent = level.transform;
                }
            }
        }
    }
}
