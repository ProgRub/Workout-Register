
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
			this.LabelCompletionDateAndTime = new System.Windows.Forms.Label();
			this.DateTimePickerCompletionTime = new System.Windows.Forms.DateTimePicker();
			this.ComboBoxWorkouts = new System.Windows.Forms.ComboBox();
			this.ButtonAddWorkoutTime = new System.Windows.Forms.Button();
			this.DateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TextBoxNewWorkout
			// 
			this.TextBoxNewWorkout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxNewWorkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.TextBoxNewWorkout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanel1.SetColumnSpan(this.TextBoxNewWorkout, 4);
			this.TextBoxNewWorkout.Enabled = false;
			this.TextBoxNewWorkout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.TextBoxNewWorkout.Location = new System.Drawing.Point(127, 45);
			this.TextBoxNewWorkout.Name = "TextBoxNewWorkout";
			this.TextBoxNewWorkout.Size = new System.Drawing.Size(494, 24);
			this.TextBoxNewWorkout.TabIndex = 0;
			// 
			// LabelNewWorkoutName
			// 
			this.LabelNewWorkoutName.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.LabelNewWorkoutName.AutoSize = true;
			this.LabelNewWorkoutName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LabelNewWorkoutName.Location = new System.Drawing.Point(6, 40);
			this.LabelNewWorkoutName.Name = "LabelNewWorkoutName";
			this.LabelNewWorkoutName.Size = new System.Drawing.Size(115, 34);
			this.LabelNewWorkoutName.TabIndex = 1;
			this.LabelNewWorkoutName.Text = "New Workout Name";
			// 
			// LabelWorkouts
			// 
			this.LabelWorkouts.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.LabelWorkouts.AutoSize = true;
			this.LabelWorkouts.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LabelWorkouts.Location = new System.Drawing.Point(37, 10);
			this.LabelWorkouts.Name = "LabelWorkouts";
			this.LabelWorkouts.Size = new System.Drawing.Size(84, 17);
			this.LabelWorkouts.TabIndex = 2;
			this.LabelWorkouts.Text = "Workouts";
			// 
			// LabelCompletionDateAndTime
			// 
			this.LabelCompletionDateAndTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.LabelCompletionDateAndTime.AutoSize = true;
			this.LabelCompletionDateAndTime.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.LabelCompletionDateAndTime.Location = new System.Drawing.Point(19, 79);
			this.LabelCompletionDateAndTime.Name = "LabelCompletionDateAndTime";
			this.LabelCompletionDateAndTime.Size = new System.Drawing.Size(102, 34);
			this.LabelCompletionDateAndTime.TabIndex = 3;
			this.LabelCompletionDateAndTime.Text = "Completion Date && Time";
			// 
			// DateTimePickerCompletionTime
			// 
			this.DateTimePickerCompletionTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.DateTimePickerCompletionTime.CustomFormat = "";
			this.DateTimePickerCompletionTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.DateTimePickerCompletionTime.Location = new System.Drawing.Point(375, 84);
			this.DateTimePickerCompletionTime.Name = "DateTimePickerCompletionTime";
			this.DateTimePickerCompletionTime.ShowUpDown = true;
			this.DateTimePickerCompletionTime.Size = new System.Drawing.Size(118, 24);
			this.DateTimePickerCompletionTime.TabIndex = 4;
			this.DateTimePickerCompletionTime.Value = new System.DateTime(2021, 7, 23, 0, 0, 0, 0);
			// 
			// ComboBoxWorkouts
			// 
			this.ComboBoxWorkouts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ComboBoxWorkouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(91)))));
			this.tableLayoutPanel1.SetColumnSpan(this.ComboBoxWorkouts, 4);
			this.ComboBoxWorkouts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxWorkouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ComboBoxWorkouts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.ComboBoxWorkouts.FormattingEnabled = true;
			this.ComboBoxWorkouts.Location = new System.Drawing.Point(127, 7);
			this.ComboBoxWorkouts.Name = "ComboBoxWorkouts";
			this.ComboBoxWorkouts.Size = new System.Drawing.Size(494, 24);
			this.ComboBoxWorkouts.TabIndex = 5;
			this.ComboBoxWorkouts.DropDownClosed += new System.EventHandler(this.ComboBoxWorkouts_DropDownClosed);
			// 
			// ButtonAddWorkoutTime
			// 
			this.ButtonAddWorkoutTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonAddWorkoutTime.AutoSize = true;
			this.ButtonAddWorkoutTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ButtonAddWorkoutTime.BackColor = System.Drawing.Color.Transparent;
			this.ButtonAddWorkoutTime.FlatAppearance.BorderSize = 0;
			this.ButtonAddWorkoutTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.ButtonAddWorkoutTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.ButtonAddWorkoutTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonAddWorkoutTime.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ButtonAddWorkoutTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ButtonAddWorkoutTime.Location = new System.Drawing.Point(499, 82);
			this.ButtonAddWorkoutTime.Name = "ButtonAddWorkoutTime";
			this.ButtonAddWorkoutTime.Size = new System.Drawing.Size(122, 27);
			this.ButtonAddWorkoutTime.TabIndex = 6;
			this.ButtonAddWorkoutTime.Text = "Add Workout";
			this.ButtonAddWorkoutTime.UseVisualStyleBackColor = false;
			this.ButtonAddWorkoutTime.Click += new System.EventHandler(this.ButtonAddWorkoutTime_Click);
			// 
			// DateTimePickerDate
			// 
			this.DateTimePickerDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.SetColumnSpan(this.DateTimePickerDate, 2);
			this.DateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DateTimePickerDate.Location = new System.Drawing.Point(127, 84);
			this.DateTimePickerDate.Name = "DateTimePickerDate";
			this.DateTimePickerDate.Size = new System.Drawing.Size(242, 24);
			this.DateTimePickerDate.TabIndex = 7;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.LabelWorkouts, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.ButtonAddWorkoutTime, 4, 2);
			this.tableLayoutPanel1.Controls.Add(this.DateTimePickerDate, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.DateTimePickerCompletionTime, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.LabelNewWorkoutName, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.LabelCompletionDateAndTime, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.ComboBoxWorkouts, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.TextBoxNewWorkout, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 116);
			this.tableLayoutPanel1.TabIndex = 8;
			// 
			// Window
			// 
			this.AcceptButton = this.ButtonAddWorkoutTime;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(41)))));
			this.ClientSize = new System.Drawing.Size(624, 116);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(640, 155);
			this.Name = "Window";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "WorkoutRegister";
			this.Load += new System.EventHandler(this.Window_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TextBox TextBoxNewWorkout;
		private System.Windows.Forms.Label LabelNewWorkoutName;
		private System.Windows.Forms.Label LabelWorkouts;
		private System.Windows.Forms.Label LabelCompletionDateAndTime;
		private System.Windows.Forms.DateTimePicker DateTimePickerCompletionTime;
		private System.Windows.Forms.ComboBox ComboBoxWorkouts;
		private System.Windows.Forms.Button ButtonAddWorkoutTime;
		private System.Windows.Forms.DateTimePicker DateTimePickerDate;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

