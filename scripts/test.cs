using Godot;
using System;

public partial class test : Node2D {
	
	[Signal] public delegate void PressKeyEventHandler();
	[Signal] public delegate void PressKeyArgsEventHandler(string caca);


	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		PressKey += _on_PressKeyEventHandler;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
		// Position = new Vector2(Position.X, Position.Y + 0.1f);
		Save s = (Save)GetNode("/root/Save");
		Position = new Vector2(Position.X, s.gameData["number"]);
		

		if (Input.IsActionJustPressed("ui_accept")) {
			EmitSignal("PressKey");
			EmitSignal("PressKeyArgs", "caca");
		}
	}

	// Este es el método que manejará la señal "PressKeyEventHandler".
	private void _on_PressKeyEventHandler()
	{
		GD.Print("PressKeyEventHandler");
	}

}
