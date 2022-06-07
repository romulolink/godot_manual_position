using Godot;
using System;

public class Move : MeshInstance
{
	// Declare member variables here. Examples:
	private float position_step = 2;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		position_step++;

		Spatial box = GetParent().GetNode<Spatial>("CubeCSScript");

		box.Translation = new Vector3(0.0f, position_step, 0.0f);
	}
}

