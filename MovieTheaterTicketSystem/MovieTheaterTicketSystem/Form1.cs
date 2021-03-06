﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheaterTicketSystem
{
    public partial class Form1 : Form
    {
        private int[] status = new int[10];

        public Form1()
        {
            InitializeComponent();
            UpdateSeat();
        }

        public void UpdateSeat()
        {
            Random random = new Random();
            int index = 0;
            while (index < status.Length)
            {
                status[index] = random.Next(0, 2);
                index++;
            }
            SetSeatImage(status);
        }

        public void SetSeatImage(int[] status)
        {
            pictureBox1.Image = GetSeatImage(status[0]);
            pictureBox2.Image = GetSeatImage(status[1]);
            pictureBox3.Image = GetSeatImage(status[2]);
            pictureBox4.Image = GetSeatImage(status[3]);
            pictureBox5.Image = GetSeatImage(status[4]);
            pictureBox6.Image = GetSeatImage(status[5]);
            pictureBox7.Image = GetSeatImage(status[6]);
            pictureBox8.Image = GetSeatImage(status[7]);
            pictureBox9.Image = GetSeatImage(status[8]);
            pictureBox10.Image = GetSeatImage(status[9]);
        }

        public Image GetSeatImage(int type)
        {
            if (type == 0)
                return global::MovieTheaterTicketSystem.Properties.Resources.Seat_Avail;
            else if (type == 1)
                return global::MovieTheaterTicketSystem.Properties.Resources.Seat_Unavail;
            else
                return global::MovieTheaterTicketSystem.Properties.Resources.Seat_Select;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            UpdateSeat();
        }

        private void chooseSeatButton_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < status.Length; index++)
            {
                if (status[index] == 0 && status[index + 1] == 0 && status[index + 2] == 0)
                {
                    status[index] = 2;
                    status[index + 1] = 2;
                    status[index + 2] = 2;
                    SetSeatImage(status);
                    break;
                }
            }
        }
    }
}