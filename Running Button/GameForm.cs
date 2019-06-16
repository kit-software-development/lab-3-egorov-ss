using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RunningButton
{
    static class Extention
    {
        public static Point Subtract(this Point lhs, Point rhs)
        {
            return new Point(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }
    }
    public partial class GameForm : Form
    {
        private Size  lastFieldSize;
        private Point btnCenterLocation;
        private Point prevMouseLocation;
        private Point prevTopBorderLocation;
        private Point prevBottomBorderLocation;
        private Point prevLeftBorderLocation;
        private Point prevRightBorderLocation;
        private const float minDistancePx = 100f;

        public GameForm()
        {
            InitializeComponent();
        }


        private void OnFormLoad(object sender, EventArgs e)
        {
            // Place button at center of window
            Size contentSize = pnlContent.Size;
            btn.Location = new Point(
                contentSize.Width  - btn.Size.Width  >> 1,
                contentSize.Height - btn.Size.Height >> 1
            );
            this.lastFieldSize = contentSize;
            btnCenterLocation = new Point
            {
                X = (int)(btn.Location.X + btn.Width / 2f),
                Y = (int)(btn.Location.Y + btn.Height / 2f),
            };
            prevTopBorderLocation = new Point(btnCenterLocation.X, 0);
            prevBottomBorderLocation = new Point(btnCenterLocation.X, pnlContent.Size.Height);
            prevLeftBorderLocation = new Point(0, btnCenterLocation.Y);
            prevRightBorderLocation = new Point(pnlContent.Size.Width, btnCenterLocation.Y);
        }

        private void OnFormResize(object sender, EventArgs e)
        {
            PlaceWithoutClipping(btn);
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Поздравляем! Вы смогли нажать на кнопку!", "YOU WIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void PlaceWithoutClipping(Control control)
        {
            control.Location = new Point
            {
                X = Math.Min(Math.Max(0, control.Location.X), control.Parent.Size.Width - control.Size.Width),
                Y = Math.Min(Math.Max(0, control.Location.Y), control.Parent.Size.Height - control.Size.Height),
            };
        }

        private void OnMouseOnForm(object sender, MouseEventArgs e)
        {
            Point mouseLocation = MousePosition;
            if (mouseLocation == prevMouseLocation)
                return;
            btnCenterLocation = new Point
            {
                X = (int)(btn.Location.X + btn.Width / 2f),
                Y = (int)(btn.Location.Y + btn.Height / 2f),
            };
            Point topBorderLocation = new Point(btnCenterLocation.X, 0),
                  bottomBorderLocation = new Point(btnCenterLocation.X, pnlContent.Size.Height),
                  leftBottomLocation = new Point(0, btnCenterLocation.Y),
                  rightBottomLocation = new Point(pnlContent.Size.Width, btnCenterLocation.Y);
            Point btnLocation = btn.Location;
            btnLocation.Offset( CalculateAdjustment(
                ConvertToFormCoordinates(mouseLocation),
                ConvertToFormCoordinates(prevMouseLocation),
                isMouse: true
            ));
            btnLocation.Offset( CalculateAdjustment(
                topBorderLocation,
                prevTopBorderLocation)
            );
            btnLocation.Offset( CalculateAdjustment(
                bottomBorderLocation,
                prevBottomBorderLocation)
            );
            btnLocation.Offset( CalculateAdjustment(
                leftBottomLocation,
                prevLeftBorderLocation)
            );
            btnLocation.Offset( CalculateAdjustment(
                rightBottomLocation,
                prevRightBorderLocation)
            );
            btn.Location = btnLocation;
            PlaceWithoutClipping(btn);

            prevMouseLocation = MousePosition;
            prevTopBorderLocation = topBorderLocation;
            prevBottomBorderLocation = bottomBorderLocation;
            prevLeftBorderLocation = leftBottomLocation;
            prevRightBorderLocation = rightBottomLocation;

        }

        private void OnMouseEnter(object sender, EventArgs e)
        {

            prevMouseLocation = MousePosition;

        }

        private Point CalculateAdjustment(Point chaser, Point prevChaser, bool isMouse = false)
        {
            Point chaserMoveDelta = chaser.Subtract(prevChaser);
            Point buttonDelta = btnCenterLocation.Subtract(chaser);

            float distanceRatio = minDistancePx / (float)PythagoreanLength(buttonDelta);

            Point newLocation = Point.Empty;
            if (distanceRatio > 1)
            {
                if (isMouse)
                {
                    newLocation.Offset(
                       (Math.Sign(buttonDelta.X) == Math.Sign(chaserMoveDelta.X))
                           ? (int)(chaserMoveDelta.X * distanceRatio) : 0,
                       (Math.Sign(buttonDelta.Y) == Math.Sign(chaserMoveDelta.Y))
                           ? (int)(chaserMoveDelta.Y * distanceRatio) : 0
                    );
                }
                else
                {
                    int offset = (int)((Math.Abs(chaserMoveDelta.X) + Math.Abs(chaserMoveDelta.Y)));
                    if (chaserMoveDelta.X == 0)
                    {
                        newLocation.Offset(
                            (int)(Math.Sign(buttonDelta.X) * offset * distanceRatio),
                            (int)(Math.Sign(chaserMoveDelta.Y) * distanceRatio)
                        );
                    }
                    else
                    {
                        newLocation.Offset(
                            (int)(Math.Sign(chaserMoveDelta.X) * distanceRatio),//offset ,
                            (int)(Math.Sign(buttonDelta.Y) * offset * distanceRatio)
                        );
                    }
                }

            }
            return newLocation;
        }

        private double PythagoreanLength(Point a)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y);
        }

        private Point ConvertToFormCoordinates(Point p)
        {
           p.Offset(
               -this.Location.X - pnlContent.Location.X,
               -this.Location.Y - pnlContent.Location.Y
           );
           return p;
        }

    }
}
