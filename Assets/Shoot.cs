using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{


	// bullet prefab
	public GameObject bullet;

	// 弾丸発射点
	public Transform muzzle;

	// 弾丸の速度
	public float speed = 1000;

	public int RecastTime = 0;

	float time;
	int state = 0;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && state == 0)
		{
			state = 1;

			GameObject bullets = Instantiate(bullet) as GameObject;

			Vector3 force;

			force = this.gameObject.transform.forward * speed;

			bullets.GetComponent<Rigidbody>().AddForce(force);

			bullets.transform.position = muzzle.position;
		}

		if(state == 1)
		{
			time += Time.deltaTime;
		}
		if(time >= RecastTime)
		{
			state = 0;
			time = 0;
		}

	}
}
