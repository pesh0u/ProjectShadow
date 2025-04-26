using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProjectShadow.Core
{
    public static class Design
    {
        public static void CenterPanel(Control form, Panel panel)
        {
            int panelWidth = panel.Width;
            int panelHeight = panel.Height;

            int formWidth = form.ClientSize.Width;
            int formHeight = form.ClientSize.Height;

            panel.Location = new Point(
                (formWidth - panelWidth) / 2,
                (formHeight - panelHeight) / 2
            );
        }

        public static void AnimatePopup(Panel panel, int targetHeight = 200, int animationSpeed = 10, int interval = 15)
        {
            panel.Height = 0;
            panel.Visible = true;

            Timer animationTimer = new Timer();
            animationTimer.Interval = interval;
            animationTimer.Tick += (s, e) =>
            {
                if (panel.Height < targetHeight)
                {
                    panel.Height += animationSpeed;
                    if (panel.Height >= targetHeight)
                    {
                        panel.Height = targetHeight; // Snap exactly to target
                        animationTimer.Stop();
                        animationTimer.Dispose();
                    }
                }
                else
                {
                    animationTimer.Stop();
                    animationTimer.Dispose();
                }
            };

            animationTimer.Start();
        }


        public static void AnimatePopout(Panel panel, int animationSpeed = 10, int interval = 15)
        {
            Timer animationTimer = new Timer();
            animationTimer.Interval = interval;
            animationTimer.Tick += (s, e) =>
            {
                if (panel.Height > 0)
                {
                    panel.Height -= animationSpeed;
                    if (panel.Height < 0)
                        panel.Height = 0;
                }
                else
                {
                    panel.Visible = false;
                    animationTimer.Stop();
                    animationTimer.Dispose();
                }
            };

            animationTimer.Start();
        }


        public static void AnimateCollapse(Panel panel, int animationSpeed = 10, int interval = 15, Action onComplete = null)
        {
            Timer animationTimer = new Timer();
            animationTimer.Interval = interval;
            animationTimer.Tick += (s, e) =>
            {
                if (panel.Height > 0)
                {
                    panel.Height -= animationSpeed;
                    if (panel.Height < 0)
                        panel.Height = 0;
                }
                else
                {
                    panel.Visible = false;
                    animationTimer.Stop();
                    animationTimer.Dispose();
                    onComplete?.Invoke(); // Callback after collapse is complete
                }
            };

            animationTimer.Start();
        }

        public static async void InitializeAnimations(Control form, Panel welcomePanel, Panel loginPanel, int delayMilliseconds = 2000)
        {
            CenterPanel(form, welcomePanel);
            CenterPanel(form, loginPanel);
            loginPanel.Visible = false;

            AnimatePopup(welcomePanel);
            await Task.Delay(delayMilliseconds); // Now uses custom delay

            AnimateCollapse(welcomePanel, onComplete: () =>
            {
                AnimatePopup(loginPanel);
            });
        }

    }
}
