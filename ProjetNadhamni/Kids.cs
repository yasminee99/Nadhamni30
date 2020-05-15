﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetNadhamni
{
    public partial class Kids : Form
    {
        public Kids()
        {
            InitializeComponent();
        }
        string gender, health;
        private void btnAddKids_Click(object sender, EventArgs e)
        {

        }

        private void rd_femIKid_CheckedChanged(object sender, EventArgs e)
        {
            gender = "girl";
        }

        private void rd_maleKid_CheckedChanged(object sender, EventArgs e)
        {
            gender = "boy";
        }

        private void rd_HealthyKid_CheckedChanged(object sender, EventArgs e)
        {
            health = "healthy";
        }

        private void rd_SickKid_CheckedChanged(object sender, EventArgs e)
        {
            health = "sick";
        }

        private void btnSaveKids_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            try
            {

                con.ConnectionString = @"Data Source=DESKTOP-69MM1NJ\SQLEXPRESS;Initial Catalog=NadhamniDB;Integrated Security=True;Pooling=False";
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Kids(FirstName,Gender,Birthday,Health,Consultation,DrName,LevelOfEducation,Establishment,Adress) values(@FirstName,@Gender,@Birthday,@Health,@Consultation,@DrName,@LevelOfEducation,@Establishment,@Adress)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@FirstName", txt_firstnameKid.Text);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Birthday", birthdayKid.Value.ToString());
                cmd.Parameters.AddWithValue("@Health", health);
                cmd.Parameters.AddWithValue("@Consultation", ConsultationKids.Value.ToString());
                cmd.Parameters.AddWithValue("@DrName", txt_docNameKids.Text);
                cmd.Parameters.AddWithValue("@LevelOfEducation", cmb_levelEducation.Text.ToString());
                cmd.Parameters.AddWithValue("@Establishment", txt_establishmentKid.Text);
                cmd.Parameters.AddWithValue("@Adress", txt_AdrKid.Text);
               

                //Execute Command
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");

                Parents p = new Parents();
                p.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }



            
        }
    }
}
