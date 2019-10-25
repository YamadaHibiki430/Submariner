using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    MeshRenderer meshrende;
    void Start()
    {
        meshrende = GetComponent<MeshRenderer>();
        meshrende.material.color = new Color(0, 0, 0, 0.0f);
    }

    void Update()
    {
        
    }

    //敵が見えるようになる
    public void Entry()
    {
        meshrende.material.color = new Color(0, 0, 0, 1.0f);
        Debug.Log("敵を発見");
    }
}
