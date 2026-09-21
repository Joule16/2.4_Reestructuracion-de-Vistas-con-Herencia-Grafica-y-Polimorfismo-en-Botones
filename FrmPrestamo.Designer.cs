// Actividad 2.4 - Equipo #2
//   SUÑIGA Maciel Joule Alexander
//   VILLA Olivarez Ariel
//   NUÑEZ Martinez Marco Antonio
// ===============================
namespace SistemaBiblioteca1
{
    partial class FrmPrestamo
    {

        private void InitializeComponent()
        {
            lblIdUsuarioPrestamo = new Label();
            txtIdUsuarioPrestamo = new TextBox();
            lblIdEjemplarPrestamo = new Label();
            txtIdEjemplarPrestamo = new TextBox();
            lblFechaPrestamo = new Label();
            dtpFechaPrestamo = new DateTimePicker();
            lblFechaLimite = new Label();
            dtpFechaLimite = new DateTimePicker();
            chkDevuelto = new CheckBox();
            chkEstadoPrestamo = new CheckBox();
            pnlFormularioBase.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFormularioBase
            // 
            pnlFormularioBase.Controls.Add(lblIdUsuarioPrestamo);
            pnlFormularioBase.Controls.Add(txtIdUsuarioPrestamo);
            pnlFormularioBase.Controls.Add(lblIdEjemplarPrestamo);
            pnlFormularioBase.Controls.Add(txtIdEjemplarPrestamo);
            pnlFormularioBase.Controls.Add(lblFechaPrestamo);
            pnlFormularioBase.Controls.Add(dtpFechaPrestamo);
            pnlFormularioBase.Controls.Add(lblFechaLimite);
            pnlFormularioBase.Controls.Add(dtpFechaLimite);
            pnlFormularioBase.Controls.Add(chkDevuelto);
            pnlFormularioBase.Controls.Add(chkEstadoPrestamo);
            pnlFormularioBase.Controls.SetChildIndex(chkEstadoPrestamo, 0);
            pnlFormularioBase.Controls.SetChildIndex(chkDevuelto, 0);
            pnlFormularioBase.Controls.SetChildIndex(dtpFechaLimite, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblFechaLimite, 0);
            pnlFormularioBase.Controls.SetChildIndex(dtpFechaPrestamo, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblFechaPrestamo, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtIdEjemplarPrestamo, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblIdEjemplarPrestamo, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtIdUsuarioPrestamo, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblIdUsuarioPrestamo, 0);
            pnlFormularioBase.Controls.SetChildIndex(txtId, 0);
            pnlFormularioBase.Controls.SetChildIndex(lblId, 0);
            // 
            // lblId
            // 
            lblId.Location = new Point(13, 16);
            // 
            // txtId
            // 
            txtId.Location = new Point(184, 13);
            // 
            // lblIdUsuarioPrestamo
            // 
            lblIdUsuarioPrestamo.AutoSize = true;
            lblIdUsuarioPrestamo.Location = new Point(16, 60);
            lblIdUsuarioPrestamo.Margin = new Padding(2, 0, 2, 0);
            lblIdUsuarioPrestamo.Name = "lblIdUsuarioPrestamo";
            lblIdUsuarioPrestamo.Size = new Size(81, 20);
            lblIdUsuarioPrestamo.TabIndex = 2;
            lblIdUsuarioPrestamo.Text = "ID Usuario:";
            // 
            // txtIdUsuarioPrestamo
            // 
            txtIdUsuarioPrestamo.Location = new Point(184, 58);
            txtIdUsuarioPrestamo.Margin = new Padding(2, 2, 2, 2);
            txtIdUsuarioPrestamo.Name = "txtIdUsuarioPrestamo";
            txtIdUsuarioPrestamo.Size = new Size(185, 27);
            txtIdUsuarioPrestamo.TabIndex = 3;
            // 
            // lblIdEjemplarPrestamo
            // 
            lblIdEjemplarPrestamo.AutoSize = true;
            lblIdEjemplarPrestamo.Location = new Point(16, 96);
            lblIdEjemplarPrestamo.Margin = new Padding(2, 0, 2, 0);
            lblIdEjemplarPrestamo.Name = "lblIdEjemplarPrestamo";
            lblIdEjemplarPrestamo.Size = new Size(90, 20);
            lblIdEjemplarPrestamo.TabIndex = 4;
            lblIdEjemplarPrestamo.Text = "ID Ejemplar:";
            // 
            // txtIdEjemplarPrestamo
            // 
            txtIdEjemplarPrestamo.Location = new Point(184, 94);
            txtIdEjemplarPrestamo.Margin = new Padding(2, 2, 2, 2);
            txtIdEjemplarPrestamo.Name = "txtIdEjemplarPrestamo";
            txtIdEjemplarPrestamo.Size = new Size(185, 27);
            txtIdEjemplarPrestamo.TabIndex = 5;
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.Location = new Point(16, 132);
            lblFechaPrestamo.Margin = new Padding(2, 0, 2, 0);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(138, 20);
            lblFechaPrestamo.TabIndex = 6;
            lblFechaPrestamo.Text = "Fecha de préstamo:";
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(184, 130);
            dtpFechaPrestamo.Margin = new Padding(2, 2, 2, 2);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(185, 27);
            dtpFechaPrestamo.TabIndex = 7;
            // 
            // lblFechaLimite
            // 
            lblFechaLimite.AutoSize = true;
            lblFechaLimite.Location = new Point(16, 168);
            lblFechaLimite.Margin = new Padding(2, 0, 2, 0);
            lblFechaLimite.Name = "lblFechaLimite";
            lblFechaLimite.Size = new Size(92, 20);
            lblFechaLimite.TabIndex = 8;
            lblFechaLimite.Text = "Fecha límite:";
            // 
            // dtpFechaLimite
            // 
            dtpFechaLimite.Format = DateTimePickerFormat.Short;
            dtpFechaLimite.Location = new Point(184, 166);
            dtpFechaLimite.Margin = new Padding(2, 2, 2, 2);
            dtpFechaLimite.Name = "dtpFechaLimite";
            dtpFechaLimite.Size = new Size(185, 27);
            dtpFechaLimite.TabIndex = 9;
            // 
            // chkDevuelto
            // 
            chkDevuelto.AutoSize = true;
            chkDevuelto.Location = new Point(184, 204);
            chkDevuelto.Margin = new Padding(2, 2, 2, 2);
            chkDevuelto.Name = "chkDevuelto";
            chkDevuelto.Size = new Size(91, 24);
            chkDevuelto.TabIndex = 10;
            chkDevuelto.Text = "Devuelto";
            chkDevuelto.UseVisualStyleBackColor = true;
            // 
            // chkEstadoPrestamo
            // 
            chkEstadoPrestamo.AutoSize = true;
            chkEstadoPrestamo.Location = new Point(288, 204);
            chkEstadoPrestamo.Margin = new Padding(2, 2, 2, 2);
            chkEstadoPrestamo.Name = "chkEstadoPrestamo";
            chkEstadoPrestamo.Size = new Size(73, 24);
            chkEstadoPrestamo.TabIndex = 11;
            chkEstadoPrestamo.Text = "Activo";
            chkEstadoPrestamo.UseVisualStyleBackColor = true;
            // 
            // FrmPrestamo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Name = "FrmPrestamo";
            Text = "FrmPrestamo";
            pnlFormularioBase.ResumeLayout(false);
            pnlFormularioBase.PerformLayout();
            ResumeLayout(false);
        }



        private Label lblIdUsuarioPrestamo;
        private TextBox txtIdUsuarioPrestamo;
        private Label lblIdEjemplarPrestamo;
        private TextBox txtIdEjemplarPrestamo;
        private Label lblFechaPrestamo;
        private DateTimePicker dtpFechaPrestamo;
        private Label lblFechaLimite;
        private DateTimePicker dtpFechaLimite;
        private CheckBox chkDevuelto;
        private CheckBox chkEstadoPrestamo;
    }
}