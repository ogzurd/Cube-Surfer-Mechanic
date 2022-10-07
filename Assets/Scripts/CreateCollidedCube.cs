using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCollidedCube : MonoBehaviour
{



public GameObject collidedCubePrefab;
GameObject newCollidedCube;


    private void Start() {
        newCollidedCube = Instantiate(collidedCubePrefab, transform.position, Quaternion.identity);
        StartCoroutine(CreateCollidedCubes());
    }


    IEnumerator CreateCollidedCubes() {
        
        int i = 0;
        while (i <= 50) {
            
            yield return new WaitForSeconds(0.01f);

            float randomX = Random.Range(-4, 4);
            float randomZ = Random.Range(15, 200);
            newCollidedCube.transform.position = new Vector3(randomX, transform.position.y + 0.5f, randomZ);
            newCollidedCube = Instantiate(collidedCubePrefab, newCollidedCube.transform.position, Quaternion.identity);
            i++;
        }

    }







}
