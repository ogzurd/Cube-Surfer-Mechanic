using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideController : MonoBehaviour
{

    public GameObject lastCube;
    Vector3 cubePos;
    public List<GameObject> cubeList = new List<GameObject>();
    public List<Color> colorList = new List<Color>();
    

    
    private void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == "Bottom Cube") {
            GetCubeBlocks(other.gameObject);
        }
    }


    private void GetCubeBlocks(GameObject collidedCube) {

        transform.position = new Vector3(transform.position.x, transform.position.y + 1.1f, transform.position.z);
        collidedCube.transform.position = new Vector3(lastCube.transform.position.x, lastCube.transform.position.y - 1.1f, lastCube.transform.position.z); 
        
        collidedCube.transform.SetParent(transform);
        
        cubeList.Add(collidedCube);

        lastCube = cubeList[cubeList.Count - 1];

        ChangeBoxColor();
    
    }

    

    private void ChangeBoxColor() {
        int randomIndex = Random.Range(0, colorList.Count - 1);
        lastCube.GetComponent<MeshRenderer>().material.color = colorList[randomIndex];
    }






}
