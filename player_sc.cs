using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class player_sc : MonoBehaviour
{
    [SerializeField]
    float speed = 10;
    float speedMultiplier=2;
    
    [SerializeField]
    private bool isTripleShotActive = false;
    
    [SerializeField]
    private bool isSpeedBonusActive=false;

    [SerializeField]
    private bool isShieldBonusActive=false;

    private float nextFire = 0;

    [SerializeField]
    private float fireRate = 0.25f;

    [SerializeField]
    private GameObject laserPrefab;

    [SerializeField]
    private GameObject tripleLaserPrefab;

    [SerializeField]
    GameObject shieldVisualizer;

    [SerializeField]
    private int lives = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        CalculateMovement();

        if (Input.GetKeyDown(KeyCode.Space) && (Time.time > nextFire))
        {
            nextFire = Time.time + fireRate;
            FireLaser();
        }

    }

    void FireLaser()
    {

        if (!isTripleShotActive)
        {
            Instantiate(laserPrefab, (this.transform.position + new Vector3(0, 0, 0)), Quaternion.identity);

        }

        else
        {
            Instantiate(tripleLaserPrefab, (this.transform.position + new Vector3(0, 0, 0)), Quaternion.identity);

        }

    }


    void CalculateMovement()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction * speed * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.8f, 0), 0);
        /*
                if(trnasform.positon.y>=0){
                    transform.positon=new Vector3(transform.positon.x,0,0);
                }

                else if(transform.positon.y<=-5.6f){
                    transform.position=new Vector3(transform.position,-5.6f,0);
                }
          */
        if (transform.position.x > 11.7f)
        {
            transform.position = new Vector3(-11.7f, transform.position.y, 0);
        }

        else if (transform.position.x < -11.7f)
        {
            transform.position = new Vector3(11.7f, transform.position.y, 0);
        }


    }

    public void Damage()
    {
        if (isShieldBonusActive)
        {
            isShieldBonusActive=false;
            shieldVisualizer.SetActive(false);
            return;
        }
       
        lives--;

        if (lives == 0)
        {
            SpawnManager_sc spawnManager_sc = GameObject.Find("Spawn_Manager").GetComponent<SpawnManager_sc>();

            if (spawnManager_sc != null)
            {
                spawnManager_sc.OnPlayerDeath();
            }

            else
            {
                Debug.LogError("Player_sc::Damage spawnManager_sc is NULL");
            }


            Destroy(this.gameObject);


        }
    }


    public void TripleShotActive()
    {
        isTripleShotActive = true;
        StartCoroutine(TripleShotCancelRoutine());
    }

    public void SpeedBonusActive()
    {
        isSpeedBonusActive=false;
        speed*=speedMultiplier;
        StartCoroutine(SpeedBonusCancelRoutine());
    }

    public void ShieldBonusActive()
    {
        isSpeedBonusActive=true;
        shieldVisualizer.SetActive(true);
        
    }

    IEnumerator TripleShotCancelRoutine()
    {
        yield return new WaitForSeconds(5.0f);
        isTripleShotActive = false;
    }

    IEnumerator SpeedBonusCancelRoutine()
    {
        yield return new WaitForSeconds(5.0f);
        isSpeedBonusActive = false;
        speed/=speedMultiplier;
    }

    IEnumerator ShieldBonusCancelRoutine()
    {
        yield return new WaitForSeconds(5.0f);
        isShieldBonusActive = false;
    }

}



