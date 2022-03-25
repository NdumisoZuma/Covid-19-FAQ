
namespace Magic_8_ball
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
            this.Ask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Response = new System.Windows.Forms.RichTextBox();
            this.Again = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ask
            // 
            this.Ask.BackColor = System.Drawing.Color.LimeGreen;
            this.Ask.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ask.Location = new System.Drawing.Point(511, 134);
            this.Ask.Name = "Ask";
            this.Ask.Size = new System.Drawing.Size(95, 39);
            this.Ask.TabIndex = 1;
            this.Ask.Text = "Ask";
            this.Ask.UseVisualStyleBackColor = false;
            this.Ask.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter question";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(60, 150);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Response
            // 
            this.Response.Location = new System.Drawing.Point(60, 207);
            this.Response.Name = "Response";
            this.Response.Size = new System.Drawing.Size(390, 129);
            this.Response.TabIndex = 4;
            this.Response.Text = "Response";
            this.Response.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Again
            // 
            this.Again.BackColor = System.Drawing.Color.Yellow;
            this.Again.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Again.Location = new System.Drawing.Point(60, 369);
            this.Again.Name = "Again";
            this.Again.Size = new System.Drawing.Size(142, 45);
            this.Again.TabIndex = 5;
            this.Again.Text = "Play Again";
            this.Again.UseVisualStyleBackColor = false;
            this.Again.Click += new System.EventHandler(this.Again_Click);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Red;
            this.Quit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quit.Location = new System.Drawing.Point(579, 369);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(93, 45);
            this.Quit.TabIndex = 6;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(347, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Corona Virus FAQ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(286, 92);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(307, 23);
            this.Question.TabIndex = 8;
            this.Question.TextChanged += new System.EventHandler(this.Question_TextChanged);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.OrangeRed;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(300, 369);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(104, 45);
            this.clear.TabIndex = 9;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magic_8_ball.Properties.Resources.covid19_open_graph;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Again);
            this.Controls.Add(this.Response);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Ask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox Response;
        private System.Windows.Forms.Button Again;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.Button clear;
    }
}

