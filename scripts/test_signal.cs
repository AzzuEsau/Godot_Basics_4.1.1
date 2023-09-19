using Godot;
using System;

public partial class test_signal : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		test t = this.GetParent<test>();
		t.PressKeyArgs += key_pressed;
		// t.Connect("PressKey", this, "key_pressed");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {

	}

	public void key_pressed(string caca) {
		GD.Print("pene y " + caca);
	}
}
