using UnityEngine;

public class bonus_sc : MonoBehaviour
{
    [SerializeField]
    float speed = 3;
   
    
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (this.transform.position.y < -5.8f)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Üçlü atış bonusunu aktifleştir
            player_sc player_sc = other.transform.GetComponent<player_sc>();

            if (player_sc != null)
            {
                player_sc.TripleShotActive();
            }

            //Bonus nesnesini yok et
            Destroy(this.gameObject);   

        }
    }
}
