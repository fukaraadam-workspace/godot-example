using Godot;

public partial class MoveAround : Sprite2D
{
  private int _speed = 400;
  private float _angularSpeed = Mathf.Pi;

  public MoveAround()
  {
    GD.Print("Hello, world!");
  }

  public override void _Ready()
  {
    var timer = GetNode<Timer>("Timer");
    timer.Timeout += OnTimerTimeout;
  }

  public override void _Process(double delta)
  {
    Rotation += _angularSpeed * (float)delta;

    var velocity = Vector2.Up.Rotated(Rotation) * _speed;
    Position += velocity * (float)delta;
  }

  private void OnButtonPressed()
  {
    SetProcess(!IsProcessing());
  }

  private void OnTimerTimeout()
  {
    Visible = !Visible;
  }
}
