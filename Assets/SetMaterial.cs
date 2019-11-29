using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaterial : MonoBehaviour
{
	[SerializeField] private Renderer[] a = null;
	private Material mate = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

	private void Reset()
	{
		a = gameObject.GetComponentsInChildren<Renderer>();

		mate = (Material)Resources.Load("wireframe");

		for (int i = 0; i < a.Length; i++)
		{
			for (int m = 0; m < a[i].materials.Length; m++)
			{
				a[i].materials[m] = mate;

			}

		}
	}
}
