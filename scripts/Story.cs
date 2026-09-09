using Godot;
using System;

public partial class Story : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	using Godot;
using System;

public partial class StoryGame : Control
{
	private Label _storyLabel;
	private Button _choice1Button;
	private Button _choice2Button;

	private int _currentStoryStep = 0;

	public override void _Ready()
	{
		_storyLabel = GetNode<Label>("VBoxContainer/StoryLabel");
		_choice1Button = GetNode<Button>("VBoxContainer/Choice1Button");
		_choice2Button = GetNode<Button>("VBoxContainer/Choice2Button");

		DisplayStep(0);
	}

	private void DisplayStep(int step)
	{
		_currentStoryStep = step;
		_choice2Button.Visible = true;

		if (step == 0)
		{
			_storyLabel.Text = "You stand in front of a dark cave entrance. You hear a strange noise inside.";
			_choice1Button.Text = "Enter the cave";
			_choice2Button.Text = "Turn around and run home";
		}
		else if (step == 1)
		{
			_storyLabel.Text = "Inside the cave, you find a glowing treasure chest sitting on a pedestal!";
			_choice1Button.Text = "Open the chest";
			_choice2Button.Text = "Leave it alone and go back outside";
		}
		else if (step == 2)
		{
			_storyLabel.Text = "You ran safely back home and drank a cup of warm tea. The End!";
			_choice1Button.Text = "Play Again";
			_choice2Button.Visible = false; // Hide second button on end screen
		}
		else if (step == 3)
		{
			_storyLabel.Text = "The chest opens to reveal thousands of shiny gold coins! You win!";
			_choice1Button.Text = "Play Again";
			_choice2Button.Visible = false;
		}
	}

	private void _on_choice_1_button_pressed()
	{
		if (_currentStoryStep == 0) DisplayStep(1);        // Go to cave inside
		else if (_currentStoryStep == 1) DisplayStep(3);   // Open chest
		else if (_currentStoryStep == 2 || _currentStoryStep == 3) DisplayStep(0); // Restart
	}

	private void _on_choice_2_button_pressed()
	{
		if (_currentStoryStep == 0) DisplayStep(2);        // Run home
		else if (_currentStoryStep == 1) DisplayStep(0);   // Back to cave entrance
	}
}
}
