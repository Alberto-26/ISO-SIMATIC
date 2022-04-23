namespace SIMATIC
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.pAddCliente = new System.Windows.Forms.Panel();
            this.tbNITCliente = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.tbGiroCliente = new System.Windows.Forms.TextBox();
            this.tbDireccionCliente = new System.Windows.Forms.TextBox();
            this.tbNRCCliente = new System.Windows.Forms.TextBox();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.btnRegistroCliente = new System.Windows.Forms.Button();
            this.pRegistrosCliente = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNombreClienteBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNITModificar = new System.Windows.Forms.MaskedTextBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tbGiroModificar = new System.Windows.Forms.TextBox();
            this.tbDireccionModificar = new System.Windows.Forms.TextBox();
            this.tbNRCModificar = new System.Windows.Forms.TextBox();
            this.tbNombreModificar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnCerrarCliente = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pAddCliente.SuspendLayout();
            this.pRegistrosCliente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pAddCliente
            // 
            this.pAddCliente.Controls.Add(this.tbNITCliente);
            this.pAddCliente.Controls.Add(this.btnLimpiarCliente);
            this.pAddCliente.Controls.Add(this.btnGuardarCliente);
            this.pAddCliente.Controls.Add(this.tbGiroCliente);
            this.pAddCliente.Controls.Add(this.tbDireccionCliente);
            this.pAddCliente.Controls.Add(this.tbNRCCliente);
            this.pAddCliente.Controls.Add(this.tbNombreCliente);
            this.pAddCliente.Controls.Add(this.label5);
            this.pAddCliente.Controls.Add(this.label4);
            this.pAddCliente.Controls.Add(this.label3);
            this.pAddCliente.Controls.Add(this.label2);
            this.pAddCliente.Controls.Add(this.label1);
            this.pAddCliente.Location = new System.Drawing.Point(0, 51);
            this.pAddCliente.Margin = new System.Windows.Forms.Padding(2);
            this.pAddCliente.Name = "pAddCliente";
            this.pAddCliente.Size = new System.Drawing.Size(712, 315);
            this.pAddCliente.TabIndex = 3;
            // 
            // tbNITCliente
            // 
            this.tbNITCliente.Location = new System.Drawing.Point(297, 100);
            this.tbNITCliente.Mask = "0000-000000-000-0";
            this.tbNITCliente.Name = "tbNITCliente";
            this.tbNITCliente.Size = new System.Drawing.Size(213, 20);
            this.tbNITCliente.TabIndex = 12;
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnLimpiarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarCliente.Image")));
            this.btnLimpiarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarCliente.Location = new System.Drawing.Point(365, 195);
            this.btnLimpiarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(136, 45);
            this.btnLimpiarCliente.TabIndex = 11;
            this.btnLimpiarCliente.Text = "       Limpiar";
            this.btnLimpiarCliente.UseVisualStyleBackColor = true;
            this.btnLimpiarCliente.Click += new System.EventHandler(this.btnLimpiarCliente_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCliente.Image")));
            this.btnGuardarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCliente.Location = new System.Drawing.Point(109, 195);
            this.btnGuardarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(136, 45);
            this.btnGuardarCliente.TabIndex = 10;
            this.btnGuardarCliente.Text = "       Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // tbGiroCliente
            // 
            this.tbGiroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGiroCliente.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbGiroCliente.Location = new System.Drawing.Point(297, 165);
            this.tbGiroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbGiroCliente.Name = "tbGiroCliente";
            this.tbGiroCliente.Size = new System.Drawing.Size(213, 22);
            this.tbGiroCliente.TabIndex = 9;
            // 
            // tbDireccionCliente
            // 
            this.tbDireccionCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDireccionCliente.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbDireccionCliente.Location = new System.Drawing.Point(297, 131);
            this.tbDireccionCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbDireccionCliente.Name = "tbDireccionCliente";
            this.tbDireccionCliente.Size = new System.Drawing.Size(213, 22);
            this.tbDireccionCliente.TabIndex = 8;
            // 
            // tbNRCCliente
            // 
            this.tbNRCCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNRCCliente.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbNRCCliente.Location = new System.Drawing.Point(297, 43);
            this.tbNRCCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbNRCCliente.Name = "tbNRCCliente";
            this.tbNRCCliente.Size = new System.Drawing.Size(213, 22);
            this.tbNRCCliente.TabIndex = 6;
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombreCliente.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbNombreCliente.Location = new System.Drawing.Point(297, 70);
            this.tbNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.Size = new System.Drawing.Size(213, 22);
            this.tbNombreCliente.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(149, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giro:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIT:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de cliente:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "NRC:";
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.btnAddCliente.FlatAppearance.BorderSize = 0;
            this.btnAddCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCliente.ForeColor = System.Drawing.Color.White;
            this.btnAddCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCliente.Image")));
            this.btnAddCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCliente.Location = new System.Drawing.Point(0, 0);
            this.btnAddCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(109, 40);
            this.btnAddCliente.TabIndex = 1;
            this.btnAddCliente.Text = "       Agregar";
            this.btnAddCliente.UseVisualStyleBackColor = false;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // btnRegistroCliente
            // 
            this.btnRegistroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.btnRegistroCliente.FlatAppearance.BorderSize = 0;
            this.btnRegistroCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.btnRegistroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroCliente.ForeColor = System.Drawing.Color.White;
            this.btnRegistroCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroCliente.Image")));
            this.btnRegistroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroCliente.Location = new System.Drawing.Point(109, 0);
            this.btnRegistroCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistroCliente.Name = "btnRegistroCliente";
            this.btnRegistroCliente.Size = new System.Drawing.Size(109, 40);
            this.btnRegistroCliente.TabIndex = 2;
            this.btnRegistroCliente.Text = "       Registros";
            this.btnRegistroCliente.UseVisualStyleBackColor = false;
            this.btnRegistroCliente.Click += new System.EventHandler(this.btnRegistroCliente_Click);
            // 
            // pRegistrosCliente
            // 
            this.pRegistrosCliente.Controls.Add(this.groupBox2);
            this.pRegistrosCliente.Controls.Add(this.groupBox1);
            this.pRegistrosCliente.Controls.Add(this.dgvClientes);
            this.pRegistrosCliente.Location = new System.Drawing.Point(0, 44);
            this.pRegistrosCliente.Margin = new System.Windows.Forms.Padding(2);
            this.pRegistrosCliente.Name = "pRegistrosCliente";
            this.pRegistrosCliente.Size = new System.Drawing.Size(741, 345);
            this.pRegistrosCliente.TabIndex = 6;
            this.pRegistrosCliente.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbNombreClienteBuscar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 59);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Cliente";
            // 
            // tbNombreClienteBuscar
            // 
            this.tbNombreClienteBuscar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbNombreClienteBuscar.Location = new System.Drawing.Point(146, 20);
            this.tbNombreClienteBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombreClienteBuscar.Name = "tbNombreClienteBuscar";
            this.tbNombreClienteBuscar.Size = new System.Drawing.Size(173, 22);
            this.tbNombreClienteBuscar.TabIndex = 4;
            this.tbNombreClienteBuscar.TextChanged += new System.EventHandler(this.tbNombreClienteBuscar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre de Cliente :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNITModificar);
            this.groupBox1.Controls.Add(this.Limpiar);
            this.groupBox1.Controls.Add(this.btnEliminarCliente);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.tbGiroModificar);
            this.groupBox1.Controls.Add(this.tbDireccionModificar);
            this.groupBox1.Controls.Add(this.tbNRCModificar);
            this.groupBox1.Controls.Add(this.tbNombreModificar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(392, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(347, 324);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar";
            // 
            // tbNITModificar
            // 
            this.tbNITModificar.Location = new System.Drawing.Point(166, 142);
            this.tbNITModificar.Mask = "000-000000-000-0";
            this.tbNITModificar.Name = "tbNITModificar";
            this.tbNITModificar.Size = new System.Drawing.Size(140, 22);
            this.tbNITModificar.TabIndex = 23;
            // 
            // Limpiar
            // 
            this.Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Limpiar.Image")));
            this.Limpiar.Location = new System.Drawing.Point(244, 273);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(62, 40);
            this.Limpiar.TabIndex = 22;
            this.Limpiar.Text = "     ";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCliente.Image")));
            this.btnEliminarCliente.Location = new System.Drawing.Point(166, 272);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(74, 42);
            this.btnEliminarCliente.TabIndex = 21;
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(20, 272);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(140, 42);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "       Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbGiroModificar
            // 
            this.tbGiroModificar.Location = new System.Drawing.Point(166, 237);
            this.tbGiroModificar.Margin = new System.Windows.Forms.Padding(2);
            this.tbGiroModificar.Name = "tbGiroModificar";
            this.tbGiroModificar.Size = new System.Drawing.Size(140, 22);
            this.tbGiroModificar.TabIndex = 19;
            // 
            // tbDireccionModificar
            // 
            this.tbDireccionModificar.Location = new System.Drawing.Point(166, 183);
            this.tbDireccionModificar.Margin = new System.Windows.Forms.Padding(2);
            this.tbDireccionModificar.Multiline = true;
            this.tbDireccionModificar.Name = "tbDireccionModificar";
            this.tbDireccionModificar.Size = new System.Drawing.Size(140, 32);
            this.tbDireccionModificar.TabIndex = 18;
            // 
            // tbNRCModificar
            // 
            this.tbNRCModificar.Enabled = false;
            this.tbNRCModificar.Location = new System.Drawing.Point(166, 42);
            this.tbNRCModificar.Margin = new System.Windows.Forms.Padding(2);
            this.tbNRCModificar.Name = "tbNRCModificar";
            this.tbNRCModificar.Size = new System.Drawing.Size(140, 22);
            this.tbNRCModificar.TabIndex = 16;
            // 
            // tbNombreModificar
            // 
            this.tbNombreModificar.Location = new System.Drawing.Point(166, 91);
            this.tbNombreModificar.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombreModificar.Name = "tbNombreModificar";
            this.tbNombreModificar.Size = new System.Drawing.Size(140, 22);
            this.tbNombreModificar.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Giro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dirección:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "NIT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nombre de cliente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 43);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "NRC:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(8, 81);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowTemplate.Height = 28;
            this.dgvClientes.Size = new System.Drawing.Size(353, 252);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // btnCerrarCliente
            // 
            this.btnCerrarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarCliente.AutoSize = true;
            this.btnCerrarCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCerrarCliente.Location = new System.Drawing.Point(727, 6);
            this.btnCerrarCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnCerrarCliente.Name = "btnCerrarCliente";
            this.btnCerrarCliente.Size = new System.Drawing.Size(14, 13);
            this.btnCerrarCliente.TabIndex = 7;
            this.btnCerrarCliente.Text = "X";
            this.btnCerrarCliente.Click += new System.EventHandler(this.btnCerrarCliente_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 397);
            this.Controls.Add(this.btnCerrarCliente);
            this.Controls.Add(this.pRegistrosCliente);
            this.Controls.Add(this.pAddCliente);
            this.Controls.Add(this.btnRegistroCliente);
            this.Controls.Add(this.btnAddCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.pAddCliente.ResumeLayout(false);
            this.pAddCliente.PerformLayout();
            this.pRegistrosCliente.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pAddCliente;
        private System.Windows.Forms.Button btnLimpiarCliente;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.TextBox tbGiroCliente;
        private System.Windows.Forms.TextBox tbDireccionCliente;
        private System.Windows.Forms.TextBox tbNRCCliente;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Button btnRegistroCliente;
        private System.Windows.Forms.Panel pRegistrosCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox tbGiroModificar;
        private System.Windows.Forms.TextBox tbDireccionModificar;
        private System.Windows.Forms.TextBox tbNRCModificar;
        private System.Windows.Forms.TextBox tbNombreModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label btnCerrarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbNombreClienteBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.MaskedTextBox tbNITCliente;
        private System.Windows.Forms.MaskedTextBox tbNITModificar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

        