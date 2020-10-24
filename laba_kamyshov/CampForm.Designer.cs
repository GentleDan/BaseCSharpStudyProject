namespace laba_kamyshov
{
    partial class CampForm
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
            this.pictureCampBox = new System.Windows.Forms.PictureBox();
            this.parkTracked = new System.Windows.Forms.Button();
            this.parkExcavator = new System.Windows.Forms.Button();
            this.placeGroupBox = new System.Windows.Forms.GroupBox();
            this.takeExcavator = new System.Windows.Forms.Button();
            this.placeCount = new System.Windows.Forms.MaskedTextBox();
            this.place = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCampBox)).BeginInit();
            this.placeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureCampBox
            // 
            this.pictureCampBox.BackColor = System.Drawing.Color.White;
            this.pictureCampBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureCampBox.Location = new System.Drawing.Point(0, 0);
            this.pictureCampBox.Name = "pictureCampBox";
            this.pictureCampBox.Size = new System.Drawing.Size(890, 525);
            this.pictureCampBox.TabIndex = 0;
            this.pictureCampBox.TabStop = false;
            // 
            // parkTracked
            // 
            this.parkTracked.Location = new System.Drawing.Point(896, 12);
            this.parkTracked.Name = "parkTracked";
            this.parkTracked.Size = new System.Drawing.Size(135, 49);
            this.parkTracked.TabIndex = 1;
            this.parkTracked.Text = "Припарковать гусеничную машину";
            this.parkTracked.UseVisualStyleBackColor = true;
            this.parkTracked.Click += new System.EventHandler(this.parkTracked_Click);
            // 
            // parkExcavator
            // 
            this.parkExcavator.Location = new System.Drawing.Point(896, 67);
            this.parkExcavator.Name = "parkExcavator";
            this.parkExcavator.Size = new System.Drawing.Size(135, 63);
            this.parkExcavator.TabIndex = 2;
            this.parkExcavator.Text = "Припарковать экскаватор ";
            this.parkExcavator.UseVisualStyleBackColor = true;
            this.parkExcavator.Click += new System.EventHandler(this.parkExcavator_Click);
            // 
            // placeGroupBox
            // 
            this.placeGroupBox.Controls.Add(this.takeExcavator);
            this.placeGroupBox.Controls.Add(this.placeCount);
            this.placeGroupBox.Controls.Add(this.place);
            this.placeGroupBox.Location = new System.Drawing.Point(896, 154);
            this.placeGroupBox.Name = "placeGroupBox";
            this.placeGroupBox.Size = new System.Drawing.Size(135, 100);
            this.placeGroupBox.TabIndex = 3;
            this.placeGroupBox.TabStop = false;
            this.placeGroupBox.Text = "Забрать экскаватор";
            // 
            // takeExcavator
            // 
            this.takeExcavator.Location = new System.Drawing.Point(25, 71);
            this.takeExcavator.Name = "takeExcavator";
            this.takeExcavator.Size = new System.Drawing.Size(75, 23);
            this.takeExcavator.TabIndex = 2;
            this.takeExcavator.Text = "Забрать";
            this.takeExcavator.UseVisualStyleBackColor = true;
            this.takeExcavator.Click += new System.EventHandler(this.takeExcavator_Click);
            // 
            // placeCount
            // 
            this.placeCount.Location = new System.Drawing.Point(75, 39);
            this.placeCount.Mask = "00";
            this.placeCount.Name = "placeCount";
            this.placeCount.Size = new System.Drawing.Size(25, 20);
            this.placeCount.TabIndex = 1;
            this.placeCount.ValidatingType = typeof(int);
            // 
            // place
            // 
            this.place.AutoSize = true;
            this.place.Location = new System.Drawing.Point(27, 42);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(42, 13);
            this.place.TabIndex = 0;
            this.place.Text = "Место:";
            // 
            // CampForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 525);
            this.Controls.Add(this.placeGroupBox);
            this.Controls.Add(this.parkExcavator);
            this.Controls.Add(this.parkTracked);
            this.Controls.Add(this.pictureCampBox);
            this.Name = "CampForm";
            this.Text = "Стоянка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCampBox)).EndInit();
            this.placeGroupBox.ResumeLayout(false);
            this.placeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCampBox;
        private System.Windows.Forms.Button parkTracked;
        private System.Windows.Forms.Button parkExcavator;
        private System.Windows.Forms.GroupBox placeGroupBox;
        private System.Windows.Forms.Button takeExcavator;
        private System.Windows.Forms.MaskedTextBox placeCount;
        private System.Windows.Forms.Label place;
    }
}