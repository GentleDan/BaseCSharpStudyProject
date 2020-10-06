namespace laba_kamyshov
{
    partial class ExcavatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcavatorForm));
            this.pictureBoxEx = new System.Windows.Forms.PictureBox();
            this.button_Up = new System.Windows.Forms.Button();
            this.button_Left = new System.Windows.Forms.Button();
            this.button_Down = new System.Windows.Forms.Button();
            this.button_Right = new System.Windows.Forms.Button();
            this.CreateTrackedVehicle_button = new System.Windows.Forms.Button();
            this.CreateExcavator_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEx)).BeginInit();
            this.SuspendLayout();
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
            // button_Up
            // 
            this.button_Up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Up.BackgroundImage")));
            this.button_Up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Up.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_Up.Location = new System.Drawing.Point(711, 310);
            this.button_Up.Name = "button_Up";
            this.button_Up.Size = new System.Drawing.Size(30, 30);
            this.button_Up.TabIndex = 1;
            this.button_Up.UseVisualStyleBackColor = true;
            this.button_Up.Click += new System.EventHandler(this.button_Move_Click);
            // 
            // button_Left
            // 
            this.button_Left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Left.BackgroundImage")));
            this.button_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Left.Location = new System.Drawing.Point(673, 346);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(30, 30);
            this.button_Left.TabIndex = 2;
            this.button_Left.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_Left.UseVisualStyleBackColor = true;
            this.button_Left.Click += new System.EventHandler(this.button_Move_Click);
            // 
            // button_Down
            // 
            this.button_Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Down.BackgroundImage")));
            this.button_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Down.Location = new System.Drawing.Point(711, 382);
            this.button_Down.Name = "button_Down";
            this.button_Down.Size = new System.Drawing.Size(30, 30);
            this.button_Down.TabIndex = 3;
            this.button_Down.UseVisualStyleBackColor = true;
            this.button_Down.Click += new System.EventHandler(this.button_Move_Click);
            // 
            // button_Right
            // 
            this.button_Right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Right.BackgroundImage")));
            this.button_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Right.Location = new System.Drawing.Point(749, 346);
            this.button_Right.Name = "button_Right";
            this.button_Right.Size = new System.Drawing.Size(30, 30);
            this.button_Right.TabIndex = 4;
            this.button_Right.UseVisualStyleBackColor = true;
            this.button_Right.Click += new System.EventHandler(this.button_Move_Click);
            // 
            // CreateTrackedVehicle_button
            // 
            this.CreateTrackedVehicle_button.Location = new System.Drawing.Point(12, 12);
            this.CreateTrackedVehicle_button.Name = "CreateTrackedVehicle_button";
            this.CreateTrackedVehicle_button.Size = new System.Drawing.Size(98, 27);
            this.CreateTrackedVehicle_button.TabIndex = 5;
            this.CreateTrackedVehicle_button.Text = "Create Tracked";
            this.CreateTrackedVehicle_button.UseVisualStyleBackColor = true;
            this.CreateTrackedVehicle_button.Click += new System.EventHandler(this.CreateTrackedVehicle_button_Click);
            // 
            // CreateExcavator_button
            // 
            this.CreateExcavator_button.Location = new System.Drawing.Point(132, 12);
            this.CreateExcavator_button.Name = "CreateExcavator_button";
            this.CreateExcavator_button.Size = new System.Drawing.Size(98, 27);
            this.CreateExcavator_button.TabIndex = 6;
            this.CreateExcavator_button.Text = "Create Excavator";
            this.CreateExcavator_button.UseVisualStyleBackColor = true;
            this.CreateExcavator_button.Click += new System.EventHandler(this.CreateExcavator_button_Click);
            // 
            // ExcavatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateExcavator_button);
            this.Controls.Add(this.CreateTrackedVehicle_button);
            this.Controls.Add(this.button_Right);
            this.Controls.Add(this.button_Down);
            this.Controls.Add(this.button_Left);
            this.Controls.Add(this.button_Up);
            this.Controls.Add(this.pictureBoxEx);
            this.Name = "ExcavatorForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEx;
        private System.Windows.Forms.Button button_Up;
        private System.Windows.Forms.Button button_Left;
        private System.Windows.Forms.Button button_Down;
        private System.Windows.Forms.Button button_Right;
        private System.Windows.Forms.Button CreateTrackedVehicle_button;
        private System.Windows.Forms.Button CreateExcavator_button;
    }
}