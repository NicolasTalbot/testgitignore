using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireGun : MonoBehaviour {
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject bulletEmitter;
    [SerializeField] float firerate = 1;
    // Use this for initialization
    private float timerLastShot = 0;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timerLastShot += Time.deltaTime;
        if(timerLastShot > firerate)
        {
            var fire1 = Input.GetAxis("Fire1");
            if (fire1 >0)
            {
                Instantiate(bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation);
                timerLastShot = 0;
            }
	    }
    }
        
}
