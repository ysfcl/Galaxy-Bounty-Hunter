using UnityEngine;

public class Ödev2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int hiz = 10;

    private float nextFire = 0;


    [SerializeField]
    private float fireRate = 0.25f;

    [SerializeField]
    public GameObject laserPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && (Time.time > nextFire))
        {
            nextFire = Time.time + fireRate;
            atesEt(); //ateş etme fonksiyonu
        }



    }
    
    void atesEt()
    {
        Instantiate(laserPrefab, (this.transform.position + new Vector3(0, 0, 0)),Quaternion.identity); //başlangıç pozisyonunu, ve dönme hareketi olmadığını belirtir
    }
}
