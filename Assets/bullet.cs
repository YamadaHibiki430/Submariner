using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

	float time_;
	public int DestroyTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		time_ += Time.deltaTime;

		if (time_ >= DestroyTime)
		{
			Destroy(this.gameObject);
		}
    }
}
