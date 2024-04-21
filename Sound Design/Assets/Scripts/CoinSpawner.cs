using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnTime;

    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(spawnCoin());
    }


    IEnumerator spawnCoin()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            Debug.Log("guanch");
            Instantiate(coinPrefab, new Vector3(10, 0.2f, 0), Quaternion.identity, gameObject.transform);
        }
    }
}
