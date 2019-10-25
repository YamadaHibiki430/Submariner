using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleHitCheck : MonoBehaviour
{
    float rayarea =0.0f;
    float areatime = 0.0f;

    private void OnParticleCollision(GameObject obj)
    {
        Debug.Log("オブジェクトを発見");
        if (obj.gameObject.tag == "Player")
        {
            Debug.Log("敵を発見");
        }

    }


    private void Update()
    {
        rayarea += 0.03833474f;
        areatime += 1.0f;
        if(areatime >= 60.0f)
        {
            rayarea = 0.0f;
            areatime = 0.0f;
        }
        //HitRay(rayarea);
        Hitobj(rayarea);
    }

    void HitArea(Vector3 vec, float max)
    {
      
        Vector3 pos = this.transform.position;

        Ray ray = new Ray(pos, vec);
        if (Physics.Raycast(ray, max))
        {
            Debug.Log("敵を発見");
        }
    }
    void HitAreaObj(Vector3 vec, float max)
    {
        RaycastHit hit;
        Vector3 pos = this.transform.position;

        Ray ray = new Ray(pos, vec);
        if (Physics.Raycast(ray,out hit, max))
        {
            if(hit.collider.tag =="Enemy")
            {
                hit.transform.GetComponent<Enemy>().Entry();
 
            }
           // Debug.Log("オブジェクトを発見");
        }
    }
    void HitRay(float max)
    {
        HitArea(Vector3.forward, max);
        HitArea(Vector3.right, max);
        HitArea(Vector3.up, max);
        HitArea(Vector3.back, max);
        HitArea(Vector3.down, max);
        HitArea(Vector3.left, max);

    }

    void Hitobj(float max)
    {

        HitAreaObj(Vector3.forward, max);
        HitAreaObj(Vector3.right, max);
        HitAreaObj(Vector3.up, max);
        HitAreaObj(Vector3.back, max);
        HitAreaObj(Vector3.down, max);
        HitAreaObj(Vector3.left, max);
    }
}
