namespace WinForm_Delegate_Event_Example
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timeLineView1 = new WinForm_Delegate_Event_Example.TimeLineView();
            this.resorceView1 = new WinForm_Delegate_Event_Example.ResorceView();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(12, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 127);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeLineView1
            // 
            this.timeLineView1.Location = new System.Drawing.Point(12, 194);
            this.timeLineView1.Name = "timeLineView1";
            this.timeLineView1.Size = new System.Drawing.Size(480, 85);
            this.timeLineView1.TabIndex = 2;
            // 
            // resorceView1
            // 
            this.resorceView1.Location = new System.Drawing.Point(342, 12);
            this.resorceView1.Name = "resorceView1";
            this.resorceView1.Size = new System.Drawing.Size(150, 176);
            this.resorceView1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeLineView1);
            this.Controls.Add(this.resorceView1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ResorceView resorceView1;
        private TimeLineView timeLineView1;
        private System.Windows.Forms.Button button1;
    }
}

