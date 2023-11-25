using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject[] fruitprefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    [SerializeField] Transform Parent;

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
            GameObject gameObject = Instantiate(fruitprefab[Random.Range(0, fruitprefab.Length)], position, Quaternion.identity, Parent);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }
}
