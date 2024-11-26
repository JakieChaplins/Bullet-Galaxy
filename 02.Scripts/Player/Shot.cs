using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public AudioSource shot;

    public Transform shotInItPoint;
    public GameObject bullet;

    public float shotForce;

    void Update()
    {
       if (Input.GetMouseButtonDown(0) && GameManager.Instance.ammo>0)
        {
            //Debug.Log(GameManager.Instance.ammo);
            GameManager.Instance.ammo--;
            GameObject newBullet = Instantiate(bullet, shotInItPoint.position, shotInItPoint.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(shotInItPoint.forward * shotForce);
            shot.Play();
            Destroy(newBullet, 5);

            GameManager.Instance.textAmmo.text = GameManager.Instance.ammo.ToString();

        }
    }
}
