using Godot;
using Godot.Collections;
using System;
using System.Collections.Generic;

public partial class Save : Node {
	public const string saveFile = "user://SAVEFILE.SAVE";
	public Godot.Collections.Dictionary<string, int> gameData = new Godot.Collections.Dictionary<string, int>() {
		{"number", 30},
		{"playerLevel", 0},
		{"playerWeapon", 12},
		{"maxHP", 100},
	};



	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		Load();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta) {
	}

	public void Load() {
		FileAccess file = FileAccess.Open(saveFile, FileAccess.ModeFlags.Read);
		if(file == null)
			SaveData();
		else {
			gameData = (Godot.Collections.Dictionary<string, int>)file.GetVar();
			GD.Print(gameData["number"]);
		}
	}

	public void SaveData() {
		FileAccess file = FileAccess.Open(saveFile, FileAccess.ModeFlags.Write);
		file.StoreVar(gameData, true);
		file = null;
	}

	public int GetNumber() => gameData["number"];
}
