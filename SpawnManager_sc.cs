using System.Collections;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class SpawnManager_sc : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    GameObject enemyContainer;

    [SerializeField]
    GameObject[] bonusPrefab;

    [SerializeField]
    private GameObject tripleShotBonusLaserPrefab;

    bool stopSpawning = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnRoutine());
        StartCoroutine(SpawnBonusRoutine());       
    }


    IEnumerator SpawnRoutine()
    {
        while (stopSpawning==false)
        {
            Vector3 position = new Vector3(Random.Range(-9.5f, 9.5f),
                                                                    7.4f, 0);

            GameObject enemy = Instantiate(enemyPrefab, position, Quaternion.identity);
            enemy.transform.parent = enemyContainer.transform;
            yield return new WaitForSeconds(5.0f);       //5 saniyeliğine kontrol unityye bırakılıyor                                                 
        }
    }


    public void OnPlayerDeath()
    {
        stopSpawning = true;
    }

    IEnumerator SpawnBonusRoutine()
    {
        while (stopSpawning == false)
        {
            
            int waitTime = Random.Range(5, 10);
            Debug.Log("Üçlü atış bekleme süresi:" + waitTime);
            yield return new WaitForSeconds(waitTime);

            Vector3 position = new Vector3(Random.Range(-9.18f, 9.18f),
                                                                    7.4f, 0); 
            
            int randomBonus=Random.Range(0,2);
            GameObject tripleShotBonus = Instantiate(bonusPrefab[randomBonus], position, Quaternion.identity);

        }

    }

    

}
