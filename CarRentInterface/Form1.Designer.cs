namespace CarRentInterface
{
    partial class Form1
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
            this.carList = new System.Windows.Forms.ListBox();
            this.labelAvailableCars = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.dateTimePicerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.buttonRent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // carList
            // 
            this.carList.FormattingEnabled = true;
            this.carList.Location = new System.Drawing.Point(12, 29);
            this.carList.Name = "carList";
            this.carList.Size = new System.Drawing.Size(164, 212);
            this.carList.TabIndex = 0;
            this.carList.SelectedIndexChanged += new System.EventHandler(this.carList_SelectedIndexChanged);
            // 
            // labelAvailableCars
            // 
            this.labelAvailableCars.AutoSize = true;
            this.labelAvailableCars.Location = new System.Drawing.Point(13, 13);
            this.labelAvailableCars.Name = "labelAvailableCars";
            this.labelAvailableCars.Size = new System.Drawing.Size(131, 13);
            this.labelAvailableCars.TabIndex = 1;
            this.labelAvailableCars.Text = "Доступные автомобили:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(274, 29);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(0, 13);
            this.labelDescription.TabIndex = 2;
            // 
            // dateTimePicerFrom
            // 
            this.dateTimePicerFrom.Location = new System.Drawing.Point(289, 41);
            this.dateTimePicerFrom.Name = "dateTimePicerFrom";
            this.dateTimePicerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicerFrom.TabIndex = 3;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(289, 89);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 4;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(206, 41);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(20, 13);
            this.labelFrom.TabIndex = 5;
            this.labelFrom.Text = "От";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(204, 89);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(22, 13);
            this.labelTo.TabIndex = 6;
            this.labelTo.Text = "До";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(289, 132);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(207, 138);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(57, 13);
            this.labelClientName.TabIndex = 8;
            this.labelClientName.Text = "Ваше имя";
            // 
            // buttonRent
            // 
            this.buttonRent.Location = new System.Drawing.Point(423, 197);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(75, 23);
            this.buttonRent.TabIndex = 9;
            this.buttonRent.Text = "Заказать";
            this.buttonRent.UseVisualStyleBackColor = true;
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 261);
            this.Controls.Add(this.buttonRent);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePicerFrom);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelAvailableCars);
            this.Controls.Add(this.carList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox carList;
        private System.Windows.Forms.Label labelAvailableCars;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.DateTimePicker dateTimePicerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Button buttonRent;
    }
}

