namespace UI
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
            this.components = new System.ComponentModel.Container();
            this.lbl_player = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.game_field = new System.Windows.Forms.GroupBox();
            this.Game_Timer = new System.Windows.Forms.Timer(this.components);
            this.tmr_Open = new System.Windows.Forms.Timer(this.components);
            this.tmr_Close = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_player
            // 
            this.lbl_player.AutoSize = true;
            this.lbl_player.Location = new System.Drawing.Point(730, 11);
            this.lbl_player.Name = "lbl_player";
            this.lbl_player.Size = new System.Drawing.Size(0, 17);
            this.lbl_player.TabIndex = 10;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(76, 11);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(163, 57);
            this.btn_Start.TabIndex = 9;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // game_field
            // 
            this.game_field.Location = new System.Drawing.Point(50, 99);
            this.game_field.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_field.Name = "game_field";
            this.game_field.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.game_field.Size = new System.Drawing.Size(635, 550);
            this.game_field.TabIndex = 8;
            this.game_field.TabStop = false;
            // 
            // Game_Timer
            // 
            this.Game_Timer.Interval = 30000;
            this.Game_Timer.Tick += new System.EventHandler(this.Game_Timer_Tick);
            // 
            // tmr_Open
            // 
            this.tmr_Open.Interval = 2000;
            this.tmr_Open.Tick += new System.EventHandler(this.tmr_Open_Tick);
            // 
            // tmr_Close
            // 
            this.tmr_Close.Interval = 2000;
            this.tmr_Close.Tick += new System.EventHandler(this.tmr_Close_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 699);
            this.Controls.Add(this.lbl_player);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.game_field);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_player;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.GroupBox game_field;
        private System.Windows.Forms.Timer Game_Timer;
        private System.Windows.Forms.Timer tmr_Open;
        private System.Windows.Forms.Timer tmr_Close;
    }
}

