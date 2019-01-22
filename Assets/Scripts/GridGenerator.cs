using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour {

    public GameObject _tile;
    public float _offsetValue;
    Vector3 tilePos = Vector3.zero;

	// Use this for initialization
	void Start ()
    {
        GridGenerate();
    }
	
	private void GridGenerate()
    {
        for(int i=0; i< 3; i++)
        {
           
            for(int j=0; j< 3; j++)
            {
                tilePos.x = transform.position.x + j;
                tilePos.y = transform.position.y - i;
                GameObject tileInstance = Instantiate(_tile, tilePos * _offsetValue, Quaternion.identity);
                tileInstance.transform.SetParent(this.transform);
            }
        }
    }
}
