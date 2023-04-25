using UnityEngine;

public class STEP :  MonoBehaviour, ICommand
{
    private Transform _model;
    public STEP(Transform model)
    {
        _model = model;
    }
    public  void Execute() => _model.position += new Vector3(0, 50f, 0) * 100f;
    public  void Undo() => _model.position -= new Vector3(0, 50f, 0) * 100f;
}