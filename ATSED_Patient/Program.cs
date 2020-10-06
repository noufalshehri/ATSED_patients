using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATSED_Patient
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class currentPatientID
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-EN3PV7Q;Initial Catalog=ATSED;Integrated Security=True");
        public currentPatientID(int id)
        {

            new priority(id);
        }
    }
    public class triage
    {
        public triage(string chiefComplaint)
        {
            //Red cases 
            //priority one 
             if (chiefComplaint .Equals("Vomiting blood".ToLower().Trim())
                || chiefComplaint.Equals("loss of conscious".ToLower().Trim())
                || chiefComplaint.Equals("hyper sensitivity".ToLower().Trim())
                || chiefComplaint.Equals("Severe chest pain".ToLower().Trim())
                || chiefComplaint.Equals("Newborn (month or younger)".ToLower().Trim())
                || chiefComplaint.Equals("shortness of breath ".ToLower().Trim())
                || chiefComplaint.Equals("Severe bleeding".ToLower().Trim())
                || chiefComplaint.Equals("Accident, assault or bite".ToLower().Trim())
                || chiefComplaint.Equals("seizures".ToLower().Trim())
                || chiefComplaint.Equals("Burns".ToLower().Trim())
                || chiefComplaint.Equals("Severe vomiting or diarrhea".ToLower().Trim())
                || chiefComplaint.Equals("Difficulty in speaking".ToLower().Trim())
                || chiefComplaint.Equals("Hallucination".ToLower().Trim())
                || chiefComplaint.Equals("Unstable".ToLower().Trim())
                )
                new priority(1, chiefComplaint);
            //Orange cases 
            //priority two 
            else if (chiefComplaint.Equals("FeverSeven".ToLower().Trim())
                || chiefComplaint.Equals("pain".ToLower().Trim())
                || chiefComplaint.Equals("Irritation".ToLower().Trim())
                || chiefComplaint.Equals("Under the influence of alcohol or anaesthetic".ToLower().Trim())
                || chiefComplaint.Equals("Urine incarceration or not Urinating".ToLower().Trim())
                )
                new priority(2, chiefComplaint);
            //Yellow cases 
            //priority three 
            else if (chiefComplaint.Equals("Cough or cold or coryza".ToLower().Trim())
                || chiefComplaint.Equals("Joint pain or Joint swelling".ToLower().Trim())
                || chiefComplaint.Equals("object entered the eye or vision changes".ToLower().Trim())
                || chiefComplaint.Equals("Constipation without flatulence".ToLower().Trim())
                || chiefComplaint.Equals("Stomach ache".ToLower().Trim())
                )
                new priority(3, chiefComplaint);
            //Green cases 
            //priority four 
           else if (chiefComplaint.Equals("Fever".ToLower().Trim())
                || chiefComplaint.Equals("Heart palpitations".ToLower().Trim())
                || chiefComplaint.Equals("Vomiting".ToLower().Trim())
                || chiefComplaint.Equals("severe headache".ToLower().Trim())
                || chiefComplaint.Equals("Swollen feet".ToLower().Trim())
                || chiefComplaint.Equals("Transfer from pharmacy or lab".ToLower().Trim())
                || chiefComplaint.Equals("Constipation with flatulence".ToLower().Trim())
                || chiefComplaint.Equals("Pain in another area".ToLower().Trim())
                || chiefComplaint.Equals("Frequent urination".ToLower().Trim())
                || chiefComplaint.Equals("diabetes or hypertension Follow up".ToLower().Trim())
                )
                new priority(4, chiefComplaint);
            //None of the cases 
            else if (chiefComplaint.Equals("none"))
                new priority(0, chiefComplaint);
        }
    }
    public class priority
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-EN3PV7Q;Initial Catalog=ATSED;Integrated Security=True");
        static int id;
        public priority(int id)
        {
            priority.id = id;
        }

        public priority(int p,string chiefComplaint)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand
           ("INSERT INTO waitingPatients (id, enName,arName, age, gender) SELECT id, enName,arName, age, gender FROM hospitalRecords WHERE id = '" + id + "'; ", cn);
            cmd.ExecuteNonQuery();

            //set the chief complaint and priority 
             cmd = new SqlCommand
          ("UPDATE waitingPatients SET chiefComplaint='" + chiefComplaint + "', priority="+p+ " WHERE id=" + id + ";", cn);
            cmd.ExecuteNonQuery();
            
            //set time
             cmd = new SqlCommand
           ("UPDATE waitingPatients SET time = GETDATE() WHERE id = " + id + ";", cn);
            cmd.ExecuteNonQuery();

           
            cn.Close();
        }


    }
}
