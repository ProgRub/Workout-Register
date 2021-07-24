using System;
using System.Collections.Generic;
using DB.Entities;

namespace Business
{
	public class WorkoutDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<DateTime> WorkoutDateTimes { get; set; }

		internal static WorkoutDTO ConvertWorkoutToDTO(Workout workout)
		{
			return new()
			{
				Id = workout.Id, Name = workout.Name, WorkoutDateTimes = workout.WorkoutDateTimes
			};
		}
	}
}