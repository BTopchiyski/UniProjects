namespace HeroWarsGame
{
    partial class MainMenu
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
            this.MM_CharPreview = new System.Windows.Forms.PictureBox();
            this.MM_CharName = new System.Windows.Forms.TextBox();
            this.MM_Level = new System.Windows.Forms.TextBox();
            this.MM_Gold = new System.Windows.Forms.TextBox();
            this.MM_Wins = new System.Windows.Forms.TextBox();
            this.MM_LvlText = new System.Windows.Forms.Label();
            this.MM_GoldText = new System.Windows.Forms.Label();
            this.MM_WinsText = new System.Windows.Forms.Label();
            this.Start_GameName = new System.Windows.Forms.TextBox();
            this.MM_DmgTxt = new System.Windows.Forms.Label();
            this.MM_Dmg = new System.Windows.Forms.TextBox();
            this.MM_IncreaseDmg = new System.Windows.Forms.Button();
            this.MM_ToBattle = new System.Windows.Forms.Button();
            this.MM_QuitStartMenu = new System.Windows.Forms.Button();
            this.MM_SwitchChar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MM_CharPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // MM_CharPreview
            // 
            this.MM_CharPreview.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MM_CharPreview.Location = new System.Drawing.Point(36, 98);
            this.MM_CharPreview.Margin = new System.Windows.Forms.Padding(4);
            this.MM_CharPreview.Name = "MM_CharPreview";
            this.MM_CharPreview.Size = new System.Drawing.Size(132, 116);
            this.MM_CharPreview.TabIndex = 0;
            this.MM_CharPreview.TabStop = false;
            this.MM_CharPreview.Click += new System.EventHandler(this.MM_CharPreview_Click);
            // 
            // MM_CharName
            // 
            this.MM_CharName.AccessibleName = "False";
            this.MM_CharName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MM_CharName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MM_CharName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MM_CharName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MM_CharName.Location = new System.Drawing.Point(36, 70);
            this.MM_CharName.Margin = new System.Windows.Forms.Padding(4);
            this.MM_CharName.Name = "MM_CharName";
            this.MM_CharName.ReadOnly = true;
            this.MM_CharName.Size = new System.Drawing.Size(160, 22);
            this.MM_CharName.TabIndex = 6;
            this.MM_CharName.Text = "CharacterName";
            // 
            // MM_Level
            // 
            this.MM_Level.AccessibleName = "False";
            this.MM_Level.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MM_Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MM_Level.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MM_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MM_Level.Location = new System.Drawing.Point(80, 240);
            this.MM_Level.Margin = new System.Windows.Forms.Padding(4);
            this.MM_Level.Name = "MM_Level";
            this.MM_Level.ReadOnly = true;
            this.MM_Level.Size = new System.Drawing.Size(160, 22);
            this.MM_Level.TabIndex = 9;
            // 
            // MM_Gold
            // 
            this.MM_Gold.AccessibleName = "False";
            this.MM_Gold.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MM_Gold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MM_Gold.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MM_Gold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MM_Gold.Location = new System.Drawing.Point(80, 284);
            this.MM_Gold.Margin = new System.Windows.Forms.Padding(4);
            this.MM_Gold.Name = "MM_Gold";
            this.MM_Gold.ReadOnly = true;
            this.MM_Gold.Size = new System.Drawing.Size(160, 22);
            this.MM_Gold.TabIndex = 10;
            // 
            // MM_Wins
            // 
            this.MM_Wins.AccessibleName = "False";
            this.MM_Wins.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MM_Wins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MM_Wins.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MM_Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MM_Wins.Location = new System.Drawing.Point(80, 324);
            this.MM_Wins.Margin = new System.Windows.Forms.Padding(4);
            this.MM_Wins.Name = "MM_Wins";
            this.MM_Wins.ReadOnly = true;
            this.MM_Wins.Size = new System.Drawing.Size(160, 22);
            this.MM_Wins.TabIndex = 11;
            // 
            // MM_LvlText
            // 
            this.MM_LvlText.AutoSize = true;
            this.MM_LvlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MM_LvlText.Location = new System.Drawing.Point(32, 239);
            this.MM_LvlText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MM_LvlText.Name = "MM_LvlText";
            this.MM_LvlText.Size = new System.Drawing.Size(38, 24);
            this.MM_LvlText.TabIndex = 13;
            this.MM_LvlText.Text = "Lvl:";
            this.MM_LvlText.Click += new System.EventHandler(this.label1_Click);
            // 
            // MM_GoldText
            // 
            this.MM_GoldText.AutoSize = true;
            this.MM_GoldText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MM_GoldText.Location = new System.Drawing.Point(13, 283);
            this.MM_GoldText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MM_GoldText.Name = "MM_GoldText";
            this.MM_GoldText.Size = new System.Drawing.Size(55, 24);
            this.MM_GoldText.TabIndex = 14;
            this.MM_GoldText.Text = "Gold:";
            // 
            // MM_WinsText
            // 
            this.MM_WinsText.AutoSize = true;
            this.MM_WinsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MM_WinsText.Location = new System.Drawing.Point(11, 322);
            this.MM_WinsText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MM_WinsText.Name = "MM_WinsText";
            this.MM_WinsText.Size = new System.Drawing.Size(57, 24);
            this.MM_WinsText.TabIndex = 15;
            this.MM_WinsText.Text = "Wins:";
            // 
            // Start_GameName
            // 
            this.Start_GameName.AccessibleName = "False";
            this.Start_GameName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Start_GameName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Start_GameName.Font = new System.Drawing.Font("Mistral", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_GameName.Location = new System.Drawing.Point(176, 15);
            this.Start_GameName.Margin = new System.Windows.Forms.Padding(4);
            this.Start_GameName.Multiline = true;
            this.Start_GameName.Name = "Start_GameName";
            this.Start_GameName.ReadOnly = true;
            this.Start_GameName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Start_GameName.Size = new System.Drawing.Size(191, 48);
            this.Start_GameName.TabIndex = 19;
            this.Start_GameName.Text = "HeroWars";
            // 
            // MM_DmgTxt
            // 
            this.MM_DmgTxt.AutoSize = true;
            this.MM_DmgTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MM_DmgTxt.Location = new System.Drawing.Point(8, 364);
            this.MM_DmgTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MM_DmgTxt.Name = "MM_DmgTxt";
            this.MM_DmgTxt.Size = new System.Drawing.Size(58, 24);
            this.MM_DmgTxt.TabIndex = 20;
            this.MM_DmgTxt.Text = "DMG:";
            // 
            // MM_Dmg
            // 
            this.MM_Dmg.AccessibleName = "False";
            this.MM_Dmg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MM_Dmg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MM_Dmg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MM_Dmg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MM_Dmg.Location = new System.Drawing.Point(80, 366);
            this.MM_Dmg.Margin = new System.Windows.Forms.Padding(4);
            this.MM_Dmg.Name = "MM_Dmg";
            this.MM_Dmg.ReadOnly = true;
            this.MM_Dmg.Size = new System.Drawing.Size(160, 22);
            this.MM_Dmg.TabIndex = 21;
            // 
            // MM_IncreaseDmg
            // 
            this.MM_IncreaseDmg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MM_IncreaseDmg.Location = new System.Drawing.Point(248, 361);
            this.MM_IncreaseDmg.Margin = new System.Windows.Forms.Padding(4);
            this.MM_IncreaseDmg.Name = "MM_IncreaseDmg";
            this.MM_IncreaseDmg.Size = new System.Drawing.Size(32, 32);
            this.MM_IncreaseDmg.TabIndex = 22;
            this.MM_IncreaseDmg.Text = "+";
            this.MM_IncreaseDmg.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MM_IncreaseDmg.UseVisualStyleBackColor = true;
            this.MM_IncreaseDmg.Click += new System.EventHandler(this.MM_IncreaseDmg_Click);
            // 
            // MM_ToBattle
            // 
            this.MM_ToBattle.Location = new System.Drawing.Point(355, 361);
            this.MM_ToBattle.Margin = new System.Windows.Forms.Padding(4);
            this.MM_ToBattle.Name = "MM_ToBattle";
            this.MM_ToBattle.Size = new System.Drawing.Size(135, 36);
            this.MM_ToBattle.TabIndex = 24;
            this.MM_ToBattle.Text = "Battle!";
            this.MM_ToBattle.UseVisualStyleBackColor = true;
            this.MM_ToBattle.Click += new System.EventHandler(this.MM_ToBattle_Click);
            // 
            // MM_QuitStartMenu
            // 
            this.MM_QuitStartMenu.Location = new System.Drawing.Point(356, 415);
            this.MM_QuitStartMenu.Margin = new System.Windows.Forms.Padding(4);
            this.MM_QuitStartMenu.Name = "MM_QuitStartMenu";
            this.MM_QuitStartMenu.Size = new System.Drawing.Size(133, 37);
            this.MM_QuitStartMenu.TabIndex = 26;
            this.MM_QuitStartMenu.Text = "Quit";
            this.MM_QuitStartMenu.UseVisualStyleBackColor = true;
            this.MM_QuitStartMenu.Click += new System.EventHandler(this.MM_QuitStartMenu_Click);
            // 
            // MM_SwitchChar
            // 
            this.MM_SwitchChar.Location = new System.Drawing.Point(59, 415);
            this.MM_SwitchChar.Margin = new System.Windows.Forms.Padding(4);
            this.MM_SwitchChar.Name = "MM_SwitchChar";
            this.MM_SwitchChar.Size = new System.Drawing.Size(153, 38);
            this.MM_SwitchChar.TabIndex = 27;
            this.MM_SwitchChar.Text = "Switch Character";
            this.MM_SwitchChar.UseVisualStyleBackColor = true;
            this.MM_SwitchChar.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 479);
            this.Controls.Add(this.MM_SwitchChar);
            this.Controls.Add(this.MM_QuitStartMenu);
            this.Controls.Add(this.MM_ToBattle);
            this.Controls.Add(this.MM_IncreaseDmg);
            this.Controls.Add(this.MM_Dmg);
            this.Controls.Add(this.MM_DmgTxt);
            this.Controls.Add(this.Start_GameName);
            this.Controls.Add(this.MM_WinsText);
            this.Controls.Add(this.MM_GoldText);
            this.Controls.Add(this.MM_LvlText);
            this.Controls.Add(this.MM_Wins);
            this.Controls.Add(this.MM_Gold);
            this.Controls.Add(this.MM_Level);
            this.Controls.Add(this.MM_CharName);
            this.Controls.Add(this.MM_CharPreview);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MM_CharPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MM_CharPreview;
        private System.Windows.Forms.TextBox MM_CharName;
        private System.Windows.Forms.TextBox MM_Level;
        private System.Windows.Forms.TextBox MM_Gold;
        private System.Windows.Forms.TextBox MM_Wins;
        private System.Windows.Forms.Label MM_LvlText;
        private System.Windows.Forms.Label MM_GoldText;
        private System.Windows.Forms.Label MM_WinsText;
        private System.Windows.Forms.TextBox Start_GameName;
        private System.Windows.Forms.Label MM_DmgTxt;
        private System.Windows.Forms.TextBox MM_Dmg;
        private System.Windows.Forms.Button MM_IncreaseDmg;
        private System.Windows.Forms.Button MM_ToBattle;
        private System.Windows.Forms.Button MM_QuitStartMenu;
        private System.Windows.Forms.Button MM_SwitchChar;
    }
}