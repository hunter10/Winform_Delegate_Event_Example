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
            this.label1 = new System.Windows.Forms.Label();
            this.actionView1 = new WinForm_Delegate_Event_Example.ActionView();
            this.timeLineView1 = new WinForm_Delegate_Event_Example.TimeLineView();
            this.resorceView1 = new WinForm_Delegate_Event_Example.ResorceView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(128, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 127);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "MVC Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // actionView1
            // 
            this.actionView1.Location = new System.Drawing.Point(12, 12);
            this.actionView1.Name = "actionView1";
            this.actionView1.Size = new System.Drawing.Size(110, 176);
            this.actionView1.TabIndex = 4;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delegate Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.actionView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeLineView1);
            this.Controls.Add(this.resorceView1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ResorceView resorceView1;
        private TimeLineView timeLineView1;
        private System.Windows.Forms.Button button1;
        private ActionView actionView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

