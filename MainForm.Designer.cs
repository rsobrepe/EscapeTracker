namespace HighScore
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDaily = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWeekly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonthly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.editDaily = new System.Windows.Forms.ToolStripMenuItem();
            this.editWeekly = new System.Windows.Forms.ToolStripMenuItem();
            this.editMonthly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDa = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.comboRoom = new System.Windows.Forms.ComboBox();
            this.pnlList = new System.Windows.Forms.Panel();
            this.lblTimeSlot = new System.Windows.Forms.Label();
            this.txtTimeSlot = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.checkPass = new System.Windows.Forms.CheckBox();
            this.checkFail = new System.Windows.Forms.CheckBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblClues = new System.Windows.Forms.Label();
            this.txtClues = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitle.Controls.Add(this.lblDa);
            this.pnlTitle.Controls.Add(this.lblDate);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(12, 36);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(776, 66);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell Nova Cond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(255, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(265, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "High Score Tracker";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Controls.Add(this.txtClues);
            this.pnlMain.Controls.Add(this.lblClues);
            this.pnlMain.Controls.Add(this.txtDuration);
            this.pnlMain.Controls.Add(this.lblDuration);
            this.pnlMain.Controls.Add(this.checkFail);
            this.pnlMain.Controls.Add(this.checkPass);
            this.pnlMain.Controls.Add(this.lblResult);
            this.pnlMain.Controls.Add(this.txtTimeSlot);
            this.pnlMain.Controls.Add(this.lblTimeSlot);
            this.pnlMain.Controls.Add(this.comboRoom);
            this.pnlMain.Controls.Add(this.lblRoom);
            this.pnlMain.Location = new System.Drawing.Point(12, 122);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(358, 316);
            this.pnlMain.TabIndex = 1;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHistory,
            this.mnuEdit,
            this.mnuHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 2;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuView,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(180, 22);
            this.mnuSave.Text = "Save";
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(180, 22);
            this.mnuView.Text = "Export";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuHistory
            // 
            this.mnuHistory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDaily,
            this.mnuWeekly,
            this.mnuMonthly});
            this.mnuHistory.Name = "mnuHistory";
            this.mnuHistory.Size = new System.Drawing.Size(57, 20);
            this.mnuHistory.Text = "History";
            // 
            // mnuDaily
            // 
            this.mnuDaily.Name = "mnuDaily";
            this.mnuDaily.Size = new System.Drawing.Size(180, 22);
            this.mnuDaily.Text = "Daily";
            // 
            // mnuWeekly
            // 
            this.mnuWeekly.Name = "mnuWeekly";
            this.mnuWeekly.Size = new System.Drawing.Size(180, 22);
            this.mnuWeekly.Text = "Weekly";
            // 
            // mnuMonthly
            // 
            this.mnuMonthly.Name = "mnuMonthly";
            this.mnuMonthly.Size = new System.Drawing.Size(180, 22);
            this.mnuMonthly.Text = "Monthly";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDaily,
            this.editWeekly,
            this.editMonthly});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "Edit";
            // 
            // editDaily
            // 
            this.editDaily.Name = "editDaily";
            this.editDaily.Size = new System.Drawing.Size(180, 22);
            this.editDaily.Text = "Daily";
            // 
            // editWeekly
            // 
            this.editWeekly.Name = "editWeekly";
            this.editWeekly.Size = new System.Drawing.Size(180, 22);
            this.editWeekly.Text = "Weekly";
            // 
            // editMonthly
            // 
            this.editMonthly.Name = "editMonthly";
            this.editMonthly.Size = new System.Drawing.Size(180, 22);
            this.editMonthly.Text = "Monthly";
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Rockwell Nova Cond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(607, 36);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 18);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // lblDa
            // 
            this.lblDa.AutoSize = true;
            this.lblDa.BackColor = System.Drawing.Color.Transparent;
            this.lblDa.Font = new System.Drawing.Font("Rockwell Nova Cond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDa.ForeColor = System.Drawing.Color.Red;
            this.lblDa.Location = new System.Drawing.Point(650, 36);
            this.lblDa.Name = "lblDa";
            this.lblDa.Size = new System.Drawing.Size(58, 18);
            this.lblDa.TabIndex = 2;
            this.lblDa.Text = "date here";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(44, 29);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(53, 22);
            this.lblRoom.TabIndex = 0;
            this.lblRoom.Text = "Room:";
            this.lblRoom.Click += new System.EventHandler(this.lblRoom_Click);
            // 
            // comboRoom
            // 
            this.comboRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRoom.FormattingEnabled = true;
            this.comboRoom.Items.AddRange(new object[] {
            "Elevator",
            "Criminal Binds",
            "Kate\'s Motel",
            "The Last Laugh",
            "The Short Cut"});
            this.comboRoom.Location = new System.Drawing.Point(103, 29);
            this.comboRoom.Name = "comboRoom";
            this.comboRoom.Size = new System.Drawing.Size(121, 21);
            this.comboRoom.TabIndex = 1;
            this.comboRoom.Text = "Choose Room";
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.White;
            this.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlList.Location = new System.Drawing.Point(430, 122);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(358, 316);
            this.pnlList.TabIndex = 3;
            // 
            // lblTimeSlot
            // 
            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSlot.Location = new System.Drawing.Point(25, 70);
            this.lblTimeSlot.Name = "lblTimeSlot";
            this.lblTimeSlot.Size = new System.Drawing.Size(77, 22);
            this.lblTimeSlot.TabIndex = 2;
            this.lblTimeSlot.Text = "Time Slot:";
            // 
            // txtTimeSlot
            // 
            this.txtTimeSlot.Location = new System.Drawing.Point(103, 70);
            this.txtTimeSlot.Name = "txtTimeSlot";
            this.txtTimeSlot.Size = new System.Drawing.Size(121, 20);
            this.txtTimeSlot.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(41, 111);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(56, 22);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Result:";
            // 
            // checkPass
            // 
            this.checkPass.AutoSize = true;
            this.checkPass.Font = new System.Drawing.Font("Rockwell Nova Cond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPass.Location = new System.Drawing.Point(103, 113);
            this.checkPass.Name = "checkPass";
            this.checkPass.Size = new System.Drawing.Size(51, 22);
            this.checkPass.TabIndex = 5;
            this.checkPass.Text = "Pass";
            this.checkPass.UseVisualStyleBackColor = true;
            // 
            // checkFail
            // 
            this.checkFail.AutoSize = true;
            this.checkFail.Font = new System.Drawing.Font("Rockwell Nova Cond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFail.Location = new System.Drawing.Point(103, 136);
            this.checkFail.Name = "checkFail";
            this.checkFail.Size = new System.Drawing.Size(49, 22);
            this.checkFail.TabIndex = 6;
            this.checkFail.Text = "Fail";
            this.checkFail.UseVisualStyleBackColor = true;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(23, 164);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(74, 22);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = "Duration:";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(103, 167);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(121, 20);
            this.txtDuration.TabIndex = 8;
            // 
            // lblClues
            // 
            this.lblClues.AutoSize = true;
            this.lblClues.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClues.Location = new System.Drawing.Point(14, 205);
            this.lblClues.Name = "lblClues";
            this.lblClues.Size = new System.Drawing.Size(83, 22);
            this.lblClues.TabIndex = 9;
            this.lblClues.Text = "Clues Used:";
            // 
            // txtClues
            // 
            this.txtClues.Location = new System.Drawing.Point(103, 205);
            this.txtClues.Name = "txtClues";
            this.txtClues.Size = new System.Drawing.Size(121, 20);
            this.txtClues.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(103, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "HighScore Tracker";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblDa;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ComboBox comboRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHistory;
        private System.Windows.Forms.ToolStripMenuItem mnuDaily;
        private System.Windows.Forms.ToolStripMenuItem mnuWeekly;
        private System.Windows.Forms.ToolStripMenuItem mnuMonthly;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem editDaily;
        private System.Windows.Forms.ToolStripMenuItem editWeekly;
        private System.Windows.Forms.ToolStripMenuItem editMonthly;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.CheckBox checkFail;
        private System.Windows.Forms.CheckBox checkPass;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtTimeSlot;
        private System.Windows.Forms.Label lblTimeSlot;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtClues;
        private System.Windows.Forms.Label lblClues;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblDuration;
    }
}

