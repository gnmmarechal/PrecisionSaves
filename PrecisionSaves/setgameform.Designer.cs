namespace PrecisionSaves
{
    partial class setgameform
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
            this.game_combobox = new System.Windows.Forms.ComboBox();
            this.selectgame_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // game_combobox
            // 
            this.game_combobox.FormattingEnabled = true;
            this.game_combobox.Items.AddRange(new object[] {
            "Hatsune Miku: Project Mirai DX (EUR/US)",
            "Pokémon: Alpha Sapphire (EUR/US)",
            "Pokémon: Omega Ruby (EUR/US)",
            "Pokémon: X (EUR/US)",
            "Pokémon: Y (EUR/US)"});
            this.game_combobox.Location = new System.Drawing.Point(13, 13);
            this.game_combobox.Name = "game_combobox";
            this.game_combobox.Size = new System.Drawing.Size(243, 21);
            this.game_combobox.TabIndex = 0;
            // 
            // selectgame_button
            // 
            this.selectgame_button.Location = new System.Drawing.Point(262, 13);
            this.selectgame_button.Name = "selectgame_button";
            this.selectgame_button.Size = new System.Drawing.Size(75, 21);
            this.selectgame_button.TabIndex = 1;
            this.selectgame_button.Text = "Select";
            this.selectgame_button.UseVisualStyleBackColor = true;
            // 
            // setgameform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 56);
            this.Controls.Add(this.selectgame_button);
            this.Controls.Add(this.game_combobox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "setgameform";
            this.Text = "Select Game:";
            this.Load += new System.EventHandler(this.setgameform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox game_combobox;
        private System.Windows.Forms.Button selectgame_button;
    }
}