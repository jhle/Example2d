using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    public Camera MainCamera;
    public GameObject coinPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        StartCoroutine(coinWave());
    }


    private void spawnCoin()
    {
        GameObject coin = Instantiate(coinPrefab) as GameObject;
        coin.transform.position = new Vector2( Random.Range(-screenBounds.x, screenBounds.x),screenBounds.y);
            
        
    }
    IEnumerator coinWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnCoin();
        }
 
    }
}
