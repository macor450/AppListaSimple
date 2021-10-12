
namespace AppListaSimple
{
    partial class frmAlumnos
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
            this.lblMAT = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtAp = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.lblNOM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNUM = new System.Windows.Forms.Label();
            this.lblAP = new System.Windows.Forms.Label();
            this.txtAm = new System.Windows.Forms.TextBox();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.lblAM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomMat = new System.Windows.Forms.TextBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.txtNumMat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarMat = new System.Windows.Forms.Button();
            this.btnModificarMat = new System.Windows.Forms.Button();
            this.btnAggregarMat = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblMAT
            // 
            this.lblMAT.AutoSize = true;
            this.lblMAT.Location = new System.Drawing.Point(52, 96);
            this.lblMAT.Name = "lblMAT";
            this.lblMAT.Size = new System.Drawing.Size(50, 13);
            this.lblMAT.TabIndex = 0;
            this.lblMAT.Text = "Matricula";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(111, 55);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(220, 51);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 26);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(220, 149);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 26);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(220, 85);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 26);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(220, 117);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 26);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtAp
            // 
            this.txtAp.Location = new System.Drawing.Point(111, 157);
            this.txtAp.Name = "txtAp";
            this.txtAp.Size = new System.Drawing.Size(100, 20);
            this.txtAp.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(111, 123);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 2;
            // 
            // txtMat
            // 
            this.txtMat.Enabled = false;
            this.txtMat.Location = new System.Drawing.Point(111, 89);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(100, 20);
            this.txtMat.TabIndex = 12;
            // 
            // lblNOM
            // 
            this.lblNOM.AutoSize = true;
            this.lblNOM.Location = new System.Drawing.Point(52, 130);
            this.lblNOM.Name = "lblNOM";
            this.lblNOM.Size = new System.Drawing.Size(44, 13);
            this.lblNOM.TabIndex = 9;
            this.lblNOM.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // lblNUM
            // 
            this.lblNUM.AutoSize = true;
            this.lblNUM.Location = new System.Drawing.Point(52, 58);
            this.lblNUM.Name = "lblNUM";
            this.lblNUM.Size = new System.Drawing.Size(44, 13);
            this.lblNUM.TabIndex = 11;
            this.lblNUM.Text = "Numero";
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Location = new System.Drawing.Point(52, 164);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(21, 13);
            this.lblAP.TabIndex = 12;
            this.lblAP.Text = "AP";
            // 
            // txtAm
            // 
            this.txtAm.Location = new System.Drawing.Point(111, 193);
            this.txtAm.Name = "txtAm";
            this.txtAm.Size = new System.Drawing.Size(100, 20);
            this.txtAm.TabIndex = 4;
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(55, 393);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(501, 56);
            this.lstDatos.TabIndex = 14;
            // 
            // lblAM
            // 
            this.lblAM.AutoSize = true;
            this.lblAM.Location = new System.Drawing.Point(52, 200);
            this.lblAM.Name = "lblAM";
            this.lblAM.Size = new System.Drawing.Size(23, 13);
            this.lblAM.TabIndex = 15;
            this.lblAM.Text = "AM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Calificacion";
            // 
            // txtNomMat
            // 
            this.txtNomMat.Enabled = false;
            this.txtNomMat.Location = new System.Drawing.Point(400, 86);
            this.txtNomMat.Name = "txtNomMat";
            this.txtNomMat.Size = new System.Drawing.Size(100, 20);
            this.txtNomMat.TabIndex = 21;
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(400, 123);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(100, 20);
            this.txtCalificacion.TabIndex = 18;
            // 
            // txtNumMat
            // 
            this.txtNumMat.Location = new System.Drawing.Point(400, 55);
            this.txtNumMat.Name = "txtNumMat";
            this.txtNumMat.Size = new System.Drawing.Size(100, 20);
            this.txtNumMat.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Matricula";
            // 
            // btnBuscarMat
            // 
            this.btnBuscarMat.Location = new System.Drawing.Point(481, 186);
            this.btnBuscarMat.Name = "btnBuscarMat";
            this.btnBuscarMat.Size = new System.Drawing.Size(75, 26);
            this.btnBuscarMat.TabIndex = 24;
            this.btnBuscarMat.Text = "Buscar";
            this.btnBuscarMat.UseVisualStyleBackColor = true;
            // 
            // btnModificarMat
            // 
            this.btnModificarMat.Location = new System.Drawing.Point(400, 186);
            this.btnModificarMat.Name = "btnModificarMat";
            this.btnModificarMat.Size = new System.Drawing.Size(75, 26);
            this.btnModificarMat.TabIndex = 23;
            this.btnModificarMat.Text = "Modificar";
            this.btnModificarMat.UseVisualStyleBackColor = true;
            // 
            // btnAggregarMat
            // 
            this.btnAggregarMat.Location = new System.Drawing.Point(319, 186);
            this.btnAggregarMat.Name = "btnAggregarMat";
            this.btnAggregarMat.Size = new System.Drawing.Size(75, 26);
            this.btnAggregarMat.TabIndex = 22;
            this.btnAggregarMat.Text = "Agregar";
            this.btnAggregarMat.UseVisualStyleBackColor = true;
            this.btnAggregarMat.Click += new System.EventHandler(this.btnAggregarMat_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(55, 227);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(501, 160);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numero";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Matricula";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(581, 227);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(305, 160);
            this.listView2.TabIndex = 26;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Numero";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Matricula";
            this.columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Calificaciones";
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnBuscarMat);
            this.Controls.Add(this.btnModificarMat);
            this.Controls.Add(this.btnAggregarMat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomMat);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.txtNumMat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAM);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.txtAm);
            this.Controls.Add(this.lblAP);
            this.Controls.Add(this.lblNUM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNOM);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtAp);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblMAT);
            this.Name = "frmAlumnos";
            this.Text = "frmAlumnos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMAT;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtAp;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Label lblNOM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNUM;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.TextBox txtAm;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Label lblAM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomMat;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.TextBox txtNumMat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarMat;
        private System.Windows.Forms.Button btnModificarMat;
        private System.Windows.Forms.Button btnAggregarMat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}