namespace ServiceBusExamplewithQueue
{
    partial class ServiceBusForm
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
            this.qNametxt = new System.Windows.Forms.TextBox();
            this.sendQueuetxt = new System.Windows.Forms.TextBox();
            this.readQueuetxt = new System.Windows.Forms.TextBox();
            this.sendTopictxt = new System.Windows.Forms.TextBox();
            this.createQ = new System.Windows.Forms.Button();
            this.sendQ = new System.Windows.Forms.Button();
            this.readQ = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qNametxt
            // 
            this.qNametxt.Location = new System.Drawing.Point(356, 61);
            this.qNametxt.Name = "qNametxt";
            this.qNametxt.Size = new System.Drawing.Size(376, 22);
            this.qNametxt.TabIndex = 1;
            // 
            // sendQueuetxt
            // 
            this.sendQueuetxt.Location = new System.Drawing.Point(356, 135);
            this.sendQueuetxt.Name = "sendQueuetxt";
            this.sendQueuetxt.Size = new System.Drawing.Size(376, 22);
            this.sendQueuetxt.TabIndex = 7;
            // 
            // readQueuetxt
            // 
            this.readQueuetxt.Location = new System.Drawing.Point(356, 210);
            this.readQueuetxt.Name = "readQueuetxt";
            this.readQueuetxt.Size = new System.Drawing.Size(376, 22);
            this.readQueuetxt.TabIndex = 5;
            // 
            // sendTopictxt
            // 
            this.sendTopictxt.Location = new System.Drawing.Point(356, 292);
            this.sendTopictxt.Name = "sendTopictxt";
            this.sendTopictxt.Size = new System.Drawing.Size(376, 22);
            this.sendTopictxt.TabIndex = 6;
            // 
            // createQ
            // 
            this.createQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQ.Location = new System.Drawing.Point(25, 60);
            this.createQ.Name = "createQ";
            this.createQ.Size = new System.Drawing.Size(303, 37);
            this.createQ.TabIndex = 8;
            this.createQ.Text = "MakeQueue";
            this.createQ.UseVisualStyleBackColor = true;
            this.createQ.Click += new System.EventHandler(this.createQ_Click);
            // 
            // sendQ
            // 
            this.sendQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendQ.Location = new System.Drawing.Point(25, 128);
            this.sendQ.Name = "sendQ";
            this.sendQ.Size = new System.Drawing.Size(303, 41);
            this.sendQ.TabIndex = 9;
            this.sendQ.Text = "SendQueue";
            this.sendQ.UseVisualStyleBackColor = true;
            this.sendQ.Click += new System.EventHandler(this.sendQ_Click);
            // 
            // readQ
            // 
            this.readQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readQ.Location = new System.Drawing.Point(25, 214);
            this.readQ.Name = "readQ";
            this.readQ.Size = new System.Drawing.Size(303, 33);
            this.readQ.TabIndex = 10;
            this.readQ.Text = "ReadQueue";
            this.readQ.UseVisualStyleBackColor = true;
            this.readQ.Click += new System.EventHandler(this.readQ_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(25, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(303, 37);
            this.button4.TabIndex = 11;
            this.button4.Text = "Send Topic";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.readQ);
            this.Controls.Add(this.sendQ);
            this.Controls.Add(this.createQ);
            this.Controls.Add(this.sendTopictxt);
            this.Controls.Add(this.readQueuetxt);
            this.Controls.Add(this.sendQueuetxt);
            this.Controls.Add(this.qNametxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox qNametxt;
        private System.Windows.Forms.TextBox sendQueuetxt;
        private System.Windows.Forms.TextBox readQueuetxt;
        private System.Windows.Forms.TextBox sendTopictxt;
        private System.Windows.Forms.Button createQ;
        private System.Windows.Forms.Button sendQ;
        private System.Windows.Forms.Button readQ;
        private System.Windows.Forms.Button button4;
    }
}