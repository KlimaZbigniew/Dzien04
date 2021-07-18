
namespace MathQuiz
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.lblTimer = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblQ1 = new System.Windows.Forms.Label();
            this.numQ1 = new System.Windows.Forms.NumericUpDown();
            this.numQ4 = new System.Windows.Forms.NumericUpDown();
            this.lblQ4 = new System.Windows.Forms.Label();
            this.numQ3 = new System.Windows.Forms.NumericUpDown();
            this.lblQ3 = new System.Windows.Forms.Label();
            this.numQ2 = new System.Windows.Forms.NumericUpDown();
            this.lblQ2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timerQuiz = new System.Windows.Forms.Timer(this.components);
            this.panel1Quiz = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ2)).BeginInit();
            this.panel1Quiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTimer.Location = new System.Drawing.Point(31, 40);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(329, 39);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "Pozostały czas: XX sek.";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(503, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabel1.Text = "wersja 1.0";
            // 
            // lblQ1
            // 
            this.lblQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQ1.Location = new System.Drawing.Point(51, 104);
            this.lblQ1.Name = "lblQ1";
            this.lblQ1.Size = new System.Drawing.Size(174, 40);
            this.lblQ1.TabIndex = 2;
            this.lblQ1.Text = "11 +11 =";
            this.lblQ1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numQ1
            // 
            this.numQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numQ1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numQ1.InterceptArrowKeys = false;
            this.numQ1.Location = new System.Drawing.Point(231, 109);
            this.numQ1.Name = "numQ1";
            this.numQ1.Size = new System.Drawing.Size(120, 35);
            this.numQ1.TabIndex = 2;
            this.numQ1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQ1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numQ1.Enter += new System.EventHandler(this.numQ1_Enter);
            // 
            // numQ4
            // 
            this.numQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numQ4.InterceptArrowKeys = false;
            this.numQ4.Location = new System.Drawing.Point(231, 232);
            this.numQ4.Name = "numQ4";
            this.numQ4.Size = new System.Drawing.Size(120, 35);
            this.numQ4.TabIndex = 5;
            this.numQ4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblQ4
            // 
            this.lblQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQ4.Location = new System.Drawing.Point(51, 227);
            this.lblQ4.Name = "lblQ4";
            this.lblQ4.Size = new System.Drawing.Size(174, 40);
            this.lblQ4.TabIndex = 4;
            this.lblQ4.Text = "11 / 11 =";
            this.lblQ4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numQ3
            // 
            this.numQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numQ3.InterceptArrowKeys = false;
            this.numQ3.Location = new System.Drawing.Point(231, 191);
            this.numQ3.Name = "numQ3";
            this.numQ3.Size = new System.Drawing.Size(120, 35);
            this.numQ3.TabIndex = 4;
            this.numQ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblQ3
            // 
            this.lblQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQ3.Location = new System.Drawing.Point(51, 186);
            this.lblQ3.Name = "lblQ3";
            this.lblQ3.Size = new System.Drawing.Size(174, 40);
            this.lblQ3.TabIndex = 6;
            this.lblQ3.Text = "11 *11 =";
            this.lblQ3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numQ2
            // 
            this.numQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numQ2.InterceptArrowKeys = false;
            this.numQ2.Location = new System.Drawing.Point(231, 150);
            this.numQ2.Name = "numQ2";
            this.numQ2.Size = new System.Drawing.Size(120, 35);
            this.numQ2.TabIndex = 3;
            this.numQ2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblQ2
            // 
            this.lblQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQ2.Location = new System.Drawing.Point(-5, 64);
            this.lblQ2.Name = "lblQ2";
            this.lblQ2.Size = new System.Drawing.Size(174, 40);
            this.lblQ2.TabIndex = 8;
            this.lblQ2.Text = "11 -11 =";
            this.lblQ2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(168, 291);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 39);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timerQuiz
            // 
            this.timerQuiz.Interval = 1000;
            this.timerQuiz.Tick += new System.EventHandler(this.timerQuiz_Tick);
            // 
            // panel1Quiz
            // 
            this.panel1Quiz.Controls.Add(this.lblQ2);
            this.panel1Quiz.Location = new System.Drawing.Point(37, 76);
            this.panel1Quiz.Name = "panel1Quiz";
            this.panel1Quiz.Size = new System.Drawing.Size(344, 209);
            this.panel1Quiz.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 383);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numQ2);
            this.Controls.Add(this.numQ3);
            this.Controls.Add(this.lblQ3);
            this.Controls.Add(this.numQ4);
            this.Controls.Add(this.lblQ4);
            this.Controls.Add(this.numQ1);
            this.Controls.Add(this.lblQ1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.panel1Quiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathQuiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQ2)).EndInit();
            this.panel1Quiz.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblQ1;
        private System.Windows.Forms.NumericUpDown numQ1;
        private System.Windows.Forms.NumericUpDown numQ4;
        private System.Windows.Forms.Label lblQ4;
        private System.Windows.Forms.NumericUpDown numQ3;
        private System.Windows.Forms.Label lblQ3;
        private System.Windows.Forms.NumericUpDown numQ2;
        private System.Windows.Forms.Label lblQ2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerQuiz;
        private System.Windows.Forms.Panel panel1Quiz;
    }
}

