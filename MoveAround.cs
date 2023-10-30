using Godot;

public partial class MoveAround : Sprite2D
{
  private int _speed = 400;
  private float _angularSpeed = Mathf.Pi;

  public MoveAround()
  {
    GD.Print("Hello, world!");
  }

  public override void _Process(double delta)
  {
    Rotation += _angularSpeed * (float)delta;

    var velocity = Vector2.Up.Rotated(Rotation) * _speed;
    Position += velocity * (float)delta;
  }
}
