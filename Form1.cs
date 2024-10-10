using System;
using System.Windows.Forms;
using SharpDX.XInput;

namespace PruebaControl
{
    public partial class Form1 : Form
    {
        private Controller controller;
        private System.Windows.Forms.Timer controllerTimer;

        public Form1()
        {
            InitializeComponent();

            // Inicializa el controlador de Xbox
            controller = new Controller(UserIndex.One);

            if (!controller.IsConnected)
            {
                MessageBox.Show("El control de Xbox no está conectado.");
                return;
            }

            // Configura un Timer para revisar el estado del control periódicamente
            controllerTimer = new System.Windows.Forms.Timer();
            controllerTimer.Interval = 100; // 100 ms de intervalo
            controllerTimer.Tick += ControllerTimer_Tick;
            controllerTimer.Start();
        }

        // Evento que se llama cada vez que el Timer se dispara (cada 100ms)
        private void ControllerTimer_Tick(object sender, EventArgs e)
        {
            // Obtiene el estado actual del control de Xbox
            var state = controller.GetState();

            // Actualiza el estado de los botones
            var buttons = state.Gamepad.Buttons;
            UpdateButtonLabels(buttons);

            // Actualiza la posición de los joysticks
            UpdateJoystickLabels(state.Gamepad.LeftThumbX, state.Gamepad.LeftThumbY, state.Gamepad.RightThumbX, state.Gamepad.RightThumbY);

            // Actualiza la posición de los gatillos
            UpdateTriggerLabels(state.Gamepad.LeftTrigger, state.Gamepad.RightTrigger);

            // Actualiza la cruceta
            UpdateDPadLabels(buttons);
        }

        // Actualiza los Labels de los botones
        private void UpdateButtonLabels(GamepadButtonFlags buttons)
        {
            buttonALabel.Text = buttons.HasFlag(GamepadButtonFlags.A) ? "Botón A presionado" : "Botón A suelto";
            buttonBLabel.Text = buttons.HasFlag(GamepadButtonFlags.B) ? "Botón B presionado" : "Botón B suelto";
            buttonXLabel.Text = buttons.HasFlag(GamepadButtonFlags.X) ? "Botón X presionado" : "Botón X suelto";
            buttonYLabel.Text = buttons.HasFlag(GamepadButtonFlags.Y) ? "Botón Y presionado" : "Botón Y suelto";
        }

        // Actualiza los Labels de los joysticks
        private void UpdateJoystickLabels(short leftX, short leftY, short rightX, short rightY)
        {
            leftJoystickLabel.Text = $"Joystick Izquierdo: X = {leftX}, Y = {leftY}";
            rightJoystickLabel.Text = $"Joystick Derecho: X = {rightX}, Y = {rightY}";
        }

        // Actualiza los Labels de los gatillos
        private void UpdateTriggerLabels(byte leftTrigger, byte rightTrigger)
        {
            leftTriggerLabel.Text = $"Gatillo Izquierdo: {leftTrigger}";
            rightTriggerLabel.Text = $"Gatillo Derecho: {rightTrigger}";
        }

        // Actualiza los Labels de la cruceta
        private void UpdateDPadLabels(GamepadButtonFlags buttons)
        {
            dpadLabel.Text = "Cruceta: ";
            if (buttons.HasFlag(GamepadButtonFlags.DPadUp))
                dpadLabel.Text += "Arriba ";
            if (buttons.HasFlag(GamepadButtonFlags.DPadDown))
                dpadLabel.Text += "Abajo ";
            if (buttons.HasFlag(GamepadButtonFlags.DPadLeft))
                dpadLabel.Text += "Izquierda ";
            if (buttons.HasFlag(GamepadButtonFlags.DPadRight))
                dpadLabel.Text += "Derecha ";
        }
    }
}