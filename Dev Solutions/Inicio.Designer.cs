namespace Dev_Solutions
{
    partial class Inicio
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
            this.btnEmpadronarse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpi = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FechaN = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.primaryGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.primaryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpadronarse
            // 
            this.btnEmpadronarse.Location = new System.Drawing.Point(1190, 547);
            this.btnEmpadronarse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmpadronarse.Name = "btnEmpadronarse";
            this.btnEmpadronarse.Size = new System.Drawing.Size(123, 31);
            this.btnEmpadronarse.TabIndex = 0;
            this.btnEmpadronarse.Text = "Empadronarse";
            this.btnEmpadronarse.UseVisualStyleBackColor = true;
            this.btnEmpadronarse.Click += new System.EventHandler(this.btnEmpadronarse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "DPI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Nacimento:";
            // 
            // dpi
            // 
            this.dpi.Location = new System.Drawing.Point(325, 603);
            this.dpi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpi.Name = "dpi";
            this.dpi.Size = new System.Drawing.Size(135, 27);
            this.dpi.TabIndex = 4;
            // 
            // FechaN
            // 
            this.FechaN.Location = new System.Drawing.Point(136, 603);
            this.FechaN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FechaN.Name = "FechaN";
            this.FechaN.Size = new System.Drawing.Size(135, 27);
            this.FechaN.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(1227, 469);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(86, 31);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // primaryGrid
            // 
            this.primaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.primaryGrid.Location = new System.Drawing.Point(11, 43);
            this.primaryGrid.Name = "primaryGrid";
            this.primaryGrid.RowHeadersWidth = 51;
            this.primaryGrid.RowTemplate.Height = 29;
            this.primaryGrid.Size = new System.Drawing.Size(1728, 254);
            this.primaryGrid.TabIndex = 6;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1752, 723);
            this.Controls.Add(this.primaryGrid);
            this.Controls.Add(this.FechaN);
            this.Controls.Add(this.dpi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEmpadronarse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.primaryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEmpadronarse;
        private Label label1;
        private Label label2;
        private TextBox dpi;
        private ToolTip toolTip1;
        private TextBox FechaN;
        private Button btnConsultar;
        private DataGridView primaryGrid;
    }
}