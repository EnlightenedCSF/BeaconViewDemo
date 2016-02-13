﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TrilaterationDemo.Model;
using TrilaterationDemo.Presenters;
using TrilaterationDemo.Properties;
using TrilaterationDemo.TrilateratingStrategy;

namespace TrilaterationDemo
{
    public partial class MainForm : Form
    {
        private AbstractDrawer _drawer;
        private Bitmap _bitmap;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(picBoxTrilateration.Size.Width, picBoxTrilateration.Size.Height);
            picBoxTrilateration.Image = _bitmap;

            _drawer = new Drawer(_bitmap);
            Floor.GetFloor().ChangeTrilaterationMethod(0);
            
            _drawer.SetNeedsDisplay();
            picBoxTrilateration.Invalidate();

            /*panelTrilaterationMethods.Hide();
            btnReset.Hide();

            var g = new Graph();
            var a = new LocationNode { X = 1, Y = 1, Label = "A" };
            var b = new LocationNode { X = 1, Y = 3, Label = "B" };
            var c = new LocationNode { X = 3, Y = 3, Label = "C" };
            var d = new LocationNode { X = 3, Y = 1, Label = "D" };

            //g.ConnectNodes(a, b).ConnectNodes(b, c).ConnectNodes(c, d).ConnectNodes(d, a);
            g.AddNode(a).AddNode(b).AddNode(c).AddNode(d);

            var at = new Attractor {Graph = g};

            _drawer = new GraphDrawer(_bitmap, at);
            */

            picBoxTrilateration.MouseDown += (o, args) => { 
                _drawer.OnMouseDown(args.X, args.Y); 
                picBoxTrilateration.Invalidate();
                RefreshLabels();
            };

            picBoxTrilateration.MouseMove += (o, args) =>
            {
                _drawer.OnMouseMove(args.X, args.Y); 
                picBoxTrilateration.Invalidate();
                RefreshLabels();
            };

            picBoxTrilateration.MouseUp += (o, args) =>
            {
                _drawer.OnMouseUp(); 
                picBoxTrilateration.Invalidate();
                RefreshLabels();
            };
            
            /*
            _drawer.SetNeedsDisplay();
            picBoxTrilateration.Invalidate();*/
        }

        private void RefreshLabels()
        {
            lblBeacon1.Text = Floor.GetFloor().Beacons[0].ToString();
            lblBeacon2.Text = Floor.GetFloor().Beacons[1].ToString();
            lblBeacon3.Text = Floor.GetFloor().Beacons[2].ToString();

            lblResult.Text = Floor.GetFloor().UserPositions[0].ToString();

            log.Clear();
            var epta = Floor.GetFloor().Strategies[3] as EptaStrategy ?? new EptaStrategy(null);
            var intersections = epta.Intersections ?? new List<PointF>();
            foreach (var point in intersections)
            {
                log.AppendText(point + "\n");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //_drawer.Reset();
            _drawer.SetNeedsDisplay();
            picBoxTrilateration.Invalidate();
        }

        private void rBtnMethod_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var radio in panelTrilaterationMethods.Controls.OfType<RadioButton>()
                .Select(control => control)
                .Where(radio => radio.Checked && radio.Text != Resources.Both))
            {
                Floor.GetFloor().ChangeTrilaterationMethod(radio.TabIndex);
                _drawer.SetNeedsDisplay();
                picBoxTrilateration.Invalidate();
            }
        }

        private void rBtnBoth_CheckedChanged(object sender, EventArgs e)
        {
            Floor.GetFloor().UseBothMethods();
            _drawer.SetNeedsDisplay();
            picBoxTrilateration.Invalidate();
        }
    }
}
