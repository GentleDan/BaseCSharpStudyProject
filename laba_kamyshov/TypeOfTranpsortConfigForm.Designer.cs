namespace laba_kamyshov
{
    partial class TypeOfTranpsortConfigForm
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
            this.groupBoxTypeOfTransport = new System.Windows.Forms.GroupBox();
            this.ExcavatorLable = new System.Windows.Forms.Label();
            this.TrackedVehicleLable = new System.Windows.Forms.Label();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.CheckBoxAttachFlasher = new System.Windows.Forms.CheckBox();
            this.CheckBoxAttachStand = new System.Windows.Forms.CheckBox();
            this.CheckBoxAttachLadle = new System.Windows.Forms.CheckBox();
            this.ChooseWeight = new System.Windows.Forms.NumericUpDown();
            this.ChooseMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.WeightTransport = new System.Windows.Forms.Label();
            this.MaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxTransport = new System.Windows.Forms.PictureBox();
            this.panelTransport = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelColorBlue = new System.Windows.Forms.Panel();
            this.panelColorGreen = new System.Windows.Forms.Panel();
            this.panelColorOrange = new System.Windows.Forms.Panel();
            this.panelColorGray = new System.Windows.Forms.Panel();
            this.panelColorWhite = new System.Windows.Forms.Panel();
            this.panelColorBlack = new System.Windows.Forms.Panel();
            this.panelColorYellow = new System.Windows.Forms.Panel();
            this.panelColorRed = new System.Windows.Forms.Panel();
            this.AdditionalColorLable = new System.Windows.Forms.Label();
            this.MainColorLable = new System.Windows.Forms.Label();
            this.ButtonAddTransport = new System.Windows.Forms.Button();
            this.ButtonCancelChoose = new System.Windows.Forms.Button();
            this.groupBoxTypeOfTransport.SuspendLayout();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransport)).BeginInit();
            this.panelTransport.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTypeOfTransport
            // 
            this.groupBoxTypeOfTransport.Controls.Add(this.ExcavatorLable);
            this.groupBoxTypeOfTransport.Controls.Add(this.TrackedVehicleLable);
            this.groupBoxTypeOfTransport.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTypeOfTransport.Name = "groupBoxTypeOfTransport";
            this.groupBoxTypeOfTransport.Size = new System.Drawing.Size(203, 222);
            this.groupBoxTypeOfTransport.TabIndex = 0;
            this.groupBoxTypeOfTransport.TabStop = false;
            this.groupBoxTypeOfTransport.Text = "Тип транспорта";
            // 
            // ExcavatorLable
            // 
            this.ExcavatorLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExcavatorLable.Location = new System.Drawing.Point(47, 133);
            this.ExcavatorLable.Name = "ExcavatorLable";
            this.ExcavatorLable.Size = new System.Drawing.Size(99, 54);
            this.ExcavatorLable.TabIndex = 1;
            this.ExcavatorLable.Text = "Экскаватор";
            this.ExcavatorLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExcavatorLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExcavatorLable_MouseDown);
            // 
            // TrackedVehicleLable
            // 
            this.TrackedVehicleLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrackedVehicleLable.Location = new System.Drawing.Point(47, 41);
            this.TrackedVehicleLable.Name = "TrackedVehicleLable";
            this.TrackedVehicleLable.Size = new System.Drawing.Size(99, 54);
            this.TrackedVehicleLable.TabIndex = 0;
            this.TrackedVehicleLable.Text = "Гусеничная машина";
            this.TrackedVehicleLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TrackedVehicleLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrackedVehicleLable_MouseDown);
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.CheckBoxAttachFlasher);
            this.groupBoxParameters.Controls.Add(this.CheckBoxAttachStand);
            this.groupBoxParameters.Controls.Add(this.CheckBoxAttachLadle);
            this.groupBoxParameters.Controls.Add(this.ChooseWeight);
            this.groupBoxParameters.Controls.Add(this.ChooseMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.WeightTransport);
            this.groupBoxParameters.Controls.Add(this.MaxSpeed);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 271);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(534, 131);
            this.groupBoxParameters.TabIndex = 1;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // CheckBoxAttachFlasher
            // 
            this.CheckBoxAttachFlasher.AutoSize = true;
            this.CheckBoxAttachFlasher.Location = new System.Drawing.Point(312, 97);
            this.CheckBoxAttachFlasher.Name = "CheckBoxAttachFlasher";
            this.CheckBoxAttachFlasher.Size = new System.Drawing.Size(121, 17);
            this.CheckBoxAttachFlasher.TabIndex = 7;
            this.CheckBoxAttachFlasher.Text = "Добавить мигалку";
            this.CheckBoxAttachFlasher.UseVisualStyleBackColor = true;
            // 
            // CheckBoxAttachStand
            // 
            this.CheckBoxAttachStand.AutoSize = true;
            this.CheckBoxAttachStand.Location = new System.Drawing.Point(312, 64);
            this.CheckBoxAttachStand.Name = "CheckBoxAttachStand";
            this.CheckBoxAttachStand.Size = new System.Drawing.Size(131, 17);
            this.CheckBoxAttachStand.TabIndex = 6;
            this.CheckBoxAttachStand.Text = "Добавить подставку";
            this.CheckBoxAttachStand.UseVisualStyleBackColor = true;
            // 
            // CheckBoxAttachLadle
            // 
            this.CheckBoxAttachLadle.AutoSize = true;
            this.CheckBoxAttachLadle.Location = new System.Drawing.Point(312, 30);
            this.CheckBoxAttachLadle.Name = "CheckBoxAttachLadle";
            this.CheckBoxAttachLadle.Size = new System.Drawing.Size(105, 17);
            this.CheckBoxAttachLadle.TabIndex = 5;
            this.CheckBoxAttachLadle.Text = "Добавить ковш";
            this.CheckBoxAttachLadle.UseVisualStyleBackColor = true;
            // 
            // ChooseWeight
            // 
            this.ChooseWeight.Location = new System.Drawing.Point(69, 97);
            this.ChooseWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ChooseWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ChooseWeight.Name = "ChooseWeight";
            this.ChooseWeight.Size = new System.Drawing.Size(52, 20);
            this.ChooseWeight.TabIndex = 4;
            this.ChooseWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ChooseMaxSpeed
            // 
            this.ChooseMaxSpeed.Location = new System.Drawing.Point(69, 46);
            this.ChooseMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ChooseMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ChooseMaxSpeed.Name = "ChooseMaxSpeed";
            this.ChooseMaxSpeed.Size = new System.Drawing.Size(52, 20);
            this.ChooseMaxSpeed.TabIndex = 3;
            this.ChooseMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // WeightTransport
            // 
            this.WeightTransport.AutoSize = true;
            this.WeightTransport.Location = new System.Drawing.Point(37, 81);
            this.WeightTransport.Name = "WeightTransport";
            this.WeightTransport.Size = new System.Drawing.Size(29, 13);
            this.WeightTransport.TabIndex = 1;
            this.WeightTransport.Text = "Вес:";
            // 
            // MaxSpeed
            // 
            this.MaxSpeed.AutoSize = true;
            this.MaxSpeed.Location = new System.Drawing.Point(37, 30);
            this.MaxSpeed.Name = "MaxSpeed";
            this.MaxSpeed.Size = new System.Drawing.Size(90, 13);
            this.MaxSpeed.TabIndex = 0;
            this.MaxSpeed.Text = "Макс. скорость:";
            // 
            // pictureBoxTransport
            // 
            this.pictureBoxTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTransport.Location = new System.Drawing.Point(25, 24);
            this.pictureBoxTransport.Name = "pictureBoxTransport";
            this.pictureBoxTransport.Size = new System.Drawing.Size(288, 163);
            this.pictureBoxTransport.TabIndex = 2;
            this.pictureBoxTransport.TabStop = false;
            // 
            // panelTransport
            // 
            this.panelTransport.AllowDrop = true;
            this.panelTransport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTransport.Controls.Add(this.pictureBoxTransport);
            this.panelTransport.Location = new System.Drawing.Point(232, 12);
            this.panelTransport.Name = "panelTransport";
            this.panelTransport.Size = new System.Drawing.Size(336, 214);
            this.panelTransport.TabIndex = 2;
            this.panelTransport.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTransport_DragDrop);
            this.panelTransport.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTransport_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelColorBlue);
            this.groupBoxColors.Controls.Add(this.panelColorGreen);
            this.groupBoxColors.Controls.Add(this.panelColorOrange);
            this.groupBoxColors.Controls.Add(this.panelColorGray);
            this.groupBoxColors.Controls.Add(this.panelColorWhite);
            this.groupBoxColors.Controls.Add(this.panelColorBlack);
            this.groupBoxColors.Controls.Add(this.panelColorYellow);
            this.groupBoxColors.Controls.Add(this.panelColorRed);
            this.groupBoxColors.Controls.Add(this.AdditionalColorLable);
            this.groupBoxColors.Controls.Add(this.MainColorLable);
            this.groupBoxColors.Location = new System.Drawing.Point(574, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(314, 214);
            this.groupBoxColors.TabIndex = 3;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelColorBlue
            // 
            this.panelColorBlue.BackColor = System.Drawing.Color.Blue;
            this.panelColorBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorBlue.Location = new System.Drawing.Point(233, 157);
            this.panelColorBlue.Name = "panelColorBlue";
            this.panelColorBlue.Size = new System.Drawing.Size(30, 30);
            this.panelColorBlue.TabIndex = 3;
            // 
            // panelColorGreen
            // 
            this.panelColorGreen.BackColor = System.Drawing.Color.Green;
            this.panelColorGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorGreen.Location = new System.Drawing.Point(175, 157);
            this.panelColorGreen.Name = "panelColorGreen";
            this.panelColorGreen.Size = new System.Drawing.Size(30, 30);
            this.panelColorGreen.TabIndex = 3;
            // 
            // panelColorOrange
            // 
            this.panelColorOrange.BackColor = System.Drawing.Color.Orange;
            this.panelColorOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorOrange.Location = new System.Drawing.Point(111, 157);
            this.panelColorOrange.Name = "panelColorOrange";
            this.panelColorOrange.Size = new System.Drawing.Size(30, 30);
            this.panelColorOrange.TabIndex = 3;
            // 
            // panelColorGray
            // 
            this.panelColorGray.BackColor = System.Drawing.Color.Gray;
            this.panelColorGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorGray.Location = new System.Drawing.Point(45, 157);
            this.panelColorGray.Name = "panelColorGray";
            this.panelColorGray.Size = new System.Drawing.Size(30, 30);
            this.panelColorGray.TabIndex = 3;
            // 
            // panelColorWhite
            // 
            this.panelColorWhite.BackColor = System.Drawing.Color.White;
            this.panelColorWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorWhite.Location = new System.Drawing.Point(233, 112);
            this.panelColorWhite.Name = "panelColorWhite";
            this.panelColorWhite.Size = new System.Drawing.Size(30, 30);
            this.panelColorWhite.TabIndex = 3;
            // 
            // panelColorBlack
            // 
            this.panelColorBlack.BackColor = System.Drawing.Color.Black;
            this.panelColorBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorBlack.Location = new System.Drawing.Point(175, 112);
            this.panelColorBlack.Name = "panelColorBlack";
            this.panelColorBlack.Size = new System.Drawing.Size(30, 30);
            this.panelColorBlack.TabIndex = 3;
            // 
            // panelColorYellow
            // 
            this.panelColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelColorYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorYellow.Location = new System.Drawing.Point(111, 112);
            this.panelColorYellow.Name = "panelColorYellow";
            this.panelColorYellow.Size = new System.Drawing.Size(30, 30);
            this.panelColorYellow.TabIndex = 3;
            // 
            // panelColorRed
            // 
            this.panelColorRed.BackColor = System.Drawing.Color.Red;
            this.panelColorRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorRed.Location = new System.Drawing.Point(45, 112);
            this.panelColorRed.Name = "panelColorRed";
            this.panelColorRed.Size = new System.Drawing.Size(30, 30);
            this.panelColorRed.TabIndex = 2;
            // 
            // AdditionalColorLable
            // 
            this.AdditionalColorLable.AllowDrop = true;
            this.AdditionalColorLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdditionalColorLable.Location = new System.Drawing.Point(175, 24);
            this.AdditionalColorLable.Name = "AdditionalColorLable";
            this.AdditionalColorLable.Size = new System.Drawing.Size(118, 37);
            this.AdditionalColorLable.TabIndex = 1;
            this.AdditionalColorLable.Text = "Дополнительный цвет";
            this.AdditionalColorLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdditionalColorLable.DragDrop += new System.Windows.Forms.DragEventHandler(this.AdditionalColorLable_DragDrop);
            this.AdditionalColorLable.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainColorLable_DragEnter);
            // 
            // MainColorLable
            // 
            this.MainColorLable.AllowDrop = true;
            this.MainColorLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainColorLable.Location = new System.Drawing.Point(23, 24);
            this.MainColorLable.Name = "MainColorLable";
            this.MainColorLable.Size = new System.Drawing.Size(118, 37);
            this.MainColorLable.TabIndex = 0;
            this.MainColorLable.Text = "Базовый цвет";
            this.MainColorLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainColorLable.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainColorLable_DragDrop);
            this.MainColorLable.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainColorLable_DragEnter);
            // 
            // ButtonAddTransport
            // 
            this.ButtonAddTransport.Location = new System.Drawing.Point(807, 331);
            this.ButtonAddTransport.Name = "ButtonAddTransport";
            this.ButtonAddTransport.Size = new System.Drawing.Size(81, 23);
            this.ButtonAddTransport.TabIndex = 4;
            this.ButtonAddTransport.Text = "Добавить";
            this.ButtonAddTransport.UseVisualStyleBackColor = true;
            this.ButtonAddTransport.Click += new System.EventHandler(this.ButtonAddTransport_Click);
            // 
            // ButtonCancelChoose
            // 
            this.ButtonCancelChoose.Location = new System.Drawing.Point(807, 368);
            this.ButtonCancelChoose.Name = "ButtonCancelChoose";
            this.ButtonCancelChoose.Size = new System.Drawing.Size(81, 23);
            this.ButtonCancelChoose.TabIndex = 5;
            this.ButtonCancelChoose.Text = "Отменить";
            this.ButtonCancelChoose.UseVisualStyleBackColor = true;
            // 
            // TypeOfTranpsortConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 414);
            this.Controls.Add(this.ButtonCancelChoose);
            this.Controls.Add(this.ButtonAddTransport);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelTransport);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.groupBoxTypeOfTransport);
            this.Name = "TypeOfTranpsortConfigForm";
            this.Text = "Выбрать транспорт";
            this.groupBoxTypeOfTransport.ResumeLayout(false);
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransport)).EndInit();
            this.panelTransport.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTypeOfTransport;
        private System.Windows.Forms.Label ExcavatorLable;
        private System.Windows.Forms.Label TrackedVehicleLable;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.CheckBox CheckBoxAttachFlasher;
        private System.Windows.Forms.CheckBox CheckBoxAttachStand;
        private System.Windows.Forms.CheckBox CheckBoxAttachLadle;
        private System.Windows.Forms.NumericUpDown ChooseWeight;
        private System.Windows.Forms.NumericUpDown ChooseMaxSpeed;
        private System.Windows.Forms.Label WeightTransport;
        private System.Windows.Forms.Label MaxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxTransport;
        private System.Windows.Forms.Panel panelTransport;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelColorBlue;
        private System.Windows.Forms.Panel panelColorGreen;
        private System.Windows.Forms.Panel panelColorOrange;
        private System.Windows.Forms.Panel panelColorGray;
        private System.Windows.Forms.Panel panelColorWhite;
        private System.Windows.Forms.Panel panelColorBlack;
        private System.Windows.Forms.Panel panelColorYellow;
        private System.Windows.Forms.Panel panelColorRed;
        private System.Windows.Forms.Label AdditionalColorLable;
        private System.Windows.Forms.Label MainColorLable;
        private System.Windows.Forms.Button ButtonAddTransport;
        private System.Windows.Forms.Button ButtonCancelChoose;
    }
}