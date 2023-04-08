using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;


namespace WindowsFormsApp1
{
    public partial class SPAINGAME : Form
    {
        int angle =0;
        Boolean isrotation = false;
        
         
        public SPAINGAME()
        {
            InitializeComponent();
            chart1.Titles.Add("SpainGame");
            /*chart1.Series["s1"].IsValueShownAsLabel = false;
            chart1.Series["s1"].Points.AddXY("momo", "50");
           */ /*chart1.Series["s1"].Points.AddXY("sugar", "50");
            chart1.Series["s1"].Points.AddXY("manogo", "50");*/
          
            chart1.Series["s1"].Points.AddXY("PEN", "50");
            chart1.Series["s1"].Points.AddXY("Sorry", "50");
            chart1.Series["s1"].Points.AddXY("toffee", "50");

            chart1.Series["s1"].Points.AddXY("sorry", "50");
            chart1.Series["s1"].Points.AddXY("Diary", "50");
            chart1.Series["s1"].Points.AddXY("Sorry", "50");
            chart1.Series["s1"].Points.AddXY("Color pen", "50");
            chart1.Series["s1"].Points.AddXY("Sorry", "50");
            chart1.Series["s1"].Points.AddXY("juice", "50");
            chart1.Series["s1"].Points.AddXY("Sorry", "50");
           /* chart2.Series["S2"].Points.AddXY("", "50");
            chart2.Series["S2"].Points.AddXY("", "50");
            chart2.Series["S2"].Points.AddXY("", "50");
            chart2.Series["S2"].Points.AddXY("", "50");


*/
        }
       /* public string constring = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Connectiontest; Integrated Security = True";
        private void StudentEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'connectiontestDataSet1.spain_game_term' table. You can move, or remove it, as needed.
          

        }*/

       /* private void btn_add_Student_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into manoj values('" + txt_id.Text.ToString() + " ','" + txt_name.Text.ToString() + "')";
                SqlCommand sqln = new  SqlCommand(q, con);
                sqln.ExecuteNonQuery();
                MessageBox.Show("sussess");

            }
        }
*/
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (isrotation)
            {
                timer1.Interval = 1;
                // Update the angle




                angle +=30;
                if (angle > 360) angle = 0;

                // Set the Chart's rotation angle
                chart1.Series["s1"]["PieStartAngle"] = angle.ToString();
                await Task.Delay(500);
                angle+=25;
                if (angle > 360) angle = 0;
                chart1.Series["s1"]["PieStartAngle"] = angle.ToString();
                await Task.Delay(500);
                angle += 20;
                if (angle > 360) angle = 0;
                chart1.Series["s1"]["PieStartAngle"] = angle.ToString();
                await Task.Delay(500);
                angle+=15;
                if (angle > 360) angle = 0;
                chart1.Series["s1"]["PieStartAngle"] = angle.ToString();
                await Task.Delay(500);
                angle += 10;
                if (angle > 360) angle = 0;
                chart1.Series["s1"]["PieStartAngle"] = angle.ToString();
                await Task.Delay(500);
                angle +=5;
                if (angle > 360) angle = 0;
                chart1.Series["s1"]["PieStartAngle"] = angle.ToString();
                await Task.Delay(1000);




                isrotation = false;
               


                // Redraw the Chart
                chart1.Invalidate();

              
            }
          
            
               
                

        }

        private void chart1_AnnotationPositionChanging(object sender, System.Windows.Forms.DataVisualization.Charting.AnnotationPositionChangingEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            isrotation = true;
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {

            
               
           
                isrotation = false;
           
            

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}
