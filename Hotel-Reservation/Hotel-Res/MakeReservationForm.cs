﻿using Hotel_Res.Models;
using Hotel_Res.Utilities;
using Hotel_Reservations;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Res
{
    public partial class MakeReservationForm : Form
    {
        List<Room> Rooms;
        MethodList methodList;

        public MakeReservationForm()
        {
            InitializeComponent();

            Rooms = new();

            methodList = new MethodList();
        }
        private void MakeReservationForm_Load(object sender, EventArgs e)
        {
            methodList.LoadingData(Rooms);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            methodList.ReturnToHome();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show(ExceptionMessages.roomNumberNecessary);
            }
            else
            {
                int roomNumber = int.Parse(textBox1.Text);
                string reservationName = textBox2.Text;

                if (roomNumber <= 0 || roomNumber > 30)
                {
                    MessageBox.Show(ExceptionMessages.nonExistantRoomNumber);

                }
                else if (reservationName == null || reservationName == "")
                {
                    MessageBox.Show(ExceptionMessages.reservationNameNecessary);

                }
                else
                {
                    var roomToUpdate = Rooms.FirstOrDefault(x => x.RoomNumber == roomNumber);
                    if (roomToUpdate.IsCleaned == true)
                    {
                        roomToUpdate.IsOccupated = true;
                        roomToUpdate.IsCleaned = false;
                        roomToUpdate.ReservationName = reservationName;

                        var index = Rooms.IndexOf(roomToUpdate);
                        Rooms.RemoveAt(index);
                        Rooms.Insert(index, roomToUpdate);

                        string filePath2 = FilePaths.ReservationFileSavePath;
                        using (StreamWriter writer = new StreamWriter(filePath2))

                            foreach (var room in Rooms)
                            {
                                writer.WriteLine($"{room.RoomNumber}, {room.ReservationName}, {room.RoomType}, {room.IsCleaned}, {room.IsOccupated}");

                            }

                        MessageBox.Show(ExceptionMessages.doneReservation + reservationName);
                    }
                    else
                    {
                        MessageBox.Show(ExceptionMessages.impossibleReservation);
                    }
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
