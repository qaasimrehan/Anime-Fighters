using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rasengan : MonoBehaviour
{

    public Transform firePoint;
    public GameObject firePrefab;
    public GameObject Naruto;
    

    public float fireForce = 20f;
    public float fireRate = 10.0f;
    public float nextFire = 0.0f; 


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("NFire1")){

           if (Time.time > nextFire) {
               nextFire = Time.time + fireRate;
                     Naruto.GetComponent<Animator>().Play("Naruto Special Move");
                Invoke("Shoot", 1.2f); // run shoot after 0.75 seconds
            }
        }
        
    }
 
    void Shoot()
    {
        GameObject fire = Instantiate(firePrefab, firePoint.position, firePoint.rotation);
        Destroy(fire, 2); // destroy the fire after 2 seconds
        Rigidbody2D rb = fire.GetComponent<Rigidbody2D>();

        float direction = Mathf.Sign(Naruto.transform.localScale.x);

        fire.transform.localScale = new Vector3(fire.transform.localScale.x * direction,fire.transform.localScale.y,fire.transform.localScale.z);

       rb.AddForce(direction * firePoint.right * fireForce, ForceMode2D.Impulse);
    }
}
