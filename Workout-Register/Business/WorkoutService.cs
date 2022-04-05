using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using DB;
using DB.Entities;
using DB.Repositories.Implementations;
using DB.Repositories.Interfaces;

namespace Business
{
	public class WorkoutService
	{
		private readonly IWorkoutRepository _workoutRepository;
		private readonly ICollection<WorkoutDTO> _addedWorkouts=new List<WorkoutDTO>();

		private WorkoutService()
		{
			_workoutRepository = new WorkoutRepository(Database.GetContext());
		}

		public static WorkoutService Instance { get; } = new();


		public IEnumerable<WorkoutDTO> GetWorkouts()
		{
			return _workoutRepository.GetAll().Select(WorkoutDTO.ConvertWorkoutToDTO);
		}

		public void AddWorkoutTime(WorkoutDTO workout, DateTime dateTime)
		{
			if (_workoutRepository.GetById(workout.Id) != null)
			{
				_workoutRepository.AddTimeToWorkoutById(workout.Id,dateTime);
			}
			else
			{
				_addedWorkouts.First(e=>e.Name==workout.Name).WorkoutDateTimes.Add(dateTime);
			}
		}

		public void CreateNewWorkout(WorkoutDTO newWorkout,DateTime dateTime)
		{
			_addedWorkouts.Add(new WorkoutDTO{Name = newWorkout.Name,WorkoutDateTimes = new HashSet<DateTime>()});
			AddWorkoutTime(newWorkout,dateTime);
		}

		public void SaveChanges()
		{
			foreach (var workout in _addedWorkouts)
			{
				_workoutRepository.Add(new Workout{Name = workout.Name,WorkoutDateTimes = workout.WorkoutDateTimes});
			}
			_workoutRepository.SaveChanges();
		}
	}
}