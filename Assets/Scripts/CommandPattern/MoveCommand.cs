using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    private Transform _playerTransform;
    private Vector3 _direction;
    private float _distance;
    public MoveCommand(Transform playerTransform, Vector3 direction, float distance)
    {
        _playerTransform = playerTransform;
        _direction = direction;
        _distance = distance;
    }
    public void Execute()
    {
        _playerTransform.position += _direction * _distance;
    }

    public void Undo()
    {
        _playerTransform.position -= _direction * _distance;
    }

   
    
}
