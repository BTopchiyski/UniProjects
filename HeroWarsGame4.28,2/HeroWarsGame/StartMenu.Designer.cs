namespace HeroWarsGame
{
    partial class StartMenu
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
            this.StartMenu_StartGame = new System.Windows.Forms.Button();
            this.StartMenu_CreateCharacter = new System.Windows.Forms.Button();
            this.HeroWars_Label = new System.Windows.Forms.Label();
            this.StarMenu_Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartMenu_StartGame
            // 
            this.StartMenu_StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartMenu_StartGame.Location = new System.Drawing.Point(156, 233);
            this.StartMenu_StartGame.Name = "StartMenu_StartGame";
            this.StartMenu_StartGame.Size = new System.Drawing.Size(158, 39);
            this.StartMenu_StartGame.TabIndex = 7;
            this.StartMenu_StartGame.Text = "Start Game";
            this.StartMenu_StartGame.UseVisualStyleBackColor = true;
            this.StartMenu_StartGame.Click += new System.EventHandler(this.StartMenu_StartGame_Click);
            // 
            // StartMenu_CreateCharacter
            // 
            this.StartMenu_CreateCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartMenu_CreateCharacter.Location = new System.Drawing.Point(156, 167);
            this.StartMenu_CreateCharacter.Name = "StartMenu_CreateCharacter";
            this.StartMenu_CreateCharacter.Size = new System.Drawing.Size(158, 39);
            this.StartMenu_CreateCharacter.TabIndex = 9;
            this.StartMenu_CreateCharacter.Text = "Create Character";
            this.StartMenu_CreateCharacter.UseVisualStyleBackColor = true;
            this.StartMenu_CreateCharacter.Click += new System.EventHandler(this.StartMenu_CreateCharacter_Click);
            // 
            // HeroWars_Label
            // 
            this.HeroWars_Label.AccessibleDescription = "False";
            this.HeroWars_Label.AccessibleName = "False";
            this.HeroWars_Label.AutoSize = true;
            this.HeroWars_Label.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroWars_Label.Location = new System.Drawing.Point(125, 60);
            this.HeroWars_Label.Name = "HeroWars_Label";
            this.HeroWars_Label.Size = new System.Drawing.Size(229, 76);
            this.HeroWars_Label.TabIndex = 10;
            this.HeroWars_Label.Text = "HeroWars";
            // 
            // StarMenu_Quit
            // 
            this.StarMenu_Quit.Location = new System.Drawing.Point(183, 292);
            this.StarMenu_Quit.Name = "StarMenu_Quit";
            this.StarMenu_Quit.Size = new System.Drawing.Size(100, 30);
            this.StarMenu_Quit.TabIndex = 11;
            this.StarMenu_Quit.Text = "Quit";
            this.StarMenu_Quit.UseVisualStyleBackColor = true;
            this.StarMenu_Quit.Click += new System.EventHandler(this.StarMenu_Quit_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 345);
            this.Controls.Add(this.StarMenu_Quit);
            this.Controls.Add(this.HeroWars_Label);
            this.Controls.Add(this.StartMenu_CreateCharacter);
            this.Controls.Add(this.StartMenu_StartGame);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartMenu_StartGame;
        private System.Windows.Forms.Button StartMenu_CreateCharacter;
        private System.Windows.Forms.Label HeroWars_Label;
        private System.Windows.Forms.Button StarMenu_Quit;
    }
}