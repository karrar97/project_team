﻿namespace project_team
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
               this.button1 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.button5 = new System.Windows.Forms.Button();
               this.button6 = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // button1
               // 
               this.button1.Location = new System.Drawing.Point(320, 85);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(140, 64);
               this.button1.TabIndex = 0;
               this.button1.Text = "مواد غذائيه";
               this.button1.UseVisualStyleBackColor = true;
               // 
               // button2
               // 
               this.button2.Location = new System.Drawing.Point(517, 85);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(140, 64);
               this.button2.TabIndex = 1;
               this.button2.Text = "مكتبه + قاعة استراحه";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button3
               // 
               this.button3.Location = new System.Drawing.Point(773, 84);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(140, 64);
               this.button3.TabIndex = 2;
               this.button3.Text = "سينما";
               this.button3.UseVisualStyleBackColor = true;
               // 
               // button4
               // 
               this.button4.Location = new System.Drawing.Point(773, 218);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(140, 64);
               this.button4.TabIndex = 5;
               this.button4.Text = "مطعم";
               this.button4.UseVisualStyleBackColor = true;
               // 
               // button5
               // 
               this.button5.Location = new System.Drawing.Point(517, 219);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(140, 64);
               this.button5.TabIndex = 4;
               this.button5.Text = "ملابس";
               this.button5.UseVisualStyleBackColor = true;
               this.button5.Click += new System.EventHandler(this.button5_Click);
               // 
               // button6
               // 
               this.button6.Location = new System.Drawing.Point(320, 219);
               this.button6.Name = "button6";
               this.button6.Size = new System.Drawing.Size(140, 64);
               this.button6.TabIndex = 3;
               this.button6.Text = "اجهزه الكترونيه";
               this.button6.UseVisualStyleBackColor = true;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1303, 589);
               this.Controls.Add(this.button4);
               this.Controls.Add(this.button5);
               this.Controls.Add(this.button6);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Name = "Form1";
               this.RightToLeft = System.Windows.Forms.RightToLeft.No;
               this.Text = "مرحبا بك في واجهات المول";
               this.TransparencyKey = System.Drawing.Color.White;
               this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
               this.ResumeLayout(false);

          }

          #endregion

          public System.Windows.Forms.Button button1;
          public System.Windows.Forms.Button button2;
          public System.Windows.Forms.Button button3;
          public System.Windows.Forms.Button button4;
          public System.Windows.Forms.Button button5;
          public System.Windows.Forms.Button button6;

     }
}

