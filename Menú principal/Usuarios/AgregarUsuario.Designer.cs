﻿
namespace CompuGross
{
    partial class AgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuario));
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.compuGrossDataSet1 = new CompuGross.CompuGrossDataSet1();
            this.compuGrossDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localidadesTableAdapter = new CompuGross.CompuGrossDataSet1TableAdapters.LocalidadesTableAdapter();
            this.lblAsterisco1 = new System.Windows.Forms.Label();
            this.lblAsterisco2 = new System.Windows.Forms.Label();
            this.lblAsterisco3 = new System.Windows.Forms.Label();
            this.lblAsterisco4 = new System.Windows.Forms.Label();
            this.lblAsterisco5 = new System.Windows.Forms.Label();
            this.lblAsterisco6 = new System.Windows.Forms.Label();
            this.lblMayus = new System.Windows.Forms.Label();
            this.lblMinus = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblMailInvalido = new System.Windows.Forms.Label();
            this.lblMailValido = new System.Windows.Forms.Label();
            this.cbMostrarClave = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compuGrossDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compuGrossDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.White;
            this.txtApellidos.Location = new System.Drawing.Point(112, 146);
            this.txtApellidos.MaxLength = 50;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(315, 26);
            this.txtApellidos.TabIndex = 1;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.White;
            this.txtNombres.Location = new System.Drawing.Point(112, 108);
            this.txtNombres.MaxLength = 50;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(315, 26);
            this.txtNombres.TabIndex = 0;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.Location = new System.Drawing.Point(112, 183);
            this.txtMail.MaxLength = 100;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(315, 26);
            this.txtMail.TabIndex = 2;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.White;
            this.txtDni.Location = new System.Drawing.Point(112, 220);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(315, 26);
            this.txtDni.TabIndex = 3;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.White;
            this.txtClave.Location = new System.Drawing.Point(112, 256);
            this.txtClave.MaxLength = 15;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(315, 26);
            this.txtClave.TabIndex = 4;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            this.txtClave.Enter += new System.EventHandler(this.txtClave_Enter);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            this.txtClave.Leave += new System.EventHandler(this.txtClave_Leave);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(300, 317);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(132, 40);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.BackColor = System.Drawing.Color.Transparent;
            this.lblCaracteres.ForeColor = System.Drawing.Color.LightCoral;
            this.lblCaracteres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCaracteres.Location = new System.Drawing.Point(109, 290);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(91, 13);
            this.lblCaracteres.TabIndex = 11;
            this.lblCaracteres.Text = "* 8-15 caracteres,";
            this.lblCaracteres.UseMnemonic = false;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.lblTipoUsuario.Location = new System.Drawing.Point(12, 71);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(39, 20);
            this.lblTipoUsuario.TabIndex = 12;
            this.lblTipoUsuario.Text = "Tipo";
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.cbTipoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Items.AddRange(new object[] {
            "-",
            "admin",
            "user"});
            this.cbTipoUsuario.Location = new System.Drawing.Point(112, 71);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(315, 26);
            this.cbTipoUsuario.TabIndex = 13;
            this.cbTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.cbTipoUsuario_SelectedIndexChanged);
            // 
            // compuGrossDataSet1
            // 
            this.compuGrossDataSet1.DataSetName = "CompuGrossDataSet1";
            this.compuGrossDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compuGrossDataSet1BindingSource
            // 
            this.compuGrossDataSet1BindingSource.DataSource = this.compuGrossDataSet1;
            this.compuGrossDataSet1BindingSource.Position = 0;
            // 
            // localidadesBindingSource
            // 
            this.localidadesBindingSource.DataMember = "Localidades";
            this.localidadesBindingSource.DataSource = this.compuGrossDataSet1BindingSource;
            // 
            // localidadesTableAdapter
            // 
            this.localidadesTableAdapter.ClearBeforeFill = true;
            // 
            // lblAsterisco1
            // 
            this.lblAsterisco1.AutoSize = true;
            this.lblAsterisco1.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterisco1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco1.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAsterisco1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAsterisco1.Location = new System.Drawing.Point(0, 71);
            this.lblAsterisco1.Name = "lblAsterisco1";
            this.lblAsterisco1.Size = new System.Drawing.Size(17, 24);
            this.lblAsterisco1.TabIndex = 14;
            this.lblAsterisco1.Text = "*";
            this.lblAsterisco1.UseMnemonic = false;
            // 
            // lblAsterisco2
            // 
            this.lblAsterisco2.AutoSize = true;
            this.lblAsterisco2.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterisco2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco2.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAsterisco2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAsterisco2.Location = new System.Drawing.Point(0, 110);
            this.lblAsterisco2.Name = "lblAsterisco2";
            this.lblAsterisco2.Size = new System.Drawing.Size(17, 24);
            this.lblAsterisco2.TabIndex = 15;
            this.lblAsterisco2.Text = "*";
            this.lblAsterisco2.UseMnemonic = false;
            // 
            // lblAsterisco3
            // 
            this.lblAsterisco3.AutoSize = true;
            this.lblAsterisco3.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterisco3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco3.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAsterisco3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAsterisco3.Location = new System.Drawing.Point(0, 149);
            this.lblAsterisco3.Name = "lblAsterisco3";
            this.lblAsterisco3.Size = new System.Drawing.Size(17, 24);
            this.lblAsterisco3.TabIndex = 16;
            this.lblAsterisco3.Text = "*";
            this.lblAsterisco3.UseMnemonic = false;
            // 
            // lblAsterisco4
            // 
            this.lblAsterisco4.AutoSize = true;
            this.lblAsterisco4.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterisco4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco4.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAsterisco4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAsterisco4.Location = new System.Drawing.Point(0, 185);
            this.lblAsterisco4.Name = "lblAsterisco4";
            this.lblAsterisco4.Size = new System.Drawing.Size(17, 24);
            this.lblAsterisco4.TabIndex = 17;
            this.lblAsterisco4.Text = "*";
            this.lblAsterisco4.UseMnemonic = false;
            // 
            // lblAsterisco5
            // 
            this.lblAsterisco5.AutoSize = true;
            this.lblAsterisco5.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterisco5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco5.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAsterisco5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAsterisco5.Location = new System.Drawing.Point(0, 223);
            this.lblAsterisco5.Name = "lblAsterisco5";
            this.lblAsterisco5.Size = new System.Drawing.Size(17, 24);
            this.lblAsterisco5.TabIndex = 18;
            this.lblAsterisco5.Text = "*";
            this.lblAsterisco5.UseMnemonic = false;
            // 
            // lblAsterisco6
            // 
            this.lblAsterisco6.AutoSize = true;
            this.lblAsterisco6.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterisco6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco6.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAsterisco6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAsterisco6.Location = new System.Drawing.Point(0, 259);
            this.lblAsterisco6.Name = "lblAsterisco6";
            this.lblAsterisco6.Size = new System.Drawing.Size(17, 24);
            this.lblAsterisco6.TabIndex = 19;
            this.lblAsterisco6.Text = "*";
            this.lblAsterisco6.UseMnemonic = false;
            // 
            // lblMayus
            // 
            this.lblMayus.AutoSize = true;
            this.lblMayus.BackColor = System.Drawing.Color.Transparent;
            this.lblMayus.ForeColor = System.Drawing.Color.LightCoral;
            this.lblMayus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMayus.Location = new System.Drawing.Point(212, 290);
            this.lblMayus.Name = "lblMayus";
            this.lblMayus.Size = new System.Drawing.Size(77, 13);
            this.lblMayus.TabIndex = 20;
            this.lblMayus.Text = "*1 Mayúscula, ";
            this.lblMayus.UseMnemonic = false;
            // 
            // lblMinus
            // 
            this.lblMinus.AutoSize = true;
            this.lblMinus.BackColor = System.Drawing.Color.Transparent;
            this.lblMinus.ForeColor = System.Drawing.Color.LightCoral;
            this.lblMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMinus.Location = new System.Drawing.Point(295, 290);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.Size = new System.Drawing.Size(71, 13);
            this.lblMinus.TabIndex = 21;
            this.lblMinus.Text = "*1 Minúscula.";
            this.lblMinus.UseMnemonic = false;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.Transparent;
            this.lblNum.ForeColor = System.Drawing.Color.LightCoral;
            this.lblNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNum.Location = new System.Drawing.Point(372, 290);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(60, 13);
            this.lblNum.TabIndex = 22;
            this.lblNum.Text = "*1 Número.";
            this.lblNum.UseMnemonic = false;
            // 
            // lblMailInvalido
            // 
            this.lblMailInvalido.AutoSize = true;
            this.lblMailInvalido.BackColor = System.Drawing.Color.White;
            this.lblMailInvalido.ForeColor = System.Drawing.Color.Red;
            this.lblMailInvalido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMailInvalido.Location = new System.Drawing.Point(368, 200);
            this.lblMailInvalido.Name = "lblMailInvalido";
            this.lblMailInvalido.Size = new System.Drawing.Size(57, 13);
            this.lblMailInvalido.TabIndex = 23;
            this.lblMailInvalido.Text = "INVÁLIDO";
            this.lblMailInvalido.UseMnemonic = false;
            // 
            // lblMailValido
            // 
            this.lblMailValido.AutoSize = true;
            this.lblMailValido.BackColor = System.Drawing.Color.White;
            this.lblMailValido.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMailValido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMailValido.Location = new System.Drawing.Point(380, 200);
            this.lblMailValido.Name = "lblMailValido";
            this.lblMailValido.Size = new System.Drawing.Size(46, 13);
            this.lblMailValido.TabIndex = 24;
            this.lblMailValido.Text = "VÁLIDO";
            this.lblMailValido.UseMnemonic = false;
            // 
            // cbMostrarClave
            // 
            this.cbMostrarClave.AutoSize = true;
            this.cbMostrarClave.BackColor = System.Drawing.Color.Transparent;
            this.cbMostrarClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMostrarClave.ForeColor = System.Drawing.Color.White;
            this.cbMostrarClave.Location = new System.Drawing.Point(17, 286);
            this.cbMostrarClave.Name = "cbMostrarClave";
            this.cbMostrarClave.Size = new System.Drawing.Size(61, 17);
            this.cbMostrarClave.TabIndex = 25;
            this.cbMostrarClave.Text = "Mostrar";
            this.cbMostrarClave.UseVisualStyleBackColor = false;
            this.cbMostrarClave.CheckedChanged += new System.EventHandler(this.cbMostrarClave_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(118, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 30);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nuevo Usuario";
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(439, 365);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMostrarClave);
            this.Controls.Add(this.lblMailValido);
            this.Controls.Add(this.lblMailInvalido);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.lblMayus);
            this.Controls.Add(this.lblAsterisco6);
            this.Controls.Add(this.lblAsterisco5);
            this.Controls.Add(this.lblAsterisco4);
            this.Controls.Add(this.lblAsterisco3);
            this.Controls.Add(this.lblAsterisco2);
            this.Controls.Add(this.lblAsterisco1);
            this.Controls.Add(this.cbTipoUsuario);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblCaracteres);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compuGrossDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compuGrossDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblCaracteres;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.BindingSource compuGrossDataSet1BindingSource;
        private CompuGrossDataSet1 compuGrossDataSet1;
        private System.Windows.Forms.BindingSource localidadesBindingSource;
        private CompuGrossDataSet1TableAdapters.LocalidadesTableAdapter localidadesTableAdapter;
        private System.Windows.Forms.Label lblAsterisco1;
        private System.Windows.Forms.Label lblAsterisco2;
        private System.Windows.Forms.Label lblAsterisco3;
        private System.Windows.Forms.Label lblAsterisco4;
        private System.Windows.Forms.Label lblAsterisco5;
        private System.Windows.Forms.Label lblAsterisco6;
        private System.Windows.Forms.Label lblMayus;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblMailInvalido;
        private System.Windows.Forms.Label lblMailValido;
        private System.Windows.Forms.CheckBox cbMostrarClave;
        private System.Windows.Forms.Label label6;
    }
}