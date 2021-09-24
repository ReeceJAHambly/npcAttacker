using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Math;
using System.Windows.Forms;
using System.Drawing;
using GTA.Native;

public class CreateVehicle : Script
{
    public CreateVehicle()
    {
        Tick += OnTick;
        KeyUp += OnKeyUp;
        KeyDown += OnKeyDown;
    }

    private void OnTick(object sender, EventArgs e)
    {
    }

    private void OnKeyDown(object sender, KeyEventArgs e)
    {
    }

    private void OnKeyUp(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.NumPad1)
        {
            Vehicle vehicle = World.CreateVehicle(VehicleHash.Zentorno, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 3.0f, Game.Player.Character.Heading + 90);
            vehicle.CanTiresBurst = false;
            vehicle.Mods.CustomPrimaryColor = Color.FromArgb(38, 38, 38);
            vehicle.Mods.CustomSecondaryColor = Color.DarkOrange;
            vehicle.PlaceOnGround();
        }
    }
}
