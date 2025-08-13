namespace Controller
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
            red = new Button();
            blue = new Button();
            shutter = new Button();
            Logs = new TextBox();
            SuspendLayout();
            // 
            // red
            // 
            red.BackColor = SystemColors.ActiveBorder;
            red.FlatStyle = FlatStyle.System;
            red.ForeColor = SystemColors.Control;
            red.Location = new Point(43, 44);
            red.Name = "red";
            red.Size = new Size(188, 133);
            red.TabIndex = 0;
            red.Text = "Зажечь красную лампочку\r\n";
            red.UseVisualStyleBackColor = false;
            red.Click += Button1_Click;
            // 
            // blue
            // 
            blue.Location = new Point(569, 44);
            blue.Name = "blue";
            blue.Size = new Size(188, 133);
            blue.TabIndex = 1;
            blue.Text = "Зажечь красную лампочку";
            blue.UseVisualStyleBackColor = true;
            blue.Click += Button2_Click;
            // 
            // shutter
            // 
            shutter.Location = new Point(316, 44);
            shutter.Name = "shutter";
            shutter.Size = new Size(188, 133);
            shutter.TabIndex = 2;
            shutter.Text = "Выключить обе";
            shutter.UseVisualStyleBackColor = true;
            shutter.Click += Button3_Click;
            // 
            // Logs
            // 
            Logs.AcceptsReturn = true;
            Logs.AcceptsTab = true;
            Logs.AllowDrop = true;
            Logs.BackColor = SystemColors.Info;
            Logs.Location = new Point(267, 271);
            Logs.Multiline = true;
            Logs.Name = "Logs";
            Logs.ScrollBars = ScrollBars.Vertical;
            Logs.Size = new Size(295, 116);
            Logs.TabIndex = 3;
            Logs.Text = "Logs\r\n";
            Logs.TextAlign = HorizontalAlignment.Center;
            Logs.TextChanged += Logs_TextChanged;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 447);
            Controls.Add(Logs);
            Controls.Add(shutter);
            Controls.Add(blue);
            Controls.Add(red);
            Name = "Form1";
            Text = "Controller";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button red;
        private Button blue;
        private Button shutter;
        private TextBox Logs;
    }
}
