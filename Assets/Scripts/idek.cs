using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idek : MonoBehaviour, IDamage
{
    public LayerMask mask;
    Camera cam; 
    public float weaponDamage = 25;

    public GameObject Chest;
    private Vector3 scaleChange, positionChange;
    

    void Start()
    {
        cam = Camera.main;
        scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;
        mousePos = cam.ScreenToWorldPoint(mousePos);
        Debug.DrawRay(transform.position, mousePos - transform.position, Color.white);
    

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        
            if (Physics.Raycast(ray,out hit, 100, mask));
            {
                Enemy target = hit.collider.GetComponent<Enemy>();
                if(target != null)
                {
                    target.hit(weaponDamage);
                }
                Debug.Log(hit.transform.name);
                if(hit.transform.name == "Uppy")
                    hit.transform.Translate(Vector3.up * Time.deltaTime * 100, Space.World);
                if(hit.transform.tag == "human");
                {
                    GameObject blood =  GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    blood.transform.localScale += new Vector3(.02f,.02f,.02f);
                    blood.transform.position = new Vector3(hit.transform.position.x, hit.transform.position.y + 1, hit.transform.position.z);
                }
                if(hit.transform.tag == "human");
                {
                    target.hit(weaponDamage);
                } 
                if(hit.transform.name == "ROTATEBOI");
                {
                    target.rotatE();
                }    
            }
        }     
    }

    public void TakeDamage(float DamageAmount)
    {
        print("hi");
    }
}