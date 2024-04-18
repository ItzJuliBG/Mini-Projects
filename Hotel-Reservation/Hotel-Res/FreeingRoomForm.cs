using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Hotel_Res.Models;
using Hotel_Res.Utilities;
using Hotel_Reservations;

namespace Hotel_Res
{
    public partial class FreeingRoomForm : Form
    {

        List<Room> Rooms;
        MethodList methodList;
        public FreeingRoomForm()
        {
            InitializeComponent();

            Rooms = new List<Room>();

            methodList = new MethodList();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            methodList.ReturnToHome();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (int.TryParse(input, out _))
            {
                int inputNumber = int.Parse(input);
                if (inputNumber < 1 || inputNumber > 30)
                {
                    MessageBox.Show(ExceptionMessages.nonExistantRoomNumber);
                }
                else
                {
                    Room currentRoom = Rooms.FirstOrDefault(x => x.RoomNumber == inputNumber);

                    if (currentRoom.IsOccupated == false)
                    {
                        MessageBox.Show(ExceptionMessages.roomAlreadyFree);
                    }
                    else
                    {
                        currentRoom.IsOccupated = false;
                        currentRoom.ReservationName = "";
                        MessageBox.Show(ExceptionMessages.roomFreedSuccessfully);
                        var index = Rooms.IndexOf(currentRoom);
                        Rooms.RemoveAt(index);
                        Rooms.Insert(index, currentRoom);

                        string filePath2 = FilePaths.ReservationFileSavePath;
                        using (StreamWriter writer = new StreamWriter(filePath2))

                            foreach (var room in Rooms)
                            {
                                writer.WriteLine($"{room.RoomNumber}, {room.ReservationName}, {room.RoomType}, {room.IsCleaned}, {room.IsOccupated}");
                            }
                    }
                }
            }
            else
            {
                MessageBox.Show(ExceptionMessages.useOnlyNums);
            }
        }

        private void FreeingRoomForm_Load(object sender, EventArgs e)
        {
            methodList.LoadingData(Rooms);
        }
    }
}
