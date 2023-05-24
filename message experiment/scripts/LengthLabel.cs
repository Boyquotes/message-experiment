using Godot;
using System;

public partial class LengthLabel : Label
{
	private TextEdit Message;
	
	public override void _Ready(){
		Message = GetTree().Root.GetNode<TextEdit>("Main/Control/Message Section/TextEdit");
	}
	
	public override void _Process(double delta){
		Text = $"Message Length: {Message.Text.Length}";
	}
}
