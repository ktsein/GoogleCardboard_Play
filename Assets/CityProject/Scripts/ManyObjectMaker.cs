using UnityEngine;
using System.Collections;

public class ManyObjectMaker : MonoBehaviour {

    public GameObject objectToCreate;

	// Use this for initialization
	void Start () {
        for (int i= 0; i <10; i++)
        {
            //Object.Instantiate(objectToCreate, new Vector3(i, i, i), Quaternion.identity);
            GameObject newBird = (GameObject)Object.Instantiate(objectToCreate, new Vector3(i, 0, 0), Quaternion.identity);
            Renderer objectRenderer = newBird.GetComponentInChildren<Renderer>();
            objectRenderer.material.color = Color.white * Random.value;
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
