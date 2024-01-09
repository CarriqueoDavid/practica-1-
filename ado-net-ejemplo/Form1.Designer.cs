namespace ado_net_ejemplo
{
    partial class fmrpokemons
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvpokemon = new System.Windows.Forms.DataGridView();
            this.pb_pokemon = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpokemon
            // 
            this.dgvpokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpokemon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvpokemon.Location = new System.Drawing.Point(54, 43);
            this.dgvpokemon.Name = "dgvpokemon";
            this.dgvpokemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpokemon.Size = new System.Drawing.Size(502, 257);
            this.dgvpokemon.TabIndex = 0;
            this.dgvpokemon.SelectionChanged += new System.EventHandler(this.dgvpokemon_SelectionChanged);
            // 
            // pb_pokemon
            // 
            this.pb_pokemon.Location = new System.Drawing.Point(612, 44);
            this.pb_pokemon.Name = "pb_pokemon";
            this.pb_pokemon.Size = new System.Drawing.Size(243, 218);
            this.pb_pokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pokemon.TabIndex = 1;
            this.pb_pokemon.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(669, 308);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elementos";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(58, 363);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // fmrpokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pb_pokemon);
            this.Controls.Add(this.dgvpokemon);
            this.Name = "fmrpokemons";
            this.Text = "Pokemons";
            this.Load += new System.EventHandler(this.fmrpokemons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpokemon;
        private System.Windows.Forms.PictureBox pb_pokemon;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
    }
}

