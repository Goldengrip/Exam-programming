using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static Manager _gamecontrols;

    public static void Init(BallManager myPlayer)

    {
        _gamecontrols = new Manager();


        // Connects input action to code
        _gamecontrols.InGame.Movement.performed += jeff =>
        {

            myPlayer.SetMovementDirection(jeff.ReadValue<Vector3>());
        };
    }
    public static void SetManager()
    {
        _gamecontrols.InGame.Enable();

    }

}
