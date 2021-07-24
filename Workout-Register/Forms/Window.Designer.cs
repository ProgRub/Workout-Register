
namespace Forms
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
			this.TextBoxNewWorkout = new System.Windows.Forms.TextBox();
			this.LabelNewWorkoutName = new System.Windows.Forms.Label();
			this.LabelWorkouts = new System.Windows.Forms.Label();
			this.LabelCompletionTime = new System.Windows.Forms.Label();
			this.DateTimePickerCompletionTime = new System.Windows.Forms.DateTimePicker();
			this.ComboBoxWorkouts = new System.Windows.Forms.ComboBox();
			this.ButtonAddWorkoutTime = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TextBoxNewWorkout
			// 
			this.TextBoxNewWorkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxNewWorkout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBoxNewWorkout.Enabled = false;
			this.TextBoxNewWorkout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxNewWorkout.Location = new System.Drawing.Point(179, 39);
			this.TextBoxNewWorkout.Name = "TextBoxNewWorkout";
			this.TextBoxNewWorkout.Size = new System.Drawing.Size(439, 24);
			this.TextBoxNewWorkout.TabIndex = 0;
			// 
			// LabelNewWorkoutName
			// 
			this.LabelNewWorkoutName.AutoSize = true;
			this.LabelNewWorkoutName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LabelNewWorkoutName.Location = new System.Drawing.Point(10, 41);
			this.LabelNewWorkoutName.Name = "LabelNewWorkoutName";
			this.LabelNewWorkoutName.Size = new System.Drawing.Size(163, 17);
			this.LabelNewWorkoutName.TabIndex = 1;
			this.LabelNewWorkoutName.Text = "New Workout Name";
			// 
			// LabelWorkouts
			// 
			this.LabelWorkouts.AutoSize = true;
			this.LabelWorkouts.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LabelWorkouts.Location = new System.Drawing.Point(89, 9);
			this.LabelWorkouts.Name = "LabelWorkouts";
			this.LabelWorkouts.Size = new System.Drawing.Size(84, 17);
			this.LabelWorkouts.TabIndex = 2;
			this.LabelWorkouts.Text = "Workouts";
			// 
			// LabelCompletionTime
			// 
			this.LabelCompletionTime.AutoSize = true;
			this.LabelCompletionTime.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LabelCompletionTime.Location = new System.Drawing.Point(35, 75);
			this.LabelCompletionTime.Name = "LabelCompletionTime";
			this.LabelCompletionTime.Size = new System.Drawing.Size(138, 17);
			this.LabelCompletionTime.TabIndex = 3;
			this.LabelCompletionTime.Text = "Completion Time";
			// 
			// DateTimePickerCompletionTime
			// 
			this.DateTimePickerCompletionTime.CustomFormat = "";
			this.DateTimePickerCompletionTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.DateTimePickerCompletionTime.Location = new System.Drawing.Point(179, 69);
			this.DateTimePickerCompletionTime.Name = "DateTimePickerCompletionTime";
			this.DateTimePickerCompletionTime.ShowUpDown = true;
			this.DateTimePickerCompletionTime.Size = new System.Drawing.Size(96, 24);
			this.DateTimePickerCompletionTime.TabIndex = 4;
			this.DateTimePickerCompletionTime.Value = new System.DateTime(2021, 7, 23, 0, 0, 0, 0);
			// 
			// ComboBoxWorkouts
			// 
			this.ComboBoxWorkouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.ComboBoxWorkouts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxWorkouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ComboBoxWorkouts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.ComboBoxWorkouts.FormattingEnabled = true;
			this.ComboBoxWorkouts.Location = new System.Drawing.Point(179, 6);
			this.ComboBoxWorkouts.Name = "ComboBoxWorkouts";
			this.ComboBoxWorkouts.Size = new System.Drawing.Size(439, 24);
			this.ComboBoxWorkouts.TabIndex = 5;
			this.ComboBoxWorkouts.DropDownClosed += new System.EventHandler(this.ComboBoxWorkouts_DropDownClosed);
			// 
			// ButtonAddWorkoutTime
			// 
			this.ButtonAddWorkoutTime.AutoSize = true;
			this.ButtonAddWorkoutTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonAddWorkoutTime.BackColor = System.Drawing.Color.Transparent;
			this.ButtonAddWorkoutTime.FlatAppearance.BorderSize = 0;
			this.ButtonAddWorkoutTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonAddWorkoutTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonAddWorkoutTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonAddWorkoutTime.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonAddWorkoutTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonAddWorkoutTime.Location = new System.Drawing.Point(342, 69);
			this.ButtonAddWorkoutTime.Name = "ButtonAddWorkoutTime";
			this.ButtonAddWorkoutTime.Size = new System.Drawing.Size(122, 27);
			this.ButtonAddWorkoutTime.TabIndex = 6;
			this.ButtonAddWorkoutTime.Text = "Add Workout";
			this.ButtonAddWorkoutTime.UseVisualStyleBackColor = false;
			this.ButtonAddWorkoutTime.Click += new System.EventHandler(this.ButtonAddWorkoutTime_Click);
			// 
			// Window
			// 
			this.AcceptButton = this.ButtonAddWorkoutTime;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(41)))));
			this.ClientSize = new System.Drawing.Size(639, 101);
			this.Controls.Add(this.ButtonAddWorkoutTime);
			this.Controls.Add(this.ComboBoxWorkouts);
			this.Controls.Add(this.DateTimePickerCompletionTime);
			this.Controls.Add(this.LabelCompletionTime);
			this.Controls.Add(this.LabelWorkouts);
			this.Controls.Add(this.LabelNewWorkoutName);
			this.Controls.Add(this.TextBoxNewWorkout);
			this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Window";
			this.Text = "WorkoutRegister";
			this.Load += new System.EventHandler(this.Window_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TextBox TextBoxNewWorkout;
		private System.Windows.Forms.Label LabelNewWorkoutName;
		private System.Windows.Forms.Label LabelWorkouts;
		private System.Windows.Forms.Label LabelCompletionTime;
		private System.Windows.Forms.DateTimePicker DateTimePickerCompletionTime;
		private System.Windows.Forms.ComboBox ComboBoxWorkouts;
		private System.Windows.Forms.Button ButtonAddWorkoutTime;
	}
}

