namespace ProgrammingProject2
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
            this.redButton = new System.Windows.Forms.RadioButton();
            this.blueButton = new System.Windows.Forms.RadioButton();
            this.greenButton = new System.Windows.Forms.RadioButton();
            this.nameBox = new System.Windows.Forms.CheckBox();
            this.typeBox = new System.Windows.Forms.CheckBox();
            this.priceBox = new System.Windows.Forms.CheckBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.checkBoxes = new System.Windows.Forms.Panel();
            this.radioButtons = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.Label();
            this.checkBoxes.SuspendLayout();
            this.radioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Checked = true;
            this.redButton.Location = new System.Drawing.Point(0, 3);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(45, 17);
            this.redButton.TabIndex = 0;
            this.redButton.TabStop = true;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            // 
            // blueButton
            // 
            this.blueButton.AutoSize = true;
            this.blueButton.Location = new System.Drawing.Point(0, 26);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(46, 17);
            this.blueButton.TabIndex = 1;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            // 
            // greenButton
            // 
            this.greenButton.AutoSize = true;
            this.greenButton.Location = new System.Drawing.Point(0, 49);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(54, 17);
            this.greenButton.TabIndex = 2;
            this.greenButton.Text = "Green";
            this.greenButton.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Location = new System.Drawing.Point(3, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(54, 17);
            this.nameBox.TabIndex = 3;
            this.nameBox.Text = "Name";
            this.nameBox.UseVisualStyleBackColor = true;
            // 
            // typeBox
            // 
            this.typeBox.AutoSize = true;
            this.typeBox.Location = new System.Drawing.Point(3, 35);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(50, 17);
            this.typeBox.TabIndex = 4;
            this.typeBox.Text = "Type";
            this.typeBox.UseVisualStyleBackColor = true;
            // 
            // priceBox
            // 
            this.priceBox.AutoSize = true;
            this.priceBox.Location = new System.Drawing.Point(3, 58);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(50, 17);
            this.priceBox.TabIndex = 5;
            this.priceBox.Text = "Price";
            this.priceBox.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Items.AddRange(new object[] {
            "Laptop",
            "Notebook",
            "Scissors"});
            this.listBox.Location = new System.Drawing.Point(44, 62);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(96, 56);
            this.listBox.TabIndex = 6;
            // 
            // checkBoxes
            // 
            this.checkBoxes.Controls.Add(this.nameBox);
            this.checkBoxes.Controls.Add(this.typeBox);
            this.checkBoxes.Controls.Add(this.priceBox);
            this.checkBoxes.Location = new System.Drawing.Point(44, 165);
            this.checkBoxes.Name = "checkBoxes";
            this.checkBoxes.Size = new System.Drawing.Size(96, 83);
            this.checkBoxes.TabIndex = 8;
            // 
            // radioButtons
            // 
            this.radioButtons.Controls.Add(this.redButton);
            this.radioButtons.Controls.Add(this.greenButton);
            this.radioButtons.Controls.Add(this.blueButton);
            this.radioButtons.Location = new System.Drawing.Point(44, 287);
            this.radioButtons.Name = "radioButtons";
            this.radioButtons.Size = new System.Drawing.Size(91, 75);
            this.radioButtons.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Labels";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Item";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(285, 196);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 14;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(436, 91);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(251, 216);
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(433, 317);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "label4";
            this.nameLabel.Visible = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(433, 338);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(35, 13);
            this.typeLabel.TabIndex = 16;
            this.typeLabel.Text = "label5";
            this.typeLabel.Visible = false;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(433, 358);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(35, 13);
            this.priceLabel.TabIndex = 17;
            this.priceLabel.Text = "label6";
            this.priceLabel.Visible = false;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(173, 80);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(107, 13);
            this.errorMessage.TabIndex = 18;
            this.errorMessage.Text = "Please select an item";
            this.errorMessage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtons);
            this.Controls.Add(this.checkBoxes);
            this.Controls.Add(this.listBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.checkBoxes.ResumeLayout(false);
            this.checkBoxes.PerformLayout();
            this.radioButtons.ResumeLayout(false);
            this.radioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton blueButton;
        private System.Windows.Forms.RadioButton greenButton;
        private System.Windows.Forms.CheckBox nameBox;
        private System.Windows.Forms.CheckBox typeBox;
        private System.Windows.Forms.CheckBox priceBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Panel checkBoxes;
        private System.Windows.Forms.Panel radioButtons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label errorMessage;
    }
}

