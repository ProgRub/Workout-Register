﻿using System;
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
		private IWorkoutRepository _workoutRepository;
		private ICollection<WorkoutDTO> _addedWorkouts=new List<WorkoutDTO>();

		private WorkoutService()
		{
			_workoutRepository = new WorkoutRepository(Database.GetContext());
		}

		public static WorkoutService Instance { get; } = new();


		public IEnumerable<WorkoutDTO> GetWorkouts()
		{
			return _workoutRepository.GetAll().Select(WorkoutDTO.ConvertWorkoutToDTO);
		}

		public void AddWorkoutTime(WorkoutDTO workout, TimeSpan time)
		{
			try
			{
				var workoutInDB = _workoutRepository.GetById(workout.Id);
				workoutInDB.WorkoutDateTimes.Add(DateTime.Today.Date.Add(time));
			}
			catch (NullReferenceException)
			{
				_addedWorkouts.First(e=>e.Name==workout.Name).WorkoutDateTimes.Add(DateTime.Today.Date.Add(time));
			}
		}

		public void CreateNewWorkout(WorkoutDTO newWorkout,TimeSpan time)
		{
			_addedWorkouts.Add(new WorkoutDTO{Name = newWorkout.Name,WorkoutDateTimes = new List<DateTime>()});
			AddWorkoutTime(newWorkout,time);
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