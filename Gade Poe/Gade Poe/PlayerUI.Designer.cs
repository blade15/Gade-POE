
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
            this.grpBxShop = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttnThird = new System.Windows.Forms.Button();
            this.bttnSecond = new System.Windows.Forms.Button();
            this.bttnFirst = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grpBxStats.SuspendLayout();
            this.grpBxAttack.SuspendLayout();
            this.grpBxShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnUp
            // 
            this.bttnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.bttnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(60)))), ((int)(((byte)(36)))));
            this.bttnUp.Location = new System.Drawing.Point(422, 382);
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
            this.bttnRight.Location = new System.Drawing.Point(496, 431);
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
            this.bttnDown.Location = new System.Drawing.Point(422, 481);
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
            this.bttnLeft.Location = new System.Drawing.Point(348, 431);
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
            this.grpBxStats.Location = new System.Drawing.Point(296, 12);
            this.grpBxStats.Name = "grpBxStats";
            this.grpBxStats.Size = new System.Drawing.Size(329, 366);
            this.grpBxStats.TabIndex = 4;
            this.grpBxStats.TabStop = false;
            this.grpBxStats.Text = "Stats";
            // 
            // rchTxtStats
            // 
            this.rchTxtStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            this.rchTxtStats.Location = new System.Drawing.Point(12, 23);
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
            // grpBxShop
            // 
            this.grpBxShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            this.grpBxShop.Controls.Add(this.pictureBox1);
            this.grpBxShop.Controls.Add(this.groupBox1);
            this.grpBxShop.Controls.Add(this.bttnThird);
            this.grpBxShop.Controls.Add(this.bttnSecond);
            this.grpBxShop.Controls.Add(this.bttnFirst);
            this.grpBxShop.Location = new System.Drawing.Point(642, 12);
            this.grpBxShop.Name = "grpBxShop";
            this.grpBxShop.Size = new System.Drawing.Size(282, 508);
            this.grpBxShop.TabIndex = 6;
            this.grpBxShop.TabStop = false;
            this.grpBxShop.Text = "Shop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Task_1.Properties.Resources.thumb_1920_482592;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 136);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dwight D. Eisenhower";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "\"In preparing for battle I have";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "always found that plans are";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "indispensable.\"";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "useless, but planning is";
            // 
            // bttnThird
            // 
            this.bttnThird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            this.bttnThird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnThird.Location = new System.Drawing.Point(6, 156);
            this.bttnThird.Name = "bttnThird";
            this.bttnThird.Size = new System.Drawing.Size(270, 59);
            this.bttnThird.TabIndex = 2;
            this.bttnThird.Text = "Weapon 3";
            this.bttnThird.UseVisualStyleBackColor = false;
            this.bttnThird.Click += new System.EventHandler(this.bttnThird_Click);
            // 
            // bttnSecond
            // 
            this.bttnSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            this.bttnSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSecond.Location = new System.Drawing.Point(6, 92);
            this.bttnSecond.Name = "bttnSecond";
            this.bttnSecond.Size = new System.Drawing.Size(270, 58);
            this.bttnSecond.TabIndex = 1;
            this.bttnSecond.Text = "Weapon 2";
            this.bttnSecond.UseVisualStyleBackColor = false;
            this.bttnSecond.Click += new System.EventHandler(this.button4_Click);
            // 
            // bttnFirst
            // 
            this.bttnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            this.bttnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnFirst.Location = new System.Drawing.Point(6, 27);
            this.bttnFirst.Name = "bttnFirst";
            this.bttnFirst.Size = new System.Drawing.Size(270, 59);
            this.bttnFirst.TabIndex = 0;
            this.bttnFirst.Text = "Weapon 1";
            this.bttnFirst.UseVisualStyleBackColor = false;
            this.bttnFirst.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(130, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Task_1.Properties.Resources.Background2;
            this.ClientSize = new System.Drawing.Size(945, 535);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpBxShop);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.grpBxStats);
            this.Controls.Add(this.bttnLeft);
            this.Controls.Add(this.bttnDown);
            this.Controls.Add(this.bttnRight);
            this.Controls.Add(this.bttnUp);
            this.Name = "frmUI";
            this.Text = "Goblins and Heroes - Attack!";
            this.Load += new System.EventHandler(this.PlayerUI_Load);
            this.grpBxStats.ResumeLayout(false);
            this.grpBxAttack.ResumeLayout(false);
            this.grpBxShop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpBxShop;
        private System.Windows.Forms.Button bttnThird;
        private System.Windows.Forms.Button bttnSecond;
        private System.Windows.Forms.Button bttnFirst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}