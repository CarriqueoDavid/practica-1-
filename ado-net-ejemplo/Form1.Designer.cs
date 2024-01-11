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
            this.bmodif = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btneliminarlogico = new System.Windows.Forms.Button();
            this.lfiltro = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.btnfiltro = new System.Windows.Forms.Button();
            this.lbcampo = new System.Windows.Forms.Label();
            this.lbcriterio = new System.Windows.Forms.Label();
            this.lbclave = new System.Windows.Forms.Label();
            this.cbocampo = new System.Windows.Forms.ComboBox();
            this.cbocriterio = new System.Windows.Forms.ComboBox();
            this.txtclave = new System.Windows.Forms.TextBox();
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
            // bmodif
            // 
            this.bmodif.Location = new System.Drawing.Point(155, 365);
            this.bmodif.Name = "bmodif";
            this.bmodif.Size = new System.Drawing.Size(75, 23);
            this.bmodif.TabIndex = 5;
            this.bmodif.Text = "modificar";
            this.bmodif.UseVisualStyleBackColor = true;
            this.bmodif.Click += new System.EventHandler(this.bmodif_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(249, 365);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 6;
            this.btnborrar.Text = "borrar fisico";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btneliminarlogico
            // 
            this.btneliminarlogico.Location = new System.Drawing.Point(376, 365);
            this.btneliminarlogico.Name = "btneliminarlogico";
            this.btneliminarlogico.Size = new System.Drawing.Size(105, 23);
            this.btneliminarlogico.TabIndex = 7;
            this.btneliminarlogico.Text = "eliminar logico";
            this.btneliminarlogico.UseVisualStyleBackColor = true;
            this.btneliminarlogico.Click += new System.EventHandler(this.btneliminarlogico_Click);
            // 
            // lfiltro
            // 
            this.lfiltro.AutoSize = true;
            this.lfiltro.Location = new System.Drawing.Point(51, 20);
            this.lfiltro.Name = "lfiltro";
            this.lfiltro.Size = new System.Drawing.Size(26, 13);
            this.lfiltro.TabIndex = 8;
            this.lfiltro.Text = "filtro";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(83, 14);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(135, 20);
            this.txtfiltro.TabIndex = 9;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // btnfiltro
            // 
            this.btnfiltro.Location = new System.Drawing.Point(581, 410);
            this.btnfiltro.Name = "btnfiltro";
            this.btnfiltro.Size = new System.Drawing.Size(75, 23);
            this.btnfiltro.TabIndex = 10;
            this.btnfiltro.Text = "buscar";
            this.btnfiltro.UseVisualStyleBackColor = true;
            this.btnfiltro.Click += new System.EventHandler(this.btnfiltro_Click);
            // 
            // lbcampo
            // 
            this.lbcampo.AutoSize = true;
            this.lbcampo.Location = new System.Drawing.Point(12, 413);
            this.lbcampo.Name = "lbcampo";
            this.lbcampo.Size = new System.Drawing.Size(39, 13);
            this.lbcampo.TabIndex = 11;
            this.lbcampo.Text = "campo";
            // 
            // lbcriterio
            // 
            this.lbcriterio.AutoSize = true;
            this.lbcriterio.Location = new System.Drawing.Point(210, 415);
            this.lbcriterio.Name = "lbcriterio";
            this.lbcriterio.Size = new System.Drawing.Size(38, 13);
            this.lbcriterio.TabIndex = 12;
            this.lbcriterio.Text = "criterio";
            // 
            // lbclave
            // 
            this.lbclave.AutoSize = true;
            this.lbclave.Location = new System.Drawing.Point(390, 415);
            this.lbclave.Name = "lbclave";
            this.lbclave.Size = new System.Drawing.Size(26, 13);
            this.lbclave.TabIndex = 13;
            this.lbclave.Text = "filtro";
            // 
            // cbocampo
            // 
            this.cbocampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocampo.FormattingEnabled = true;
            this.cbocampo.Location = new System.Drawing.Point(58, 412);
            this.cbocampo.Name = "cbocampo";
            this.cbocampo.Size = new System.Drawing.Size(121, 21);
            this.cbocampo.TabIndex = 14;
            this.cbocampo.SelectedIndexChanged += new System.EventHandler(this.cbocampo_SelectedIndexChanged);
            // 
            // cbocriterio
            // 
            this.cbocriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocriterio.FormattingEnabled = true;
            this.cbocriterio.Location = new System.Drawing.Point(249, 412);
            this.cbocriterio.Name = "cbocriterio";
            this.cbocriterio.Size = new System.Drawing.Size(121, 21);
            this.cbocriterio.TabIndex = 15;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(422, 412);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(100, 20);
            this.txtclave.TabIndex = 16;
            // 
            // fmrpokemons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.cbocriterio);
            this.Controls.Add(this.cbocampo);
            this.Controls.Add(this.lbclave);
            this.Controls.Add(this.lbcriterio);
            this.Controls.Add(this.lbcampo);
            this.Controls.Add(this.btnfiltro);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.lfiltro);
            this.Controls.Add(this.btneliminarlogico);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.bmodif);
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
        private System.Windows.Forms.Button bmodif;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btneliminarlogico;
        private System.Windows.Forms.Label lfiltro;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Button btnfiltro;
        private System.Windows.Forms.Label lbcampo;
        private System.Windows.Forms.Label lbcriterio;
        private System.Windows.Forms.Label lbclave;
        private System.Windows.Forms.ComboBox cbocampo;
        private System.Windows.Forms.ComboBox cbocriterio;
        private System.Windows.Forms.TextBox txtclave;
    }
}

