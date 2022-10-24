﻿/*
 * Created by SharpDevelop.
 * User: Gustavo
 * Date: 10/10/2022
 * Time: 09:02 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace PlanificadorFCFS
{
	/// <summary>
	
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		List<Process> procesos = new List<Process>();
		
		int contador = 1,max=-1,min=Int32.MaxValue,total=0,proc=0;
		double med=0.0f,desv=0.0f;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			chart.Titles.Add("Tareas");
			Series serie = chart.Series.Add("MAX");
			serie.Label = "MAX";
			serie.Points.Add(100);
			serie.Points[0].Color = Color.Blue;

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private void FCFS()
		{
      		int totalWaitingTime = 0;
      		foreach(Process pro in procesos)
      		{
      			pro.WaitingTime = totalWaitingTime;
      			
      			totalWaitingTime = pro.ServiceTime + totalWaitingTime;
      			
      			pro.TotalTime = totalWaitingTime;
      			

      		}
      		
			
      		
      		foreach(Process pro in procesos)
      		{
				pro.DoWork(100);
      			
      		}
      		
		}
		
		private void RoundRobin(int quantum)
		{
			List<Process> rrp = procesos;
			for(int i = 0; i < rrp.Count; i++)
			{
				rrp[i].DoWork(quantum);
				if(!rrp[i].Finish)
				{
					rrp.Add(rrp[i]);
				}
			}
		}
		
		
		void reset()
		{
			foreach(Process pro in procesos)
			{
				pro.Pb.Points[0].SetValueXY(pro.Name, 0);
			}
			
		}


		
		void Btn_startClick(object sender, EventArgs e)
		{
			reset();
			chart.Update();
			FCFS();
		}

        private void btn_addproc_Click(object sender, EventArgs e)
        {

			Series serie = chart.Series.Add(tb_name.Text);
			serie.Label = tb_name.Text;
			serie.Points.Add(0);

			try
            {
				int tiempo = Int32.Parse(tb_time.Text);
				if(tiempo > 0)
                {
					Process auxProcess = new Process(contador,tiempo,tb_name.Text,chart);
					
					auxProcess.Pb = serie;
					procesos.Add(auxProcess);
					
					if(tiempo < min)
						min = tiempo;
				
					if(tiempo > max)
						max = tiempo;

					total = total + tiempo;
				}
				else
                {
					throw new Exception();
                }
			}
            catch
            {
				Random rd = new Random();
				int rand_num;
				rand_num = rd.Next(1, 10);
				Process auxProcess = new Process(contador, rand_num,tb_name.Text,chart);

				auxProcess.Pb = serie;
				procesos.Add(auxProcess);
				
				if(rand_num < min)
					min = rand_num;
			
				if(rand_num > max)
					max = rand_num;

				total = total + rand_num;
				
					

			}
			
            proc++;
			contador++;
			tb_name.Text = "";
			tb_time.Text = "0";
			reset();
			
			lbl_min.Text = "Min: "+min.ToString();
			lbl_max.Text = "Max: "+max.ToString();
			med = total / proc;
			lbl_med.Text = "Media: "+med.ToString();
			double aux=0.0f;
			foreach(Process pro in procesos)
			{
				aux = aux + Math.Abs(med - Math.Pow(pro.ServiceTime,2));
			}
			
			desv = aux / proc;
			desv = Math.Sqrt(desv);
			desv = Math.Round(desv,4);
			lbl_desv.Text = "Desv: "+desv.ToString();
        }


		
		void Btn_rrClick(object sender, EventArgs e)
		{
			chart.Update();
			
			RoundRobin(1);
		}
    }
}
