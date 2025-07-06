using MaterialSkin.Controls;

namespace MobileShop.UI.Forms.Views
{
    partial class ConfirmPurchaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Text = "Confirm Purchase";
            ClientSize = new System.Drawing.Size(400, 800);
            //
            // Info label
            //
            lblInfo = new MaterialLabel
            {
                Text = $"IMEI: {_imei}  –  Model: {_model}  –  Price: {_price:C}",
                Location = new System.Drawing.Point(24, 80),
                AutoSize = true
            };
            //
            // Customer Name
            //
            var lblName = new MaterialLabel { Text = "Customer Name:", Location = new System.Drawing.Point(24, 350), AutoSize = true };
            txtName = new MaterialTextBox { Hint = "Enter full name", Location = new System.Drawing.Point(24, 380), Size = new System.Drawing.Size(350, 48) };
            //
            // Mobile Number
            //
            var lblMobile = new MaterialLabel { Text = "Mobile Number:", Location = new System.Drawing.Point(24, 440), AutoSize = true };
            txtMobile = new MaterialTextBox { Hint = "+1234567890 or 0123456789", Location = new System.Drawing.Point(24, 470), Size = new System.Drawing.Size(350, 48) };
            //
            // Email
            //
            var lblEmail = new MaterialLabel { Text = "Email:", Location = new System.Drawing.Point(24, 530), AutoSize = true };
            txtEmail = new MaterialTextBox { Hint = "email@example.com", Location = new System.Drawing.Point(24, 560), Size = new System.Drawing.Size(350, 48) };
            //
            // Address
            //
            var lblAddress = new MaterialLabel { Text = "Address:", Location = new System.Drawing.Point(24, 620), AutoSize = true };
            txtAddress = new MaterialTextBox { Hint = "Customer address", Location = new System.Drawing.Point(24, 650), Size = new System.Drawing.Size(350, 48) };
            //
            // Buttons
            //
            btnCancel = new MaterialButton { Text = "Cancel", AutoSize = true, Location = new System.Drawing.Point(200, 720) };
            btnCancel.Click += btnCancel_Click;
            btnConfirm = new MaterialButton { Text = "Confirm", AutoSize = true, Location = new System.Drawing.Point(300, 720) };
            btnConfirm.Click += btnConfirm_Click;
            
            // Add to form
            Controls.AddRange(new Control[] {
                lblInfo,
                lblName, txtName,
                lblMobile, txtMobile,
                lblEmail,  txtEmail,
                lblAddress, txtAddress,
                btnCancel, btnConfirm
            });
        }

        #endregion

        private MaterialLabel lblInfo;
        private MaterialTextBox txtName;
        private MaterialTextBox txtMobile;
        private MaterialTextBox txtEmail;
        private MaterialTextBox txtAddress;
        private MaterialButton btnConfirm;
        private MaterialButton btnCancel;
    }
}