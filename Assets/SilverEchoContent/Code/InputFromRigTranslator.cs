using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputFromRigTranslator : MonoBehaviour
{

   
    public PlayerBallContoller ball_player_controller;


    [Header("Sensor Input Links")]
    public VirtualTouchPad ball_movement_touchpad;
    public VirtualTouchPad camera_movement_touchpad;



    public void SendMoveRequest()
    {

        // x - напрямки вліво вправо
        //y - напрямки вверх вниз
        //z - напрямки вперед назад

        Vector3 movement_direction = new Vector3(ball_movement_touchpad.pixel_delta.x , 0 , ball_movement_touchpad.pixel_delta.y );
        
        ball_player_controller.ball_movement_system.MoveByCamera(movement_direction);

    }
    public void SendRotateRequest() 
    {
        Vector2 rotate_direction = camera_movement_touchpad.pixel_delta;
        ball_player_controller.ball_camera_system.RotateByX(rotate_direction.y);
        ball_player_controller.ball_camera_system.RotateByY(rotate_direction.x);


    }

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        SendMoveRequest();
        SendRotateRequest();
    }
}
