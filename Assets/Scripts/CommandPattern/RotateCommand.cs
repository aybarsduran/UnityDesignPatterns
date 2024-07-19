using UnityEngine;

public class RotateCommand : ICommand
{
    private Transform _playerTransform;
    private float _angle;

    public RotateCommand(Transform playerTransform, float angle)
    {
        _playerTransform = playerTransform;
        _angle = angle;
    }

    public void Execute()
    {
        _playerTransform.Rotate(Vector3.up, _angle);
    }

    public void Undo()
    {
        _playerTransform.Rotate(Vector3.up, -_angle);
    }
}
