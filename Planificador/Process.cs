/*
 * Created by SharpDevelop.
 * User: Gustavo
 * Date: 10/10/2022
 * Time: 09:10 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace PlanificadorFCFS
{
	/// <summary>
	/// Description of Process.
	/// </summary>
	public class Process
	{
		private int id,serviceTime,waitingTime,totalTime,step,actualStep,total;
		private string name="";
		private Series pb;
		private Chart chr;
		private bool finish;
		
		public Process()
		{}
		
		public Process(int id,int serviceTime, string name,Chart chr)
		{
			this.finish=false;
			this.actualStep=0;
			this.chr = chr;
			this.id = id;
			this.serviceTime = serviceTime;
			this.name = name;
			this.waitingTime = -1;
			this.totalTime = -1;
			this.step = 100 / serviceTime;
			this.total=0;

		}
		
		public void DoWork(int quantum)
		{
			int toStop;
			if(quantum < serviceTime)
			{
				toStop = quantum + actualStep;
			}
			else
			{
				toStop = serviceTime;
			}
			
			if(!this.finish)
			{
				for(int i = actualStep; i < toStop; i++)
				{
					Debug.WriteLine("Proceso "+this.name+" ["+id.ToString()+"]  "+total.ToString()+"%");
					total = total + step;
					Thread.Sleep(1000);
					pb.Points[0].SetValueXY(this.name, total);
					pb.Points[0].Color = Color.Red;
					chr.Update();
					actualStep++;
				}
			}

			
			
			
			if(actualStep >= serviceTime)
			{
				finish = true;
				pb.Points[0].SetValueXY(this.name, 100);
				pb.Points[0].Color = Color.Green;
					
				chr.Update();
				Debug.WriteLine("Proceso "+id.ToString()+" terminado con exito! ");
			}
			

		}
		
		public String ToString()
		{
			String result;
			result = "ID: "+id.ToString()+" / Service Time: " + serviceTime.ToString() +" / Waiting Time: " +
				waitingTime.ToString() + " / Total Time: "+totalTime.ToString();
			return result;
		}
		
		
		public bool Finish {
			get { return finish; }
			set { finish = value; }
		}
		
		public int Step {
			get { return step; }
			set { step = value; }
		}

		public string Name {
			get { return name; }
			set { name = value; }
		}
		
		public Series Pb {
			get { return pb; }
			set { pb = value; }
		}

		public int Id {
			get { return id; }
			set { id = value; }
		}

		public int ServiceTime {
			get { return serviceTime; }
			set { serviceTime = value; }
		}

		public int WaitingTime {
			get { return waitingTime; }
			set { waitingTime = value; }
		}

		public int TotalTime {
			get { return totalTime; }
			set { totalTime = value; }
		}
		
	}
}
