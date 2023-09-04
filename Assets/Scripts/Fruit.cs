using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField] GameObject[] fruitprefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;

    void Start()
    {
        StartCoroutine(FruitSpawn());
    }

    IEnumerator FruitSpawn()
    {
        while (true) 
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(fruitprefab[Random.Range(0, fruitprefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }
}
