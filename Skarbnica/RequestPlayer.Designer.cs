namespace Skarbnica
{
    partial class RequestPlayer
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
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.NeedforRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(50, 51);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 0;
            this.b1.Text = "Player1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.NeedforRequest_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(131, 51);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 23);
            this.b2.TabIndex = 1;
            this.b2.Text = "Player2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.NeedforRequest_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(50, 80);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 23);
            this.b3.TabIndex = 2;
            this.b3.Text = "Player3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.NeedforRequest_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(131, 80);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 23);
            this.b4.TabIndex = 3;
            this.b4.Text = "Player4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.NeedforRequest_Click);
            // 
            // NeedforRequest
            // 
            this.NeedforRequest.Location = new System.Drawing.Point(13, 13);
            this.NeedforRequest.Name = "NeedforRequest";
            this.NeedforRequest.Size = new System.Drawing.Size(10, 10);
            this.NeedforRequest.TabIndex = 4;
            this.NeedforRequest.Text = ".";
            this.NeedforRequest.UseVisualStyleBackColor = true;
            this.NeedforRequest.Visible = false;
            this.NeedforRequest.Click += new System.EventHandler(this.NeedforRequest_Click);
            // 
            // RequestPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 161);
            this.Controls.Add(this.NeedforRequest);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "RequestPlayer";
            this.Text = "RequestPlayer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button NeedforRequest;
    }
}