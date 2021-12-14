
namespace Calculadora
{
    partial class Form1
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Quitar = new System.Windows.Forms.Button();
            this.BorrarTodo = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Punto = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.Exponente = new System.Windows.Forms.Button();
            this.Raiz = new System.Windows.Forms.Button();
            this.Multiplicacion = new System.Windows.Forms.Button();
            this.Divicion = new System.Windows.Forms.Button();
            this.Menos = new System.Windows.Forms.Button();
            this.Mas = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(15, 287);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(54, 44);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // Resultado
            // 
            this.Resultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(21, 43);
            this.Resultado.MaxLength = 21;
            this.Resultado.Multiline = true;
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Size = new System.Drawing.Size(336, 50);
            this.Resultado.TabIndex = 1;
            this.Resultado.Text = "0";
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(85, 287);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(54, 44);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(158, 287);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(54, 44);
            this.Button3.TabIndex = 3;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(158, 236);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(54, 44);
            this.Button6.TabIndex = 6;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(85, 236);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(54, 44);
            this.Button5.TabIndex = 5;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(15, 236);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(54, 44);
            this.Button4.TabIndex = 4;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // Quitar
            // 
            this.Quitar.Location = new System.Drawing.Point(158, 134);
            this.Quitar.Name = "Quitar";
            this.Quitar.Size = new System.Drawing.Size(54, 44);
            this.Quitar.TabIndex = 12;
            this.Quitar.Text = "<-";
            this.Quitar.UseVisualStyleBackColor = true;
            this.Quitar.Click += new System.EventHandler(this.Quitar_Click);
            // 
            // BorrarTodo
            // 
            this.BorrarTodo.Location = new System.Drawing.Point(85, 134);
            this.BorrarTodo.Name = "BorrarTodo";
            this.BorrarTodo.Size = new System.Drawing.Size(54, 44);
            this.BorrarTodo.TabIndex = 11;
            this.BorrarTodo.Text = "C";
            this.BorrarTodo.UseVisualStyleBackColor = true;
            this.BorrarTodo.Click += new System.EventHandler(this.BorrarTodo_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(15, 134);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(54, 44);
            this.Borrar.TabIndex = 10;
            this.Borrar.Text = "CE";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(158, 185);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(54, 44);
            this.Button9.TabIndex = 9;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(85, 185);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(54, 44);
            this.Button8.TabIndex = 8;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(15, 185);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(54, 44);
            this.Button7.TabIndex = 7;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // Punto
            // 
            this.Punto.Location = new System.Drawing.Point(158, 338);
            this.Punto.Name = "Punto";
            this.Punto.Size = new System.Drawing.Size(54, 44);
            this.Punto.TabIndex = 15;
            this.Punto.Text = ".";
            this.Punto.UseVisualStyleBackColor = true;
            this.Punto.Click += new System.EventHandler(this.Punto_Click);
            // 
            // Button0
            // 
            this.Button0.Location = new System.Drawing.Point(85, 338);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(54, 44);
            this.Button0.TabIndex = 14;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(15, 338);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(54, 44);
            this.button15.TabIndex = 13;
            this.button15.Text = "+/-";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // Exponente
            // 
            this.Exponente.Location = new System.Drawing.Point(247, 134);
            this.Exponente.Name = "Exponente";
            this.Exponente.Size = new System.Drawing.Size(55, 44);
            this.Exponente.TabIndex = 21;
            this.Exponente.Tag = "²";
            this.Exponente.Text = "x²";
            this.Exponente.UseVisualStyleBackColor = true;
            this.Exponente.Click += new System.EventHandler(this.ClickOperador);
            // 
            // Raiz
            // 
            this.Raiz.Location = new System.Drawing.Point(312, 134);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(55, 43);
            this.Raiz.TabIndex = 20;
            this.Raiz.Tag = "√";
            this.Raiz.Text = "√";
            this.Raiz.UseVisualStyleBackColor = true;
            this.Raiz.Click += new System.EventHandler(this.ClickOperador);
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.Location = new System.Drawing.Point(312, 198);
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.Size = new System.Drawing.Size(55, 43);
            this.Multiplicacion.TabIndex = 19;
            this.Multiplicacion.Tag = "x";
            this.Multiplicacion.Text = "x";
            this.Multiplicacion.UseVisualStyleBackColor = true;
            this.Multiplicacion.Click += new System.EventHandler(this.ClickOperador);
            // 
            // Divicion
            // 
            this.Divicion.Location = new System.Drawing.Point(247, 198);
            this.Divicion.Name = "Divicion";
            this.Divicion.Size = new System.Drawing.Size(55, 43);
            this.Divicion.TabIndex = 18;
            this.Divicion.Tag = "/";
            this.Divicion.Text = "/";
            this.Divicion.UseVisualStyleBackColor = true;
            this.Divicion.Click += new System.EventHandler(this.ClickOperador);
            // 
            // Menos
            // 
            this.Menos.Location = new System.Drawing.Point(312, 253);
            this.Menos.Name = "Menos";
            this.Menos.Size = new System.Drawing.Size(55, 42);
            this.Menos.TabIndex = 17;
            this.Menos.Tag = "-";
            this.Menos.Text = "-";
            this.Menos.UseVisualStyleBackColor = true;
            this.Menos.Click += new System.EventHandler(this.ClickOperador);
            // 
            // Mas
            // 
            this.Mas.Location = new System.Drawing.Point(247, 254);
            this.Mas.Name = "Mas";
            this.Mas.Size = new System.Drawing.Size(55, 43);
            this.Mas.TabIndex = 16;
            this.Mas.Tag = "+";
            this.Mas.Text = "+";
            this.Mas.UseVisualStyleBackColor = true;
            this.Mas.Click += new System.EventHandler(this.ClickOperador);
            // 
            // Igual
            // 
            this.Igual.Location = new System.Drawing.Point(247, 312);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(120, 62);
            this.Igual.TabIndex = 22;
            this.Igual.Tag = "=";
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = true;
            this.Igual.Click += new System.EventHandler(this.Form1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(379, 416);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.Exponente);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.Multiplicacion);
            this.Controls.Add(this.Divicion);
            this.Controls.Add(this.Menos);
            this.Controls.Add(this.Mas);
            this.Controls.Add(this.Punto);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.Quitar);
            this.Controls.Add(this.BorrarTodo);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Quitar;
        private System.Windows.Forms.Button BorrarTodo;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Punto;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button Exponente;
        private System.Windows.Forms.Button Raiz;
        private System.Windows.Forms.Button Multiplicacion;
        private System.Windows.Forms.Button Divicion;
        private System.Windows.Forms.Button Menos;
        private System.Windows.Forms.Button Mas;
        private System.Windows.Forms.Button Igual;
    }
}

