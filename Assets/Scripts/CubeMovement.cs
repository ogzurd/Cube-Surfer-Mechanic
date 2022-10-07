using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    
    public BoxCollider planeCollider;
    private Vector3 _direction;
    private float newPositionX;
    private void Start() {
        
    }

    private void FixedUpdate() {
        GetBoundsRange();
        Move(); 
    }


    private void Move() { 
        

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){ 
            _direction = Vector3.left * 3f;
            transform.Translate(Vector3.forward * Time.fixedDeltaTime);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){ 
            _direction = Vector3.right * 3f;
            transform.Translate(Vector3.forward * Time.fixedDeltaTime);
        }
        else { 
            _direction = Vector3.forward;
        }
        
        transform.Translate(_direction * Time.fixedDeltaTime * 5f);
    
    } 


    private void GetBoundsRange() { 
        // -4.5 , 4.5
        newPositionX = Mathf.Clamp(transform.position.x, -4f, 4f);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);

    }
        
}
    



