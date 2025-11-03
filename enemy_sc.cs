using UnityEngine;

public class enemy_sc : MonoBehaviour
{
    [SerializeField]
    int speed = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*    void Start()
        {

        }
    */
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (this.transform.position.y < -5.5f)
        {
            //Destroy(this.gameObject);

            float randomX = Random.Range(-9.5f, 9.5f);



            this.transform.position = new Vector3(Random.Range(-9.5f, 9.5f), 7.4f, 0);

        }
    }

    void OnTiggerEnter2D(Collider2D collision)
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //TODO:Player'ın canını bir eksilt
            player_sc player = other.transform.GetComponent<player_sc>();
            player.Damage();
            Destroy(this.gameObject);
        }

        else if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }


}
