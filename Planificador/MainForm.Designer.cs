/*
 * Created by SharpDevelop.
 * User: Gustavo
 * Date: 10/10/2022
 * Time: 09:02 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PlanificadorFCFS
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			this.lbl_titulo = new System.Windows.Forms.Label();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.btn_addproc = new System.Windows.Forms.Button();
			this.tb_name = new System.Windows.Forms.TextBox();
			this.tb_time = new System.Windows.Forms.TextBox();
			this.lbl_name = new System.Windows.Forms.Label();
			this.lbl_time = new System.Windows.Forms.Label();
			this.btn_rr = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_max = new System.Windows.Forms.Label();
			this.lbl_min = new System.Windows.Forms.Label();
			this.lbl_med = new System.Windows.Forms.Label();
			this.lbl_desv = new System.Windows.Forms.Label();
			this.btn_respro = new System.Windows.Forms.Button();
			this.btn_start = new System.Windows.Forms.Button();
			this.btn_str = new System.Windows.Forms.Button();
			this.btn_prior = new System.Windows.Forms.Button();
			this.btn_mlq = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_titulo
			// 
			this.lbl_titulo.Font = new System.Drawing.Font("Lucida Bright", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_titulo.Location = new System.Drawing.Point(285, 9);
			this.lbl_titulo.Name = "lbl_titulo";
			this.lbl_titulo.Size = new System.Drawing.Size(411, 61);
			this.lbl_titulo.TabIndex = 0;
			this.lbl_titulo.Text = "Planificador NET";
			this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chart
			// 
			chartArea1.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart.Legends.Add(legend1);
			this.chart.Location = new System.Drawing.Point(53, 88);
			this.chart.Name = "chart";
			this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
			this.chart.Size = new System.Drawing.Size(836, 300);
			this.chart.TabIndex = 2;
			this.chart.Text = "chart";
			// 
			// btn_addproc
			// 
			this.btn_addproc.BackColor = System.Drawing.Color.White;
			this.btn_addproc.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_addproc.Location = new System.Drawing.Point(102, 480);
			this.btn_addproc.Name = "btn_addproc";
			this.btn_addproc.Size = new System.Drawing.Size(158, 43);
			this.btn_addproc.TabIndex = 3;
			this.btn_addproc.Text = "Añadir Proceso";
			this.btn_addproc.UseVisualStyleBackColor = false;
			this.btn_addproc.Click += new System.EventHandler(this.btn_addproc_Click);
			// 
			// tb_name
			// 
			this.tb_name.Location = new System.Drawing.Point(91, 407);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(182, 20);
			this.tb_name.TabIndex = 4;
			this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tb_time
			// 
			this.tb_time.Location = new System.Drawing.Point(91, 439);
			this.tb_time.Name = "tb_time";
			this.tb_time.Size = new System.Drawing.Size(182, 20);
			this.tb_time.TabIndex = 5;
			this.tb_time.Text = "0";
			this.tb_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lbl_name
			// 
			this.lbl_name.AutoSize = true;
			this.lbl_name.Location = new System.Drawing.Point(41, 410);
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.Size = new System.Drawing.Size(44, 13);
			this.lbl_name.TabIndex = 6;
			this.lbl_name.Text = "Nombre";
			// 
			// lbl_time
			// 
			this.lbl_time.AutoSize = true;
			this.lbl_time.Location = new System.Drawing.Point(41, 442);
			this.lbl_time.Name = "lbl_time";
			this.lbl_time.Size = new System.Drawing.Size(45, 13);
			this.lbl_time.TabIndex = 7;
			this.lbl_time.Text = "Tiempo ";
			// 
			// btn_rr
			// 
			this.btn_rr.BackColor = System.Drawing.Color.White;
			this.btn_rr.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_rr.Location = new System.Drawing.Point(538, 439);
			this.btn_rr.Name = "btn_rr";
			this.btn_rr.Size = new System.Drawing.Size(158, 43);
			this.btn_rr.TabIndex = 8;
			this.btn_rr.Text = "Round Robin";
			this.btn_rr.UseVisualStyleBackColor = false;
			this.btn_rr.Click += new System.EventHandler(this.Btn_rrClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(321, 407);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "EN EJECUCION";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label2.Location = new System.Drawing.Point(481, 407);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 16);
			this.label2.TabIndex = 10;
			this.label2.Text = "BLOQUEADO";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(605, 407);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 16);
			this.label3.TabIndex = 11;
			this.label3.Text = "TERMINADO";
			// 
			// lbl_max
			// 
			this.lbl_max.AutoSize = true;
			this.lbl_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_max.Location = new System.Drawing.Point(538, 493);
			this.lbl_max.Name = "lbl_max";
			this.lbl_max.Size = new System.Drawing.Size(51, 20);
			this.lbl_max.TabIndex = 12;
			this.lbl_max.Text = "Max: ";
			// 
			// lbl_min
			// 
			this.lbl_min.AutoSize = true;
			this.lbl_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_min.Location = new System.Drawing.Point(538, 513);
			this.lbl_min.Name = "lbl_min";
			this.lbl_min.Size = new System.Drawing.Size(42, 20);
			this.lbl_min.TabIndex = 13;
			this.lbl_min.Text = "Min:";
			// 
			// lbl_med
			// 
			this.lbl_med.AutoSize = true;
			this.lbl_med.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_med.Location = new System.Drawing.Point(538, 533);
			this.lbl_med.Name = "lbl_med";
			this.lbl_med.Size = new System.Drawing.Size(62, 20);
			this.lbl_med.TabIndex = 14;
			this.lbl_med.Text = "Media:";
			// 
			// lbl_desv
			// 
			this.lbl_desv.AutoSize = true;
			this.lbl_desv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_desv.Location = new System.Drawing.Point(538, 553);
			this.lbl_desv.Name = "lbl_desv";
			this.lbl_desv.Size = new System.Drawing.Size(54, 20);
			this.lbl_desv.TabIndex = 15;
			this.lbl_desv.Text = "Desv:";
			// 
			// btn_respro
			// 
			this.btn_respro.Location = new System.Drawing.Point(91, 36);
			this.btn_respro.Name = "btn_respro";
			this.btn_respro.Size = new System.Drawing.Size(104, 23);
			this.btn_respro.TabIndex = 17;
			this.btn_respro.Text = "Reset Process";
			this.btn_respro.UseVisualStyleBackColor = true;
			this.btn_respro.Click += new System.EventHandler(this.Btn_resproClick);
			// 
			// btn_start
			// 
			this.btn_start.BackColor = System.Drawing.Color.White;
			this.btn_start.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_start.Location = new System.Drawing.Point(332, 439);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(158, 43);
			this.btn_start.TabIndex = 1;
			this.btn_start.Text = "FCFS";
			this.btn_start.UseVisualStyleBackColor = false;
			this.btn_start.Click += new System.EventHandler(this.Btn_startClick);
			// 
			// btn_str
			// 
			this.btn_str.BackColor = System.Drawing.Color.White;
			this.btn_str.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_str.Location = new System.Drawing.Point(332, 510);
			this.btn_str.Name = "btn_str";
			this.btn_str.Size = new System.Drawing.Size(158, 43);
			this.btn_str.TabIndex = 16;
			this.btn_str.Text = "Shortest Time";
			this.btn_str.UseVisualStyleBackColor = false;
			this.btn_str.Click += new System.EventHandler(this.Btn_strClick);
			// 
			// btn_prior
			// 
			this.btn_prior.BackColor = System.Drawing.Color.White;
			this.btn_prior.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_prior.Location = new System.Drawing.Point(743, 510);
			this.btn_prior.Name = "btn_prior";
			this.btn_prior.Size = new System.Drawing.Size(158, 43);
			this.btn_prior.TabIndex = 19;
			this.btn_prior.Text = "Shortest Job";
			this.btn_prior.UseVisualStyleBackColor = false;
			this.btn_prior.Click += new System.EventHandler(this.Btn_priorClick);
			// 
			// btn_mlq
			// 
			this.btn_mlq.BackColor = System.Drawing.Color.White;
			this.btn_mlq.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_mlq.Location = new System.Drawing.Point(743, 439);
			this.btn_mlq.Name = "btn_mlq";
			this.btn_mlq.Size = new System.Drawing.Size(158, 43);
			this.btn_mlq.TabIndex = 18;
			this.btn_mlq.Text = "MLQ";
			this.btn_mlq.UseVisualStyleBackColor = false;
			this.btn_mlq.Click += new System.EventHandler(this.Btn_mlqClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 593);
			this.Controls.Add(this.btn_prior);
			this.Controls.Add(this.btn_mlq);
			this.Controls.Add(this.btn_respro);
			this.Controls.Add(this.btn_str);
			this.Controls.Add(this.lbl_desv);
			this.Controls.Add(this.lbl_med);
			this.Controls.Add(this.lbl_min);
			this.Controls.Add(this.lbl_max);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_rr);
			this.Controls.Add(this.lbl_time);
			this.Controls.Add(this.lbl_name);
			this.Controls.Add(this.tb_time);
			this.Controls.Add(this.tb_name);
			this.Controls.Add(this.btn_addproc);
			this.Controls.Add(this.chart);
			this.Controls.Add(this.btn_start);
			this.Controls.Add(this.lbl_titulo);
			this.Name = "MainForm";
			this.Text = "PlanificadorFCFS";
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btn_mlq;
		private System.Windows.Forms.Button btn_prior;
		private System.Windows.Forms.Button btn_respro;
		private System.Windows.Forms.Button btn_str;
		private System.Windows.Forms.Label lbl_desv;
		private System.Windows.Forms.Label lbl_med;
		private System.Windows.Forms.Label lbl_min;
		private System.Windows.Forms.Label lbl_max;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_rr;
		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btn_addproc;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_time;
    }
}
