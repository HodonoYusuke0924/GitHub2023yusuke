using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float MoveSpeed;
    [SerializeField] private float xMax;
    [SerializeField] private float xMin;
    [SerializeField] private float zMax;
    [SerializeField] private float zMin;
    //private このスクリプト内でしか書き換えられない
    //public どこからでも書き換えられる
    //[SerializeFIeld] private unity上では変えられるけど他のスクリプトでは変えられない
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && this.transform.position.x > xMin)//Aを押したら移動、かつオブジェクトのx座標がxMin以上の値なら移動可能
            transform.Translate(new Vector3(-MoveSpeed, 0, 0) * Time.deltaTime); //移動するためのプログラム

        if (Input.GetKey(KeyCode.D) && this.transform.position.x< xMax)//Dを押したら移動、かつオブジェクトのx座標がxMax以下の値なら移動可能
            transform.Translate(new Vector3(MoveSpeed, 0, 0) * Time. deltaTime); //移動するためのプログラム

        if (Input.GetKey(KeyCode.W) && this.transform.position.z < zMax)//Wを押したら移動、かつオブジェクトのz座標がzMax以下の値なら移動可能
            transform.Translate(new Vector3(0, 0, MoveSpeed) * Time.deltaTime); //移動するためのプログラム

        if (Input.GetKey(KeyCode.S) && this.transform.position.z > zMin)//Sを押したら移動、かつオブジェクトのz座標がxMin以上の値なら移動可能
            transform.Translate(new Vector3(0, 0, -MoveSpeed) * Time.deltaTime); //移動するためのプログラム
    
    }
    private void OnTriggerEnter(Collider other)
    { 
        Debug.Log("Enemy");
    }


    private void OnDestroy()
    {
        SceneManager.LoadScene("End");
            }

}