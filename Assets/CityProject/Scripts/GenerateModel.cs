using UnityEngine;
using System.Collections;

public class GenerateModel : MonoBehaviour {

    public GameObject Tree;
    public GameObject Tent;
    public GameObject Mountain;
    public GameObject FlatLand;

    public void GenerateTree()
    {
        Object.Instantiate(Tree, new Vector3(-4, -2, -5), Quaternion.identity);
    }

    public void GenerateTent()
    {
        Object.Instantiate(Tent, new Vector3(-4, -2, -5), Quaternion.identity);
    }

    public void GenerateMountain()
    {
        Object.Instantiate(Mountain, new Vector3(-4, -2, -5), Quaternion.identity);
    }

    public void GenerateFlatLand()
    {
        Object.Instantiate(FlatLand, new Vector3(-4, -2, -5), Quaternion.identity);
    }
}
