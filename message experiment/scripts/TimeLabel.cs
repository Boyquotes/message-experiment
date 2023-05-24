using Godot;
using System;

public partial class TimeLabel : Label
{
	public override void _Process(double delta){
		Text = $"Current Time: {Time.GetTimeStringFromSystem()}";
	}
}
