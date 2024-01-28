namespace _02_Ordering_A_Taxi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelName = new System.Windows.Forms.Label();
            this.labelNumberPhone = new System.Windows.Forms.Label();
            this.labelTypeOfTaxi = new System.Windows.Forms.Label();
            this.labelNumberOfPassengers = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.maskedTextBoxNumberPhone = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxTypeOfTaxi = new System.Windows.Forms.ComboBox();
            this.numericUpDownNumberOfPassengers = new System.Windows.Forms.NumericUpDown();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.checkBoxIsTrue = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(25, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 38);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelNumberPhone
            // 
            this.labelNumberPhone.AutoSize = true;
            this.labelNumberPhone.Font = new System.Drawing.Font("Javanese Text", 10.2F);
            this.labelNumberPhone.Location = new System.Drawing.Point(234, 34);
            this.labelNumberPhone.Name = "labelNumberPhone";
            this.labelNumberPhone.Size = new System.Drawing.Size(126, 38);
            this.labelNumberPhone.TabIndex = 1;
            this.labelNumberPhone.Text = "Number Phone";
            // 
            // labelTypeOfTaxi
            // 
            this.labelTypeOfTaxi.AutoSize = true;
            this.labelTypeOfTaxi.Font = new System.Drawing.Font("Javanese Text", 10.2F);
            this.labelTypeOfTaxi.Location = new System.Drawing.Point(25, 122);
            this.labelTypeOfTaxi.Name = "labelTypeOfTaxi";
            this.labelTypeOfTaxi.Size = new System.Drawing.Size(105, 38);
            this.labelTypeOfTaxi.TabIndex = 2;
            this.labelTypeOfTaxi.Text = "Type of Taxi";
            // 
            // labelNumberOfPassengers
            // 
            this.labelNumberOfPassengers.AutoSize = true;
            this.labelNumberOfPassengers.Font = new System.Drawing.Font("Javanese Text", 10.2F);
            this.labelNumberOfPassengers.Location = new System.Drawing.Point(234, 122);
            this.labelNumberOfPassengers.Name = "labelNumberOfPassengers";
            this.labelNumberOfPassengers.Size = new System.Drawing.Size(175, 38);
            this.labelNumberOfPassengers.TabIndex = 3;
            this.labelNumberOfPassengers.Text = "Number of passengers";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Javanese Text", 10.2F);
            this.labelAddress.Location = new System.Drawing.Point(25, 211);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(75, 38);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Address";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Red;
            this.buttonCancel.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(240, 268);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(157, 45);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonOrder.Font = new System.Drawing.Font("Javanese Text", 12F);
            this.buttonOrder.Location = new System.Drawing.Point(241, 211);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(157, 42);
            this.buttonOrder.TabIndex = 7;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(32, 75);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(163, 22);
            this.textBoxName.TabIndex = 8;
            // 
            // maskedTextBoxNumberPhone
            // 
            this.maskedTextBoxNumberPhone.Location = new System.Drawing.Point(241, 75);
            this.maskedTextBoxNumberPhone.Mask = "+380-(00)-000-00-00";
            this.maskedTextBoxNumberPhone.Name = "maskedTextBoxNumberPhone";
            this.maskedTextBoxNumberPhone.Size = new System.Drawing.Size(168, 22);
            this.maskedTextBoxNumberPhone.TabIndex = 10;
            // 
            // comboBoxTypeOfTaxi
            // 
            this.comboBoxTypeOfTaxi.FormattingEnabled = true;
            this.comboBoxTypeOfTaxi.Items.AddRange(new object[] {
            "Economy Class",
            "Standard Class",
            "Premium Class"});
            this.comboBoxTypeOfTaxi.Location = new System.Drawing.Point(32, 163);
            this.comboBoxTypeOfTaxi.Name = "comboBoxTypeOfTaxi";
            this.comboBoxTypeOfTaxi.Size = new System.Drawing.Size(163, 24);
            this.comboBoxTypeOfTaxi.TabIndex = 12;
            // 
            // numericUpDownNumberOfPassengers
            // 
            this.numericUpDownNumberOfPassengers.Location = new System.Drawing.Point(241, 163);
            this.numericUpDownNumberOfPassengers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownNumberOfPassengers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfPassengers.Name = "numericUpDownNumberOfPassengers";
            this.numericUpDownNumberOfPassengers.Size = new System.Drawing.Size(168, 22);
            this.numericUpDownNumberOfPassengers.TabIndex = 13;
            this.numericUpDownNumberOfPassengers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(32, 252);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(163, 22);
            this.textBoxAddress.TabIndex = 14;
            // 
            // checkBoxIsTrue
            // 
            this.checkBoxIsTrue.AutoSize = true;
            this.checkBoxIsTrue.Font = new System.Drawing.Font("Javanese Text", 9.3F);
            this.checkBoxIsTrue.Location = new System.Drawing.Point(32, 286);
            this.checkBoxIsTrue.Name = "checkBoxIsTrue";
            this.checkBoxIsTrue.Size = new System.Drawing.Size(182, 40);
            this.checkBoxIsTrue.TabIndex = 15;
            this.checkBoxIsTrue.Text = "I agree to everything";
            this.checkBoxIsTrue.UseVisualStyleBackColor = true;
            this.checkBoxIsTrue.CheckedChanged += new System.EventHandler(this.checkBoxIsTrue_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(437, 348);
            this.Controls.Add(this.checkBoxIsTrue);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.numericUpDownNumberOfPassengers);
            this.Controls.Add(this.comboBoxTypeOfTaxi);
            this.Controls.Add(this.maskedTextBoxNumberPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelNumberOfPassengers);
            this.Controls.Add(this.labelTypeOfTaxi);
            this.Controls.Add(this.labelNumberPhone);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Taxi Bogdana";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfPassengers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNumberPhone;
        private System.Windows.Forms.Label labelTypeOfTaxi;
        private System.Windows.Forms.Label labelNumberOfPassengers;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumberPhone;
        private System.Windows.Forms.ComboBox comboBoxTypeOfTaxi;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfPassengers;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.CheckBox checkBoxIsTrue;
    }
}

