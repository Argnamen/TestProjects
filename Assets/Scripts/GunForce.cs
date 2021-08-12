using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunForce : MonoBehaviour
{
    private Ray ray;
    private GameObject _gun;
    void Update()
    {
        if (this.gameObject.activeSelf)
        {
            for (var i = 0; i < Input.touchCount; ++i)
            {
                ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                
            }
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit, 100f))
            {
                Collider raycastHitCollider = raycastHit.collider;
                if (raycastHitCollider.gameObject.tag == "Evil")
                {
                    raycastHitCollider.gameObject.SetActive(false);
                    ++MovePlayer.mobCount;
                }
            }
                if (Physics.Raycast(this.transform.position, ray.direction))
                    this.transform.position = Vector3.MoveTowards(this.transform.position, ray.direction, 1f);
        }
    }
}
