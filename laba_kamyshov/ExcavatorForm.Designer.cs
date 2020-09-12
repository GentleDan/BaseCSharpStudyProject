namespace laba_kamyshov
{
	partial class ExcavatorForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.Up_Button = new System.Windows.Forms.Button();
            this.Right_Button = new System.Windows.Forms.Button();
            this.Left_Button = new System.Windows.Forms.Button();
            this.Down_Button = new System.Windows.Forms.Button();
            this.Create_button = new System.Windows.Forms.Button();
            this.button_Left = new System.Windows.Forms.Button();
            this.button_Down = new System.Windows.Forms.Button();
            this.button_Up = new System.Windows.Forms.Button();
            this.button_Right = new System.Windows.Forms.Button();
            this.pictureBoxEx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEx)).BeginInit();
            this.SuspendLayout();
            // 
            // Up_Button
            // 
            this.Up_Button.Location = new System.Drawing.Point(0, 0);
            this.Up_Button.Name = "Up_Button";
            this.Up_Button.Size = new System.Drawing.Size(75, 23);
            this.Up_Button.TabIndex = 9;
            // 
            // Right_Button
            // 
            this.Right_Button.Location = new System.Drawing.Point(0, 0);
            this.Right_Button.Name = "Right_Button";
            this.Right_Button.Size = new System.Drawing.Size(75, 23);
            this.Right_Button.TabIndex = 8;
            // 
            // Left_Button
            // 
            this.Left_Button.Location = new System.Drawing.Point(0, 0);
            this.Left_Button.Name = "Left_Button";
            this.Left_Button.Size = new System.Drawing.Size(75, 23);
            this.Left_Button.TabIndex = 7;
            // 
            // Down_Button
            // 
            this.Down_Button.Location = new System.Drawing.Point(0, 0);
            this.Down_Button.Name = "Down_Button";
            this.Down_Button.Size = new System.Drawing.Size(75, 23);
            this.Down_Button.TabIndex = 6;
            // 
            // Create_button
            // 
            this.Create_button.Location = new System.Drawing.Point(0, 0);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(75, 23);
            this.Create_button.TabIndex = 5;
            this.Create_button.Text = "Create";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // button_Left
            // 
            this.button_Left.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.left;
            this.button_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Left.Location = new System.Drawing.Point(676, 372);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(30, 30);
            this.button_Left.TabIndex = 13;
            this.button_Left.UseVisualStyleBackColor = true;
            this.button_Left.Click += new System.EventHandler(this.MoveExcavator);
            // 
            // button_Down
            // 
            this.button_Down.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.down;
            this.button_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Down.Location = new System.Drawing.Point(705, 408);
            this.button_Down.Name = "button_Down";
            this.button_Down.Size = new System.Drawing.Size(30, 30);
            this.button_Down.TabIndex = 12;
            this.button_Down.UseVisualStyleBackColor = true;
            this.button_Down.Click += new System.EventHandler(this.MoveExcavator);
            // 
            // button_Up
            // 
            this.button_Up.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.up;
            this.button_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Up.Location = new System.Drawing.Point(705, 336);
            this.button_Up.Name = "button_Up";
            this.button_Up.Size = new System.Drawing.Size(30, 30);
            this.button_Up.TabIndex = 11;
            this.button_Up.UseVisualStyleBackColor = true;
            this.button_Up.Click += new System.EventHandler(this.MoveExcavator);
            // 
            // button_Right
            // 
            this.button_Right.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.right;
            this.button_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Right.Location = new System.Drawing.Point(733, 372);
            this.button_Right.Name = "button_Right";
            this.button_Right.Size = new System.Drawing.Size(30, 30);
            this.button_Right.TabIndex = 10;
            this.button_Right.UseVisualStyleBackColor = true;
            this.button_Right.Click += new System.EventHandler(this.MoveExcavator);
            // 
            // pictureBoxEx
            // 
            this.pictureBoxEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxEx.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEx.Name = "pictureBoxEx";
            this.pictureBoxEx.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxEx.TabIndex = 0;
            this.pictureBoxEx.TabStop = false;
            // 
            // ExcavatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Left);
            this.Controls.Add(this.button_Down);
            this.Controls.Add(this.button_Up);
            this.Controls.Add(this.button_Right);
            this.Controls.Add(this.Create_button);
            this.Controls.Add(this.Down_Button);
            this.Controls.Add(this.Left_Button);
            this.Controls.Add(this.Right_Button);
            this.Controls.Add(this.Up_Button);
            this.Controls.Add(this.pictureBoxEx);
            this.Name = "ExcavatorForm";
            this.Text = "ExcavatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEx)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxEx;
		private System.Windows.Forms.Button Up_Button;
		private System.Windows.Forms.Button Right_Button;
		private System.Windows.Forms.Button Left_Button;
		private System.Windows.Forms.Button Down_Button;
		private System.Windows.Forms.Button Create_button;
		private System.Windows.Forms.Button button_Right;
		private System.Windows.Forms.Button button_Up;
		private System.Windows.Forms.Button button_Down;
		private System.Windows.Forms.Button button_Left;
	}
}

