namespace NuclearReactor
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactor1Label = new System.Windows.Forms.Label();
            this.reactor2Label = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.reactor2StateLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(16, 11);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(739, 63);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor Control";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reactor1Label
            // 
            this.reactor1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1Label.Location = new System.Drawing.Point(200, 87);
            this.reactor1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reactor1Label.Name = "reactor1Label";
            this.reactor1Label.Size = new System.Drawing.Size(133, 28);
            this.reactor1Label.TabIndex = 1;
            this.reactor1Label.Text = "Reactor 1";
            this.reactor1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reactor2Label
            // 
            this.reactor2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2Label.Location = new System.Drawing.Point(441, 87);
            this.reactor2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reactor2Label.Name = "reactor2Label";
            this.reactor2Label.Size = new System.Drawing.Size(133, 28);
            this.reactor2Label.TabIndex = 2;
            this.reactor2Label.Text = "Reactor 2";
            this.reactor2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.BackColor = System.Drawing.Color.LawnGreen;
            this.reactor1StateLabel.Location = new System.Drawing.Point(201, 138);
            this.reactor1StateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(133, 114);
            this.reactor1StateLabel.TabIndex = 3;
            // 
            // reactor2StateLabel
            // 
            this.reactor2StateLabel.BackColor = System.Drawing.Color.LawnGreen;
            this.reactor2StateLabel.Location = new System.Drawing.Point(441, 138);
            this.reactor2StateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reactor2StateLabel.Name = "reactor2StateLabel";
            this.reactor2StateLabel.Size = new System.Drawing.Size(133, 114);
            this.reactor2StateLabel.TabIndex = 4;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(72, 361);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(636, 44);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Reactors Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(261, 278);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(234, 43);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start Reactors";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(771, 442);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.reactor2StateLabel);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.reactor2Label);
            this.Controls.Add(this.reactor1Label);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactor1Label;
        private System.Windows.Forms.Label reactor2Label;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label reactor2StateLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button StartButton;
    }
}

