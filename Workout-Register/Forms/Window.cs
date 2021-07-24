using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Forms
{
	public partial class Window : Form
	{
		private ICollection<WorkoutDTO> _workouts;

		public Window()
		{
			InitializeComponent();
		}

		private void Window_Load(object sender, EventArgs e)
		{
			_workouts = WorkoutService.Instance.GetWorkouts().ToList();
			foreach (var workout in _workouts)
			{
				ComboBoxWorkouts.Items.Add($"{workout.Id} - {workout.Name}");
			}

			ComboBoxWorkouts.Items.Add("New Workout");
		}

		private void ComboBoxWorkouts_DropDownClosed(object sender, EventArgs e)
		{
			TextBoxNewWorkout.Enabled = ComboBoxWorkouts.Text == "New Workout";
			TextBoxNewWorkout.Text = "";
		}

		private void ButtonAddWorkoutTime_Click(object sender, EventArgs e)
		{
			if (ComboBoxWorkouts.Text == "New Workout")
			{
				var newWorkout = new WorkoutDTO{Id=ComboBoxWorkouts.Items.Count,Name = TextBoxNewWorkout.Text,WorkoutDateTimes = new List<DateTime>()};
				WorkoutService.Instance.CreateNewWorkout(newWorkout,DateTimePickerCompletionTime.Value.TimeOfDay);
				_workouts.Add(newWorkout);
				ComboBoxWorkouts.Items.Insert(ComboBoxWorkouts.Items.Count-1,$"{newWorkout.Id} - {newWorkout.Name}");
				return;
			}
			WorkoutService.Instance.AddWorkoutTime(_workouts.First(e=>e.Id.ToString()==ComboBoxWorkouts.Text.Split(" - ")[0]),DateTimePickerCompletionTime.Value.TimeOfDay);
		}
	}
}