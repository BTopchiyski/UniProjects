namespace HeroWarsGame
{
    partial class CharacterCreator
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
            this.CC_NameBox = new System.Windows.Forms.TextBox();
            this.CC_Create = new System.Windows.Forms.Button();
            this.CC_Male = new System.Windows.Forms.RadioButton();
            this.CC_Female = new System.Windows.Forms.RadioButton();
            this.CC_NameTxt = new System.Windows.Forms.Label();
            this.CC_GenderTxt = new System.Windows.Forms.Label();
            this.CC_RaceTxt = new System.Windows.Forms.Label();
            this.CC_ClassTxt = new System.Windows.Forms.Label();
            this.Start_GameName = new System.Windows.Forms.TextBox();
            this.CC_RaceList = new System.Windows.Forms.ComboBox();
            this.CC_ClassList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CC_NameBox
            // 
            this.CC_NameBox.Location = new System.Drawing.Point(12, 77);
            this.CC_NameBox.Name = "CC_NameBox";
            this.CC_NameBox.Size = new System.Drawing.Size(199, 20);
            this.CC_NameBox.TabIndex = 0;
            this.CC_NameBox.TextChanged += new System.EventHandler(this.CC_NameBox_TextChanged);
            // 
            // CC_Create
            // 
            this.CC_Create.Location = new System.Drawing.Point(136, 287);
            this.CC_Create.Name = "CC_Create";
            this.CC_Create.Size = new System.Drawing.Size(75, 23);
            this.CC_Create.TabIndex = 2;
            this.CC_Create.Text = "Create";
            this.CC_Create.UseVisualStyleBackColor = true;
            this.CC_Create.Click += new System.EventHandler(this.CC_Create_Click);
            // 
            // CC_Male
            // 
            this.CC_Male.AutoSize = true;
            this.CC_Male.Location = new System.Drawing.Point(13, 132);
            this.CC_Male.Name = "CC_Male";
            this.CC_Male.Size = new System.Drawing.Size(48, 17);
            this.CC_Male.TabIndex = 7;
            this.CC_Male.TabStop = true;
            this.CC_Male.Text = "Male";
            this.CC_Male.UseVisualStyleBackColor = true;
            // 
            // CC_Female
            // 
            this.CC_Female.AutoSize = true;
            this.CC_Female.Location = new System.Drawing.Point(67, 132);
            this.CC_Female.Name = "CC_Female";
            this.CC_Female.Size = new System.Drawing.Size(59, 17);
            this.CC_Female.TabIndex = 8;
            this.CC_Female.TabStop = true;
            this.CC_Female.Text = "Female";
            this.CC_Female.UseVisualStyleBackColor = true;
            // 
            // CC_NameTxt
            // 
            this.CC_NameTxt.AutoSize = true;
            this.CC_NameTxt.Location = new System.Drawing.Point(12, 61);
            this.CC_NameTxt.Name = "CC_NameTxt";
            this.CC_NameTxt.Size = new System.Drawing.Size(38, 13);
            this.CC_NameTxt.TabIndex = 14;
            this.CC_NameTxt.Text = "Name:";
            // 
            // CC_GenderTxt
            // 
            this.CC_GenderTxt.AutoSize = true;
            this.CC_GenderTxt.Location = new System.Drawing.Point(12, 116);
            this.CC_GenderTxt.Name = "CC_GenderTxt";
            this.CC_GenderTxt.Size = new System.Drawing.Size(45, 13);
            this.CC_GenderTxt.TabIndex = 15;
            this.CC_GenderTxt.Text = "Gender:";
            // 
            // CC_RaceTxt
            // 
            this.CC_RaceTxt.AutoSize = true;
            this.CC_RaceTxt.Location = new System.Drawing.Point(12, 165);
            this.CC_RaceTxt.Name = "CC_RaceTxt";
            this.CC_RaceTxt.Size = new System.Drawing.Size(36, 13);
            this.CC_RaceTxt.TabIndex = 16;
            this.CC_RaceTxt.Text = "Race:";
            // 
            // CC_ClassTxt
            // 
            this.CC_ClassTxt.AutoSize = true;
            this.CC_ClassTxt.Location = new System.Drawing.Point(10, 217);
            this.CC_ClassTxt.Name = "CC_ClassTxt";
            this.CC_ClassTxt.Size = new System.Drawing.Size(35, 13);
            this.CC_ClassTxt.TabIndex = 17;
            this.CC_ClassTxt.Text = "Class:";
            // 
            // Start_GameName
            // 
            this.Start_GameName.AccessibleName = "False";
            this.Start_GameName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Start_GameName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Start_GameName.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_GameName.Location = new System.Drawing.Point(55, 12);
            this.Start_GameName.Multiline = true;
            this.Start_GameName.Name = "Start_GameName";
            this.Start_GameName.ReadOnly = true;
            this.Start_GameName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Start_GameName.Size = new System.Drawing.Size(130, 40);
            this.Start_GameName.TabIndex = 18;
            this.Start_GameName.Text = "HeroWars";
            // 
            // CC_RaceList
            // 
            this.CC_RaceList.AccessibleDescription = "";
            this.CC_RaceList.AccessibleName = "";
            this.CC_RaceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CC_RaceList.FormattingEnabled = true;
            this.CC_RaceList.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Dwarf"});
            this.CC_RaceList.Location = new System.Drawing.Point(12, 181);
            this.CC_RaceList.Name = "CC_RaceList";
            this.CC_RaceList.Size = new System.Drawing.Size(199, 21);
            this.CC_RaceList.TabIndex = 19;
            // 
            // CC_ClassList
            // 
            this.CC_ClassList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CC_ClassList.FormattingEnabled = true;
            this.CC_ClassList.Items.AddRange(new object[] {
            "Archer",
            "Mage",
            "Gunner"});
            this.CC_ClassList.Location = new System.Drawing.Point(12, 233);
            this.CC_ClassList.Name = "CC_ClassList";
            this.CC_ClassList.Size = new System.Drawing.Size(199, 21);
            this.CC_ClassList.TabIndex = 20;
            // 
            // CharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 322);
            this.Controls.Add(this.CC_ClassList);
            this.Controls.Add(this.CC_RaceList);
            this.Controls.Add(this.Start_GameName);
            this.Controls.Add(this.CC_ClassTxt);
            this.Controls.Add(this.CC_RaceTxt);
            this.Controls.Add(this.CC_GenderTxt);
            this.Controls.Add(this.CC_NameTxt);
            this.Controls.Add(this.CC_Female);
            this.Controls.Add(this.CC_Male);
            this.Controls.Add(this.CC_Create);
            this.Controls.Add(this.CC_NameBox);
            this.Name = "CharacterCreator";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CharacterCreator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CC_NameBox;
        private System.Windows.Forms.Button CC_Create;
        private System.Windows.Forms.RadioButton CC_Male;
        private System.Windows.Forms.RadioButton CC_Female;
        private System.Windows.Forms.Label CC_NameTxt;
        private System.Windows.Forms.Label CC_GenderTxt;
        private System.Windows.Forms.Label CC_RaceTxt;
        private System.Windows.Forms.Label CC_ClassTxt;
        private System.Windows.Forms.TextBox Start_GameName;
        private System.Windows.Forms.ComboBox CC_RaceList;
        private System.Windows.Forms.ComboBox CC_ClassList;
    }
}

