using UnityEngine;

public class mermi_sc : MonoBehaviour
{
    public int hiz = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
    //start() fonksiyonuna gerek yoktur**********

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.up * hiz * Time.deltaTime);    //Vector3.up ile yukarı hareket sağlanır

        if (this.transform.position.y > 7)  // ekran sınırı 7 olmak zorunda değildir, bilgisayara ve ayara göre değiştirilebilir 
        {
            Destroy(this.gameObject);   // ekrandan çıkmaya başlayan prefableri siler
        }
    }
}
