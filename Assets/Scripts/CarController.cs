using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour
{
   [SerializeField] 
   private Transform _target;
   [SerializeField]
   private Vector3 _moveLeftVector;
   [SerializeField]
   private Vector3 _moveRightVector;
   private float _speed = 10f;
   public bool isRight;
   public bool isLeft;

    void Update()
    {
        Vector3 MovePosition = new Vector3(_target.position.x, 0, -20f);
        
        if(Input.GetKey(KeyCode.A))
        {
            MoveLeft();
        }
        
        if(Input.GetKey(KeyCode.D))
        {
            MoveRight();
        }

        if(isRight)
        {
           MoveRight();
        }
        
        if(isLeft)
        {
           MoveLeft();
        }
        transform.LookAt(_target);
        transform.position = Vector3.MoveTowards(transform.position, MovePosition, Time.deltaTime*(_speed-0.5f)*3);
    }

    private void MoveRight()
    {
        if(_target.transform.position.x < 8.3f)
            {
                _target.transform.Translate(_moveRightVector*Time.deltaTime*_speed*1.4f); 
            }
    }
    private void MoveLeft()
    {
         if(_target.transform.position.x >-8.3f)
            {
                _target.transform.Translate(_moveLeftVector*Time.deltaTime*_speed*1.4f);
            }
    }
    public void TurnRight(bool isOn)
    {
        isRight = isOn;
    }

    public void TurnLeft(bool isOn)
    {
        isLeft = isOn;
    }
}
