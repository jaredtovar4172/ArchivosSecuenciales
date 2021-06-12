namespace ProyectoFinalDC
{
    partial class Menu
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeVentasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPorNombreDelProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLaVentaMasAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mostrarPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(86, 70);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(591, 243);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha de venta";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre del producto";
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cantidad";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Precio";
            this.columnHeader4.Width = 85;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(753, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarTodoToolStripMenuItem,
            this.consultaDeVentasToolStripMenuItem,
            this.bajaDeEToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.mostrarPorFechasToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // mostrarTodoToolStripMenuItem
            // 
            this.mostrarTodoToolStripMenuItem.Name = "mostrarTodoToolStripMenuItem";
            this.mostrarTodoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.mostrarTodoToolStripMenuItem.Text = "Ventas";
            this.mostrarTodoToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodoToolStripMenuItem_Click);
            // 
            // consultaDeVentasToolStripMenuItem
            // 
            this.consultaDeVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeVentasToolStripMenuItem1,
            this.consultaPorNombreDelProductoToolStripMenuItem,
            this.consultarLaVentaMasAltaToolStripMenuItem});
            this.consultaDeVentasToolStripMenuItem.Name = "consultaDeVentasToolStripMenuItem";
            this.consultaDeVentasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.consultaDeVentasToolStripMenuItem.Text = "Consulta";
            // 
            // consultaDeVentasToolStripMenuItem1
            // 
            this.consultaDeVentasToolStripMenuItem1.Name = "consultaDeVentasToolStripMenuItem1";
            this.consultaDeVentasToolStripMenuItem1.Size = new System.Drawing.Size(281, 22);
            this.consultaDeVentasToolStripMenuItem1.Text = "Consulta de ventas";
            this.consultaDeVentasToolStripMenuItem1.Click += new System.EventHandler(this.consultaDeVentasToolStripMenuItem1_Click);
            // 
            // consultaPorNombreDelProductoToolStripMenuItem
            // 
            this.consultaPorNombreDelProductoToolStripMenuItem.Name = "consultaPorNombreDelProductoToolStripMenuItem";
            this.consultaPorNombreDelProductoToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.consultaPorNombreDelProductoToolStripMenuItem.Text = "Consulta por nombre del producto";
            this.consultaPorNombreDelProductoToolStripMenuItem.Click += new System.EventHandler(this.consultaPorNombreDelProductoToolStripMenuItem_Click);
            // 
            // consultarLaVentaMasAltaToolStripMenuItem
            // 
            this.consultarLaVentaMasAltaToolStripMenuItem.Name = "consultarLaVentaMasAltaToolStripMenuItem";
            this.consultarLaVentaMasAltaToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.consultarLaVentaMasAltaToolStripMenuItem.Text = "Consultar la venta mas alta";
            // 
            // bajaDeEToolStripMenuItem
            // 
            this.bajaDeEToolStripMenuItem.Name = "bajaDeEToolStripMenuItem";
            this.bajaDeEToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.bajaDeEToolStripMenuItem.Text = "Baja de productos";
            this.bajaDeEToolStripMenuItem.Click += new System.EventHandler(this.bajaDeEToolStripMenuItem_Click_1);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.modificarProductoToolStripMenuItem.Text = "Modificar Producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 342);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Precio Total";
            this.columnHeader5.Width = 77;
            // 
            // mostrarPorFechasToolStripMenuItem
            // 
            this.mostrarPorFechasToolStripMenuItem.Name = "mostrarPorFechasToolStripMenuItem";
            this.mostrarPorFechasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.mostrarPorFechasToolStripMenuItem.Text = "Mostrar por Fechas";
            this.mostrarPorFechasToolStripMenuItem.Click += new System.EventHandler(this.mostrarPorFechasToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeVentasToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem consultaDeVentasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaPorNombreDelProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarLaVentaMasAltaToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem mostrarPorFechasToolStripMenuItem;
    }
}