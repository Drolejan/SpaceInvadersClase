using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    //public GameObject bullet;
    void Start()
    {
        StartCoroutine(enemyShoot());
    }

    IEnumerator enemyShoot()
    {
        do
        {
            yield return new WaitForSeconds(1);
            eShoot();
        } while (true);
    }

    public void eShoot()
    {
        //Esta funci�n toma el objeto desactivado disponible
        //Para utilizarlo al gusto
        GameObject bullet = ObjectPooler.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.transform.position = this.transform.position;
            bullet.transform.rotation = this.transform.rotation;
            bullet.SetActive(true);
        }
    }
}
