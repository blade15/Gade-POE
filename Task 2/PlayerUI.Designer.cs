﻿
namespace Task_1
{
    partial class frmUI
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
            this.bttnUp = new System.Windows.Forms.Button();
            this.bttnRight = new System.Windows.Forms.Button();
            this.bttnDown = new System.Windows.Forms.Button();
            this.bttnLeft = new System.Windows.Forms.Button();
            this.grpBxStats = new System.Windows.Forms.GroupBox();
            this.rchTxtStats = new System.Windows.Forms.RichTextBox();
            this.grpBxAttack = new System.Windows.Forms.GroupBox();
            this.EnemycomboBox = new System.Windows.Forms.ComboBox();
            this.bttnAttack = new System.Windows.Forms.Button();
            this.rchtTxtBxLog = new System.Windows.Forms.RichTextBox();
            this.lblMap = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpBxStats.SuspendLayout();
            this.grpBxAttack.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnUp
            // 
            this.bttnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.bttnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(36)))));
            this.bttnUp.Location = new System.Drawing.Point(535, 384);
            this.bttnUp.Name = "bttnUp";
            this.bttnUp.Size = new System.Drawing.Size(69, 48);
            this.bttnUp.TabIndex = 0;
            this.bttnUp.Text = "^";
            this.bttnUp.UseVisualStyleBackColor = false;
            this.bttnUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttnRight
            // 
            this.bttnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.bttnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRight.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(36)))));
            this.bttnRight.Location = new System.Drawing.Point(609, 433);
            this.bttnRight.Name = "bttnRight";
            this.bttnRight.Size = new System.Drawing.Size(69, 48);
            this.bttnRight.TabIndex = 1;
            this.bttnRight.Text = ">";
            this.bttnRight.UseVisualStyleBackColor = false;
            this.bttnRight.Click += new System.EventHandler(this.bttnRight_Click);
            // 
            // bttnDown
            // 
            this.bttnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.bttnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDown.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(36)))));
            this.bttnDown.Location = new System.Drawing.Point(535, 502);
            this.bttnDown.Name = "bttnDown";
            this.bttnDown.Size = new System.Drawing.Size(69, 48);
            this.bttnDown.TabIndex = 2;
            this.bttnDown.Text = "V";
            this.bttnDown.UseVisualStyleBackColor = false;
            this.bttnDown.Click += new System.EventHandler(this.bttnDown_Click);
            // 
            // bttnLeft
            // 
            this.bttnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.bttnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLeft.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(36)))));
            this.bttnLeft.Location = new System.Drawing.Point(456, 433);
            this.bttnLeft.Name = "bttnLeft";
            this.bttnLeft.Size = new System.Drawing.Size(69, 48);
            this.bttnLeft.TabIndex = 3;
            this.bttnLeft.Text = "<";
            this.bttnLeft.UseVisualStyleBackColor = false;
            this.bttnLeft.Click += new System.EventHandler(this.bttnLeft_Click);
            // 
            // grpBxStats
            // 
            this.grpBxStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            this.grpBxStats.Controls.Add(this.rchTxtStats);
            this.grpBxStats.Controls.Add(this.grpBxAttack);
            this.grpBxStats.Location = new System.Drawing.Point(399, 12);
            this.grpBxStats.Name = "grpBxStats";
            this.grpBxStats.Size = new System.Drawing.Size(329, 366);
            this.grpBxStats.TabIndex = 4;
            this.grpBxStats.TabStop = false;
            this.grpBxStats.Text = "Stats";
            // 
            // rchTxtStats
            // 
            this.rchTxtStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            this.rchTxtStats.Location = new System.Drawing.Point(12, 27);
            this.rchTxtStats.Name = "rchTxtStats";
            this.rchTxtStats.Size = new System.Drawing.Size(300, 129);
            this.rchTxtStats.TabIndex = 1;
            this.rchTxtStats.Text = "";
            // 
            // grpBxAttack
            // 
            this.grpBxAttack.Controls.Add(this.EnemycomboBox);
            this.grpBxAttack.Controls.Add(this.bttnAttack);
            this.grpBxAttack.Controls.Add(this.rchtTxtBxLog);
            this.grpBxAttack.Location = new System.Drawing.Point(6, 153);
            this.grpBxAttack.Name = "grpBxAttack";
            this.grpBxAttack.Size = new System.Drawing.Size(312, 207);
            this.grpBxAttack.TabIndex = 0;
            this.grpBxAttack.TabStop = false;
            this.grpBxAttack.Text = "Attack";
            // 
            // EnemycomboBox
            // 
            this.EnemycomboBox.FormattingEnabled = true;
            this.EnemycomboBox.Location = new System.Drawing.Point(6, 26);
            this.EnemycomboBox.Name = "EnemycomboBox";
            this.EnemycomboBox.Size = new System.Drawing.Size(300, 28);
            this.EnemycomboBox.TabIndex = 5;
            this.EnemycomboBox.Text = "--Select Enemy--";
            // 
            // bttnAttack
            // 
            this.bttnAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(97)))), ((int)(((byte)(52)))));
            this.bttnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnAttack.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnAttack.Location = new System.Drawing.Point(6, 73);
            this.bttnAttack.Name = "bttnAttack";
            this.bttnAttack.Size = new System.Drawing.Size(300, 29);
            this.bttnAttack.TabIndex = 4;
            this.bttnAttack.Text = "ATTACK";
            this.bttnAttack.UseVisualStyleBackColor = false;
            this.bttnAttack.Click += new System.EventHandler(this.bttnAttack_Click);
            // 
            // rchtTxtBxLog
            // 
            this.rchtTxtBxLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            this.rchtTxtBxLog.Location = new System.Drawing.Point(6, 108);
            this.rchtTxtBxLog.Name = "rchtTxtBxLog";
            this.rchtTxtBxLog.Size = new System.Drawing.Size(300, 92);
            this.rchtTxtBxLog.TabIndex = 3;
            this.rchtTxtBxLog.Text = "";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            this.lblMap.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMap.Location = new System.Drawing.Point(44, 39);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(152, 25);
            this.lblMap.TabIndex = 5;
            this.lblMap.Text = "XXXXXXXXXX";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(761, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 366);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shop";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(60, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 58);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(60, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 58);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 58);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Task_1.Properties.Resources.Background2;
            this.ClientSize = new System.Drawing.Size(1055, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.grpBxStats);
            this.Controls.Add(this.bttnLeft);
            this.Controls.Add(this.bttnDown);
            this.Controls.Add(this.bttnRight);
            this.Controls.Add(this.bttnUp);
            this.Name = "frmUI";
            this.Text = "Goblins and Heroes - The Game";
            this.Load += new System.EventHandler(this.PlayerUI_Load);
            this.grpBxStats.ResumeLayout(false);
            this.grpBxAttack.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnUp;
        private System.Windows.Forms.Button bttnRight;
        private System.Windows.Forms.Button bttnDown;
        private System.Windows.Forms.Button bttnLeft;
        private System.Windows.Forms.GroupBox grpBxStats;
        private System.Windows.Forms.RichTextBox rchTxtStats;
        private System.Windows.Forms.GroupBox grpBxAttack;
        private System.Windows.Forms.Button bttnAttack;
        private System.Windows.Forms.RichTextBox rchtTxtBxLog;
        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.ComboBox EnemycomboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}