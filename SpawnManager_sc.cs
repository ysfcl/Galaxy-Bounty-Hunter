using System.Collections;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class SpawnManager_sc : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    
    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            Vector3 position = new Vector3(Random.Range(-9.5f, 9.5f),
                                                                    7.4f, 0);

            GameObject enemy = Instantiate(enemyPrefab, position, Quaternion.identity);
            yield return new WaitForSeconds(5.0f);       //5 saniyeliğine kontrol unityye bırakılıyor                                                 
        }
    }

}
