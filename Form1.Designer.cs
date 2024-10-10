
namespace PruebaControl
{
    partial class Form1
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
            leftJoystickLabel = new Label();
            dpadLabel = new Label();
            buttonALabel = new Label();
            buttonBLabel = new Label();
            buttonXLabel = new Label();
            buttonYLabel = new Label();
            rightJoystickLabel = new Label();
            leftTriggerLabel = new Label();
            rightTriggerLabel = new Label();
            SuspendLayout();
            // 
            // leftJoystickLabel
            // 
            leftJoystickLabel.AutoSize = true;
            leftJoystickLabel.Location = new Point(12, 134);
            leftJoystickLabel.Name = "leftJoystickLabel";
            leftJoystickLabel.Size = new Size(71, 15);
            leftJoystickLabel.TabIndex = 0;
            leftJoystickLabel.Text = "Left Joystick";
            // 
            // dpadLabel
            // 
            dpadLabel.AutoSize = true;
            dpadLabel.Location = new Point(31, 185);
            dpadLabel.Name = "dpadLabel";
            dpadLabel.Size = new Size(90, 15);
            dpadLabel.TabIndex = 1;
            dpadLabel.Text = "Soy otra prueba";
            // 
            // buttonALabel
            // 
            buttonALabel.AutoSize = true;
            buttonALabel.Location = new Point(296, 158);
            buttonALabel.Name = "buttonALabel";
            buttonALabel.Size = new Size(50, 15);
            buttonALabel.TabIndex = 2;
            buttonALabel.Text = "Boton A";
            buttonALabel.Click += buttonALabel_Click;
            // 
            // buttonBLabel
            // 
            buttonBLabel.AutoSize = true;
            buttonBLabel.Location = new Point(347, 134);
            buttonBLabel.Name = "buttonBLabel";
            buttonBLabel.Size = new Size(49, 15);
            buttonBLabel.TabIndex = 3;
            buttonBLabel.Text = "Boton B";
            // 
            // buttonXLabel
            // 
            buttonXLabel.AutoSize = true;
            buttonXLabel.Location = new Point(242, 134);
            buttonXLabel.Name = "buttonXLabel";
            buttonXLabel.Size = new Size(49, 15);
            buttonXLabel.TabIndex = 4;
            buttonXLabel.Text = "Boton X";
            // 
            // buttonYLabel
            // 
            buttonYLabel.AutoSize = true;
            buttonYLabel.Location = new Point(296, 107);
            buttonYLabel.Name = "buttonYLabel";
            buttonYLabel.Size = new Size(49, 15);
            buttonYLabel.TabIndex = 5;
            buttonYLabel.Text = "Boton Y";
            // 
            // rightJoystickLabel
            // 
            rightJoystickLabel.AutoSize = true;
            rightJoystickLabel.Location = new Point(159, 185);
            rightJoystickLabel.Name = "rightJoystickLabel";
            rightJoystickLabel.Size = new Size(79, 15);
            rightJoystickLabel.TabIndex = 6;
            rightJoystickLabel.Text = "Right Joystick";
            // 
            // leftTriggerLabel
            // 
            leftTriggerLabel.AutoSize = true;
            leftTriggerLabel.Location = new Point(31, 57);
            leftTriggerLabel.Name = "leftTriggerLabel";
            leftTriggerLabel.Size = new Size(66, 15);
            leftTriggerLabel.TabIndex = 7;
            leftTriggerLabel.Text = "Left Trigger";
            // 
            // rightTriggerLabel
            // 
            rightTriggerLabel.AutoSize = true;
            rightTriggerLabel.Location = new Point(296, 57);
            rightTriggerLabel.Name = "rightTriggerLabel";
            rightTriggerLabel.Size = new Size(74, 15);
            rightTriggerLabel.TabIndex = 8;
            rightTriggerLabel.Text = "Right Trigger";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 303);
            Controls.Add(rightTriggerLabel);
            Controls.Add(leftTriggerLabel);
            Controls.Add(rightJoystickLabel);
            Controls.Add(buttonYLabel);
            Controls.Add(buttonXLabel);
            Controls.Add(buttonBLabel);
            Controls.Add(buttonALabel);
            Controls.Add(dpadLabel);
            Controls.Add(leftJoystickLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void buttonALabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label leftJoystickLabel;
        private Label dpadLabel;
        private Label buttonALabel;
        private Label buttonBLabel;
        private Label buttonXLabel;
        private Label buttonYLabel;
        private Label rightJoystickLabel;
        private Label leftTriggerLabel;
        private Label rightTriggerLabel;
    }
}
