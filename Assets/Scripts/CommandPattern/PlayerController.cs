using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveDistance = 1f;
    public float rotateAngle = 45f;
    private CommandManager _commandManager;

    void Start()
    {
        _commandManager = new CommandManager();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Move(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Move(Vector3.back);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Move(Vector3.left);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Move(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Rotate(-rotateAngle);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Rotate(rotateAngle);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _commandManager.UndoCommand();
        }
    }

    private void Move(Vector3 direction)
    {
        ICommand moveCommand = new MoveCommand(transform, direction, moveDistance);
        _commandManager.ExecuteCommand(moveCommand);
    }

    private void Rotate(float angle)
    {
        ICommand rotateCommand = new RotateCommand(transform, angle);
        _commandManager.ExecuteCommand(rotateCommand);
    }
}
