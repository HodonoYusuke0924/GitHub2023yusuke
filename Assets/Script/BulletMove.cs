using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float lifeTime;
    [SerializeField] private GameObject bulletPrefab;
    private GameObject bullet;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            bullet = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);//�o��������bulletPrefab��bullet�ɑ��
            rb = bullet.GetComponent<Rigidbody>();//bullet��rigidbody���擾
            rb.AddForce(transform.forward * bulletSpeed);//�O�ʂɌ������ė͂�������
            Destroy(bullet, lifeTime);//bullet��lifetime�b��ɉ�
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}