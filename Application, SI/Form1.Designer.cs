
namespace Application__SI
{
    partial class EasyCheat
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyCheat));
            this.titre = new System.Windows.Forms.Label();
            this.terminale = new System.Windows.Forms.Button();
            this.premiere = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nousContacter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titre
            // 
            this.titre.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.titre, "titre");
            this.titre.ForeColor = System.Drawing.Color.LawnGreen;
            this.titre.Name = "titre";
            this.titre.Click += new System.EventHandler(this.label2_Click);
            // 
            // terminale
            // 
            this.terminale.BackColor = System.Drawing.Color.Transparent;
            this.terminale.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.terminale, "terminale");
            this.terminale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.terminale.Name = "terminale";
            this.terminale.UseVisualStyleBackColor = false;
            this.terminale.Click += new System.EventHandler(this.terminale_Click);
            // 
            // premiere
            // 
            this.premiere.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.premiere, "premiere");
            this.premiere.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.premiere.Name = "premiere";
            this.premiere.UseVisualStyleBackColor = true;
            this.premiere.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // nousContacter
            // 
            this.nousContacter.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.nousContacter, "nousContacter");
            this.nousContacter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nousContacter.Name = "nousContacter";
            this.nousContacter.UseVisualStyleBackColor = false;
            this.nousContacter.Click += new System.EventHandler(this.nousContacter_Click);
            // 
            // EasyCheat
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.premiere);
            this.Controls.Add(this.nousContacter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.terminale);
            this.Controls.Add(this.titre);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "EasyCheat";
            this.Load += new System.EventHandler(this.EasyCheat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nousContacter;
        private System.Windows.Forms.Button premiere;
        private System.Windows.Forms.Button terminale;
    }
}

