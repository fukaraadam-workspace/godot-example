using Godot;

public partial class ScriptNet : Sprite2D
{
	private int _speed = 400;
	private float _angularSpeed = Mathf.Pi;

	public ScriptNet()
	{
		GD.Print("Hello, world!");
	}

	public override void _Process(double delta)
	{
		Rotation += _angularSpeed * (float)delta;
	}
}
