using UnityEngine;
using JoshKart.InputSystems;

public class TouchScreenInput : BaseInput
{
    public Joystick steering;
    public JoyconButton gasButton;
    public JoyconButton brakeButton;

    public override InputData GenerateInput()
    {
        return new InputData()
        {
            Accelerate = gasButton.IsPressed,
            Brake = brakeButton.IsPressed,
            TurnInput = steering.Horizontal
        };
    }
}
