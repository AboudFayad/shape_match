using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class control : MonoBehaviour
{
    public float PushForce = 10f;
    public float TurnForce = 45f;
    private Rigidbody rb = null;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }


    void OnMouseDown()
    {

    }

    public LayerMask mask;
    void OnMouseDrag()
    {


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity, mask))
        {
            Debug.Log(hitInfo.collider.gameObject.name);
            //Destroy(hitInfo.transform.gameObject);
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);
            transform.position = hitInfo.point;
        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 100, Color.green);
        }

    }

    private void Update()
    {



    }
}